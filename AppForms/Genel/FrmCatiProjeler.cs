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
    public partial class FrmCatiProjeler : Sistem.BaseRecordList
    {
        string CatiProje = "";
        public FrmCatiProjeler()
        {
            Sql = "Select MAINPROJECT CatiProjeKodu,PROJECTNAME ProjeAdi,PLANT Tesis from MAINPROJECTS ";
            InitializeComponent();
            FormCode = "CATIPROJELER";
            FormName = "Çatı Projeler";
        }

        private void FrmCatiProjeler_Load(object sender, EventArgs e)
        {

        }

        public override void Yeni()
        {
            CatiProje = "";
            FrmCatiProjeDetay fm = new FrmCatiProjeDetay();
            fm.ShowDialog();
            if (fm.DialogResult == DialogResult.OK)
                RefresGrid();
            base.Yeni();
        }
        public override void Degistir()
        {
            if (GrdList.CurrentRow != null)
            {
                CatiProje = GrdList.CurrentRow.Cells["CatiProjeKodu"].Value.ToString();
                FrmCatiProjeDetay fm = new FrmCatiProjeDetay();
                fm.CatiProje = CatiProje;
                fm.ShowDialog();
                if (fm.DialogResult == DialogResult.OK)
                    RefresGrid();
                base.Degistir();
            }
        }

        public override void Sil()
        {
            CatiProje = GrdList.CurrentRow.Cells["CatiProjeKodu"].Value.ToString();
            if (AppParams.fnc.SilmeOnayi(CatiProje) == true)
            {
                if (AppParams.DbCon.GetDataTable("Select top 1 MAINPROJECT from MAINPROJECTS where MAINPROJECT='" + CatiProje + "'").Rows.Count == 0)
                {
                    AppParams.DbCon.ExecCommand("Delete from MAINPROJECTS where MAINPROJECT='" + CatiProje + "'", "");
                    RefresGrid();
                }
                else
                { AppParams.fnc.Mesaj_Uyari("Silme Kontrol", " Seçilen çatı proje taleplerde kullanılmış silinemez!"); }
            }
            base.Sil();
        }
    }
}
