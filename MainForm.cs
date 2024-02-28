using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Screen.PrimaryScreen.WorkingArea.Width > 1200)
            {
                this.Width = 1200;
                this.Height = 700;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            ALPARGE.AppForms.FrmLogin LgnFrm = new AppForms.FrmLogin();
            if (LgnFrm.ShowDialog() == DialogResult.Yes)
            {
                AppParams.fnc.WriteLog("Oturum Açıldı.","","login");
                AppParams.DbCon.ExecCommand("update ARGUSERS set ONLINE=GETDATE() WHERE USERNAME='"+AppParams.User+"'","");
                this.BringToFront();
                AppConfigLoad();
               
            }
            else
            { Application.Exit(); }
            try
            {
                this.Text = this.Text +"   v"+ AssemblyVersion.Major.ToString() + "." + AssemblyVersion.Minor.ToString() + "." + AssemblyVersion.Build.ToString() + "." + AssemblyVersion.Revision.ToString();
            //    this.Text = this.Text + string.Format(" - v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
            catch (Exception)
            {

            }
        }

        public Version AssemblyVersion
        {
            get
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
        }

        void AppConfigLoad()
        {
        }

        void LoadForm(string frm)
        {
            tabMenu.LoadForm(frm);
        }

        private void MMTest_Click(object sender, EventArgs e)
        {
            AppParams.fnc.Mesaj_Bilgi("Çalışma yolu",Application.StartupPath.ToString());
            LoadForm(@"ALPARGE.AppForms.TestForm");
        }

        private void MMDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.FrmDashboard");
        }

        private void tbDashBoard_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.FrmDashboard");
        }

        private void MMCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void tbProjeListesi_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Talepler.FrmTalepListesi");
        }

        private void MMButcePlanlama_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Projeler.FrmProjePlanlama");
        }

        private void MMMusteriler_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmMusteriler");
        }

        private void MMYeniTalep_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Talepler.FrmTalepListesi");
        }

        private void MMCatiProje_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmCatiProjeler");
        }

        private void MMProjeOnay_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Projeler.FrmProjeOnay");
        }

        private void MMTalepOnaylama_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Talepler.FrmTalepOnay");
        }

        private void MMProjeSorumlusu_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Talepler.FrmSorumluAtama");
        }

        private void MMTumProjeler_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Projeler.FrmProjeListesi");
        }

        private void MMGrupTanim_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmKullaniciGrup");
        }

        private void MMKullaniciTanim_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmKullaniciTanim");
        }

        private void MMKullaniciIslem_Click(object sender, EventArgs e)
        {
           // LoadForm(@"ALPARGE.AppForms.Genel.FrmKullaniciIslemleri");
            AppForms.Genel.FrmKullaniciIslemleri frmk = new AppForms.Genel.FrmKullaniciIslemleri();
            frmk.ShowDialog();
        }

        private void projeTakipVeTamamlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Projeler.FrmPersonelProjeCalisma");
        }

        private void projeKapatmaOnayıToolStripMenuItem_Click(object sender, EventArgs e)
        {
              LoadForm(@"ALPARGE.AppForms.Projeler.FrmProjeKapama");
        }

        private void MMProjeKaynaklar_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmProjeKaynak");
        }

        private void MMToplantilar_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Projeler.FrmProjeToplantilari");
        }

        private void MMProjeGorevTipleri_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmProjeGorevTipleri");
        }

        private void MMProjeUyumSure_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Analizler.FrmProjePlanUyumSureleri");
        }

        private void tbProjeZamanPlan_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Projeler.FrmProjePlanlama");
        }

        private void MMSistem_Click(object sender, EventArgs e)
        {
            AppForms.Genel.FrmSistemAyar frmk = new AppForms.Genel.FrmSistemAyar();
            frmk.ShowDialog();
        }

        private void MMSaatUcreti_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmSaatUcretleri");
            //AppForms.Genel.FrmSaatUcretleri frmk = new AppForms.Genel.FrmSaatUcretleri();
            //frmk.ShowDialog();
        }

        private void MMmeyerTanim_Click(object sender, EventArgs e)
        {
            AppForms.Genel.FrmPersonelGCTanim frmk = new AppForms.Genel.FrmPersonelGCTanim();
            frmk.ShowDialog();
        }

        private void MMProjeTamamlanmaOran_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Analizler.FrmProjeTamamlanmaOran");
        }

        private void MMPersonelCalismaSure_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Analizler.FrmPersonelCalismaSure");
        }

        private void MMPersCalismaPlan_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Analizler.FrmPersonelCalismaPlan");
        }

        private void tabMenu_Load(object sender, EventArgs e)
        {

        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MMDosyalar_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmDosyalar");
        }

        private void MMTextNotlar_Click(object sender, EventArgs e)
        {
            LoadForm(@"ALPARGE.AppForms.Genel.FrmProjeNotlar");
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AlpArge " + AppParams.AppVersion + "  (Alpplas Arge Proje Takip Sistemi)");
        }
      

    }
}
