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
    public partial class FrmProjeOnay : BaseForm
    {
        public FrmProjeOnay()
        {
            InitializeComponent();
            FormCode = "PROJEONAYLAMA";
            FormName = "Proje Onaylama";
        }
        DataTable Dt;

        private void FrmProjeOnay_Load(object sender, EventArgs e)
        {
            LoadRecord(txtProjeNo.Text,txtSorumlu.Text);
        }

        void LoadRecord(string pn, string sorml)
        {
            Dt = AppParams.DbCon.GetDataTable("Select convert(varchar,CREATEDATE,104) TalepTarihi, PRONUM ProjeKodu, STEXT ProjeAdi,Customer Musteri,Protype ProjeTipi,CREATEDBY TalepEden,RESPONSIBLE0 Sorumlu,DELIVERYDATE TeslimTarihi,PDELIVERYDATE PlanlananTeslimTarihi "+
                " ,convert(varchar, convert(money,(Select ISNULL(sum(TOTALAMOUNT),0)  from PROJECTPLANCOST where pronum=Demands.Pronum)+(select ISNULL(sum(TOTALWAGES ),0)  from PROJECTPLANSTEPS where pronum=Demands.Pronum))) PlanlananMaliyet from DEMANDS where PSTATUS=2 and Pronum like '%" + pn + "%' and RESPONSIBLE0 like '%" + sorml + "%'");
          GrdProjeList.DataSource = Dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadRecord(txtProjeNo.Text, txtSorumlu.Text);
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (txtSeciliProje.Text != "")
            {
                if (MessageBox.Show(txtSeciliProje.Text + " nolu projeyi onaylamak istiyor musunuz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cmd = "Update Demands set PSTATUS=3, ISCONFIRM=2 ,PCONFIRMBY='" + AppParams.User + "', PCONFIRMDATE='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now) + "',CONFIRMDESC= '" + txtAciklama.Text + "' where pronum='" + txtSeciliProje.Text + "'";
                    //    string ss = AppParams.DbCon.ExecCommand(cmd, "").Substring(0, 2);
                    if (AppParams.DbCon.ExecCommand(cmd, "").Substring(0, 2) == "OK")
                    {
                        MessageBox.Show("Proje Onaylandı.", "Bilgi");
                        AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Proje Onaylandı", txtSeciliProje.Text,this.FormCode);
                    }
                    else
                    {
                        MessageBox.Show("Proje Onaylanamadı! Logları Kontrol Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Proje Onaylanamadı",txtProjeNo.Text, this.FormCode);
                    }
                    btnListele.PerformClick();
                }
            }
        }

        private void btnProjeBilgileri_Click(object sender, EventArgs e)
        {
            Projeler.FrmProjeKart pkrt = new Projeler.FrmProjeKart();
            pkrt.ProjeKodu = txtSeciliProje.Text;
            pkrt.ShowDialog();
        }

        private void GrdProjeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSeciliProje.Text = GrdProjeList.Rows[e.RowIndex].Cells["ProjeKodu"].Value.ToString();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (txtSeciliProje.Text != "")
            {
                if (MessageBox.Show(txtSeciliProje.Text + " nolu proje reddedilecek onaylıyor musunuz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cmd = "Update Demands set PSTATUS=9, ISCONFIRM=2 ,PCONFIRMBY='" + AppParams.User + "', PCONFIRMDATE='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now) + "',CONFIRMDESC= '" + txtAciklama.Text + "' where pronum='" + txtSeciliProje.Text + "'";
                    //    string ss = AppParams.DbCon.ExecCommand(cmd, "").Substring(0, 2);
                    if (AppParams.DbCon.ExecCommand(cmd, "").Substring(0, 2) == "OK")
                    {
                        MessageBox.Show("Proje Reddedildi.", "Bilgi");
                        AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Proje Onaylandı", txtSeciliProje.Text, this.FormCode);
                    }
                    else
                    {
                        MessageBox.Show("Proje Reddedilemedi! Logları Kontrol Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Proje Reddedilemedi", txtSeciliProje.Text, this.FormCode);
                    }
                    btnListele.PerformClick();
                }
            }
        }
    }
}
