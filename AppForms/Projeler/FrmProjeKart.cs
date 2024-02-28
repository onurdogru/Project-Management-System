using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Projeler
{
    public partial class FrmProjeKart : BaseForm
    {
        public FrmProjeKart()
        {
            InitializeComponent();
        }
        public string ProjeKodu;
        DataSet Ds = new DataSet();
        DataTable DTProject = new DataTable();

        private void FrmProjeKart_Load(object sender, EventArgs e)
        {
            txtProjekodu.Text = ProjeKodu;
            firstload();
            loadData();
            getTalepbilgileri();
            getProjeBilgi();
            getKapanisBilgi();
            getPersonelBilgi();
            getLogs();
            loadfiles();
        }

        void firstload()
        {
            DataSet subitem = new DataSet();
            string sql = "SELECT * FROM LIST_DEMANDTYPES " + (char)13 +
                "Select * from LIST_PROJECTSTATUS where PASIF=0" + (char)13 +
                "Select * from LIST_COSTS" + (char)13 +
                "Select * from LIST_PROCESS" + (char)13 + 
                "Select * from LIST_CURTYPE" + (char)13 +
                "Select * from LIST_STEPS" + (char)13;
            subitem = AppParams.DbCon.GetDataSet(sql, "");
            txtTalepSekli.DataSource = subitem.Tables[0];
            txtTalepSekli.DisplayMember = "DESCRIPTION";
            txtTalepSekli.ValueMember = "DEMANDTYPE";

            txtProjeStatu.DataSource = subitem.Tables[1];
            txtProjeStatu.DisplayMember = "DESCRIPTION";
            txtProjeStatu.ValueMember = "STATUS";

            colGorevTipi.DataSource = subitem.Tables[3];
            colGorevTipi.DisplayMember = "Description";
            colGorevTipi.ValueMember = "Process";

            colMaliyetTipi.DataSource = subitem.Tables[2];
            colMaliyetTipi.DisplayMember = "costtype";
            colMaliyetTipi.ValueMember = "costtype";

            colDovizCinsi.DataSource = subitem.Tables[4];
            colDovizCinsi.DisplayMember = "CURTYPE";
            colDovizCinsi.ValueMember = "CURTYPE";

            colGorevTuru.DataSource = subitem.Tables[5];
            colGorevTuru.DisplayMember = "STEP";
            colGorevTuru.ValueMember = "STEP";
        }

        int loadData()
        {
            string sqls = "Select * from Demands where pronum='" + ProjeKodu + "'" ;
            Ds = AppParams.DbCon.GetDataSet(sqls, "");
            return 0;
        }

        void getTalepbilgileri()
        {
            if (Ds.Tables[0].Rows.Count > 0)
            {
                try
                {
                txtProjeadi.Text = Ds.Tables[0].Rows[0]["STEXT"].ToString();
                txtProjeTipi.Text = Ds.Tables[0].Rows[0]["PTYPE"].ToString();
                txtTalepEden.Text = Ds.Tables[0].Rows[0]["CREATEDBY"].ToString();
                txtTalepTarihi.Text = Ds.Tables[0].Rows[0]["CREATEDATE"].ToString();
                txtTeslimTarihi.Text = Ds.Tables[0].Rows[0]["DELIVERYDATE"].ToString();
                txtMusteriKodu.Text = Ds.Tables[0].Rows[0]["CUSTOMER"].ToString();
                txtTesisKodu.Text = Ds.Tables[0].Rows[0]["PLANT"].ToString();
                txtCatiProje.Text = Ds.Tables[0].Rows[0]["MAINPROJECT"].ToString();
                txtTalepSekli.SelectedValue = Ds.Tables[0].Rows[0]["DEMANDTYPE"];
                txtProjeBilgi.Text = "Parça No: " + Ds.Tables[0].Rows[0]["RELEVANTNO"].ToString() + Environment.NewLine;
                txtProjeBilgi.AppendText("Test Fonksiyon: " + Ds.Tables[0].Rows[0]["TESTTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Mekanik Özellik: " + Ds.Tables[0].Rows[0]["mknkTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Elektriksel Özellik: " + Ds.Tables[0].Rows[0]["elkTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Fonksiyon: " + Ds.Tables[0].Rows[0]["FONKTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Diğer Özellikler: " + Ds.Tables[0].Rows[0]["OTHERTEXT"].ToString());

                txtProjeStatu.SelectedValue = Ds.Tables[0].Rows[0]["PSTATUS"];
                
                txtTalebiOnaylayan.Text = Ds.Tables[0].Rows[0]["CONFIRMBY"].ToString();
                try { txtTalepOnayTarihi.Value = DateTime.Parse(Ds.Tables[0].Rows[0]["CONFIRMDATE"].ToString()); } catch (Exception) { }
                txtTalepOnayAciklama.Text = Ds.Tables[0].Rows[0]["CONFIRMTEXT"].ToString();
                txtTalepOnayTarihi.Update();

                txtProjesorumlusu.Text = Ds.Tables[0].Rows[0]["RESPONSIBLE0"].ToString();
                txtSorumluatayan.Text = Ds.Tables[0].Rows[0]["RESPCHANGEDBY"].ToString();
                try {txtSorumluatamatarihi.Value = DateTime.Parse( Ds.Tables[0].Rows[0]["RESPCHANGEDATE"].ToString());}	catch (Exception)	{}
                

                txtButceonaylayan.Text = Ds.Tables[0].Rows[0]["PCONFIRMBY"].ToString();
                try {txtButceonaytarihi.Value = DateTime.Parse( Ds.Tables[0].Rows[0]["PCONFIRMDATE"].ToString());}	catch (Exception)	{}
                txtButceonayaciklama.Text = Ds.Tables[0].Rows[0]["CONFIRMDESC"].ToString();

                txtSatisTutar.Text = string.Format("{0:C2}","0"+ Ds.Tables[0].Rows[0]["AMOUNT"].ToString());
                txtSatisTutar.LabelText = "Satış Fiyatı (" + AppParams.fnc.GetString(Ds.Tables[0].Rows[0]["CURRENCY"]) + ")";

                }
                catch (Exception ex)
                {
                    AppParams.fnc.LogWrite("Proje Kartı Yükleme-Talep bilgileri Error:" + ex.Message, 0);
                    MessageBox.Show("Proje bilgileri yüklenirken bir hata oluştu logları kontrol edin!", "Hata");
                }
            }
        }
        void getProjeBilgi()
        {
            GrdPlan.AutoGenerateColumns = false;
            GrdMaliyet.AutoGenerateColumns = false;
            DataTable dtplan = AppParams.DbCon.GetDataTable("Select * from PROJECTPLANSTEPS WHERE PRONUM='"+ProjeKodu+"'");
            GrdPlan.DataSource = dtplan;
            DataTable dtcost = AppParams.DbCon.GetDataTable("Select * from PROJECTPLANCOST WHERE PRONUM='" + ProjeKodu + "'");
            GrdMaliyet.DataSource = dtcost;
            DTProject = AppParams.DbCon.GetDataTable("Select * from PROJECTS WHERE PRONUM='" + ProjeKodu + "'");
            try
            {
                if (DTProject.Rows.Count==0)
                {
                    AppParams.DbCon.ExecCommand("INSERT INTO PROJECTS (COMPANY,PLANT,PRONUM) VALUES ('01','20','"+ProjeKodu+"')", "");
                }
                else
                {
                    txtKarMarji.Text = string.Format("{0:C2}",  DTProject.Rows[0]["EXSTRAGAIN"].ToString());
                    txtKarMarji.TextAlign = HorizontalAlignment.Right;
                }
            }
            catch (Exception)
            {
            }
            MaliyetToplam(dtcost, dtplan);
        }

        void MaliyetToplam(DataTable dtCost ,DataTable dtPlan)
        {
            decimal topl = 0;
            decimal total = 0;
            foreach (DataRow dr in dtCost.Rows)
            {
                try
                {
                    topl = topl + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                }
                catch (Exception ex)
                {

                }
            }
            txtToplamMaliyet.Text = string.Format("{0:C2}", topl.ToString());
            txtToplamMaliyet.TextAlign = HorizontalAlignment.Right;
            total = topl;
            topl = 0;
            foreach (DataRow dr in dtPlan.Rows)
            {
                try
                {
                    topl = topl + decimal.Parse(dr["TOTALWAGES"].ToString());
                    
                }
                catch (Exception ex)
                {

                }
            }
            try
            {
            txtIscilikMaliyeti.TextAlign = HorizontalAlignment.Right;

            total = total + topl;
            total = total + decimal.Parse("0"+txtKarMarji.Text.ToString());
            txtTotalMaliyet.Text = string.Format("{0:C2}", total.ToString());
            txtIscilikMaliyeti.Text = string.Format("{0:C2}", topl.ToString());
            txtTotalMaliyet.TextAlign = HorizontalAlignment.Right;
            txtIscilikMaliyeti.TextAlign = HorizontalAlignment.Right;
            }
            catch (Exception)
            {

            }
            

            //txtBToplamMalzeme.Text = string.Format("{0:C2}", topl.ToString());
            //txtBToplamMalzeme.TextAlign = HorizontalAlignment.Right;
            //MalzMal = topl;
            //GenelToplamlar();
        }

        void getPersonelBilgi()
        {
            GrdPersonelSure.AutoGenerateColumns = false;
            GrdPersonelSure.DataSource = AppParams.DbCon.GetDataTable("Select * from PROJECTWORKS WHERE PRONUM='" + ProjeKodu + "' Order By Workdate,Worker");
        }

        void getKapanisBilgi()
        {
            DataTable kbdt;
            kbdt = AppParams.DbCon.GetDataTable("Select * from PROJECTFINISH WHERE PRONUM='" + ProjeKodu + "'");
            if (kbdt.Rows.Count==0) return;
            txtKapanisOnaylayan.Text = kbdt.Rows[0]["APPROVED"].ToString();
            txtKapanisHazirlayan.Text = kbdt.Rows[0]["CHANGEDBY"].ToString();
            try { txtKapanisTarihi.Value = DateTime.Parse(kbdt.Rows[0]["APPROVEDATE"].ToString()); }  catch (Exception) { }
            try { txtKapanisHzTarihi.Value = DateTime.Parse(kbdt.Rows[0]["CHANGEDATE"].ToString()); }   catch (Exception) { }
            if (kbdt.Rows[0]["ISCLOSED"].ToString() == "1") { cbKapanisDurum.Checked = true; }
            txtKapanisNotu.Text = kbdt.Rows[0]["CLOSENOTE"].ToString();

        }
        

        private void GrdPlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void GrdMaliyet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

   

        // ------------------DOSYALAR----------------------------
        string SecilenDosya="";
        Classes.FileProcess Dosya = new Classes.FileProcess();
        void loadfiles()
        {
            GrdDosyalar.AutoGenerateColumns = false;
            GrdDosyalar.DataSource = AppParams.DbCon.GetDataTable("Select * from ARGFILES where FOLDERNO='" + ProjeKodu + "'  "); /* and source='Kapama'*/
        }

        private void GrdDosyalar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SecilenDosya = GrdDosyalar.Rows[e.RowIndex].Cells["colFILENAME"].Value.ToString();
            }
            catch (Exception)
            {
                SecilenDosya = "";
            }
            txtSecilenDosya.Text = SecilenDosya;
        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            try
            {
                if (SecilenDosya != "")
                {
                    string dosyayolu = Dosya.SVFL(ProjeKodu, SecilenDosya, "");
                    System.Diagnostics.Process.Start(dosyayolu);
                }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Hata", ex.Message);
            }
        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Yetki < 2)
                {
                    AppParams.fnc.Mesaj_Uyari("Yetkilendirme", "Bu işlemi gerçekleştirmeye yetkili değilsiniz.");
                    return;
                }
                if (SecilenDosya != "")
                {
                    Dosya.CLRFL(ProjeKodu, SecilenDosya, "Kapama", this.FormCode);
                    SecilenDosya = "";
                    txtSecilenDosya.Text = "";
                    loadfiles();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            if (Yetki < 2)
            {
                AppParams.fnc.Mesaj_Uyari("Yetkilendirme", "Bu işlemi gerçekleştirmeye yetkili değilsiniz.");
                return;
            }
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PDF Dosyası|*.pdf|Metin Dosyası|*.txt|Resim Dosyası|*.png|Resim Dosyası|*.jpeg|Resim Dosyası|*.jpg|Zip Dosyası|*.zip|Excel Dosyası|*.xls*|Word Dosyası|*.doc*|Tüm Dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(openFileDialog1.FileName);
                if ((ext != ".pdf") || (ext != ".txt") || (ext != ".png") || (ext != ".jpg") || (ext != ".jpeg") || (ext != ".zip") || (ext != ".rar"))
                {

                }
                
                if  (Dosya.FLSV(ProjeKodu, openFileDialog1.FileName.ToString(), "Kapama", this.FormCode))
                loadfiles();
            }
        }

        private void GrdPersonelSure_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bC_Button1_Click(object sender, EventArgs e)
        {

        }

        private void tabYonetici_Click(object sender, EventArgs e)
        {
            if (txtYeniStatu.DataSource == null)
            {
                txtYeniStatu.DataSource = AppParams.DbCon.GetDataTable(" Select STATUS,DESCRIPTION from LIST_PROJECTSTATUS WHERE PASIF=0  UNION ALL Select -1 STATUS ,'Tümü ' DESCRIPTION");
                txtYeniStatu.ValueMember = "STATUS";
                txtYeniStatu.DisplayMember = "DESCRIPTION";
                txtYeniStatu.SelectedValue = Ds.Tables[0].Rows[0]["PSTATUS"];
            }
            if (AppParams.User== "ADMIN" || Yetki==2)
            {
                btnStatuDegistir.Enabled = true;
                btnSorumluDegistir.Enabled = true;
            }
            else
            {
                btnEkKarGuncelle.Enabled = false;
                tabYonetici.Hide();
            }
        }

        private void btnStatuDegistir_Click(object sender, EventArgs e)
        {
           if ( txtYeniStatu.SelectedValue.ToString()!="" && MessageBox.Show("Bu projenin statüsünü değiştirmek istediğinizden emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
           {
               string ret = AppParams.DbCon.ExecCommand("Update DEMANDS set PSTATUS='" + txtYeniStatu.SelectedValue.ToString() + "' WHERE PRONUM='"+txtProjekodu.Text+"' ", "");
               AppParams.fnc.WriteLog("Proje Statüsü "+AppParams.User+" tarafından " + txtYeniStatu.SelectedValue.ToString() + " olarak değiştirildi", txtProjekodu.Text, this.FormCode);
               MessageBox.Show("Proje statüsü değiştirildi!", "Sonuç");
           }
        }

        private void txtYeniStatu_Enter(object sender, EventArgs e)
        {
            tabYonetici_Click(sender, e);
        }

        private void tabButcePlan_Click(object sender, EventArgs e)
        {

        }

        private void btnSorumluDegistir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtProjekodu.Text + " nolu Proje sorumlusu " + txtProjeSorumlusu2.Text + " olarak değiştirilecek onaylıyor musunuz?", "Proje Sorumlusu Değiştirme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sonuc = "";
                try
                {
                    sonuc = AppParams.DbCon.ExecCommand("Update Demands set RESPONSIBLE0='" + txtProjeSorumlusu2.Text + "', RESPCHANGEDBY='" + AppParams.User + "', RESPCHANGEDATE='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now) + "' where pronum='" + txtProjekodu.Text + "'", "");
                    AppParams.fnc.WriteLog("Proje sorumlusu atandı. " + txtProjeSorumlusu2.Text + ">" + txtProjekodu.Text, txtProjekodu.Text, this.FormCode);
                    MessageBox.Show(txtProjekodu.Text + " nolu projeye " + txtProjeSorumlusu2.Text + " sorumlu olarak atandı!");
                }
                catch (Exception ex)
                {
                    AppParams.fnc.WriteLog("Proje sorumlusu atanamadı! " + txtProjeSorumlusu2.Text + ">" + txtProjekodu.Text, txtProjekodu.Text, this.FormCode);
                    MessageBox.Show("Proje sorumlusu atanamadı!");
                }
            }
        }

        private void txtProjeSorumlusu2_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select UserName Kullanıcı,FullName AdSoyad from ARGUSERS where ISRESPONSIBLE=1  order by USERNAME");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtProjeSorumlusu2.Text = sf.Sonuc[0];
        }

        private void getLogs()
        {
            try
            {
            DataTable dtlog = AppParams.DbCon.GetDataTable("SELECT TOP 1000 convert(varchar(10),date,104) +' '+ convert(varchar(5),date,108) +' - '+ left((USERNAME+'      '),10)+' - '+ MESSAGE as Mesaj   FROM [ALPARGE].[dbo].[LOGS] where pronum='"+ProjeKodu+"' order by ID ");
                foreach(DataRow dr in dtlog.Rows)
                {
                    txtLogs.AppendText(dr[0].ToString() + Environment.NewLine); 
                }

            }
            catch (Exception ex)
            {
                AppParams.fnc.HataGoster(ex, true);
            }


        }

        private void btnEkKarGuncelle_Click(object sender, EventArgs e)
        {
            
            decimal.Parse(txtKarMarji.Text.ToString());
            AppParams.DbCon.ExecCommand("Update PROJECTS set EXSTRAGAIN='" + decimal.Parse(txtKarMarji.Text.ToString()) .ToString()+ "' WHERE PRONUM='" + ProjeKodu + "'", "");
        }

    }
}
