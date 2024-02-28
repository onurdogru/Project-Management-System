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
    public partial class FrmDosyalar : BaseForm
    {
        public FrmDosyalar()
        {
            InitializeComponent();
        }

        string KlasorNo = "";
        string KlasorAdi = "";

        private void FrmDosyalar_Load(object sender, EventArgs e)
        {
            btnAra.PerformClick();
        }

        private void txtKlasorAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btkYeniKlasor_Click(object sender, EventArgs e)
        {
            FrmDosyaYeniKlasor yk = new FrmDosyaYeniKlasor();
            if (yk.ShowDialog()== DialogResult.OK)
            {
                btnAra.PerformClick();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GrdKlasor.DataSource = AppParams.DbCon.GetDataTable("Select *,(Select count(*) from ARGFILES where Folderno=ARGFOLDERS.folderno)FILENUMBER from ARGFOLDERS where Folderno like '%" + txtKlasorNo.Text +
                "%' and FolderName like '%"+txtKlasorAdi.Text+"%' and Createdby like '%"+txtKlasorOlusturan.Text+"%' ");
        }

        private void GrdKlasor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                string projeNo = "";
                if (GrdKlasor.SelectedRows.Count > 0)
                    KlasorNo = GrdKlasor.SelectedRows[0].Cells["colKlasorNo"].Value.ToString();
                KlasorAdi = GrdKlasor.SelectedRows[0].Cells["colKlasorAdi"].Value.ToString();
                FrmDosyaDetay fd = new FrmDosyaDetay();
                fd.KlasorNo = KlasorNo;
                fd.KlasorAdi = KlasorAdi;
                fd.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
