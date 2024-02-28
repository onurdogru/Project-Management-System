using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ALPARGE.AppForms
{
    public partial class FrmLogin : BaseForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        string AppName = "ALPARGE 1.0";
        string ConTyp = "MsSQL";
        DbControls.DbConnection.ConnectionTypes ConType;
        string WSAdres = "";
        string WSPwd = "";
        string ServerName = @"Dev7";
        string DbName = "STSDB";
        string User = "sa";
        string Pwd = "1";
        string Params = "";
        string Lang = "TR";

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            SettingLoad();
            txtPassword.Focus();
           // HardwareInfo.Start();
        }

        void SettingLoad()
        {
            try
            {
                //SqlConnection startc = new SqlConnection();
                if (Properties.Settings.Default.Update)
                {
                    Properties.Settings.Default.Upgrade();
                    Properties.Settings.Default.Update = false;
                    Properties.Settings.Default.Save(); 
                    Properties.Settings.Default.Reload();
                }
            }
            catch (Exception EX)
            {       }

            try
            {



                txtUserName.Text = AppParams.fnc.GetCfgSetting("UserName");

                ConTyp = AppParams.fnc.GetCfgSetting("ConnectionType");
                string dbname=AppParams.fnc.GetCfgSetting("DbName");
                if (dbname != "") DbName = dbname;
                ConType = DbControls.DbConnection.ConnectionTypes.MSSQL;
                if (ConTyp == "WebService") ConType = DbControls.DbConnection.ConnectionTypes.WEBSERVICE;
                ServerName = AppParams.fnc.GetCfgSetting("ServerName");
                User = AppParams.fnc.GetCfgSetting("DbUser");
                Pwd = AppParams.fnc.TextSifreCoz(AppParams.fnc.GetCfgSetting("PassWord").ToString(), "@DbPassWord");
                Lang = AppParams.fnc.GetCfgSetting("Language");
                string sqlConnection = "Persist Security Info=true; Application Name= " + AppName +"_"+ txtUserName.Text + " ;Data Source=" + ServerName + ";MultipleActiveResultSets=True;Initial Catalog=" + DbName + ";Password=" + Pwd + ";User ID=" + User;
                if (txtUserName.Text == "ADMIN")
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Ayar Yüklemede Hata", ex.Message + (char)13+Application.StartupPath.ToString());
            }
            
        }

        bool OpenConnection()
        {
            try
            {
                if (AppParams.DbCon.ConnectionStarted == true) AppParams.DbCon.ConnectionClose();
                string constr = "Persist Security Info=true; Application Name= " + AppName + "_" + txtUserName.Text + " ;Data Source=" + ServerName + ";MultipleActiveResultSets=True;Initial Catalog=" + DbName + ";Password=" + Pwd + ";User ID=" + User + ";Connection Timeout=10";
                if (AppParams.DbCon.ConnectionStarted == false)
                { AppParams.fnc.SetConnectionProperty(AppParams.DbCon, DbControls.DbConnection.ConnectionTypes.MSSQL, constr);
                
                  return AppParams.DbCon.ConnectionOpen(); 
                }
            }
            catch (Exception ex)
            { AppParams.fnc.Mesaj_Hata("Bağlantı Hatası!", ex.Message); return false; }
            return true;

        }
        //-----------------------------------------------------------------------------------------------------------------------------------
        private void btnOk_Click(object sender, EventArgs e)
        {
           
           string[] sql={"Select USERGROUP,USERNAME,PASSWORD from argusers where username='"+txtUserName.Text+"'"};
           try
           {
               if (OpenConnection() == false)
               {
                   AppParams.fnc.Mesaj_Uyari("Sunucu Bağlantısı", "Sucnucya şu an bağlantı kurulamayor! \n \nSunucu kapatılmış olabilir veya network bağlantınızda sorun olabilir.\nBir süre sonra tekrar deneyin.");
                   return;
               }
               DataTable dt = AppParams.DbCon.GetDataSetEx(sql, "").Tables[0];
               if (dt.Rows.Count > 0)
               {
                   var user = dt.Rows[0][1].ToString();
                   var pwd = dt.Rows[0][2].ToString();
                   if (txtUserName.Text == user & txtPassword.Text == pwd)
                   {
                       AppParams.User = txtUserName.Text;

                       BaseControls.GlobalParameters.MasterDbConnection = AppParams.DbCon;
                        AppParams.ServerName = ServerName;
                        AppParams.DBName = DbName;
                        AppParams.DBUser = User;
                       AppParams.DBPwd =Pwd;
                        Thread.Sleep(300);
                       this.DialogResult = DialogResult.Yes;
                   }
                   else
                   {
                       this.DialogResult = DialogResult.None;
                       AppParams.fnc.Mesaj_Goster("Hata", "Şifre geçersiz!", "Lütfen şifrenizi tekrar girin.", BaseControls.Functions.MesajTipi.UyariMesaj, 0);
                   }
               }
               else
               {
                   AppParams.fnc.Mesaj_Goster("Hata", "Kullanıcı adı geçersiz!", "Lütfen kullanıcı adınızı tekrar girin.", BaseControls.Functions.MesajTipi.UyariMesaj, 0);
               }
           }
           catch (Exception ex)
           {
               AppParams.fnc.Mesaj_Hata("Hata!", ex.Message);
           }
            AppParams.fnc.SetCfgSetting("UserName", txtUserName.Text);
            Properties.Settings.Default.UserName = txtUserName.Text;
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
             //  btnCancel.PerformClick();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ALPARGE.AppForms.FrmDbConfig frmc = new ALPARGE.AppForms.FrmDbConfig();
            frmc.ShowDialog();
            SettingLoad();
            frmc.Dispose();
        }
    }
}
