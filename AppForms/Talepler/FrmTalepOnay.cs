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
    public partial class FrmTalepOnay : BaseForm
    {
        public FrmTalepOnay()
        {
            InitializeComponent();
            FormCode = "TALEPONAYLAMA";
            FormName = "Talep Onaylama";
        }
        DataTable Dt;
        string Talepeden = "";

        private void FrmProjeOnay_Load(object sender, EventArgs e)
        {
            LoadRecord(txtProjeNo.Text);
        }

        void LoadRecord(string pn)
        {
            Dt = AppParams.DbCon.GetDataTable("Select CONVERT(VARCHAR,CREATEDATE,104) TalepTarihi, PRONUM ProjeKodu, STEXT ProjeAdi,Customer Musteri,Ptype ProjeTipi,CREATEDBY TalepEden,RESPONSIBLE1 Sorumlu,CONVERT(VARCHAR,DELIVERYDATE,104) TeslimTarihi from DEMANDS where ISDELETE=0 and PSTATUS=0 and Pronum like '" + pn + "%'");
          GrdProjeList.DataSource = Dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadRecord(txtProjeNo.Text);
        }

        //---------------- ONAY -------------------------------------------------
        private void btnOnay_Click(object sender, EventArgs e)
        {

            if (GrdProjeList.SelectedRows.Count > 0 && txtSeciliProje.Text != "")
            {
                if (MessageBox.Show( txtSeciliProje.Text + " nolu talebi onaylamak istiyor musunuz? ","Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    
               {
                   string cmd = "Update Demands set PSTATUS=1,ISCONFIRM=2 ,CONFIRMBY='" + AppParams.User + "', CONFIRMDATE='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now) + "',CONFIRMTEXT= '" + txtAciklama.Text + "' where pronum='" + txtSeciliProje.Text + "'";
                //    string ss = AppParams.DbCon.ExecCommand(cmd, "").Substring(0, 2);
                   if (AppParams.DbCon.ExecCommand(cmd, "").Substring(0, 2) == "OK")
                   {
                       MessageBox.Show("Talep Onaylandı.", "Bilgi");
                       if (AppParams.fnc.getUserMail(Talepeden) != "")
                           AppParams.fnc.Sndm(AppParams.fnc.getUserMail(Talepeden), "Talep Ön Onayları", "Arge talebiniz hakkında",
                         " " + txtSeciliProje.Text + " nolu talebiniz onaylanmıştır. ", true,true);
                       AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Talep Onaylandı", txtSeciliProje.Text, this.FormCode);
                       AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin), "Talep Onayı", "AlpArge Talep Onayı", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu talep onaylandı.", true, false);
                       AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin2), "Talep Onayı", "AlpArge Talep Onayı", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu talep onaylandı.", true, false);
                   }
                   else
                   {
                       MessageBox.Show("Talep Onaylanamadı! Logları Kontrol Edin", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                       AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Talep Onaylanamadı", txtSeciliProje.Text, this.FormCode);
                   }
               }
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text.Length < 2)
            {
                MessageBox.Show("Red açıklaması boş geçilemez!");
                return;
            }
            if (GrdProjeList.SelectedRows.Count > 0 && txtSeciliProje.Text != "")
            {
                if (MessageBox.Show( txtSeciliProje.Text + " nolu talebi reddetmek istiyor musunuz? ", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string cmd = "Update Demands set PSTATUS=9,ISCONFIRM=3 ,CONFIRMTEXT= '"+txtAciklama.Text+"' where pronum='" + txtSeciliProje.Text + "'";
                    if (AppParams.DbCon.ExecCommand(cmd, "").Substring(1, 2) == "OK")
                    {
                        MessageBox.Show("Talep Reddedildi.", "Bilgi");
                        if (AppParams.fnc.getUserMail(Talepeden) != "") AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.User), "Talep Ön Onayları", "Arge talebiniz hakkında",
                         " " + txtSeciliProje.Text + " nolu talebiniz reddedilmiştir. (" + txtAciklama.Text + ")", true,true);
                        AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Talep Reddedildi ", txtSeciliProje.Text, this.FormCode);
                    }
                    else
                    {
                        MessageBox.Show("Talep Onaylanamadı! Logları Kontrol Edin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AppParams.fnc.WriteLog(txtSeciliProje.Text + " Nolu Talep Reddedilemedi", txtSeciliProje.Text, this.FormCode);
                    }
                }
            }
        }

        void test()
        {
            try
            {
                AppParams.fnc.Sndm("kadir.erdeniz@alpplas.com","Teklif Onaylama", "Deneme", "Test içerik", true,false);
            }
            catch (Exception)
            {
                throw; 
            }
        }

        private void GrdProjeList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSeciliProje.Text = GrdProjeList.Rows[e.RowIndex].Cells["ProjeKodu"].Value.ToString();
            Talepeden = GrdProjeList.Rows[e.RowIndex].Cells["TalepEden"].Value.ToString();
        }

        private void btnProjeBilgileri_Click(object sender, EventArgs e)
        {
            Projeler.FrmProjeKart pkrt = new Projeler.FrmProjeKart();
            pkrt.ProjeKodu=txtSeciliProje.Text;
            pkrt.ShowDialog();
        }
    }
}
