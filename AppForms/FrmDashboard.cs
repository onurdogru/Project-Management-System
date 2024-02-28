using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms
{
    public partial class FrmDashboard : BaseForm
    {

        DataTable dtf = new DataTable();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        void LoadProjects()
        {
            try
            {
               lbTum.Text =  ALPARGE.AppParams.fnc.getDataCell("Select sum(1)Sayi From DEMANDS where ISDELETE=0");
               lbOnonay.Text = GetProjectStatus(0,"");
               lbPlanlama.Text = GetProjectStatus(1, "");
               lbButceonay.Text = GetProjectStatus(2, "");
               lbDevamEden.Text = GetProjectStatus(3, "");
               lbBitisOnayinda.Text = GetProjectStatus(4, "");
               lbTamlanan.Text = GetProjectStatus(6, "");
              // lbPlaniyok.Text = GetProjectStatus(6, "");
               lbDurdurulan.Text = GetProjectStatus(7, "");
               lbIptaledilen.Text = GetProjectStatus(8, "");
               lbReddedilen.Text = GetProjectStatus(9, "");
               lbLidersiz.Text = AppParams.fnc.getDataCell("Select ISNULL(sum(1),0)Sayi From DEMANDS where ISDELETE=0 and pstatus=1 and RESPONSIBLE0<'0'");
               lbPlaniyok.Text = AppParams.fnc.getDataCell("Select sum(1)Sayi From DEMANDS where ISDELETE=0 AND PSTATUS<5 AND PRONUM NOT IN ( SELECT DISTINCT PRONUM FROM  PROJECTPLANSTEPS)");
            }
            catch (Exception ex)
            {
                ALPARGE.AppParams.fnc.LogWrite(ex.Message,0);
            }
        }

        string GetProjectStatus(int status,string Kosul)
        {
            string ret="0";
            try
            {
               ret =  ALPARGE.AppParams.fnc.getDataCell("Select sum(1)Sayi From DEMANDS where PSTATUS='"+status.ToString()+"' AND ISDELETE=0");
               if (ret == "") ret = "0";
            }
            catch (Exception ex)
            {
            }
            return ret;
        }

        private void bC_Panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bC_Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void lbTum_MouseClick(object sender, MouseEventArgs e)
        {
            dtf = AppParams.DbCon.GetDataTable("select pronum from DEMANDS where ISDELETE=0");
        }

        string GetProjectInfo(int status, DataTable dt)
        {
            string ret = "0";
            try
            {
                ret = ALPARGE.AppParams.fnc.getDataCell("Select sum(1)Sayi From DEMANDS where PSTATUS='" + status.ToString() + "' AND ISDELETE=0");
                if (ret == "") ret = "0";
            }
            catch (Exception ex)
            {
            }
            return ret;
        }
    }
}
