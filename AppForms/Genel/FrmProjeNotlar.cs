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
    public partial class FrmProjeNotlar : BaseForm
    {
        public FrmProjeNotlar()
        {
            InitializeComponent();
        }

        private void FrmProjeNotlar_Load(object sender, EventArgs e)
        {
            GrdNotlar.AutoGenerateColumns = false;
            btnAra.PerformClick();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            GrdNotlar.DataSource = AppParams.DbCon.GetDataTable("Select * from TEXTNOTES where PRONUM like '%" + txtProjeNo.Text +
                "%' and USERNAME like '%" + txtOlusturan.Text + "%' and SUBJECT like '%" + txtKonu.Text + "%' Order By NDATE desc, PRONUM,USERNAME ");
        }

        private void btkYeni_Click(object sender, EventArgs e)
        {
            FrmProjeNotlarDetay pnt = new FrmProjeNotlarDetay();
            if (pnt.ShowDialog() == DialogResult.OK)
            {
                btnAra.PerformClick();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string Id = "0";
            try
            {
                if (GrdNotlar.SelectedRows.Count > 0)
                    Id = GrdNotlar.SelectedRows[0].Cells["colID"].Value.ToString();
                FrmProjeNotlarDetay pnt = new FrmProjeNotlarDetay();
                pnt.NotID = Id;
                if (pnt.ShowDialog() == DialogResult.OK)
                {
                    btnAra.PerformClick();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
