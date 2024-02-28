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
    public partial class FrmPersonelProjeCalismaDetay : BaseForm
    {
        public FrmPersonelProjeCalismaDetay()
        {
            InitializeComponent();
        }
        public DateTime Gun = new DateTime();
        public string Tesis = "";

        DataSet ds;
        BindingSource Bs = new BindingSource();
        private void FrmPersonelProjeCalismaDetay_Load(object sender, EventArgs e)
        {
            if (Gun.Year<2000) Gun = DateTime.Now;
            GrdKayit.AutoGenerateColumns = false;
            firstlload();
            txtGun.Text = Gun.Date.ToShortDateString();
            loadData();
            if (ds.Tables.Count>0 && ds.Tables[0].Rows.Count > 0)
            {
                txtGun.Text = ds.Tables[0].Rows[0]["workdate"].ToString();
              //  Gun.Date. = DateTime.Parse().Date ;
            }
        }

        void firstlload()
        {
            colKonum.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colKonum.DataSource = AppParams.DbCon.GetDataTable("Select STATUS,DESCRIPTION from LIST_PROJECTPERSTATUS order by ID");
            GrdKayit.DataSource = Bs;

            DataSet Dset = new DataSet();
            string sql = "Select STATUS,DESCRIPTION from LIST_PROJECTPERSTATUS order by ID" + (char)13 + "Select * from LIST_PROCESS order by Process" + (char)13 + " ";
            Dset = AppParams.DbCon.GetDataSet(sql, "");
            colKonum.DataSource = Dset.Tables[0];
            colKonum.ValueMember = "STATUS";
            colKonum.DisplayMember = "DESCRIPTION";
            colGorevTipi.DataSource = Dset.Tables[1];
            colGorevTipi.DisplayMember = "Description";
            colGorevTipi.ValueMember = "Process";
        }

        void loadData()
        {

            string[] sqls = { "Select * from PROJECTWORKS where WorkDate='" + txtGun.Value.ToString("yyyy-MM-dd") + "'  order by WorkDate,Worker Desc" };
            ds = AppParams.DbCon.GetDataSetEx(sqls,"");
            ds.EnforceConstraints = false;
            if (ds.Tables.Count != 0)
            { Bs.DataSource = ds.Tables[0]; }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           if  (AppParams.fnc.SoruSor("Değişiklikler kaydedilsin mi?")==true) 
           {
               foreach (DataGridViewRow dr in GrdKayit.Rows)
               { 
                   dr.Cells["colWorkDate"].Value = txtGun.Value.ToString("yyyy-MM-dd");
                   var ss = dr.Cells["colPersonel"].Value;
                   if ( dr.IsNewRow==false && ( dr.Cells["colPersonel"].Value ==null ||dr.Cells["colPersonel"].Value.ToString() ==""))
                   {
                       AppParams.fnc.Mesaj_Uyari("Eksik Bilgi  ", "Personel Kodu alanı boş bırakılmış. Kaydedilemedi!");
                       return;
                   }
               }
               Bs.EndEdit();
               string ret = AppParams.DbCon.UpdateDataSetEx(ds);
               if (ret.Substring(0,2)=="OK")
               {                
                   AppParams.fnc.Mesaj_Bilgi("Kayıt", "Kaydedildi.");
                   AppParams.fnc.WriteLog(txtGun.Text + " tarihli personel süreleri "+(GrdKayit.Rows.Count-1).ToString()+" satır ile güncellendi","*" , this.FormCode);
               }
               else
               {
                   AppParams.fnc.Mesaj_Hata("Hata", "Kaydedilemedi: \n" + ret);
               }


           }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void GrdKayit_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            bC_Label1.Text = e.Exception.ToString();
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = GrdKayit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)GrdKayit.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)GrdKayit.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
            e.Cancel = true;
        }

        private void colPersonel_Button_Click(object sender, EventArgs e)
        {
            if (GrdKayit.CurrentCell.OwningColumn.Name == "colPersonel")
            {
                Button ss = sender as Button;
                var ssf = ss.Parent.Name;
                Sistem.SearchForm sf = new Sistem.SearchForm("Select UserName Kullanici,FullName IsimSoyisim from ARGUSERS WHERE ISSOURCE=1");
                sf.ShowDialog();
                if (sf.DialogResult == DialogResult.OK)
                    ((Control)sender).Parent.Text = sf.Sonuc[0];
            }
        }

        private void colProjeKodu_Button_Click(object sender, EventArgs e)
        {
            if (GrdKayit.CurrentCell.OwningColumn.Name == "colProjeKodu")
            {
                Sistem.SearchForm sfp = new Sistem.SearchForm("Select Pronum ProjeKodu,stext ProjeAdi from DEMANDS WHERE PSTATUS IN (3,4)");
                sfp.ShowDialog();
                if (sfp.DialogResult == DialogResult.OK)
                {
                    ((Control)sender).Parent.Text = sfp.Sonuc[0];
                    ((Control)sender).Parent.Update();
                }
            }
        }

        private void GrdKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrdKayit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GrdKayit.Columns["colProjeKodu"].Index == e.ColumnIndex)
                {
                    GrdKayit.Rows[e.RowIndex].Cells["colProjeKodu"].Value.ToString();
                    getPersonelBilgi(GrdKayit.Rows[e.RowIndex].Cells["colProjeKodu"].Value.ToString(),
                        GrdKayit.Rows[e.RowIndex].Cells["colPersonel"].Value.ToString(),
                        GrdKayit.Rows[e.RowIndex].Cells["colGorevTipi"].Value.ToString());
                }
            }
            catch { }
        }

        private void GrdKayit_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GrdKayit.Rows[e.RowIndex].Cells["colProjeKodu"].Value.ToString();
                getPersonelBilgi(GrdKayit.Rows[e.RowIndex].Cells["colProjeKodu"].Value.ToString(),
                    GrdKayit.Rows[e.RowIndex].Cells["colPersonel"].Value.ToString(),
                    GrdKayit.Rows[e.RowIndex].Cells["colGorevTipi"].Value.ToString());
            }
            catch { }
        }

        void getPersonelBilgi(string proje,string kaynak,string gorev)
        {
            lbPersonel.Text = AppParams.fnc.getDataCell("exec sp_GetProjectPlanHour '" + proje + "','" + kaynak + "','" + gorev + "'");
        }

        private void btnPastEx_Click(object sender, EventArgs e)
        {
            PasteInData(GrdKayit);
        }
        static void PasteInData( DataGridView dgv)
        {
            char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
            char columnSplitter = '\t';         // Tab.

            IDataObject dataInClipboard = Clipboard.GetDataObject();

            string stringInClipboard =
                dataInClipboard.GetData(DataFormats.Text).ToString();

            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter,
                StringSplitOptions.RemoveEmptyEntries);

            int r = dgv.SelectedCells[0].RowIndex;
            int c = dgv.SelectedCells[0].ColumnIndex;

            if (dgv.Rows.Count < (r + rowsInClipboard.Length))
                dgv.Rows.Add(r + rowsInClipboard.Length - dgv.Rows.Count);

            // Loop through lines:

            int iRow = 0;
            while (iRow < rowsInClipboard.Length)
            {
                // Split up rows to get individual cells:

                string[] valuesInRow =
                    rowsInClipboard[iRow].Split(columnSplitter);

                // Cycle through cells.
                // Assign cell value only if within columns of grid:

                int jCol = 0;
                while (jCol < valuesInRow.Length)
                {
                    if ((dgv.ColumnCount - 1) >= (c + jCol))
                        dgv.Rows[r + iRow].Cells[c + jCol].Value =
                        valuesInRow[jCol];

                    jCol += 1;
                } // end while

                iRow += 1;
            } // end while
        }

        private void btnOtoGetir_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count == 0 )
            {
                DataTable tdt = AppParams.DbCon.GetDataTable(" Select WORKER from PROJECTWORKS where WORKDATE = (Select max(WORKDATE) from PROJECTWORKS(NOLOCK) ) order by WORKER");
                foreach (DataRow dr in tdt.Rows)
                {
                    ds.Tables[0].Rows.Add("0", "", "", "", txtGun.Value, dr[0].ToString(), "", "ARGE-ICI-CALISMA", "08:00");
                    // GrdKayit.Rows.Add(dr[0].ToString());
                }
                Bs.CurrencyManager.Refresh();
            }           
            else
            {
                AppParams.fnc.Mesaj_Uyari("Uyarı", "Bu işlem tablo tamamen boş iken yapılabilir!");
            }

        }

        private void btnGCBilgileri_Click(object sender, EventArgs e)
        {
            FrmPersonelProjeTurnikeBilgi frm = new FrmPersonelProjeTurnikeBilgi();
            frm.ShowDialog();
        }

        private void GrdKayit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void GrdKayit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        } // PasteInData
    }
}
