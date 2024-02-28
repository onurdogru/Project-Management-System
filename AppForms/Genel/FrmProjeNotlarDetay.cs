using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Genel
{
    public partial class FrmProjeNotlarDetay : BaseForm
    {
        public FrmProjeNotlarDetay()
        {
            InitializeComponent();
        }

        public string NotID = "0";
        BindingSource Bs = new BindingSource();
        DataSet Ds = new DataSet();

        private void FrmProjeNotlar_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtProjeNo_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select PRONUM ProjeKodu,STEXT ProjeAdi from DEMANDS WHERE ISDELETE=0 AND PSTATUS>0 and PSTATUS<6 Order by pronum desc");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtProjeNo.Text = sf.Sonuc[0];
            ((Control)sender).Parent.Text = sf.Sonuc[0];
        }



        void LoadData()
        {
            string[] sqls = { "SELECT * FROM TEXTNOTES WHERE ID='" + NotID + "' " };
            Ds = AppParams.DbCon.GetDataSetEx(sqls, "");
            try
            {
                if (DateTime.Parse(Ds.Tables[0].Rows[0]["NDATE"].ToString()) < DateTime.Parse("01.01.2000"))
                {
                    Ds.Tables[0].Rows[0]["NDATE"] = DateTime.Now;
                }
            }
            catch { }
            Bs.DataSource = Ds.Tables[0];
            txtTarih.DataBindings.Add("Text", Bs, "NDATE");
            txtOlusturan.DataBindings.Add("Text", Bs, "USERNAME");
            txtKonu.DataBindings.Add("Text", Bs, "SUBJECT");
            txtIcerik.DataBindings.Add("Text", Bs, "NOTE");
            txtProjeNo.DataBindings.Add("Text", Bs, "PRONUM");
            cbSil.DataBindings.Add("Checked", Bs, "ISDELETED");
            txtNotID.DataBindings.Add("Text", Bs, "ID");

            if (Ds.Tables.Count == 1 && Ds.Tables[0].Rows.Count == 0)
            {
                Bs.AddNew();
                txtTarih.Text = DateTime.Now.ToShortDateString();
                txtTarih.Value = DateTime.Now;
                txtTarih.Update();
                txtOlusturan.Text = AppParams.User;
            }
            else
            {
                cbSil.Enabled = true;
            }

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtOlusturan.Text!=AppParams.User)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Sadece kendi kullanıcı isminizle oluşturduğunuz notu değiştirebilirsiniz! ");
                return;
            }

            if (txtProjeNo.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Proje No boş geçilemez! ");
                return;
            }

            if (txtKonu.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Not konusu boş geçilemez! ");
                return;
            }

            if (txtIcerik.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Not içeriği boş geçilemez! ");
                return;
            }


            if (MessageBox.Show("Bu Not bilgilerini kaydetmek istiyor musunuz?" + (char)13 + (char)13 + "Dikkat! Kaydedilmiş bir Not kalıcı olarak silinemeyecektir!"
             + (char)13 + "", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Bs.EndEdit();
                try
                {
                    if (DateTime.Parse(Ds.Tables[0].Rows[0]["NDATE"].ToString()) < DateTime.Parse("01.01.2000"))
                    {
                        Ds.Tables[0].Rows[0]["NDATE"] = DateTime.Now;
                    }

                        Ds.Tables[0].Rows[0]["CHANGEDATE"] = DateTime.Now;

                }
                catch (Exception)
                {

                }

                string ret = AppParams.DbCon.UpdateDataSetEx(Ds) + "--";
                if (ret.Substring(0, 2) == "OK")
                {
                    AppParams.fnc.Mesaj_Bilgi("Kayıt", "Kaydetme işlemi tamamlandı.  \n");
                    AppParams.fnc.WriteLog("Text Not kaydedildi. No: " + txtNotID.Text + "  ProjeNo: " + txtProjeNo.Text, txtProjeNo.Text, this.FormCode);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    AppParams.fnc.Mesaj_Hata("Kayıt", "Kaydetme işlemi yapılamadı! \n" + ret.Substring(3, ret.Length - 3));
                }
            }
        }
    }
}
