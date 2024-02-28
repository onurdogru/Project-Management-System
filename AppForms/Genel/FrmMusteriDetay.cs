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
    public partial class FrmMusteriDetay : BaseForm
    {
        public string MusteriKodu = "";
        DataSet dsRec = new DataSet();
        BindingSource bs = new BindingSource();
        public FrmMusteriDetay()
        {
            InitializeComponent();
            FormCode = "";
            FormName = "MUSTERI DETAY";
        }

        private void FrmMusteriDetay_Load(object sender, EventArgs e)
        {
            try
            {
                string[] sql = { "Select * from CUSTOMERS where customer='"+MusteriKodu+"'"};
                if (MusteriKodu != "") txtMusteriKodu.ReadOnly = true;
                dsRec = AppParams.DbCon.GetDataSetEx(sql,"");
                bs.DataSource=dsRec.Tables[0];
                txtMusteriKodu.DataBindings.Add("Text", bs, "CUSTOMER");
                txtMusteriAdi.DataBindings.Add("Text", bs, "CUSTOMERname");
                if (bs.Count == 0) bs.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMusteriKodu_TextChanged(object sender, EventArgs e)
        {
            txtMusteriKodu.Text = txtMusteriKodu.Text.Replace(" ", "");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bs.EndEdit();
                string ret = AppParams.DbCon.UpdateDataSetEx(dsRec);
                if (ret.Substring(0, 2) == "OK")
                {
                 //   AppParams.fnc.Mesaj_Bilgi("Kayıt", "Müşteri Kaydedildi!");
                    this.DialogResult = DialogResult.OK;
                     AppParams.fnc.WriteLog(txtMusteriKodu.Text + " " + txtMusteriAdi.Text +" Müşteri kaydedildi","",this.FormCode);
                    this.Close();
                }
                else
                { AppParams.fnc.Mesaj_Hata("HATA", "Bir hata oluştu! Kayıt işlemi gerçekleştirilemedi. Logları kontrol edin."); }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Hata", ex.Message);
            }

        }
    }
}
