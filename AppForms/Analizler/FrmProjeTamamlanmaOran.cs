using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Analizler
{
    public partial class FrmProjeTamamlanmaOran : BaseForm
    {
        string seciliproje = "";
        public FrmProjeTamamlanmaOran()
        {
            InitializeComponent();
        }

        private void FrmProjeTamamlanmaOran_Load(object sender, EventArgs e)
        {
            txtPStatu.DataSource = AppParams.DbCon.GetDataTable("Select -1 STATUS ,'Tümü '  DESCRIPTION  UNION ALL Select STATUS,DESCRIPTION from LIST_PROJECTSTATUS WHERE PASIF=0 ");
            txtPStatu.ValueMember = "STATUS";
            txtPStatu.DisplayMember = "DESCRIPTION";
            txtPStatu.SelectedValue = -1;
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            string sql = "SELECT Isnull(p.PRONUM,g.PRONUM2)  PROJEKODU,STEXT AS PROJEADI, PLANSURE,ISNULL(CALISMASURE,0) CALISMASURE,PLANSURE-ISNULL(CALISMASURE,0) FARK,CAST((ISNULL(CALISMASURE,0) / PLANSURE)*100 AS INT) ORAN,BASLAMA,BITIS,"+
                "CASE WHEN (PLANSURE-ISNULL(CALISMASURE,0))>0 THEN CAST(((PLANSURE-ISNULL(CALISMASURE,0))/9) AS DECIMAL(8,2)) ELSE 0 END KALANGUN FROM  " +
                "( Select PRONUM,SUM(CASE WHEN HOURS=0 THEN (CASE WHEN DATEDIFF(day,STARTDATE,STOPDATE)>0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE 1 END) ELSE HOURS END)PLANSURE,MIN(STARTDATE)BASLAMA, MAX(STOPDATE)BITIS from PROJECTPLANSTEPS WHERE PRONUM>'' GROUP BY PRONUM) P " +
                "LEFT join  (select PRONUM PRONUM2,SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS] WHERE PRONUM>''  GROUP BY PRONUM ) G  ON  (P.PRONUM=G.PRONUM2) "+  
                "LEFT JOIN DEMANDS D ON D.PRONUM=P.PRONUM WHERE 1=1 AND P.PRONUM LIKE '%"+txtProjeNo.Text+"%'";
            if (txtPStatu.SelectedValue.ToString() != "-1")
            {
                sql = sql + " and D.PSTATUS=" + txtPStatu.SelectedValue.ToString();
            }

                GrdReport.DataSource = AppParams.DbCon.GetDataTable(sql);


        }

        private void txtProjeNo_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sfp = new Sistem.SearchForm("Select Pronum ProjeKodu,stext ProjeAdi from DEMANDS WHERE PSTATUS IN (3,4) AND ISDELETE=0");
            sfp.ShowDialog();
            if (sfp.DialogResult == DialogResult.OK)
                ((Control)sender).Parent.Text = sfp.Sonuc[0];
        }

        private void GrdReport_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            seciliproje = GrdReport.Rows[e.RowIndex].Cells["ProjeKodu"].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void GrdReport_DoubleClick(object sender, EventArgs e)
        {
            DetayGoster();
        }

        void DetayGoster()
        {
            Analizler.FrmProjeTamamlanmaDetay frm = new FrmProjeTamamlanmaDetay();
            frm.ProjeNo = seciliproje;
            frm.ShowDialog();
        }
    }
}
