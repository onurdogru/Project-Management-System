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
    public partial class FrmDosyaYeniKlasor : BaseForm
    {
        public FrmDosyaYeniKlasor()
        {
            InitializeComponent();
        }

        private void FrmDosyaYeniKlasor_Load(object sender, EventArgs e)
        {
            GetKlasorNo();
            txtKlasorAdi.Focus();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKlasorNo.TextLength==0)
            { AppParams.fnc.Mesaj_Uyari("Kayıt Kontrol", "Klasör Numarası Girilmemiş!"); return; }

            if (txtKlasorAdi.TextLength==0)
            { AppParams.fnc.Mesaj_Uyari("Kayıt Kontrol", "Klasör Adı Giriniz!"); return; }

            if (AppParams.DbCon.GetDataTable("Select * from ARGFOLDERS where FOLDERNO='"+txtKlasorNo.Text+"' ").Rows.Count>0)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt Hatası", "Bu dosya numarası kullanılmış!");
                return;
            }
            string err = "";
            try
            {
                err = AppParams.DbCon.ExecCommand("Insert Into ARGFOLDERS (company,folderno,foldername,type,createdby) values ('01','"+txtKlasorNo.Text+"','"+txtKlasorAdi.Text+"',0,'"+AppParams.User+"') ", "");
                 AppParams.fnc.WriteLog(txtKlasorNo.Text +" "+ txtKlasorAdi.Text+ " adlı klasör oluştruldu","",this.FormCode);
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Uyari("Yeni Klasör Numarası Oluşturma", "Klasör Numarası oluşturulamadı! \n" + err + " \n" + ex.Message); 
                return;
            }
            if (AppParams.DbCon.GetDataTable("Select * from DEMANDS where PRONUM='" + txtKlasorNo.Text + "' ").Rows.Count == 0)
            {
                SetKlasorNo();
            }
            this.DialogResult = DialogResult.OK;
            Close();

        }

        void GetKlasorNo()
        {
            int no = 0;
            string err = "";
            try
            {
                no = int.Parse(AppParams.DbCon.GetDataTable("Select countnum+1 Num from ARGCOUNTERS where COUNTNAME='FOLDERS' ").Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            if (no == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Yeni Klasör Numarası Oluşturma", "Klasör Numarası oluşturulamadı! \n" + err); return;
            }
            txtKlasorNo.Text = no.ToString();
        }

        void SetKlasorNo()
        {
            string err = "";
            try
            {
                err = AppParams.DbCon.ExecCommand("Update ARGCOUNTERS set COUNTNUM= countnum+1 where COUNTNAME='FOLDERS' ", "");
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Uyari("Yeni Klasör Numarası Güncelleme", "Klasör Numarası Güncellenemedi! \n" + err + " \n" + ex.Message ); return;
            }
        }



        private void txtKlasorNo_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select PRONUM ProjeKodu,STEXT ProjeAdi from DEMANDS WHERE ISDELETE=0 AND PSTATUS>0 and PSTATUS<6 Order by pronum desc");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtKlasorNo.Text = sf.Sonuc[0];
            txtKlasorAdi.Text = sf.Sonuc[1];
            ((Control)sender).Parent.Text = sf.Sonuc[0];
        }

    }
}
