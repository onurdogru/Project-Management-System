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
    public partial class FrmSorumluAtama : BaseForm
    {
        public FrmSorumluAtama()
        {
            InitializeComponent();
            FormCode = "PSORUMLUATAMA";
            FormName = "Proje Sorumlusu Atama";
        }


        private void FrmSorumluAtama_Load(object sender, EventArgs e)
        {
            listeyenile();
        }
 
        private void btnYenile_Click(object sender, EventArgs e)
        {
            listeyenile();
        }   

        void listeyenile()
        {
            GrdListe.DataSource = AppParams.DbCon.GetDataTable("Select Pronum ProjeNo,convert(varchar,CreateDate,104) Tarih,ptype ProjeTipi,stext Aciklama, createdby TalepEden,convert(varchar,DELIVERYDATE,104) TeslimTarihi,RESPONSIBLE0 Sorumlu from Demands where PSTATUS<2 and Isdelete=0");
        }

        private void GrdListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSecilenProje.Text = GrdListe.Rows[e.RowIndex].Cells["ProjeNo"].Value.ToString();
            txtProjeSorumlusu.Text = GrdListe.Rows[e.RowIndex].Cells["Sorumlu"].Value.ToString();
        }

        private void btnSorumluAta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtSecilenProje.Text + " nolu Proje sorumlusu " + txtProjeSorumlusu.Text + " olarak değiştirilecek onaylıyor musunuz?", "Proje Sorumlusu Değiştirme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sonuc = "";
                try
                {
                    sonuc = AppParams.DbCon.ExecCommand("Update Demands set RESPONSIBLE0='" + txtProjeSorumlusu.Text + "', RESPCHANGEDBY='" + AppParams.User + "', RESPCHANGEDATE='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now) + "' where pronum='" + txtSecilenProje.Text + "'", "");
                    AppParams.fnc.WriteLog("Proje sorumlusu atandı. " + txtProjeSorumlusu.Text + ">" + txtSecilenProje.Text, txtSecilenProje.Text, this.FormCode);
                    MessageBox.Show(txtSecilenProje.Text + " nolu projeye " + txtProjeSorumlusu.Text + " sorumlu olarak atandı!");
                    listeyenile();
                }
                catch (Exception ex)
                {
                    AppParams.fnc.WriteLog("Proje sorumlusu atanamadı! " + txtProjeSorumlusu.Text + ">" + txtSecilenProje.Text, txtSecilenProje.Text, this.FormCode);
                    MessageBox.Show("Proje sorumlusu atanamadı!");
                }
            }
        }

        private void txtProjeSorumlusu_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select UserName Kullanıcı,FullName AdSoyad from ARGUSERS where ISRESPONSIBLE=1  order by USERNAME");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtProjeSorumlusu.Text = sf.Sonuc[0];
        }
    }
}
