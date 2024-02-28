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
    public partial class FrmProjeGorevTipleri : BaseForm
    {
        string Gorevtipi = "";
        public FrmProjeGorevTipleri()
        {
            InitializeComponent();
        }

        private void FrmProjeGorevTipleri_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        void LoadList()
        {
            GrdKaynakListe.DataSource = AppParams.DbCon.GetDataTable("Select Process GorevTipi,Description Aciklama,OrderNo ListeSirasi from LIST_PROCESS ORDER BY PROCESS ");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmProjeGorevTipDetay frm = new FrmProjeGorevTipDetay();
            frm.Gorevtipi = "";
            frm.KayitTipi = 1;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmProjeGorevTipDetay frm = new FrmProjeGorevTipDetay();
            frm.Gorevtipi = Gorevtipi;
            frm.KayitTipi = 2;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }

        private void GrdKaynakListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Gorevtipi = GrdKaynakListe.Rows[e.RowIndex].Cells["GorevTipi"].Value.ToString();
        }
    }
}
