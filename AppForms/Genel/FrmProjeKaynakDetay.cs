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
    public partial class FrmProjeKaynakDetay : BaseForm
    {
        public string Source = "";
        BindingSource Bs = new BindingSource();
        DataSet Ds = new DataSet();
        public FrmProjeKaynakDetay()
        {
            InitializeComponent();
        }

        private void FrmProjeKaynakDetay_Load(object sender, EventArgs e)
        {
            string[] sqls = { "Select * from LIST_SOURCE WHERE source='" + Source + "'" };
            Ds = AppParams.DbCon.GetDataSetEx(sqls, "");
            Bs.DataSource = Ds.Tables[0];
            txtKaynakKodu .DataBindings.Add("Text", Bs, "SOURCE");
            txtKaynakAdi.DataBindings.Add("Text", Bs, "DESCRIPTION");
            cbAktif.DataBindings.Add("Checked", Bs, "PASSIVE");
            if (Ds.Tables[0].Rows.Count==0)
            {
                Bs.AddNew();
            }
            loadgrup();
        }

        private void txtGrupSec_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm frm = new Sistem.SearchForm("Select USERNAME KullaniciKodu,FULLNAME KullaniciIsmi from ARGUSERS where ISSOURCE=1 ");
            if (frm.ShowDialog() == DialogResult.OK)
            {
               txtGrupSec.Text =  frm.Sonuc[0];
            }
        }

        private void btnGrubaEkle_Click(object sender, EventArgs e)
        {
            if (txtGrupSec.Text != "")
            {
             string sonuc =   AppParams.DbCon.ExecCommand("Insert into LIST_SOURCEMEMBER(SOURCE,USERNAME,TYPE,CHANGEDBY,CHANGEDATE) values ('" +
                    Source + "','" + txtGrupSec.Text + "','0','" + AppParams.User + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')", "");
                loadgrup();
            }
        }

        private void btnGruptanCikar_Click(object sender, EventArgs e)
        {
            if (GrdGrup.SelectedRows.Count > 0 && AppParams.fnc.SoruSor("Seçili Gruptan kaldırmak istiyor musunuz?") == true)
            {
                string gr = GrdGrup.SelectedRows[0].Cells[0].Value.ToString();
                AppParams.DbCon.ExecCommand("DELETE FROM LIST_SOURCEMEMBER WHERE SOURCE='" + Source + "' and USERNAME='" + gr + "' ", "");
                loadgrup();
            }
        }
        void loadgrup()
        {
            GrdGrup.DataSource = AppParams.DbCon.GetDataTable("Select USERNAME from LIST_SOURCEMEMBER where SOURCE='" + Source + "'");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Bs.EndEdit();
                if (AppParams.DbCon.GetDataTable("Select * from ARGUSERS where USERNAME='" + Source + "'").Rows.Count>0)
                {
                    AppParams.fnc.Mesaj_Hata("Kaydetmede Hata!", "Kaynak olarak belirtilen kod Kullanıcılar tablosunda kullanıldığında kayedilemedi! "+Source);
                    return;
                }
                string ret = AppParams.DbCon.UpdateDataSetEx(Ds);
                 AppParams.fnc.WriteLog(txtKaynakKodu.Text+" Proje kaynağı kaydedildi.","",this.FormCode);
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kaydetmede Hata!", ex.Message);
                this.DialogResult = DialogResult.Abort;
                return;
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (AppParams.fnc.SoruSor("Seçili Kaynağı kalıcı olarak kaldırmak istiyor musunuz?") == true && kaynakKontrol() ==0)
            {
                try
                {
                AppParams.DbCon.ExecCommand("DELETE FROM LIST_SOURCE WHERE SOURCE='" + Source + "' ", "");
                AppParams.fnc.WriteLog(txtKaynakKodu.Text + " Proje kaynağı silindi.", "", this.FormCode);
                this.DialogResult = DialogResult.OK;
                Close();
                }
                catch (Exception ex)
                {
                }


            }
        }

        int kaynakKontrol()
        {
            int ret = 0;
            if (AppParams.DbCon.GetDataTable("Select top 1 source  from PROJECTPLANSTEPS where Source='" + Source + "' ").Rows.Count > 0)
            {
                ret = 1;
                AppParams.fnc.Mesaj_Hata("Hata", "Bu kaynak Proje planlarında kullanıldığından silinemez! Belki Pasif edilebilir.");
            }
            return ret;
        }


    }
}
