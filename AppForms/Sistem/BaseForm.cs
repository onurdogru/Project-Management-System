using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE
{
    public partial class BaseForm : BaseControls.BC_Form
    {
        public int Yetki = 0;
        public int KayitTipi = 0;
        public BaseForm()
        {
            InitializeComponent();
        }


        private void BaseForm_Load(object sender, EventArgs e)
        {


        }

        protected override void OnLoad(EventArgs e)
        {
            Yetki= AppParams.fnc.Authority(FormCode);
            if (FormCode != "" && Yetki == 0 && AppParams.User != "ADMIN'")
            {
                AppParams.fnc.Mesaj_Uyari("Form Giriş Yetki Kontrolü", "Bu forma girmeye yetki değilsiniz!");
                registerForm();
                this.Close();
                return;
                
            }
            else
            {

            }
            base.OnLoad(e);
        }

        private void BaseForm_LoadFromTabForm(object sender, EventArgs e)
        {
            base.OnBindingContextChanged(e);
            Yetki = AppParams.fnc.Authority(FormCode);
            if (FormCode != "" && Yetki == 0 && AppParams.User != "ADMIN'")
            {
                AppParams.fnc.Mesaj_Uyari("Form Giriş Yetki Kontrolü", "Bu forma girmeye yetki değilsiniz!");
                registerForm();
                 this.Close();
                 this.Dispose();
            }
            else
            {
                
            }
        }

        void registerForm()
        {
            try
            {
                AppParams.DbCon.ExecCommand("insert into ARGFORMS (FormCode,FormName) Values ('"+FormCode+"','"+FormName+"')", "");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void BaseForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || AppParams.fnc.SoruSor("Form kapatılsın mı?"))
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close() ;
            }
        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && this.Modal && AppParams.fnc.SoruSor("Çıkmak istiyor musunuz?"))
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
