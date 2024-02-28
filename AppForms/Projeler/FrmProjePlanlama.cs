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
    public partial class FrmProjePlanlama : BaseForm
    {
        public string projeNo="";
        public FrmProjePlanlama()
        {
            InitializeComponent();
        }

        private void FrmProjePlanlama_Load(object sender, EventArgs e)
        {
            txtSorumlu.Text = AppParams.User;
            LoadGrid(" AND RESPONSIBLE0 like '%" + txtSorumlu.Text.Trim() + "%' ","");
        }

        void LoadGrid(string wherecon, string order)
        { 
            GrdProjeList.DataSource = ALPARGE.AppParams.DbCon.GetDataTable("SELECT PRONUM ProjeNo,STEXT ProjeAdi,RESPONSIBLE0 Sorumlu,CREATEDBY Olusturan,convert(varchar,CREATEDATE,103) AS TalepTarihi,convert(varchar, DELIVERYDATE, 103) AS TeslimTarihi,CUSTOMER Musteri,PROTYPE Tip,CONFIRMBY Onaylayan,CONFIRMDATE OnayTarihi "+
            ",convert(varchar, convert(money,(Select ISNULL(sum(TOTALAMOUNT),0)  from PROJECTPLANCOST where pronum=Demands.Pronum)+(select ISNULL(sum(TOTALWAGES ),0)  from PROJECTPLANSTEPS where pronum=Demands.Pronum)))  Maliyet FROM DEMANDS WHERE  PSTATUS IN (1,2) AND ISDELETE = '0' " //and PRONUM in (Select PRONUM from PROJECTS) "
            +wherecon+" Order by Pronum Desc");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string Kosul = "";
            if (txtProjeNo.Text != "") Kosul = " AND PRONUM like '%" + txtProjeNo.Text.Trim() + "%' ";
            if (txtSorumlu.Text != "") Kosul = Kosul + " AND RESPONSIBLE0 like '%" + txtSorumlu.Text.Trim() + "%' ";
            if (txtCatiProje.Text != "") Kosul = Kosul + " AND MASTERPROJECT like '%" + txtCatiProje.Text.Trim() + "%' ";

            LoadGrid(Kosul, "");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
            string projeNo = "";
            if (GrdProjeList.SelectedRows.Count>0)
                projeNo = GrdProjeList.SelectedRows[0].Cells["ProjeNo"].Value.ToString();
            FrmProjePlanDetay fd = new FrmProjePlanDetay();
            fd.ProjeNo = projeNo;
            fd.ShowDialog();
            fd.Dispose();
            }
            catch (Exception ex)
            {

            }

        }

        private void GrdProjeList_DoubleClick(object sender, EventArgs e)
        {
            btnDuzenle.PerformClick();
        }

        private void GrdProjeList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDuzenle.PerformClick();
        }


    }
}
