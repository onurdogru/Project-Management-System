using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Genel
{
    public partial class FrmSaatUcretleri : BaseForm
    {
        public FrmSaatUcretleri()
        {
            InitializeComponent();
        }

        private void FrmSaatUcretleri_Load(object sender, EventArgs e)
        {
            btnListele.PerformClick();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
            GrdListe.DataSource = AppParams.DbCon.GetDataTable("Select ID, Source Kaynak,StartDate BaslamaTarihi,StopDate BitisTarihi,Wages Ucret from SOURCEWAGES where Source like '%"+txtKaynak.Text+"%' ");
            GrdListe.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt Hatası", ex.Message);
            }

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Genel.FrmSaatUcretleriDetay sdt = new FrmSaatUcretleriDetay();
            sdt.KayitTipi = 1;
            sdt.ShowDialog();
            btnListele.PerformClick();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (GrdListe.SelectedRows.Count>0)
            { 
            Genel.FrmSaatUcretleriDetay sdt = new FrmSaatUcretleriDetay();
            sdt.KayitTipi = 2;
            sdt.KayitID = GrdListe.SelectedRows[0].Cells[0].Value.ToString();
            sdt.ShowDialog();
            btnListele.PerformClick();
            }
        }
    }
}
