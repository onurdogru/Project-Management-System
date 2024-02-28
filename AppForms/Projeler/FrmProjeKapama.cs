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
    public partial class FrmProjeKapama : BaseForm
    {
        public FrmProjeKapama()
        {
            InitializeComponent();
        }

        string seciliproje = "";
        string seciliprojeadi = "";
        string seciliprojesorumlu = "";
        string seciliprojeonay= "";
        private void FrmProjeKapama_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtProjeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            string sql = "Select case when PSTATUS=4 then 'Evet' else 'Hayır' end OnayBekleyen, PRONUM ProjeKodu,PTYPE ProjeTipi,PSTATUS Durum,STEXT ProjeAdi,CUSTOMER Musteri,PROTYPE ProjeTuru,CREATEDBY TelepEden,CREATEDATE TalepTarihi,CONFIRMBY Onaylayan,RESPONSIBLE0 ProjeSorumlusu,DELIVERYDATE IstenenTeslimTarihi,ENDDELIVERYDATE FiiliTeslim from DEMANDS where ISDELETE=0 and PSTATUS In (3,4) and pronum like '%" + txtProjeNo.Text + "%'";
            GrdProjeList.DataSource = AppParams.DbCon.GetDataTable(sql);
        }

        private void btnProjeKart_Click(object sender, EventArgs e)
        {
            FrmProjeKapamaDetay frm = new FrmProjeKapamaDetay();
            frm.ProjeKodu = seciliproje;
            frm.ShowDialog();
        }

        private void GrdProjeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            seciliproje = GrdProjeList.Rows[e.RowIndex].Cells["ProjeKodu"].Value.ToString();
            seciliprojeonay = GrdProjeList.Rows[e.RowIndex].Cells["OnayBekleyen"].Value.ToString();
            seciliprojeadi = GrdProjeList.Rows[e.RowIndex].Cells["ProjeAdi"].Value.ToString();
            seciliprojesorumlu = GrdProjeList.Rows[e.RowIndex].Cells["ProjeSorumlusu"].Value.ToString();
        }

        private void GrdProjeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnProjeKart.PerformClick();
        }

        private void btnProjeKapat_Click(object sender, EventArgs e)
        {
            if (GrdProjeList.SelectedRows.Count > 0 && seciliproje != ""  && seciliprojeonay=="Evet")
            {
                FrmProjeKapamaOnay pk = new FrmProjeKapamaOnay();
                pk.ProjeNo = seciliproje;
                pk.ProjeAdi = seciliprojeadi;
                pk.ProjeSorumlu = seciliprojesorumlu;
                pk.ShowDialog();
                btnYenile.PerformClick();
            }
            else
            {
                AppParams.fnc.Mesaj_Uyari("Hatalı Onay", "Yalnızca onay bekleyen projeler onaylanabilir! \n(Proje sorumlusundan ilgili projeyi onaya göndermesini isteyebilirsiniz.)");
            }
        }
    }
}
