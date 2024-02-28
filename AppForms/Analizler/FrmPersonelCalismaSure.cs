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
    public partial class FrmPersonelCalismaSure : BaseForm
    {
        public FrmPersonelCalismaSure()
        {
            InitializeComponent();
        }

        private void FrmPersonelCalismaSure_Load(object sender, EventArgs e)
        {

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            string sql = "Select WORKER Calisan,sum(DURATION) TeorikSure,sum(CASE WHEN  PRONUM>'' THEN DURATION ELSE 0 END) CalismaSuresi,ISNULL(MAX(S.PROSUM),0)ProjeSayisi from [dbo].[PROJECTWORKS] R " +
"LEFT JOIN ( SELECT SOURCE ,SUM(1)PROSUM FROM  ( Select SOURCE,PRONUM from PROJECTPLANSTEPS(NOLOCK) WHERE PRONUM>'' and STARTDATE>'2018.01.01' GROUP BY SOURCE,PRONUM) A GROUP BY SOURCE)S " +
"ON R.WORKER=S.SOURCE WHERE R.WORKER LIKE '%" + txtPersonel.Text + "%' AND R.WORKDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND R.WORKDATE<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' AND R.PRONUM LIKE '%" + txtProjeNo.Text + "%' GROUP BY WORKER";

            GrdReport.DataSource = AppParams.DbCon.GetDataTable(sql);
        }

        private void txtProjeNo_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sfp = new Sistem.SearchForm("Select Pronum ProjeKodu,stext ProjeAdi from DEMANDS WHERE PSTATUS IN (3,4) AND ISDELETE=0");
            sfp.ShowDialog();
            if (sfp.DialogResult == DialogResult.OK)
                ((Control)sender).Parent.Text = sfp.Sonuc[0];
        }

        private void txtPersonel_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm(("Select S.* from (Select S.SOURCE Kaynak, MIN(STARTDATE) GuncelProjeBaslangici,dbo.GetWorkEndDate(S.SOURCE)OnerilenYeniProjeTarihi,round(sum(HOURS)/9.0,1) ToplamGun,sum(HOURS)ToplamSaat " +
 "from (Select SOURCE,DESCRIPTION from LIST_SOURCE union all select USERNAME,FULLNAME from ARGUSERS where ISSOURCE=1 ) S LEFT JOIN (SELECT * FROM PROJECTPLANSTEPS) P ON S.SOURCE=P.SOURCE  group by S.SOURCE)S "));
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK && sf.Sonuc[0] != "")
            {
                ((Control)sender).Parent.Text = sf.Sonuc[0];
            }
        }
    }
}
