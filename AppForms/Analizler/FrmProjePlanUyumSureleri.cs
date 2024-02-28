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
    public partial class FrmProjePlanUyumSureleri : BaseForm
    {
        public FrmProjePlanUyumSureleri()
        {
            InitializeComponent();
        }

        private void FrmProjePlanUyumSureleri_Load(object sender, EventArgs e)
        {

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            string sql = "Declare @wc int, @wk int; set @wc=0; set @wk=0;  set @wc=1;  set @wk=1;  ";
            string join = " full outer join ";
            if (cbTamEsleme.Checked == true)
            {
                join = " inner join ";
            }

            sql = "Declare  @wc int, @wk int; set @wc=0; set @wk=0;  set @wc=1;  set @wk=1;  " + (char)13 +
    "SELECT ISNULL(D.PRONUM,P.PRONUM) ProjeNo,RESPONSIBLE0 Sorumlu   ,  " + (char)13 +
"MAX(P.PLANSURE) PlanlananSure,SUM(ISNULL(P.CALISMASURE,0))CalismaSuresi ,  " + (char)13 +
"AVG(CONVERT(INT,(ISNULL(P.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani  , " + (char)13 +
"max(P.pronum) p2 FROM DEMANDS D  inner join(  " + (char)13 +
"SELECT Isnull(p.PRONUM,g.PRONUM2) PRONUM,PLANSURE,BASLAMA,BITIS,CALISMASURE   " + (char)13 +
"FROM   (Select COMPANY,PRONUM,SUM(CASE WHEN HOURS=0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE HOURS END)PLANSURE,MIN(STARTDATE)BASLAMA, 	MAX(STOPDATE)BITIS  " + (char)13 +
"from PROJECTPLANSTEPS WHERE SOURCE LIKE '%" + txtKaynak.Text + "%' GROUP BY COMPANY,PRONUM) P  " + join + "   " + (char)13 +
"  (select COMPANY COMPANY2,PRONUM PRONUM2,SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS]  " + (char)13 +
"WHERE PRONUM>''  AND WORKER>'' AND PROCESS>'' GROUP BY COMPANY,PRONUM) G  	 " + (char)13 +
"ON  (P.PRONUM=G.PRONUM2  )   )P ON  P.PRONUM=D.PRONUM  " + (char)13 +
"WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%' AND RESPONSIBLE0 LIKE '%" + txtSorumlu.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'AND D.CREATEDATE<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'  " + (char)13 +
"GROUP BY ISNULL(D.PRONUM,P.PRONUM),RESPONSIBLE0,P.BASLAMA,P.BITIS   " + (char)13 +
"Order By ISNULL(D.PRONUM,P.PRONUM)  ,P.BASLAMA,P.BITIS  ";

            if (cbKaynak.Checked == true)
            {
                sql = "Declare  @wc int, @wk int; set @wc=0; set @wk=0;  set @wc=1;  set @wk=1;  " + (char)13 + 
                    "SELECT ISNULL(D.PRONUM,P.PRONUM) ProjeNo,RESPONSIBLE0 Sorumlu ,P.SOURCE Kaynak,P.WORKER Calisan  ,  " + (char)13 +
 "MAX(P.PLANSURE) PlanlananSure,SUM(ISNULL(P.CALISMASURE,0))CalismaSuresi ,  " + (char)13 +
 "AVG(CONVERT(INT,(ISNULL(P.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani  , " + (char)13 +
 "max(P.pronum) p2 FROM DEMANDS D  inner join(  " + (char)13 +
 "SELECT Isnull(p.PRONUM,g.PRONUM2) PRONUM,SOURCE,PLANSURE,BASLAMA,BITIS, G.WORKER  AS WORKER,CALISMASURE   " + (char)13 +
 "FROM   (Select COMPANY,PRONUM,SOURCE,SUM(CASE WHEN HOURS=0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE HOURS END)PLANSURE,MIN(STARTDATE)BASLAMA, 	MAX(STOPDATE)BITIS  " + (char)13 +
 "from PROJECTPLANSTEPS WHERE SOURCE LIKE '%" + txtKaynak.Text + "%' GROUP BY COMPANY,PRONUM,SOURCE) P  " + join + "   " + (char)13 +
 "  (select COMPANY COMPANY2,PRONUM PRONUM2,WORKER,SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS]  " + (char)13 +
 "WHERE PRONUM>''  AND WORKER>'' AND PROCESS>'' GROUP BY COMPANY,PRONUM,WORKER) G  	 " + (char)13 +
 "ON  (P.PRONUM=G.PRONUM2   AND (P.SOURCE=G.WORKER) )   )P ON  P.PRONUM=D.PRONUM  " + (char)13 +
 "WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%' and P.SOURCE LIKE '%" + txtKaynak.Text + "%' AND RESPONSIBLE0 LIKE '%" + txtSorumlu.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'AND D.CREATEDATE<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'  " + (char)13 +
 "GROUP BY ISNULL(D.PRONUM,P.PRONUM),RESPONSIBLE0,P.BASLAMA,P.BITIS ,P.SOURCE,P.WORKER  " + (char)13 +
 "Order By ISNULL(D.PRONUM,P.PRONUM)  ,P.BASLAMA,P.BITIS ,P.SOURCE,P.WORKER ";
            }

            if (cbGorevTip.Checked == true)            
            {
                sql = "Declare   @wc int, @wk int; set @wc=0; set @wk=0;  set @wc=1;  set @wk=1;  " + (char)13 +
                    "SELECT ISNULL(D.PRONUM,P.PRONUM) ProjeNo,RESPONSIBLE0 Sorumlu,P.PROCESS GorevTipi,P.PROCESS2 YapilanIs  ,  " + (char)13 +
"MAX(P.PLANSURE) PlanlananSure,SUM(ISNULL(P.CALISMASURE,0))CalismaSuresi ,  " + (char)13 +
"AVG(CONVERT(INT,(ISNULL(P.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani  , " + (char)13 +
"max(P.pronum) p2 FROM DEMANDS D  inner join(  " + (char)13 +
"SELECT Isnull(p.PRONUM,g.PRONUM2) PRONUM,PLANSURE,BASLAMA,BITIS,P.PROCESS,G.PROCESS PROCESS2,CALISMASURE   " + (char)13 +
"FROM   (Select COMPANY,PRONUM,PROCESS,SUM(CASE WHEN HOURS=0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE HOURS END)PLANSURE,MIN(STARTDATE)BASLAMA, 	MAX(STOPDATE)BITIS  " + (char)13 +
"from PROJECTPLANSTEPS WHERE SOURCE LIKE '%" + txtKaynak.Text + "%' GROUP BY COMPANY,PRONUM,PROCESS) P  " + join + "   " + (char)13 +
"  (select COMPANY COMPANY2,PRONUM PRONUM2,PROCESS,SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS]  " + (char)13 +
"WHERE PRONUM>''  AND WORKER>'' AND PROCESS>'' and WORKER LIKE '%" + txtKaynak.Text + "%' GROUP BY COMPANY,PRONUM,PROCESS) G  	 " + (char)13 +
"ON  (P.PRONUM=G.PRONUM2  AND (P.PROCESS=G.PROCESS)  )   )P ON  P.PRONUM=D.PRONUM  " + (char)13 +
"WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%'  AND RESPONSIBLE0 LIKE '%" + txtSorumlu.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'AND D.CREATEDATE<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'  " + (char)13 +
"GROUP BY ISNULL(D.PRONUM,P.PRONUM),RESPONSIBLE0,P.PROCESS,P.PROCESS2 ,P.BASLAMA,P.BITIS  " + (char)13 +
"Order By ISNULL(D.PRONUM,P.PRONUM) ,P.PROCESS,P.PROCESS2 ,P.BASLAMA,P.BITIS  ";
            }

            if (cbGorevTip.Checked == true && cbKaynak.Checked == true)
            {
                sql = "Declare @wc int, @wk int; set @wc=0; set @wk=0;  set @wc=1;  set @wk=1;  " + (char)13 +
                    "SELECT ISNULL(D.PRONUM,P.PRONUM) ProjeNo,RESPONSIBLE0 Sorumlu,P.PROCESS GorevTipi,P.PROCESS2 YapilanIs  ,P.SOURCE Kaynak,P.WORKER Calisan  ,  " + (char)13 +
    "MAX(P.PLANSURE) PlanlananSure,SUM(ISNULL(P.CALISMASURE,0))CalismaSuresi ,  " + (char)13 +
    "AVG(CONVERT(INT,(ISNULL(P.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani  , " + (char)13 +
    "max(P.pronum) p2 FROM DEMANDS D  inner join(  " + (char)13 +
    "SELECT Isnull(p.PRONUM,g.PRONUM2) PRONUM,SOURCE,PLANSURE,BASLAMA,BITIS,P.PROCESS,G.PROCESS PROCESS2, G.WORKER  AS WORKER,CALISMASURE   " + (char)13 +
    "FROM   (Select COMPANY,PRONUM,PROCESS,SOURCE,SUM(CASE WHEN HOURS=0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE HOURS END)PLANSURE,MIN(STARTDATE)BASLAMA, 	MAX(STOPDATE)BITIS  " + (char)13 +
    "from PROJECTPLANSTEPS WHERE SOURCE LIKE '%" + txtKaynak.Text + "%' GROUP BY COMPANY,PRONUM,PROCESS,SOURCE) P  " + join + "    " + (char)13 +
    " (select COMPANY COMPANY2,PRONUM PRONUM2,PROCESS,WORKER,SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS]  " + (char)13 +
    "WHERE PRONUM>''  AND WORKER>'' AND PROCESS>'' GROUP BY COMPANY,PRONUM,PROCESS,WORKER) G  	 " + (char)13 +
    "ON  (P.PRONUM=G.PRONUM2  AND (P.PROCESS=G.PROCESS) AND (P.SOURCE=G.WORKER ) )   )P ON  P.PRONUM=D.PRONUM  " + (char)13 +
    "WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%' and P.SOURCE LIKE '%" + txtKaynak.Text + "%' AND RESPONSIBLE0 LIKE '%" + txtSorumlu.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'AND D.CREATEDATE<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'  " + (char)13 +
    "GROUP BY ISNULL(D.PRONUM,P.PRONUM),RESPONSIBLE0,P.PROCESS,P.PROCESS2 ,P.BASLAMA,P.BITIS ,P.SOURCE,P.WORKER  " + (char)13 +
    "Order By ISNULL(D.PRONUM,P.PRONUM) ,P.PROCESS,P.PROCESS2 ,P.BASLAMA,P.BITIS ,P.SOURCE,P.WORKER ";
            }


            GrdReport.Columns.Clear();



  //          sql = "Declare @wc int, @wk int; set @wc=0; set @wk=0; " + varyant+
  //" SELECT ISNULL(D.PRONUM,P.PRONUM) ProjeNo,RESPONSIBLE0 Sorumlu" + Sel + " ,  " +
  //" MAX(P.PLANSURE) PlanlananSure,SUM(ISNULL(P.CALISMASURE,0))CalismaSuresi ,AVG(CONVERT(INT,(ISNULL(P.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani  " +
  //",max(P.pronum) p2 FROM DEMANDS D  inner join( " + (char)13+
  //" SELECT Isnull(p.PRONUM,g.PRONUM2) PRONUM,SOURCE,PLANSURE,BASLAMA,BITIS,P.PROCESS,G.PROCESS PROCESS2, G.WORKER AS WORKER,CALISMASURE  FROM  " +
  //" (Select COMPANY,PRONUM"+sub1+",SUM(CASE WHEN HOURS=0 THEN DATEDIFF(day,STARTDATE,STOPDATE)*9 ELSE HOURS END)PLANSURE,MIN(STARTDATE)BASLAMA, " +
  //"	MAX(STOPDATE)BITIS from PROJECTPLANSTEPS GROUP BY COMPANY,PRONUM"+sub1+") P   " + join +
  //" (select COMPANY COMPANY2,PRONUM PRONUM2"+sub2+",SUM(DURATION)CALISMASURE from [dbo].[PROJECTWORKS] WHERE PRONUM>'' "+
  //" AND WORKER>'' AND PROCESS>'' GROUP BY COMPANY,PRONUM"+sub2+") G  " +
  //"	ON  (P.PRONUM=G.PRONUM2  AND (P.PROCESS=G.PROCESS OR @wc=0) AND (P.SOURCE=G.WORKER OR @wk=0) )  " +
  //" )P ON  P.PRONUM=D.PRONUM " + (char)13 +
  //" WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%' and P.SOURCE LIKE '%" + txtKaynak.Text + "%' AND RESPONSIBLE0 LIKE '%" + txtSorumlu.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'AND D.CREATEDATE<='" + txtBitTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
  //" GROUP BY ISNULL(D.PRONUM,P.PRONUM),RESPONSIBLE0" + Group + " Order By ISNULL(D.PRONUM,P.PRONUM) " + Group;

            GrdReport.DataSource = AppParams.DbCon.GetDataTable(sql);

            return;



        //     sql = "SELECT ISNULL(P.PRONUM,G.PRONUM) ProjeNo,RESPONSIBLE0 Sorumlu"+Sel+",P.BASLAMA Baslama,P.BITIS Bitis,SUM(P.PLANSURE) PlanlananSüre,SUM(ISNULL(G.CALISMASURE,0))CalismaSüresi "+
        //    ",AVG(CONVERT(INT,(ISNULL(G.CALISMASURE,0))/(CASE WHEN ISNULL(P.PLANSURE,1)<1 THEN 1 ELSE ISNULL(P.PLANSURE,1) END)*100)) TamamlanmaOrani FROM " +
        //"(Select COMPANY,PRONUM,SOURCE,SUM(HOURS)PLANSURE,MIN(STARTDATE)BASLAMA,MAX(STOPDATE)BITIS,PROCESS from PROJECTPLANSTEPS  GROUP BY COMPANY,PRONUM,SOURCE,PROCESS)P " +
        //"full outer JOIN (select COMPANY,PRONUM,WORKER,SUM(DURATION)CALISMASURE,PROCESS from [dbo].[PROJECTWORKS] GROUP BY COMPANY,PRONUM,WORKER,PROCESS)G " +
        //"ON P.COMPANY=G.COMPANY AND P.PRONUM=G.PRONUM AND P.SOURCE= G.WORKER  " + Where +
        //"LEFT JOIN DEMANDS D ON (P.COMPANY=D.COMPANY OR G.COMPANY=D.COMPANY) AND (P.PRONUM=D.PRONUM OR G.PRONUM=D.PRONUM)" +
        //"WHERE P.PRONUM LIKE '%" + txtProjeNo.Text + "%' and P.SOURCE LIKE '%" + txtKaynak.Text + "%' AND RESPONSIBLE0 LIKE '%" + txtSorumlu.Text + "%' AND D.CREATEDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'AND D.DELIVERYDATE>='" + txtBasTarih.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
        //" GROUP BY ISNULL(P.PRONUM,G.PRONUM),RESPONSIBLE0" + Group + ",P.SOURCE,P.BASLAMA,P.BITIS  Order By ISNULL(P.PRONUM,G.PRONUM),P.Source";


          
        }

        private void txtProjeNo_ButtonClick(object sender, EventArgs e)
        {
                Sistem.SearchForm sfp = new Sistem.SearchForm("Select Pronum ProjeKodu,stext ProjeAdi from DEMANDS WHERE PSTATUS IN (3,4)");
                sfp.ShowDialog();
                if (sfp.DialogResult == DialogResult.OK)
                    ((Control)sender).Parent.Text = sfp.Sonuc[0];
        }

        private void txtKaynak_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm(("Select S.* from (Select S.SOURCE Kaynak, MIN(STARTDATE) GuncelProjeBaslangici,dbo.GetWorkEndDate(S.SOURCE)OnerilenYeniProjeTarihi,round(sum(HOURS)/9.0,1) ToplamGun,sum(HOURS)ToplamSaat "+
             "from (Select SOURCE,DESCRIPTION from LIST_SOURCE union all select USERNAME,FULLNAME from ARGUSERS where ISSOURCE=1 ) S LEFT JOIN (SELECT * FROM PROJECTPLANSTEPS) P ON S.SOURCE=P.SOURCE  group by S.SOURCE)S "));
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK && sf.Sonuc[0] != "")
            {
                ((Control)sender).Parent.Text = sf.Sonuc[0];
            }
        }

        private void GrdReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSorumlu_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm(("Select DISTINCT RESPONSIBLE0 ProjeSorumlusu from DEMANDS"));
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK && sf.Sonuc[0] != "")
            {
                ((Control)sender).Parent.Text = sf.Sonuc[0];
            }
        }
    }
}
