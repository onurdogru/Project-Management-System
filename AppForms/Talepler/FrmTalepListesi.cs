using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Talepler
{
    public partial class FrmTalepListesi : BaseForm
    {
        string SecilenProje = "";
        public FrmTalepListesi()
        {
            InitializeComponent();
            FormCode = "";
            FormName = "Talep Listesi";
        }

        private void FrmTalepListesi_Load(object sender, EventArgs e)
        {
            getList(""," Pronum Desc");
        }

        void getList(string wherecon,string order)
        {
            GrdTalepList.DataSource = ALPARGE.AppParams.DbCon.GetDataTable("SELECT CREATEDATE TalepTarihi, PRONUM ProjeNo,STEXT ProjeAdi,CUSTOMER Musteri,DELIVERYDATE TeslimTarihi,PTYPE EkipmanTipi,CREATEDBY TalepEden FROM DEMANDS WHERE ISDELETE=0 and PSTATUS=0 "+ wherecon+" Order By "+order);
        }

        private void btnYeniTalep_Click(object sender, EventArgs e)
        {
            ALPARGE.AppForms.Talepler.FrmTalepGiris TalepFormu = new FrmTalepGiris(1,"");
            TalepFormu.ShowDialog();
            TalepFormu.Dispose();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            getList(" and PRONUM like '%"+txtTalepNo.Text+"%' "," Pronum desc");
        }

        private void btnTalepDuzenle_Click(object sender, EventArgs e)
        {
            ALPARGE.AppForms.Talepler.FrmTalepGiris TalepFormu = new FrmTalepGiris(2, SecilenProje);
           // TalepFormu.ProjeNo = "";
            TalepFormu.ShowDialog();
            TalepFormu.Dispose();
        }

        private void GrdTalepList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SecilenProje = GrdTalepList.Rows[e.RowIndex].Cells["ProjeNo"].Value.ToString();
        }

        private void GrdTalepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
