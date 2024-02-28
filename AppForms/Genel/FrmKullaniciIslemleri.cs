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
    public partial class FrmKullaniciIslemleri : BaseForm
    {
        public FrmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text == "")
            { goto adim2;
            }
            if (txtYeniSifre.Text != txtYeniSifre2.Text)
            {
                AppParams.fnc.Mesaj_Uyari("Şifre Güncelleme", "Yeni şifreler uyumsuz! Her iki kutucuğa da aynı şifreyi girin.");
                return;
            }
            if (AppParams.DbCon.GetDataTable("Select * from ARGUSERS where username='" + AppParams.User + "' and password ='" + txtMevcutSifre.Text + "' ").Rows.Count > 0)
            {
                AppParams.DbCon.ExecCommand("Update ARGUSERS set Password='" + txtYeniSifre.Text + "' where Username='" + AppParams.User + "' ", "");
                AppParams.fnc.Mesaj_Bilgi("Şifre Güncelleme", "Şifreniz değişirildi!");
                AppParams.fnc.WriteLog( AppParams.User +" Şifresini değiştirdi.","",this.FormCode);
            }
            else
            {
                AppParams.fnc.Mesaj_Uyari("Şifre Güncelleme", "Mevcut şifre hatalı görünüyor!");
                return;
            }
        adim2:
            Close();
        }

        private void FrmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            lblUser.Text = AppParams.User;
        }
    }
}
