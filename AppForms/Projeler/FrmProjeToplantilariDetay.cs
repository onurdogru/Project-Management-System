using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Projeler
{
    public partial class FrmProjeToplantilariDetay : BaseForm
    {
        public string ToplantiNo = "";
        BindingSource Bs = new BindingSource();
        DataSet Ds = new DataSet();
        public FrmProjeToplantilariDetay()
        {
            InitializeComponent();
        }

        private void FrmProjeToplantilariDetay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            string[] sqls = {"SELECT * FROM MEETINGS WHERE TOPLANTIID='"+ToplantiNo+"' "};
            Ds = AppParams.DbCon.GetDataSetEx(sqls,"");
            Bs.DataSource = Ds.Tables[0];
            txtTarih.DataBindings.Add("Text", Bs, "TARIH");
            txtID.DataBindings.Add("Text", Bs, "TOPLANTIID");
            txtProjeNo.DataBindings.Add("Text", Bs, "PROJENO");
            txtIcerik.DataBindings.Add("Text", Bs, "ICERIK");
            txtTalepEden.DataBindings.Add("Text", Bs, "TALEPEDEN");
            txtToplantiYeri.DataBindings.Add("Text", Bs, "YER");
            txtKatilimcilar.DataBindings.Add("Text", Bs, "KATILIMCILAR");
            txtKonu.DataBindings.Add("Text", Bs, "KONU");
            txtSonuc.DataBindings.Add("Text", Bs, "SONUC");
            txtDegistiren.DataBindings.Add("Text", Bs, "CHANGEDBY");
            txtDegisTarihi.DataBindings.Add("Text", Bs, "CHANGEDATE");

            if (Ds.Tables.Count == 1 && Ds.Tables[0].Rows.Count == 0)
            {
                Bs.AddNew();
                txtTarih.Text = DateTime.Now.ToShortDateString();
                txtTarih.Value = DateTime.Now;
                txtTarih.Update();
                txtDegisTarihi.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                txtID.Enabled = false;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtProjeNo.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Proje No boş geçilemez! ");
                return;
            }

            if (txtKonu.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Toplantı konusu boş geçilemez! ");
                return;
            }

            if (txtIcerik.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt kontrol", "Toplantı içeriği boş geçilemez! ");
                return;
            }


            if (MessageBox.Show("Bu toplantı bilgilerini kaydetmek istiyor musunuz?" + (char)13 + (char)13 + "Dikkat! Kaydedilmiş bir toplantı silinemeyecektir!"
             + (char)13 + "Geriye dönük 3 günden daha eski toplantılar ise değiştirilemez.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                txtDegistiren.Text = AppParams.User;
                txtDegisTarihi.Text = DateTime.Now.ToString();
                Bs.EndEdit();
                string ret = AppParams.DbCon.UpdateDataSetEx(Ds) + "--";
                if (ret.Substring(0, 2) == "OK")
                {
                    AppParams.fnc.Mesaj_Bilgi("Kayıt", "Kaydetme işlemi tamamlandı.  \n");
                    AppParams.fnc.WriteLog("Toplantı kaydedildi. No: " + txtID.Text + "  ProjeNo: " + txtProjeNo.Text, txtProjeNo.Text, this.FormCode);
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    AppParams.fnc.Mesaj_Hata("Kayıt", "Kaydetme işlemi yapılamadı! \n" + ret.Substring(3, ret.Length - 3));
                }
            }
        }

        private void txtProjeNo_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select PRONUM ProjeKodu,STEXT ProjeAdi from DEMANDS WHERE ISDELETE=0 AND PSTATUS>0 and PSTATUS<6 Order by pronum desc" );
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtProjeNo.Text = sf.Sonuc[0];
            ((Control)sender).Parent.Text = sf.Sonuc[0];
        }
    }
}
