using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Sistem
{
    public partial class SearchForm : ALPARGE.BaseForm
    {
        public DataTable dataTable = new DataTable();
        public DataRow dataRow;
        public string Sql = "";
        public string[] Sonuc={"","","","","","","",""};

        public SearchForm( string sql)
        {
            Sql = sql;
            InitializeComponent();
        }

        private void XSearchForm_Load(object sender, EventArgs e)
        {
            this.Height = 405;
            LoadGrid(dataTable);
        }
        //---------------------------------------------------------------------------------------------
        public  void LoadGrid(DataTable DT)
        {
            try
            {
            DT = ALPARGE.AppParams.DbCon .GetDataTable(Sql);
            GRDListe.DataSource = DT;
            }
            catch (Exception)
            {

            }
        }
        //---------------------------------------------------------------------------------------------
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (GRDListe.CurrentRow != null && GRDListe.CurrentRow.DataBoundItem != null)
            {
                dataRow = ((DataRowView)GRDListe.CurrentRow.DataBoundItem).Row;
                try
                {
                    Sonuc[0] = dataRow[0].ToString();
                    Sonuc[1] = dataRow[1].ToString();
                    Sonuc[2] = dataRow[2].ToString();
                    Sonuc[3] = dataRow[3].ToString();
                    Sonuc[4] = dataRow[4].ToString();
                    Sonuc[5] = dataRow[5].ToString();
                    Sonuc[6] = dataRow[6].ToString();
                    Sonuc[7] = dataRow[7].ToString();
                }
                catch (Exception ex)
                {
                }

                this.DialogResult = DialogResult.OK;
                GRDListe.Columns.Clear();
                // Close();
            }
        }
        //---------------------------------------------------------------------------------------------
        private void DG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        //---------------------------------------------------------------------------------------------

        private void DG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                btnOk.PerformClick(); 
                //BtnOK_Click(sender, e); 
            }

            if (e.KeyCode == Keys.Escape)
            { btnCancel_Click(sender, e); }
        }
        //---------------------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Sonuc[0] = "";
            Sonuc[1] = "";
            Sonuc[2] = "";
            Sonuc[3] = "";
            Sonuc[4] = "";
            Sonuc[5] = "";
            Sonuc[6] = "";
            Sonuc[7] = "";
            this.DialogResult = DialogResult.Cancel;
            GRDListe.Columns.Clear();
        }
        //---------------------------------------------------------------------------------------------
        private void GWListe_DoubleClick(object sender, EventArgs e)
        {
            BtnOK_Click(sender, e);
        }

        private void XSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //btnCancel_Click(sender, e);
        }

        private void GRDListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnOK_Click(sender, e);
        }
    }
}
