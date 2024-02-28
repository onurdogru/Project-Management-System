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
    public partial class FrmProjeGorevTipDetay : BaseForm
    {
        public string Gorevtipi = "";
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public FrmProjeGorevTipDetay()
        {
            InitializeComponent();
        }

        private void FrmProjeGorevTipDetay_Load(object sender, EventArgs e)
        {
            string[] sqls = { "Select * from LIST_PROCESS where Process='" + Gorevtipi + "'" };
            ds = AppParams.DbCon.GetDataSetEx(sqls, "");
            bs.DataSource = ds.Tables[0];
            txtGorevTipi.DataBindings.Add("Text", bs, "Process");
            txtGorevAciklama.DataBindings.Add("Text", bs, "Description");
            txtDegistiren.DataBindings.Add("Text", bs, "ChangedBy");
            txtDegisTarih.DataBindings.Add("Text", bs, "ChangedDate");
            txtSira.DataBindings.Add("Text", bs, "OrderNo");
            txtPasif.DataBindings.Add("Checked", bs, "Passive");
            if (ds.Tables[0].Rows.Count == 0) { bs.AddNew(); }
            if (KayitTipi==2)
            {
                txtGorevTipi.ReadOnly = true;
               
            }
            else
            {
                txtSira.Text = "10";
                btnSil.Enabled = false;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                txtDegistiren.Text = AppParams.User;
                txtDegisTarih.Text = DateTime.Now.ToString();
            bs.EndEdit();
            AppParams.DbCon.UpdateDataSetEx(ds);
                 AppParams.fnc.WriteLog(txtGorevTipi.Text + " Görev tipi kaydedildi.","",this.FormCode);
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt Hatası", ex.Message);
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppParams.fnc.SilmeOnayi(Gorevtipi) && AppParams.DbCon.GetDataTable("Select * from PROJECTPLANSTEPS where Process='" + Gorevtipi + "'").Rows.Count > 0)
                {
                    AppParams.fnc.Mesaj_Hata("Kayıt Hatası", "Bu katıt kullanılmış silinemez!");
                    return;
                }
                bs.RemoveCurrent();
                bs.EndEdit();
                AppParams.DbCon.UpdateDataSetEx(ds);
                 AppParams.fnc.WriteLog(txtGorevTipi.Text+" Görev tipi silindi. ","",this.FormCode);
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt Hatası", ex.Message);
                return;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
