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

namespace ALPARGE.AppForms.Genel
{
    public partial class FrmDosyaDetay : BaseForm
    {
        public string KlasorNo = "";
        public string KlasorAdi = "";
        string SecilenDosya = "";
        Classes.FileProcess dosya = new Classes.FileProcess();
        public FrmDosyaDetay()
        {
            InitializeComponent();
        }

        private void FrmDosyaDetay_Load(object sender, EventArgs e)
        {
            txtKlasorNo.Text = KlasorNo;
            txtKlasorAdi.Text = KlasorAdi;
            loadfiles();
        }

        void loadfiles()
        {
            GrdDosyalar.AutoGenerateColumns = false;
            GrdDosyalar.DataSource = AppParams.DbCon.GetDataTable("Select * from ARGFILES where FOLDERNO='"+KlasorNo+"' ");
        }

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
                dosya.FLSV(txtKlasorNo.Text, openFileDialog1.FileName.ToString(), "DYS", this.FormCode);
                loadfiles();
            }
        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            if (SecilenDosya != "")
            {
                string dosyayolu = dosya.SVFL(KlasorNo, SecilenDosya, "DYS");
                System.Diagnostics.Process.Start(dosyayolu);
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

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            if (SecilenDosya!="")
            {
                dosya.CLRFL(KlasorNo, SecilenDosya, "DYS", this.FormCode);
                SecilenDosya = "";
                loadfiles();
            }
        }

        private void btnKlasorGuncelle_Click(object sender, EventArgs e)
        {
            if (AppParams.fnc.SoruSor("Bu klasörün ismini değiştimek istiyor musunuz?") == true)
            {
                string RET = AppParams.DbCon.ExecCommand("UPDATE ARGFOLDERS SET FOLDERNAME='"+txtKlasorAdi.Text+"' where FOLDERNO='" + KlasorNo + "' ", "");
            }
        }

        private void btnKlasorSil_Click(object sender, EventArgs e)
        {
            if (AppParams.fnc.SoruSor("Bu klasör kalıcı olarak silinecek, onaylıyor musunuz?") == true)
            {
                if (AppParams.fnc.SoruSor("Dikkat bu klasörü silerseniz verilere tekrar ulaşamayacaksınız! Emin misiniz?") == true)
                {
                    string RET = AppParams.DbCon.ExecCommand("Delete from ARGFILES where FOLDERNO='" + KlasorNo + "' AND SOURCE='DYS' ", "");
                    RET = AppParams.DbCon.ExecCommand("Delete from ARGFOLDERS where FOLDERNO='" + KlasorNo + "' ", "");
                    AppParams.fnc.WriteLog(txtKlasorNo.Text + " " + txtKlasorAdi.Text + " adlı klasör silindi!", "", this.FormCode);
                    Close();
                }
            }
        }

    }
    
}
