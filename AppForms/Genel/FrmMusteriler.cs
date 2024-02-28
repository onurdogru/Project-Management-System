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
    public partial class FrmMusteriler : Sistem.BaseRecordList
    {
        string MusteriKodu = "";
        public FrmMusteriler()
        {
            Sql = "Select Customer MusteriKodu,CustomerName MusteriAdi from CUSTOMERS ";
            InitializeComponent();
            FormCode = "MUSTERILISTESI";
            FormName = "Müşteriler";
        }

        public override void Yeni()
        {
            MusteriKodu = "";
            FrmMusteriDetay fm = new FrmMusteriDetay();
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
                RefresGrid();
            base.Yeni();
        }
        public override void Degistir()
        {
            if (GrdList.CurrentRow != null)
            {
                MusteriKodu = GrdList.CurrentRow.Cells["MusteriKodu"].Value.ToString();
                FrmMusteriDetay fm = new FrmMusteriDetay();
                fm.MusteriKodu = MusteriKodu;
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    RefresGrid();
                base.Degistir();
            }
        }

        public override void Sil()
        {
            MusteriKodu = GrdList.CurrentRow.Cells["MusteriKodu"].Value.ToString();
            if (AppParams.fnc.SilmeOnayi(MusteriKodu) == true)
            {
                if (AppParams.DbCon.GetDataTable("Select top 1 customer from Demands where customer='" + MusteriKodu + "'").Rows.Count == 0)
                {
                    AppParams.DbCon.ExecCommand("Delete from CUSTOMERS where customer='" + MusteriKodu + "'", "");
                     AppParams.fnc.WriteLog(MusteriKodu + " nolu müşteri silindi.","",this.FormCode);
                    RefresGrid();
                }
                else
                { AppParams.fnc.Mesaj_Uyari("Silme Kontrol", " Seçilen kayıt taleplerde kullanılmış silinemez!"); }
            }
            base.Sil();
        }
    }
}
