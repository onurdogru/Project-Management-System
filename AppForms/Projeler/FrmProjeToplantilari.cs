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
    public partial class FrmProjeToplantilari : BaseForm
    {
        public string ToplantiKodu="";
        public string starih = "0";
        public FrmProjeToplantilari()
        {
            InitializeComponent();
        }

        private void FrmProjeToplantilari_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void GrdToplantiListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ToplantiKodu = GrdToplantiListe.Rows[e.RowIndex].Cells["ToplantiNo"].Value.ToString();
            starih = GrdToplantiListe.Rows[e.RowIndex].Cells["STarih"].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmProjeToplantilariDetay frm = new FrmProjeToplantilariDetay();
            frm.ToplantiNo = "";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadList();
            }
        }

        void LoadList()
        {
            GrdToplantiListe.DataSource = AppParams.DbCon.GetDataTable("Select TARIH Tarih, TOPLANTIID ToplantiNo,ProjeNo,Konu,DateDIFF(DAY,TARIH,Getdate()) as STarih from MEETINGS order by TARIH DESC ");
            GrdToplantiListe.Columns["STarih"].Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ToplantiKodu != "")
            {
                FrmProjeToplantilariDetay frm = new FrmProjeToplantilariDetay();
                if (int.Parse(starih) > 15)
                {
                    frm.btnKaydet.Enabled = false;
                }

                frm.ToplantiNo = ToplantiKodu;
                
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadList();
                }
            }
        }



    }
}
