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
    public partial class FrmProjeKapamaOnay : BaseForm
    {
        public string ProjeNo = "";
        public string ProjeAdi = "";
        public string ProjeSorumlu = "";
        public FrmProjeKapamaOnay()
        {
            InitializeComponent();
        }

        private void FrmProjeKapamaOnay_Load(object sender, EventArgs e)
        {
            txtProjeNo.Text = ProjeNo;
            txtProjeAdı.Text = ProjeAdi;
            txtSorumlu.Text = ProjeSorumlu;
        }

        private void btnProjeKapat_Click(object sender, EventArgs e)
        {
            if (AppParams.fnc.SoruSor("Seçili projeyi kapatmak istiyor musunuz? \nProje üzerinde bir daha değişiklik yapılamayacak!")==true)
            {
                try
                {
                    string sql = "Update DEMANDS set PSTATUS=6, ISCLOSED=1 where pronum='" + ProjeNo + "' "+(char)13;
                    sql += "Update PROJECTFINISH set  ISCLOSED=1,CLOSENOTE='" + txtNot.Text + "',approved='" + AppParams.User + "',approvedate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'  where pronum='" + ProjeNo + "' ";
                    AppParams.DbCon.ExecCommand(sql, "");
                    AppParams.fnc.WriteLog(ProjeNo + " Nolu projeye kapatma onayı verildi.", ProjeNo, this.FormCode);
                }
                catch (Exception ex)
                {
                    AppParams.fnc.Mesaj_Hata("Kaydetme Hatası", ex.Message);
                }
            }
        }
    }
}
