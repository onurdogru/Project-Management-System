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
    public partial class FrmPersonelGCTanim : BaseForm
    {
        public FrmPersonelGCTanim()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        private void FrmPersonelGCTanim_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void  LoadData()
        {
            string[] sorgu = { "Select * from SYS_EXTERNAL WHERE ID=1" };
            ds = AppParams.DbCon.GetDataSetEx(sorgu,"");
            bs.DataSource = ds.Tables[0];
            if (bs.Count==0)
            {
                bs.AddNew();
            }
            txtSunucu.DataBindings.Add("Text", bs, "SERVER");
            txtVeritabani.DataBindings.Add("Text", bs, "DBNAME");
            txtKullanici.DataBindings.Add("Text", bs, "USERNAME");
            txtSifre.DataBindings.Add("Text", bs, "PASSWORD");
            txtSorgu.DataBindings.Add("Text", bs, "QUERY");
            bs.MoveFirst();
            txtPassword.Text = AppParams.fnc.TextSifreCoz(txtSifre.Text, "+pwd");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtSunucu.TextLength == 0 || txtVeritabani.TextLength == 0 || txtKullanici.TextLength == 0 || txtSorgu.TextLength == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik Bilgi", "Lütfen gerekli alanları doldurun! ");
                return;
            }
            txtSifre.Text = AppParams.fnc.TextSifrele(txtPassword.Text, "+pwd");
    
            bs.EndEdit();
            if (ds.Tables[0].Rows[0].RowState == DataRowState.Modified)
            {
                ds.Tables[0].Rows[0]["CHANGEBY"] = AppParams.User;
                ds.Tables[0].Rows[0]["CHANGEDATE"] = DateTime.Now;
            }
            if (ds.Tables[0].Rows[0].RowState == DataRowState.Added)
            {
                ds.Tables[0].Rows[0]["ID"] = 1;
                ds.Tables[0].Rows[0]["CHANGEBY"] = AppParams.User;
                ds.Tables[0].Rows[0]["CHANGEDATE"] = DateTime.Now;
            }
            AppParams.DbCon.UpdateDataSetEx(ds);
            AppParams.fnc.WriteLog("Aktarım tanımları değiştirildi.", "*", this.FormCode);
            Close();
                        }
            catch (Exception ex)
            {
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
