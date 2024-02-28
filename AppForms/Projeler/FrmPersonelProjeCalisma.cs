using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Projeler
{
    public partial class FrmPersonelProjeCalisma : BaseForm
    {
        public FrmPersonelProjeCalisma()
        {
            InitializeComponent();
        }

        private void FrmPersonelProjeCalisma_Load(object sender, EventArgs e)
        {
            GrdListe.AutoGenerateColumns = false;
            listele();
        }

        void listele()
        {
            GrdListe.DataSource = AppParams.DbCon.GetDataTable("Select WORKDATE Tarih ,SUM(1) Calisan from PROJECTWORKS group by WORKDATE order by WorkDate Desc ");
        }

        private void btn_Detay_Click(object sender, EventArgs e)
        {
            string Tesis = "";
            DateTime Tarih = new DateTime();
            if (GrdListe.SelectedRows.Count > 0)
            {
              //  Tesis = GrdListe.SelectedRows[0].Cells["colTesis"].Value.ToString();
                Tarih = Convert.ToDateTime( GrdListe.SelectedRows[0].Cells["colTarih"].Value.ToString());
            }

            FrmPersonelProjeCalismaDetay nfrm = new FrmPersonelProjeCalismaDetay();
            nfrm.Tesis = Tesis;
            nfrm.Gun = Tarih;
            nfrm.ShowDialog();
        }

        private void GrdListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void GrdListe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnDetay.PerformClick();
        }


    }
}
