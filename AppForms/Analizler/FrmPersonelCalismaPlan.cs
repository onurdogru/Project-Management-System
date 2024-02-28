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
    public partial class FrmPersonelCalismaPlan : BaseForm
    {
        public FrmPersonelCalismaPlan()
        {
            InitializeComponent();
        }

        private void FrmPersonelCalismaPlan_Load(object sender, EventArgs e)
        {

        }

        private void btnOku_Click(object sender, EventArgs e)
        {


            string sql = "  SELECT P.WORKER Calisan  ,ISNULL(D.PRONUM,P.PRONUM) ProjeNo,P.PROCESS GorevTipi,   "+
"MAX(P.PLANSURE) PlanlananSure,SUM(ISNULL(P.CALISMASURE,0))CalismaSuresi ,"+
"case when MAX(P.PLANSURE) - SUM(ISNULL(P.CALISMASURE,0))<0 then 0 else  MAX(P.PLANSURE) - SUM(ISNULL(P.CALISMASURE,0))end KalanSure ,"+
"AVG(CONVERT(INT,(ISNULL(P.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani  ,"+
"(Select top 1 PDELIVERYDATE from DEMANDS WHERE PRONUM=ISNULL(D.PRONUM,P.PRONUM)) SonTeslimTarihi  "+
"FROM DEMANDS D  inner join(  SELECT Isnull(p.PRONUM,g.PRONUM2) PRONUM, SOURCE,PLANSURE,BASLAMA, BITIS,PROCESS,PROCESS2,WORKER2 AS WORKER,CALISMASURE  "+
 "FROM   ( Select COMPANY,PRONUM,SOURCE, SUM(CASE WHEN HOURS=0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE HOURS END)PLANSURE,"+
" MIN(STARTDATE)BASLAMA, 	 MAX(STOPDATE)BITIS,PROCESS from PROJECTPLANSTEPS GROUP BY COMPANY,PRONUM,SOURCE,PROCESS) P    "+
 "inner join  (select COMPANY COMPANY2,PRONUM PRONUM2,WORKER WORKER2,PROCESS PROCESS2,"+
 "SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS] WHERE PRONUM>'' AND WORKER>'' AND PROCESS>'' "+
" GROUP BY COMPANY,WORKER,PRONUM,PROCESS) G   ON  (P.PRONUM=G.PRONUM2  AND (P.PROCESS=G.PROCESS2) AND (P.SOURCE=G.WORKER2) )   "+
 ")P ON  P.PRONUM=D.PRONUM  WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%' and P.SOURCE LIKE '%" + txtPersonel.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
" GROUP BY P.SOURCE,RESPONSIBLE0,ISNULL(D.PRONUM,P.PRONUM),P.PROCESS,P.PROCESS2 ,P.BASLAMA,P.BITIS ,P.WORKER "+
" Order By P.SOURCE,RESPONSIBLE0,ISNULL(D.PRONUM,P.PRONUM) ,P.PROCESS,P.PROCESS2 ,P.BASLAMA,P.BITIS ,P.WORKER ";
            GrdReport.DataSource = AppParams.DbCon.GetDataTable(sql);
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

        private void txtProjeNo_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sfp = new Sistem.SearchForm("Select Pronum ProjeKodu,stext ProjeAdi from DEMANDS WHERE PSTATUS IN (3,4) AND ISDELETE=0" );
            sfp.ShowDialog();
            if (sfp.DialogResult == DialogResult.OK)
                ((Control)sender).Parent.Text = sfp.Sonuc[0];
        }

        private void txtProjeNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
