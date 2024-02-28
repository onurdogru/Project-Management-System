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
    public partial class FrmSaatUcretleriDetay : BaseForm
    {
        public FrmSaatUcretleriDetay()
        {
            InitializeComponent();
        }
        public string KayitID="-1";
        DataTable dt = new DataTable();
        private void FrmSaatUcretleriDetay_Load(object sender, EventArgs e)
        {
            if (KayitTipi == 1)
            {
                txtKaynak.Enabled = true;
            }

            if (KayitTipi==2)
            {
                getData();
                btnSil.Enabled = true;
            }
            txtUcret.Focus();
        }

        void getData()
        {
            dt = AppParams.DbCon.GetDataTable("Select * from SOURCEWAGES where ID="+KayitID);
            if (dt.Rows.Count > 0)
            {
                txtKaynak.Text = dt.Rows[0]["SOURCE"].ToString();
                txtBasTarih.Text = dt.Rows[0]["STARTDATE"].ToString();
                txtBitTarih.Text = dt.Rows[0]["STOPDATE"].ToString();
                txtUcret.Text = dt.Rows[0]["WAGES"].ToString();
                txtParaBirimi.Text = dt.Rows[0]["CURRENCY"].ToString();
                try
                {
                    txtAciklama.Text = AppParams.DbCon.GetDataTable("Select Process GorevTipi,Description Aciklama from LIST_PROCESS where Passive=0 and  Process='" +txtKaynak.Text+"'").Rows[0][1].ToString();
                }
                catch (Exception)
                {      }
              }
            else
            {
                KayitTipi = 1;
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {                
            string sql = "Select ID from SOURCEWAGES where source='" + txtKaynak.Text + "' and StopDate>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and StartDate<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and ID<>'"+KayitID+"' ";
            if (AppParams.DbCon.GetDataTable(sql).Rows.Count > 0)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt Çakışması", "Bu kaynak için bu tarih aralığında farklı bir kayıt var! \n Kaydedilemedi!");
                return;
            }
            try
            {

                if (KayitTipi == 1)
                {
                    string ret = AppParams.DbCon.ExecCommand("INSERT INTO SOURCEWAGES (SOURCE,WAGES,CURRENCY,STARTDATE,STOPDATE,CHANGEDBY,CHANGEDATE)" +
                        " VALUES ('" + txtKaynak.Text + "','" + txtUcret.Text.Replace(",", ".") + "','TL','" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + AppParams.User + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", "");
                }
                else
                {
                    string ret = AppParams.DbCon.ExecCommand("UPDATE SOURCEWAGES SET WAGES='" + txtUcret.Text.Replace(",",".") + "' ,CURRENCY='TL',STARTDATE='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',STOPDATE='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',CHANGEDBY='" + AppParams.User + "',CHANGEDATE='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE ID=" + KayitID, "");
                }

            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt Hatası", ex.Message);
            }
            finally
            {
                AppParams.fnc.WriteLog(txtKaynak.Text +" "+txtUcret.Text + " Saat ücreti kaydedildi.", "", this.FormCode);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtKaynak_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm(("Select Process GorevTipi,Description Aciklama from LIST_PROCESS where Passive!=1 "));
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK && sf.Sonuc[0] != "")
            {
                txtKaynak.Text= sf.Sonuc[0];
                txtAciklama.Text = sf.Sonuc[1];
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppParams.fnc.SilmeOnayi(txtKaynak.Text) && KayitTipi==2)
                {
                    string ret = AppParams.DbCon.ExecCommand("Delete From SOURCEWAGES where ID="+KayitID, "");
                }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt Hatası", ex.Message);
                return;
            }
            AppParams.fnc.WriteLog(txtKaynak.Text + " " + txtUcret.Text + " Saat ücreti silindi.", "", this.FormCode);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
