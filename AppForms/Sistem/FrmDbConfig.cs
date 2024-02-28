using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms
{
    public partial class FrmDbConfig : Form
    {
        public FrmDbConfig()
        {
            InitializeComponent();
        }

        private void FrmDbConfig_Load(object sender, EventArgs e)
        {
            try
            {
                txtServer.Text = AppParams.fnc.GetCfgSetting("ServerName");
                txtDbName.Text = AppParams.fnc.GetCfgSetting("DbName");
                txtUserName.Text = AppParams.fnc.GetCfgSetting("DbUser");
                txtPassword.Text = AppParams.fnc.TextSifreCoz(AppParams.fnc.GetCfgSetting("PassWord").ToString(), "@DbPassWord");
                txtParametre.Text = AppParams.fnc.GetCfgSetting("Parameters");
            }
            catch (Exception ex)
            { var s = ex.Message; }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                AppParams.fnc.SetCfgSetting("ServerName", txtServer.Text);
                AppParams.fnc.SetCfgSetting("DbName", txtDbName.Text);
                AppParams.fnc.SetCfgSetting("DbUser", txtUserName.Text);
                AppParams.fnc.SetCfgSetting("PassWord", AppParams.fnc.TextSifrele(txtPassword.Text, "@DbPassWord"));
                AppParams.fnc.SetCfgSetting("Parameters", txtParametre.Text);
            }
            catch (Exception)
            { }
            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
