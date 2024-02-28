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
    public partial class BaseRecordList : BaseForm
    {
        public string Sql = "";
        public BaseRecordList()
        {
            InitializeComponent();
        }
        public DataTable GrdDateTable = new DataTable();

        private void BaseRecordList_Load(object sender, EventArgs e)
        {
            try
            {
                
                GrdDateTable = ALPARGE.AppParams.DbCon.GetDataTable(Sql);
                GrdList.DataSource = GrdDateTable;
                foreach (var s in GrdDateTable.Columns)
                {  cbfilterfield.Items.Add(s.ToString()); }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public virtual void RefresGrid()
        {
            GrdDateTable = ALPARGE.AppParams.DbCon.GetDataTable(Sql);
            GrdList.DataSource = GrdDateTable;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Yeni();
        }
        public virtual void Yeni()
        {
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            Degistir();
        }
        public virtual void Degistir()
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }
        public virtual void Sil()
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cbfilterfield.Text == "")
            {
                MessageBox.Show("Aramak istediğiniz kolonu seçin!");
                cbfilterfield.Focus();
            }
            else
            {
                try
                {
                    DataView DV = new DataView(GrdDateTable);
                    DV.RowFilter = string.Format(cbfilterfield.Text + " LIKE '%{0}%'", txtSearch.Text);
                    GrdList.DataSource = DV;
                }
                catch (Exception)
                {
                }
            }

        }

    }
}
