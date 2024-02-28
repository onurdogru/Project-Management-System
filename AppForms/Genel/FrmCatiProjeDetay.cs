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
    public partial class FrmCatiProjeDetay : BaseForm
    {
        public string CatiProje = "";
        DataSet dsRec = new DataSet();
        BindingSource bs = new BindingSource();
        DataTable dtProject = new DataTable();
        public FrmCatiProjeDetay()
        {
            InitializeComponent();
            FormCode = "CATIPROJEGIRIS";
            FormName = "Çatı Proje Kayıt Ekranı";
        }

        private void FrmCatiProjeDetay_Load(object sender, EventArgs e)
        {
            try
            {
                string[] sql = { "Select * from MAINPROJECTS where MAINPROJECT='" + CatiProje + "'" };
                if (CatiProje != "") txtProjeKodu.ReadOnly = true;
                dsRec = AppParams.DbCon.GetDataSetEx(sql, "");
                dsRec.EnforceConstraints = false;
                bs.DataSource = dsRec.Tables[0];
                txtProjeKodu.DataBindings.Add("Text", bs, "MAINPROJECT");
                txtProjeAdi.DataBindings.Add("Text", bs, "PROJECTNAME");
                txtTesis.DataBindings.Add("Text", bs, "PLANT");
                txtAciklama.DataBindings.Add("Text", bs, "DESCRIPTION");
                GrdProjeler.AutoGenerateColumns = false;
                if (bs.Count == 0)
                {
                    bs.AddNew();
                    GrdProjeler.Enabled = false;
                }
                else
                {
                    txtProjeKodu.ReadOnly = true;
                    txtTesis.ReadOnly = true;
                    DataSet ds = AppParams.DbCon.GetDataSet("Select PRONUM,STEXT,COSTCENTER from DEMANDS where PLANT='"+txtTesis.Text+"' and MAINPROJECT='" + txtProjeKodu.Text+ "' ","");
                    ds.EnforceConstraints = false;
                    dtProject = ds.Tables[0];
                    dtProject.Constraints.Clear();
                    GrdProjeler.DataSource = dtProject;
                    GrdProjeler.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProjeKodu_TextChanged(object sender, EventArgs e)
        {
            txtProjeKodu.Text = txtProjeKodu.Text.Replace(" ", "");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtProjeKodu.Text == "" || txtTesis.Text == "")
            {
                AppParams.fnc.Mesaj_Uyari("Eksik bilgi", "Çatı Proje Kodu ve Tesis alanları boş brakılamaz!");
                return;
            }
            try
            {
                bs.EndEdit();
                string ret = AppParams.DbCon.UpdateDataSetEx(dsRec);
                if (ret.Substring(0, 2) == "OK")
                {
                    if (SetProje() == true)
                    {
                        this.DialogResult = DialogResult.OK;
                        AppParams.fnc.WriteLog(CatiProje + " Çatı proje de değişikli yapıldı",txtProjeKodu.Text,this.FormCode);
                        this.Close();
                    }
                }
                else
                { AppParams.fnc.Mesaj_Hata("HATA", "Bir hata oluştu! Kayıt işlemi gerçekleştirilemedi. Logları kontrol edin."); }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Hata", ex.Message);
            }

        }

        bool SetProje()
        {
            bool ret =true;
            string ins = "";
            dtProject.EndInit();
            try
            {
                foreach (DataRow dr in dtProject.Rows)
                {
                    if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                    {
                        string pronum = dr["PRONUM"].ToString();
                        string ccenter = dr["COSTCENTER"].ToString();
                        ins = ins + " UPDATE DEMANDS SET MAINPROJECT ='" + txtProjeKodu.Text + "',COSTCENTER='"+ccenter+"'  WHERE PRONUM='" + pronum + "' AND PLANT='" + txtTesis.Text + "' " + (char)13;
                    }
                    if (dr.RowState == DataRowState.Deleted )
                    { 
                        string pronum = dr["PRONUM",DataRowVersion.Original].ToString();
                        ins = ins + " UPDATE DEMANDS SET MAINPROJECT ='' WHERE PRONUM='" + pronum + "' AND PLANT='" + txtTesis.Text + "' " + (char)13;
                    }
                }
               if (ins!="") AppParams.DbCon.ExecCommand(ins, "");
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Eksik Kayıt Hatası", "Bağlı projeler kaydedilemedi!  " + ex.Message);
                return false;
            }

            return ret;
        }

        private void txtTesis_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select PLANT Tesis, DESCRIPTION Tanim from PLANTS");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                ((Control)sender).Parent.Text = sf.Sonuc[0];
        }

        private void colProjeKodu_Button_Click(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm(" SELECT PRONUM ProjeKodu, STEXT ProjeAdi from DEMANDS WHERE (MAINPROJECT='' or  MAINPROJECT IS null) AND PLANT='" + txtTesis.Text + "' ");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
            {
                ((Control)sender).Parent.Text = sf.Sonuc[0];
            }
        }

        private void GrdProjeler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           // MessageBox.Show(e.Exception.Message);
            e.Cancel = true;
        }


        private void bC_Button2_Click(object sender, EventArgs e)
        {
            colProjeNo.Button_Click -= new EventHandler(colProjeKodu_Button_Click);
            colProjeNo.Button_Click += new EventHandler(colProjeKodu_Button_Click);
            //colProjeNo.DataPropertyName = "PRONUM";
            GrdProjeler.DataSource = null;
            GrdProjeler.DataSource = dsRec.Tables[1];
        }

    }
}
