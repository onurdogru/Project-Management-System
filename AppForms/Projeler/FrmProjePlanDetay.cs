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
    public partial class FrmProjePlanDetay : BaseForm
    {
        public DataSet Dset = new DataSet();
        DataTable dtCost = new DataTable();
        DataTable dtPlan = new DataTable();
        BindingSource bsCost = new BindingSource();
        BindingSource bsPlan = new BindingSource();
        public string ProjeNo="";
        public string company = "";
        decimal ProjeMal = 0;
        decimal IscMal = 0;
        decimal MalzMal = 0;
        decimal EgitimMal = 0;
        decimal EkipmanMal = 0;
        decimal HizmetMal = 0;
        decimal NakliyeMal = 0;
        decimal PatentMal = 0;
        decimal SeyehatMal = 0;
        decimal TestMal = 0;


        public FrmProjePlanDetay()
        {
            InitializeComponent();
            FormCode = "PROJEPLANDETAY";
            FormName = "Proje Planlama Ekranı";
        }

        private void FrmProjePlanDetay_Load(object sender, EventArgs e)
        {
            txtProjeNo.Text = ProjeNo;
            firstLoad();
            ReadData(ProjeNo);
            colStopDate.DefaultDate = DateTime.Now;
            if (txtProjeSorumlusu.Text != AppParams.User && AppParams.User!= "ADMIN")
            {
                btnKaydet.Enabled = false;
                btnOnayaGonder.Enabled = false;
            }
        }

        void firstLoad()
        {
            GrdMaliyet.AutoGenerateColumns = false;
            GrdPlan.AutoGenerateColumns = false;
            DataSet subitem = new DataSet();
            string sql = "Select * from LIST_COSTS Order By ID " + (char)13 + "Select * from LIST_PROCESS" + (char)13 + "Select * from LIST_CURTYPE" + (char)13 + "Select * from LIST_STEPS Order By OrderNo" + (char)13 + "Select * from LIST_UNITS Order By OrderNo" + (char)13;
            //sql = sql + " Select S.SOURCE Kaynak, MIN(STARTDATE) GuncelProjeBaslangici,dbo.GetWorkEndDate(S.SOURCE)OnerilenYeniProjeTarihi,round(sum(HOURS)/9.0,1) ToplamGun,sum(HOURS)ToplamSaat " +
            //"from (Select SOURCE,DESCRIPTION from LIST_SOURCE union all select USERNAME,FULLNAME from ARGUSERS where ISSOURCE=1 ) S LEFT JOIN (SELECT * FROM PROJECTPLANSTEPS) P ON S.SOURCE=P.SOURCE  group by S.SOURCE";
            
            Dset = AppParams.DbCon.GetDataSet(sql,"");
            colGorevTipi.DataSource = Dset.Tables[1];
            colGorevTipi.DisplayMember = "Description";
            colGorevTipi.ValueMember = "Process";

            colMaliyetTipi.DataSource = Dset.Tables[0];
            colMaliyetTipi.DisplayMember = "costtype";
            colMaliyetTipi.ValueMember = "costtype";

            colDovizCinsi.DataSource = Dset.Tables[2];
            colDovizCinsi.DisplayMember = "CURTYPE";
            colDovizCinsi.ValueMember = "CURTYPE";

            colGorevTuru.DataSource = Dset.Tables[3];
            colGorevTuru.DisplayMember = "STEP";
            colGorevTuru.ValueMember = "STEP";

            //colKaynak.DataSource = Dset.Tables[4];
            //colKaynak.DisplayMember = "STEP";
            //colKaynak.ValueMember = "STEP";
            colBirim.DataSource = Dset.Tables[4];
            colBirim.DisplayMember = "UNIT";
            colBirim.ValueMember = "UNIT";
        }

        void ReadData(string pronum)
        {
            //((ComboBox)colGorevTipi).AutoCompleteMode = AutoCompleteMode.Suggest;
            string[] Sqls = { "Select top 1 * from Demands where Pronum='" + ProjeNo + "'", "Select * from PROJECTPLANSTEPS WHERE PRONUM='" + ProjeNo + "' order by LINENUMBER ", "Select * from PROJECTPLANCOST WHERE PRONUM='" + ProjeNo + "' order by LINENUMBER " };
            Dset = AppParams.DbCon.GetDataSetEx(Sqls, "");
            Dset.EnforceConstraints = false;
            DataTable dtp = Dset.Tables[0];
            dtPlan = Dset.Tables[1];
            dtCost = Dset.Tables[2];
            bsPlan.DataSource = dtPlan;
            bsCost.DataSource = dtCost;

            dtCost.RowChanged += new DataRowChangeEventHandler(planrc);
            if (dtp.Rows.Count>0)
            {
                txtProjeAdi.Text = dtp.Rows[0]["STEXT"].ToString();
                txtMusteri.Text = dtp.Rows[0]["customer"].ToString();
                txtTalepEden.Text = dtp.Rows[0]["createdby"].ToString();
                txtProjeSorumlusu.Text = dtp.Rows[0]["RESPONSIBLE0"].ToString();
                txtProjeTipi.Text = dtp.Rows[0]["Ptype"].ToString();
                txtTeslimTarihi.Text = dtp.Rows[0]["DELIVERYDATE"].ToString();
                txtPlnTeslimTarihi.Text = dtp.Rows[0]["PDELIVERYDATE"].ToString();
                company = dtp.Rows[0]["Company"].ToString();
                txtProjeBilgi.Text ="Parça No: "+ dtp.Rows[0]["RELEVANTNO"].ToString()+ Environment.NewLine;
                txtProjeBilgi.AppendText("Test Fonksiyon: " + dtp.Rows[0]["TESTTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Mekanik Özellik: " + dtp.Rows[0]["mknkTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Elektriksel Özellik: " + dtp.Rows[0]["elkTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Fonksiyon: " + dtp.Rows[0]["FONKTEXT"].ToString() + Environment.NewLine);
                txtProjeBilgi.AppendText("Diğer Özellikler: " + dtp.Rows[0]["OTHERTEXT"].ToString());
            }
            GrdPlan.DataSource = bsPlan;
            GrdMaliyet.DataSource = bsCost;
            MalzemeToplamlar();
            PlanToplamlar();
        }
        public void planrc(object sender, DataRowChangeEventArgs e)
        {
            var w1 = e.Row["totalamount"];
         //   e.Row["totalamount"] = ((int)e.Row["examount"] * (int)e.Row["exrate"]); 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime sontarih = txtPlnTeslimTarihi.Value;
            int[] sayi = { 1, 2, 3 };
            try
            {
                Dset.Tables[0].ExtendedProperties["update"] = false;
                bsPlan.EndEdit();
                bsPlan.CurrencyManager.Refresh();
                GrdPlan.Update();
                int sirano = 1;
                foreach (DataRow dr in dtPlan.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        if (dr["process"] == null || dr["process"].ToString() == "" || dr["step"].ToString() == "" || dr["source"].ToString() == "")
                        {
                            var ss = dr["process"].ToString();
                            AppParams.fnc.Mesaj_Uyari("Eksik bilgi!", "Planlama bilgilerindeki satırlarda boş bırakılan hücreler mevcut! Kayıt yapılamadı. Sırano:"+sirano.ToString()+" \n Eskik hücreleri doldurun veya fazla satırları silin.");
                            //     return;
                        }
                        else
                        {

                            if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                            {
                                dr["CHANGEDATE"] = DateTime.Now.ToString();
                                dr["CHANGEDBY"] = AppParams.User;
                                dr["PRONUM"] = txtProjeNo.Text;
                            }
                            dr["LINENUMBER"] = sirano;
                            sirano++;
                            DateTime bitdt;
                            DateTime basdt;
                            DateTime.TryParse(dr["STARTDATE"].ToString(), out basdt);
                            DateTime.TryParse(dr["STOPDATE"].ToString(), out bitdt) ;
                            if (basdt>bitdt)
                            {
                                dr["STOPDATE"] = dr["STARTDATE"];
                            }
                            if (bitdt > sontarih)
                            {
                                sontarih = DateTime.Parse(dr["STOPDATE"].ToString());
                            }
                        }
                    }
                }
                txtPlnTeslimTarihi.Value = sontarih;

                sirano = 1;
                bsCost.EndEdit();
                bsCost.CurrencyManager.Refresh();
                GrdMaliyet.Update();
                foreach (DataRow dr in dtCost.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        if (dr["costtype"] == null || dr["costtype"].ToString() == "" || dr["QUANTITY"].ToString() == "0" || dr["PRICE"].ToString() == "0")
                        {
                            //var ss = dr["process"].ToString();
                            AppParams.fnc.Mesaj_Uyari("Eksik bilgi!", "Maliyet bilgilerindeki satırlarda boş bırakılan hücreler mevcut! Kayıt yapılamadı. Sırano:"+sirano.ToString());
                            //     return;
                        }
                        else
                        {
                            if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified)
                            {
                                dr["CHANGEDATE"] = DateTime.Now.ToString();
                                dr["CHANGEDBY"] = AppParams.User;
                                dr["PRONUM"] = txtProjeNo.Text;
                            }
                            dr["LINENUMBER"] = sirano;
                            sirano++;
                        }
                    }
                }
                Dset.Tables[0].Rows[0]["PDELIVERYDATE"] = txtPlnTeslimTarihi.Text;
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Hata", ex.Message);
                return;
            }

            //foreach (DataGridViewRow gr in GrdPlan.Rows)
            //{
            //    if (gr.Cells["colGorevTipi"].Value == null || gr.Cells["colGorevTipi"].Value.ToString() == "" | gr.Cells["colGorevAciklama"].Value==null || gr.Cells["colGorevAciklama"].Value.ToString() == "")
            //   {
            //       AppParams.fnc.Mesaj_Uyari("Eksik bilgi!", "Planlama bilgilerindeki satırlarda boş bırakılan hücreler mevcut! Kayıt yapılamadı.");
            //       return;
            //   }
            //}


            string ret = AppParams.DbCon.UpdateDataSetEx(Dset) + "--";
            if (ret.Substring(0, 2) == "OK")
            {
                AppParams.fnc.Mesaj_Bilgi("Kayıt", "Kaydetme işlemi tamamlandı.  \n" + dtPlan.Rows.Count.ToString() + " - " + dtCost.Rows.Count.ToString());
                AppParams.fnc.WriteLog("Proje planında değişiklik yapıldı.", ProjeNo, this.FormCode);
            }
            else
            {
                string msg = "";
                if (ret.Length > 15 && "-2146232060" == ret.Substring(3, 11))
                {
                    msg = "Kayıt işlemi hatası. Yinelenen kayıt. \n";
                }
                AppParams.fnc.Mesaj_Hata("Kayıt", "Kaydetme işlemi yapılamadı! \n" + msg + ret + " \n" + dtPlan.Rows.Count.ToString() + " - " + dtCost.Rows.Count.ToString());
                AppParams.fnc.WriteLog(ProjeNo + " Proje planında kaydederken hata oluştu.","*" , this.FormCode);
            }

        }

        private void GrdPlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ColumnIndex.ToString(); 
            string err = "";
            if (e.Exception.InnerException != null)
            {
                err = e.Exception.InnerException.Message;
                //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.Exception.Message + " " + err);
            }
            try
            {
                bC_Label1.Text = "Error: dr " + (e.ColumnIndex.ToString() + " " + e.Exception.Message + " " + err);
            }
            catch (Exception ex)
            {
            }


            e.Cancel = true;
        }

        private void GrdPlan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // bC_Label1.Text = GrdPlan.Rows.Count.ToString() + "   " + dtPlan.Rows.Count.ToString() ;
            try
            {
                if (GrdPlan.Columns["colSaatUcreti"].Index == e.ColumnIndex || GrdPlan.Columns["colHours"].Index == e.ColumnIndex)
                {
                    string ss1 = GrdPlan["colHours", e.RowIndex].Value.ToString();
                    string ss2 = GrdPlan["colSaatUcreti", e.RowIndex].Value.ToString();
                    GrdPlan["colToplamUcret", e.RowIndex].Value = (decimal.Parse(ss2) * decimal.Parse(ss1));
                    PlanToplamlar();
                }

                if (GrdPlan.Columns["colGorevTipi"].Index == e.ColumnIndex)
                {
                    decimal val = decimal.Parse( AppParams.fnc.getDataCell("Select top 1 wages from  SOURCEWAGES where SOURCE='" + GrdPlan[e.ColumnIndex, e.RowIndex].Value+"' and stopdate>getdate() "));
                    GrdPlan["colSaatUcreti", e.RowIndex].Value = val;
                }
            }
            catch (Exception ex)
            {
            }
            if (e.ColumnIndex != 0 && e.RowIndex > -1)
            {
            //    GrdPlan.Rows[e.RowIndex].Cells[0].Value = ProjeNo;
            }


        }

        void PlanToplamlar()
        {
            decimal topl = 0;
            decimal toplm = 0;
            foreach (DataRow dr in dtPlan.Rows)
            {
                try
                {
                    topl = topl + decimal.Parse(dr["HOURS"].ToString());
                    toplm = toplm + decimal.Parse(dr["TOTALWAGES"].ToString());
                }
                catch (Exception ex)
                {

                }
            }
            txtToplamSure.Text = string.Format("{0:0.##}", topl);
            txtBToplamProje.Text = string.Format("{0:0.##}", toplm);
            txtToplamSure.TextAlign = HorizontalAlignment.Right;
            txtBToplamProje.TextAlign = HorizontalAlignment.Right;
            ProjeMal = toplm;
            GenelToplamlar();
        }

        private void GrdPlan_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            bC_Label1.Text = e.RowIndex.ToString() + " -" + e.ColumnIndex.ToString();
        }

        private void GrdMaliyet_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrdMaliyet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GrdMaliyet.Columns["colDovizCinsi"].Index == e.ColumnIndex && GrdMaliyet[e.ColumnIndex,e.RowIndex].Value.ToString()=="TL")
                {
                    GrdMaliyet["colDovizKuru", e.RowIndex].Value = (decimal.Parse("1"));
                }
                //bsCost.EndEdit();
                if (GrdMaliyet.Columns["colMiktar"].Index == e.ColumnIndex || GrdMaliyet.Columns["colDovizFiyat"].Index == e.ColumnIndex)
                {
                    string ss1 = GrdMaliyet["colMiktar", e.RowIndex].Value.ToString();
                    string ss2 = GrdMaliyet["colDovizFiyat", e.RowIndex].Value.ToString();
                    GrdMaliyet["colDovizTutar", e.RowIndex].Value = (decimal.Parse(ss1) * decimal.Parse(ss2));
                }

                if (GrdMaliyet.Columns["colDovizTutar"].Index == e.ColumnIndex)
                {
                    string ss1 = GrdMaliyet["colMiktar", e.RowIndex].Value.ToString();
                    string ss2 = GrdMaliyet["colDovizTutar", e.RowIndex].Value.ToString();
                    GrdMaliyet["colDovizFiyat", e.RowIndex].Value = (decimal.Parse(ss2) / decimal.Parse(ss1));
                }

                if (GrdMaliyet.Columns["colMiktar"].Index == e.ColumnIndex || GrdMaliyet.Columns["colDovizKuru"].Index == e.ColumnIndex || GrdMaliyet.Columns["ColDovizFiyat"].Index == e.ColumnIndex)
                {
                    string ss1 = GrdMaliyet["colDovizTutar", e.RowIndex].Value.ToString();
                    string ss2 = GrdMaliyet["colDovizKuru", e.RowIndex].Value.ToString();
                    //DataGridCell obj = (DataGridCell)GrdMaliyet.CurrentRow.DataBoundItem;
                    GrdMaliyet["colTLTutar", e.RowIndex].Value = (decimal.Parse(ss1) * decimal.Parse(ss2));
                }

                bsCost.EndEdit();
                MalzemeToplamlar();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        void MalzemeToplamlar()
        {
            decimal topl = 0;
            IscMal = 0;
            MalzMal = 0;
            EkipmanMal = 0;
            TestMal = 0;
            HizmetMal = 0;
            SeyehatMal = 0;
            EgitimMal = 0;
            PatentMal = 0;
            NakliyeMal = 0;
            foreach (DataRow dr in dtCost.Rows)
            {
                try
                {
                    topl = topl + decimal.Parse( dr["TOTALAMOUNT"].ToString());
                    if (dr["Costtype"].ToString()=="İşcilik")
                    {
                        IscMal = IscMal + decimal.Parse( dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Malzeme")
                    {
                        MalzMal = MalzMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Ekipman / Yazılım")
                    {
                        EkipmanMal = EkipmanMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Hizmet / Danışmanlık")
                    {
                        HizmetMal = HizmetMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Test / Validasyon")
                    {
                        TestMal = TestMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Seyahat")
                    {
                        SeyehatMal = SeyehatMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Eğitim")
                    {
                        EgitimMal = EgitimMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Patent / Yayın")
                    {
                        PatentMal = PatentMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                    if (dr["Costtype"].ToString() == "Nakliye")
                    {
                        NakliyeMal = NakliyeMal + decimal.Parse(dr["TOTALAMOUNT"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
            txtBToplamIscilik.Text = string.Format("{0:C2}", IscMal.ToString());
            txtBToplamIscilik.TextAlign = HorizontalAlignment.Right;
            txtBToplamMalzeme.Text = string.Format("{0:C2}", MalzMal.ToString());
            txtBToplamMalzeme.TextAlign = HorizontalAlignment.Right;
            txtBToplamEkipman.Text = string.Format("{0:C2}", EkipmanMal.ToString());
            txtBToplamEkipman.TextAlign = HorizontalAlignment.Right;
            txtBToplamTest.Text = string.Format("{0:C2}", TestMal.ToString());
            txtBToplamTest.TextAlign = HorizontalAlignment.Right;
            txtBToplamHizmet.Text = string.Format("{0:C2}", HizmetMal.ToString());
            txtBToplamHizmet.TextAlign = HorizontalAlignment.Right;
            txtBToplamSeyehat.Text = string.Format("{0:C2}", SeyehatMal.ToString());
            txtBToplamSeyehat.TextAlign = HorizontalAlignment.Right;
            txtBToplamEgitim.Text = string.Format("{0:C2}", EgitimMal.ToString());
            txtBToplamEgitim.TextAlign = HorizontalAlignment.Right;
            txtBToplamPatent.Text = string.Format("{0:C2}", PatentMal.ToString());
            txtBToplamPatent.TextAlign = HorizontalAlignment.Right;
            txtBToplamNakliye.Text = string.Format("{0:C2}", NakliyeMal.ToString());
            txtBToplamNakliye.TextAlign = HorizontalAlignment.Right;
            txtSatisBedeli.Text = string.Format("{0:C2}", PatentMal.ToString());
            txtSatisBedeli.TextAlign = HorizontalAlignment.Right;

            MalzMal = topl;
            GenelToplamlar(); 
        }

        void GenelToplamlar()
        {
            txtBToplamMaliyet.Text = string.Format("{0:C2}", (ProjeMal + IscMal + MalzMal + EkipmanMal + TestMal + HizmetMal + SeyehatMal + EgitimMal + PatentMal + NakliyeMal).ToString());
        }
        private void GrdMaliyet_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GrdPlan_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void GrdMaliyet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ColumnIndex.ToString();
            string err = "";
            if (e.Exception.InnerException != null)
            {
                err = e.Exception.InnerException.Message;
                //MessageBox.Show(e.ColumnIndex.ToString() + " " + e.Exception.Message + " " + err);
            }
            try
            {
                bC_Label2.Text = "Error: dr " + (e.ColumnIndex.ToString() + " " + e.Exception.Message + " " + err);
            }
            catch (Exception ex)
            {
            }


            e.Cancel = true;
        }

        private void colKaynak_Button_Click(object sender, EventArgs e)
        {
           // Sistem.SearchForm sf = new Sistem.SearchForm("Select SOURCE Kaynak,DESCRIPTION Aciklama from LIST_SOURCE");
            Sistem.SearchForm sf = new Sistem.SearchForm(("Select S.* from (Select S.SOURCE Kaynak, MIN(STARTDATE) GuncelProjeBaslangici,dbo.GetWorkEndDate(S.SOURCE)OnerilenYeniProjeTarihi,round(sum(HOURS)/9.0,1) ToplamGun,sum(HOURS)ToplamSaat "+
             "from (Select SOURCE,DESCRIPTION from LIST_SOURCE union all select USERNAME,FULLNAME from ARGUSERS where ISSOURCE=1 ) S LEFT JOIN (SELECT * FROM PROJECTPLANSTEPS) P ON S.SOURCE=P.SOURCE  group by S.SOURCE)S "));
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK && sf.Sonuc[0]!="")
            {
                GrdPlan.CurrentRow.Cells[5].Value = sf.Sonuc[2];
                GrdPlan.CurrentRow.Cells[3].Value = sf.Sonuc[0];
               // GrdPlan.CurrentRow.Cells[7].Value = sf.Sonuc[5];
                ((Control)sender).Parent.Text = sf.Sonuc[0]; 
            }
        }

        private void btnOnayaGonder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu proje planını yönetici onayına göndermek istiyor musunuz?" + (char)13 + (char)13 + "Dikkat! Proje planı ile ilgili tüm bilgileri doğru şekilde girmiş olmalısınız."
                  + (char)13 + "Proje onaylandıktan sonra artık değişiklik yapamayacaksınız!", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string ret = AppParams.DbCon.ExecCommand("Update DEMANDS set PSTATUS='2' where PRONUM='"+ProjeNo+"'", "");
                if (ret.Substring(0, 2) == "OK")
                {
                    AppParams.fnc.Mesaj_Bilgi("Kayıt", "Proje onaya göndrildi.");
                    AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin), "ProjePlanDetay", "AlpArge Kapama Onayı", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu proje kapatılma talebinde bulunuldu.", true, false);
                    AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin2), "ProjePlanDetay", "AlpArge Kapama Onayı", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu proje kapatılma talebinde bulunuldu.", true, false);
                }
            }
        }

        private void GrdMaliyet_Enter(object sender, EventArgs e)
        {
            
        }

        private void GrdPlan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            PlanToplamlar();
        }

        private void GrdMaliyet_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            MalzemeToplamlar();
        }
       
    }
}
