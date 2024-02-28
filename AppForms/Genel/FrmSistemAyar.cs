using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


namespace ALPARGE.AppForms.Genel
{
    public partial class FrmSistemAyar : BaseForm
    {
        public FrmSistemAyar()
        {
            InitializeComponent();
        }

        private void FrmSistemAyar_Load(object sender, EventArgs e)
        {
            txtStatus.Text="Çalışma yolu: \n"+(char)13+"\n"+ Application.StartupPath.ToString();
        }

        private void ssclose_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer",true);
                //key.CreateSubKey("AppName");
                //key = key.OpenSubKey("AppName", true);
                key.SetValue("SmartScreenEnabled", "Off");
            }
            catch (Exception ex)
            {
                var exc = new System.Security.SecurityException();
                if (ex == exc)
                {
                    MessageBox.Show("Yetkiniz Yok!");
                }
                MessageBox.Show(ex.Message);
            }
        }
    }
}
