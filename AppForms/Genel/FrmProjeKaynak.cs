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
    public partial class FrmProjeKaynak : BaseForm
    {
        string source = "";
        public FrmProjeKaynak()
        {
            InitializeComponent();
        }

        private void FrmProjeKaynak_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        void LoadList()
        {
            GrdKaynakListe.DataSource = AppParams.DbCon.GetDataTable("Select SOURCE Kaynak,DESCRIPTION Aciklama,CHANGEDBY SonDegistiren,CHANGEDATE DegisiklikTarihi from LIST_SOURCE order by SOURCE ");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmProjeKaynakDetay frm = new FrmProjeKaynakDetay();
            frm.Source = "";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (source != "")
            {
                FrmProjeKaynakDetay frm = new FrmProjeKaynakDetay();
                frm.Source = source;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadList();
                }
            }
        }

        private void GrdKaynakListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            source = GrdKaynakListe.Rows[e.RowIndex].Cells["Kaynak"].Value.ToString();
        }
    }
}
