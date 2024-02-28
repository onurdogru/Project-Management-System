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
    public partial class FrmProjeListesi : BaseForm
    {

        string seciliproje = "";
        public FrmProjeListesi()
        {
            InitializeComponent();
        }

        private void FrmProjeListesi_Load(object sender, EventArgs e)
        {
            cbProjeTips.DataSource = AppParams.DbCon.GetDataTable(" Select STATUS,DESCRIPTION from LIST_PROJECTSTATUS WHERE PASIF=0  UNION ALL Select -1 STATUS ,'Tümü ' DESCRIPTION");
            cbProjeTips.ValueMember = "STATUS";
            cbProjeTips.DisplayMember = "DESCRIPTION";
            cbProjeTips.SelectedValue = -1;
            load();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            string sql = "Select PRONUM ProjeKodu,PTYPE ProjeTipi,S.DESCRIPTION Durum,STEXT ProjeAdi,CUSTOMER Musteri,PROTYPE ProjeTuru,CREATEDBY TalepEden,CREATEDATE TalepTarihi,CONFIRMBY Onaylayan,RESPONSIBLE0 ProjeSorumlusu,DELIVERYDATE IstenenTeslimTarihi from DEMANDS D LEFT JOIN LIST_PROJECTSTATUS S ON D.PSTATUS=S.STATUS  "+
                "where ISDELETE=0 and (pronum like '%" + txtProjeNo.Text + "%' OR stext like '%" + txtProjeNo.Text + "%') and RESPONSIBLE0 like '%" + txtProjeSorumlusu.Text + "%'";
            if ((int)cbProjeTips.SelectedValue > -1) sql = sql + " and PStatus='" + cbProjeTips.SelectedValue.ToString() + "'";
            GrdProjeList.DataSource = AppParams.DbCon.GetDataTable(sql);
            GrdProjeList.Columns["TalepTarihi"].DefaultCellStyle.Format = "yyyy.MM.dd";
            GrdProjeList.Columns["IstenenTeslimTarihi"].DefaultCellStyle.Format = "yyyy.MM.dd";
        }

        private void GrdProjeList_DoubleClick(object sender, EventArgs e)
        {
            btnProjeKart.PerformClick();
        }

        private void btnProjeKart_Click(object sender, EventArgs e)
        {
            FrmProjeKart frm = new FrmProjeKart();
            frm.ProjeKodu = seciliproje;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void GrdProjeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            seciliproje = GrdProjeList.Rows[e.RowIndex].Cells["ProjeKodu"].Value.ToString();
        }

        private void txtProjeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrdProjeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbProjeTips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GrdProjeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          //  btnProjeKart.PerformClick();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {

        }

        private void txtProjeSorumlusu_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select UserName Kullanıcı,FullName AdSoyad from ARGUSERS where ISRESPONSIBLE=1  order by USERNAME");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtProjeSorumlusu.Text = sf.Sonuc[0];
        }
    }
}
