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
    
    public partial class FrmKullaniciDetay : BaseForm
    {
        BindingSource Bs = new BindingSource();
        DataSet Ds = new DataSet();
        public string user = "";
        bool newrec = false;
        public FrmKullaniciDetay()
        {
            InitializeComponent();
            FormCode = "KULLANICIDETAY";
            FormName = "Kullanıcı Detayı";
        }

        void kayitoku()
        {
            string[] sqls = { "Select * from ARGUSERS WHERE USERNAME='"+user+"'" };
            Ds = AppParams.DbCon.GetDataSetEx(sqls, "");
            Bs.DataSource = Ds.Tables[0];
        }

        private void FrmKullaniciDetay_Load(object sender, EventArgs e)
        {
            kayitoku();
            txtUserName.DataBindings.Add("Text", Bs, "USERNAME");
            txtTamAdi.DataBindings.Add("Text", Bs, "FULLNAME");
            txtSifre.DataBindings.Add("Text", Bs, "PASSWORD");
            txtMail.DataBindings.Add("Text", Bs, "EMAIL");
            txtGorev.DataBindings.Add("Text", Bs, "POSITION");
            txtClient.DataBindings.Add("Text", Bs, "CLIENT");
            txtCompany.DataBindings.Add("Text", Bs, "COMPANY");
            txtTesis.DataBindings.Add("Text", Bs, "PLANT");
            cbAktif.DataBindings.Add("Checked", Bs, "ACTIVE");
            cbPersonel.DataBindings.Add("Checked", Bs, "ISSOURCE", true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
            cbSorumlu.DataBindings.Add("Checked", Bs, "ISRESPONSIBLE",true, DataSourceUpdateMode.OnPropertyChanged, CheckState.Indeterminate);
            if (user == "")
            { Bs.AddNew(); }
            else
            {
                txtUserName.ReadOnly = true;
                loadgrup();
            }
        }

        void loadgrup()
        {
            GrdGrup.DataSource = AppParams.DbCon.GetDataTable("Select groupcode from ARGUSERGROUPS where USERNAME='"+user+"'");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                txtClient.Text = "00";
                txtCompany.Text = "01";
                Bs.EndEdit();
                Ds.Tables[0].Rows[0]["CLIENT"] = "00";
                string ret = AppParams.DbCon.UpdateDataSetEx(Ds);
                 AppParams.fnc.WriteLog(txtUserName + " nolu kullanıcı tanımlarında değişiklik yapıldı.","",this.FormCode);
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kaydetmede Hata!", ex.Message);
                return;
            }
            finally
            {

            }                
            if (newrec == true) this.DialogResult = DialogResult.OK;
                this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtGrupSec_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm frm = new Sistem.SearchForm("Select GroupCode,GroupName from ARGROUPS");
            if (frm.ShowDialog() == DialogResult.OK)
            {
               txtGrupSec.Text =  frm.Sonuc[0];
            }
        }

        private void btnGrubaEkle_Click(object sender, EventArgs e)
        {
            if (txtGrupSec.Text != "")
            {
                AppParams.DbCon.ExecCommand(" SET DATEFORMAT MDY  " + (char)13 + " Insert into ARGUSERGROUPS(USERNAME,GROUPCODE,CHANGEDATE,CHANGEDBY) values ('" + user + "','" + txtGrupSec.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + AppParams.User + "')", "");
                loadgrup();
            }
        }

        private void btnGruptanCikar_Click(object sender, EventArgs e)
        {
            if ( GrdGrup.SelectedRows.Count>0 && AppParams.fnc.SoruSor("Seçili Gruptan kaldırmak istiyor musunuz?")==true)
            {
                string gr = GrdGrup.SelectedRows[0].Cells[0].Value.ToString();
            AppParams.DbCon.ExecCommand("DELETE FROM ARGUSERGROUPS WHERE username='"+user + "' and groupcode='"+gr+"' ","");
            loadgrup();
            }
        }
    }
}
