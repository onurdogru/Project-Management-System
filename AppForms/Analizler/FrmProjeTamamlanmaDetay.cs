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
    public partial class FrmProjeTamamlanmaDetay : BaseForm
    {
        public string ProjeNo = "";
        string seciligorev = "";
        DataSet Dset = new DataSet();
        public FrmProjeTamamlanmaDetay()
        {
            InitializeComponent();
        }

        private void FrmProjeTamamlanmaDetay_Load(object sender, EventArgs e)
        {
            txtProjeNo.Text = ProjeNo;
            LoadData();
        }

        void LoadData()
        {
            string Sqls =  "Select top 1 * from Demands where Pronum='" + ProjeNo +
                "' Select PROCESS GorevTipi,SOURCE Kaynak,HOURS Süre,STARTDATE BaslamaTarihi,STOPDATE BitisTarihi,DESCRIPTION Aciklama from PROJECTPLANSTEPS WHERE PRONUM='" + ProjeNo +
                                "' order by Process Select process GorevTipi,WORKER Calisan,WORKDATE CalismaTarihi,DURATION Sure,DESCRIPTION Aciklama from PROJECTWORKS WHERE PRONUM='" + ProjeNo + "' order by Process,WORKDATE "+
                            " Select process GorevTipi,WORKER Calisan,Sum(DURATION) Sure from PROJECTWORKS AS PROJEICMAL WHERE PRONUM='"+ProjeNo+"'group by process ,WORKER  order by PROCESS";
            Dset = AppParams.DbCon.GetDataSet(Sqls,"");
            txtProjeAdi.Text = Dset.Tables[0].Rows[0]["STEXT"].ToString();
            GrdPlan.DataSource = Dset.Tables[1];
            GrdCalisma.DataSource = Dset.Tables[3];
        }

        private void GrdPlan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            seciligorev = GrdPlan.Rows[e.RowIndex].Cells["GorevTipi"].Value.ToString();
            }
            catch (Exception)
            {

            }

        }

        private void cbDetay_CheckedChanged(object sender, EventArgs e)
        {
            GrdCalisma.Columns.Clear();
            if (cbDetay.Checked)
            {
                GrdCalisma.DataSource = Dset.Tables[2];
            }
            else
            {
                GrdCalisma.DataSource = Dset.Tables[3];
            }
        }
    }
}
