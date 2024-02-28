using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Projeler
{
    public partial class FrmProjeKapamaDetay : BaseForm
    {
        public string ProjeKodu = "";
        DataTable DtProje = new DataTable();
        DataSet DS = new DataSet();
        BindingSource BS = new BindingSource();
        Classes.FileProcess Dosya = new Classes.FileProcess();
        public FrmProjeKapamaDetay()
        {
            InitializeComponent();
        }

        private void FrmProjeKapamaDetay_Load(object sender, EventArgs e)
        {
            txtProjeNo.Text = ProjeKodu;
            loadfiles();
            if (ProjeKodu=="")
            {
                AppParams.fnc.Mesaj_Hata("Hata","Proje Kodu bulunamadı!");
                btnKaydet.Enabled = false;
                return;
            }
            DtProje = AppParams.DbCon.GetDataTable("Select * from demands where pronum='"+ProjeKodu+"' ");
            string[] sqls = { "Select * from PROJECTFINISH WHERE PRONUM='" + ProjeKodu + "'" };
            DS = AppParams.DbCon.GetDataSetEx(sqls, "");
            BS.DataSource = DS.Tables[0];
            if (BS.Count==0)
            {
                BS.AddNew();
                DS.EnforceConstraints = false;
                BS.EndEdit();
                DS.Tables[0].Rows[0]["ISCLOSED"]=0;
                DS.Tables[0].Rows[0]["C1"] = 0;
                DS.Tables[0].Rows[0]["C2"] = 0;
                DS.Tables[0].Rows[0]["C3"] = 0;
                DS.Tables[0].Rows[0]["C4"] = 0;
                DS.Tables[0].Rows[0]["C5"] = 0;
                DS.Tables[0].Rows[0]["C6"] = 0;
                DS.Tables[0].Rows[0]["C7"] = 0;
                DS.Tables[0].Rows[0]["C8"] = 0;
                DS.Tables[0].Rows[0]["C9"] = 0;
                DS.Tables[0].Rows[0]["C10"] = 0;
                DS.Tables[0].Rows[0]["C11"] = 0;
                DS.Tables[0].Rows[0]["C12"] = 0;
            }
            txtProjeNo.Text = DtProje.Rows[0]["pronum"].ToString();
            txtProjeAdi.Text = DtProje.Rows[0]["STEXT"].ToString();
            txtMusteri.Text = DtProje.Rows[0]["customer"].ToString();
            txtTalepEden.Text = DtProje.Rows[0]["createdby"].ToString();
            txtProjeSorumlusu.Text = DtProje.Rows[0]["RESPONSIBLE0"].ToString();
            txtProjeTipi.Text = DtProje.Rows[0]["Ptype"].ToString();
            txtTeslimTarihi.Text = DtProje.Rows[0]["DELIVERYDATE"].ToString();
            txtPlnTeslimTarihi.Text = DtProje.Rows[0]["PDELIVERYDATE"].ToString();
            cbOnay.DataBindings.Add("Checked", BS, "STATUS");
            C1.DataBindings.Add("Checked", BS, "C1");
            D1.DataBindings.Add("Text", BS, "D1");
            C2.DataBindings.Add("Checked", BS, "C2");
            D2.DataBindings.Add("Text", BS, "D2");
            C3.DataBindings.Add("Checked", BS, "C3");
            D3.DataBindings.Add("Text", BS, "D3");
            C4.DataBindings.Add("Checked", BS, "C4");
            D4.DataBindings.Add("Text", BS, "D4");
            C5.DataBindings.Add("Checked", BS, "C5");
            D5.DataBindings.Add("Text", BS, "D5");
            C6.DataBindings.Add("Checked", BS, "C6");
            D6.DataBindings.Add("Text", BS, "D6");
            C7.DataBindings.Add("Checked", BS, "C7");
            D7.DataBindings.Add("Text", BS, "D7");
            C8.DataBindings.Add("Checked", BS, "C8");
            D8.DataBindings.Add("Text", BS, "D8");
            C9.DataBindings.Add("Checked", BS, "C9");
            D9.DataBindings.Add("Text", BS, "D9");
            C10.DataBindings.Add("Checked", BS, "C10");
            D10.DataBindings.Add("Text", BS, "D10");
            C11.DataBindings.Add("Checked", BS, "C11");
            D11.DataBindings.Add("Text", BS, "D11");
            C12.DataBindings.Add("Checked", BS, "C12");
            D12.DataBindings.Add("Text", BS, "D12");
            txtFiiliTeslimTarihi.DataBindings.Add("Text", BS, "DELIVERYDATE");
            //txtProjeNo.DataBindings.Add("Text",bsp , "pronum");
            if (txtProjeSorumlusu.Text!=AppParams.User && AppParams.User!= "ADMIN")
            {
                btnKaydet.Enabled = false;
            }
            //string statu = DtProje.Rows[0]["status"].ToString();
            //if (statu == "4" || statu == "6")
            //{
            //    cbOnay.Checked = true;
            //}
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kayitkontrol() == false) return;
            try
            {
                BS.EndEdit();
                DS.Tables[0].Rows[0]["PRONUM"] = ProjeKodu;
                DS.Tables[0].Rows[0]["CHANGEDBY"] = AppParams.User;
                DS.Tables[0].Rows[0]["CHANGEDATE"] = DateTime.Now.ToShortDateString();
                string ret = AppParams.DbCon.UpdateDataSetEx(DS);
                if (cbOnay.Checked == true && ret.Substring(0, 2) == "OK")
                {
                    AppParams.DbCon.ExecCommand("update demands set PSTATUS=4, ISCLOSED=0,ENDDELIVERYDATE='"+txtFiiliTeslimTarihi.Value.ToString("yyyy.MM.dd")+"' where pronum='" + ProjeKodu + "' ", "");
                }
                else
                {
                    AppParams.DbCon.ExecCommand("update demands set PSTATUS=3, ISCLOSED=0,ENDDELIVERYDATE='2000.01.01' where pronum='" + ProjeKodu + "' ", "");
                }
            }
            catch (Exception ex)
            {  
                AppParams.fnc.LogWrite("ProjeKapamaHatası: "+ex.Message,0);
                AppParams.fnc.Mesaj_Hata("Hata", "Kaydetme Hatası " + ex.Message);
            }
            finally
            {
                AppParams.fnc.Mesaj_Bilgi("Kayıt", "Kaydetme işlemi tamamlandı");
                AppParams.fnc.WriteLog("Proje kapama işlemlerinde değişiklik yapıldı.", ProjeKodu, this.FormCode);
                Close();
            }
        }

        bool kayitkontrol()
        {
            if(cbOnay.Checked==true && GrdDosyalar.Rows.Count<1)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik bilgi", "Onaya gönderebilmeniz için en az bir dosya eklemelisiniz!");
                return false;
            }
            return true;
        }



        // dosya rutinleri 
        string SecilenDosya = "";
        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PDF Dosyası|*.pdf|Metin Dosyası|*.txt|Resim Dosyası|*.png|Resim Dosyası|*.jpeg|Resim Dosyası|*.jpg|Zip Dosyası|*.zip|Excel Dosyası|*.xls*|Word Dosyası|*.doc*|Tüm Dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(openFileDialog1.FileName);
                if ((ext != ".pdf") || (ext != ".txt") || (ext != ".png") || (ext != ".jpg") || (ext != ".jpeg") || (ext != ".zip") || (ext != ".rar"))
                {

                }
                Dosya.FLSV(ProjeKodu, openFileDialog1.FileName.ToString(), "Kapama", this.FormCode);
                loadfiles();
            }





            //openFileDialog1.FileName = "";
            //openFileDialog1.Filter = "PDF Dosyası|*.pdf|Metin Dosyası|*.txt|Resim Dosyası|*.png|Resim Dosyası|*.jpeg|Resim Dosyası|*.jpg|Zip Dosyası|*.zip|Excel Dosyası|*.xls*|Word Dosyası|*.doc*";
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    var ext = Path.GetExtension(openFileDialog1.FileName);
            //    if ((ext != ".pdf") || (ext != ".txt") || (ext != ".png") || (ext != ".jpg") || (ext != ".jpeg") || (ext != ".zip"))
            //    {
            //    }
            //    txtSeciliDosya.Text = openFileDialog1.FileName.ToString();
            //    lbxBekleyenDosya.Items.Add(openFileDialog1.FileName.ToString());
            //}
        }

        void loadfiles()
        {
            GrdDosyalar.AutoGenerateColumns = false;
            GrdDosyalar.DataSource = AppParams.DbCon.GetDataTable("Select FOLDERNO,FILENAME,SOURCE,TYPE,SIZE,USERNAME,DATE from ARGFILES where FOLDERNO='" + ProjeKodu + "' and source='Kapama' ");
        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecilenDosya != "")
                {
                    Dosya.CLRFL(ProjeKodu, SecilenDosya, "Kapama", this.FormCode);
                    SecilenDosya = "";
                    txtSecilenDosya.Text = "";
                    loadfiles();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            try
            {
            if (SecilenDosya != "")
            {
                string dosyayolu = Dosya.SVFL(txtProjeNo.Text, SecilenDosya, "Kapama");
                System.Diagnostics.Process.Start(dosyayolu);
            }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Hata", ex.Message);
            }

        }

        private void GrdDosyalar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SecilenDosya = GrdDosyalar.Rows[e.RowIndex].Cells["colFILENAME"].Value.ToString();
            }
            catch (Exception)
            {
                SecilenDosya = "";
            }
            txtSecilenDosya.Text = SecilenDosya;
        }

    }
}
