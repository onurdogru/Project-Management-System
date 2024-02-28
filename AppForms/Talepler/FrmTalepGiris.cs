using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Talepler
{
    public partial class FrmTalepGiris : BaseForm
    {
        int MOD = 0;
        string ProjeNo = "";
        string SecilenDosya = "";
        BindingSource Bs = new BindingSource();
        DataSet Ds = new DataSet();
        Classes.FileProcess Dosya = new Classes.FileProcess();
        public FrmTalepGiris(int Mod, string Projeno)
        {
            MOD = Mod;
            ProjeNo = Projeno;
            InitializeComponent();
            FormCode = "TALEPGIRIS";
            FormName = "Talep Kayıt Ekranı";
        }

        private void FrmTalepGiris_Load(object sender, EventArgs e)
        {
            LoadProject();
            firstLoad();
            if (Yetki == 1)
            {
                btnKaydet.Enabled = false;
            }
        }

        void firstLoad()
        {

            DataSet subitem = new DataSet();
            string sql = "Select * from LIST_PROJECTTIPS" + (char)13 + "Select * from PLANTS" + (char)13 + "SELECT * FROM LIST_DEMANDTYPES";
            subitem = AppParams.DbCon.GetDataSet(sql, "");
            cbProjeTipleri.DataSource = subitem.Tables[0];
            cbProjeTipleri.DisplayMember = "PROJECTTIP";
            cbProjeTipleri.ValueMember = "PROJECTTIP";
            cbTesisKodu.DataSource = subitem.Tables[1];
            cbTesisKodu.DisplayMember = "PLANT";
            cbTesisKodu.ValueMember = "PLANT";
            txtTalepSekli.DataSource = subitem.Tables[2];
            txtTalepSekli.DisplayMember = "DESCRIPTION";
            txtTalepSekli.ValueMember = "DEMANDTYPE";
            cbProjeTipleri.DataBindings.Add("SelectedValue", Bs, "PTYPE");
            cbProjeTipleri.DataBindings.Add("Text", Bs, "PTYPE");
            txtProjeNo.DataBindings.Add("Text", Bs, "PRONUM");
            txtProjeAdi.DataBindings.Add("Text", Bs, "STEXT");
            txtMusteriKodu.DataBindings.Add("Text", Bs, "CUSTOMER");
            txtTalepSekli.DataBindings.Add("SelectedValue", Bs, "DEMANDTYPE");
            txtTeslimTarihi.DataBindings.Add("Text", Bs, "DELIVERYDATE");
            txtTalepTarihi.DataBindings.Add("Text", Bs, "CREATEDATE");
            txtTalepEden.DataBindings.Add("Text", Bs, "CREATEDBY");
            cbTesisKodu.DataBindings.Add("Text", Bs, "PLANT");
            txtTemFonk.DataBindings.Add("Text", Bs, "TESTTEXT");
            txtIlgiliStand.DataBindings.Add("Text", Bs, "STANDARTSTEXT");
            txtMekOzellik.DataBindings.Add("Text", Bs, "MKNKTEXT");
            txtFonkOzl.DataBindings.Add("Text", Bs, "FONKTEXT");
            txtElkOzl.DataBindings.Add("Text", Bs, "ELKTEXT");
            txtElkKomp.DataBindings.Add("Text", Bs, "ELKKOPMTEXT");
            txtYapIslem.DataBindings.Add("Text", Bs, "OPERATIONTEXT");
            txtDigerTalep.DataBindings.Add("Text", Bs, "OTHERTEXT");
            txtMiktar.DataBindings.Add("Text", Bs, "QUANTITY");
            txtParcaNo.DataBindings.Add("Text", Bs, "RELEVANTNO");
            txtTutar.DataBindings.Add("Text", Bs, "AMOUNT");
            txtParaBirimi.DataBindings.Add("Text", Bs, "CURRENCY");

            if (MOD == 0) //Okuma
            {
                btnKaydet.Enabled = false;
            }
            if (MOD == 1) //Yeni
            {
                txtTalepEden.Text = AppParams.User;
            }
            if (MOD == 2) //Değiştir
            {

            }

        }

        void LoadProject()
        {
            txtProjeNo.Text = ProjeNo;
            string[] sqls = { "Select * from DEMANDS where Pronum='" + ProjeNo + "'", "Select * from ARGFILES where FOLDERNO='" + ProjeNo + "'" };
            Ds = AppParams.DbCon.GetDataSetEx(sqls, "");
            Bs.DataSource = Ds.Tables[0];
            GrdDosyalar.DataSource = Ds.Tables[1];
            if (Bs.Count == 0)
            {
                Bs.AddNew();
            }
        }

        private void txtMusteriAdi_ButtonClick(object sender, EventArgs e)
        {
            Sistem.SearchForm sf = new Sistem.SearchForm("Select customer MusteriKodu,customername MusteriAdi from CUSTOMERS order by CUSTOMERNAME");
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK)
                txtMusteriKodu.Text = sf.Sonuc[0];
            txtMusteriAdi.Text = sf.Sonuc[1];
          //  ((Control)sender).Parent.Text = sf.Sonuc[1];
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (KayitKontrol() == 1)
                {
                    if (ProjeNo == "" || MOD == 1)
                    {
                        txtProjeNo.Text = GetProjeNo();
                        if (txtProjeNo.Text=="") return;
                        Bs.EndEdit();
                        Ds.Tables[0].Rows[0]["CLIENT"] = "00";
                        Ds.Tables[0].Rows[0]["COMPANY"] = "01";

                        string sonuc = AppParams.DbCon.UpdateDataSetEx(Ds);
                        if (sonuc.Substring(0, 2) == "OK")
                        {
                            FLSV();
                            AppParams.DbCon.ExecCommand("Update ARGCOUNTERS set COUNTNUM=COUNTNUM+1 WHERE COUNTNAME='DEMANDS'", "");
                            AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin), "Talep Girişi", "AlpArge Yeni Talep Oluşturuldu", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu talep oluşturuldu.", true, false);
                            AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin2), "Talep Girişi", "AlpArge Yeni Talep Oluşturuldu", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu talep oluşturuldu.", true, false);
                            AppParams.fnc.Mesaj_Bilgi("Kayıt işlemi", "Talep başarıyla kaydedildi.");
                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    else
                    {
                        if (txtTalepEden.Text.ToString() == AppParams.User.ToString())
                        {
                            Bs.EndEdit();
                            string sonuc = AppParams.DbCon.UpdateDataSetEx(Ds);
                            if (sonuc.Substring(0, 2) == "OK")
                            {
                                FLSV();
                                AppParams.fnc.Mesaj_Bilgi("Kayıt işlemi", "Talep başarıyla güncellendi.");
                                AppParams.fnc.Sndm(AppParams.fnc.getUserMail(AppParams.ArgeAdmin), "Talep Girişi", "AlpArge Talep Değişikliği", AppParams.User + " Tarafından " + txtProjeNo.Text + " nolu talep güncellendi.", true, false);
                                AppParams.fnc.WriteLog(txtProjeNo.Text+" " + txtProjeAdi.Text +  " Nolu talep kaydedildi.",txtParcaNo.Text, this.FormCode);
                                this.DialogResult = DialogResult.OK;
                                Close();
                            }
                        }
                        else
                        {
                            AppParams.fnc.Mesaj_Uyari("Kayıt", "Talebi sadece talebi giren kullanıcı değiştirebilir! \n");
                            return;
                        }

                    }

                   

                    // AppParams.fnc.Mesaj_Bilgi("Kayıt işlemi", "Şu an kayıt işleminizi gerçekleştirmek için yeterli kontroller mevcut değil! " + Environment.NewLine + "Geçici olarak web arayüzünü kullanın!");

                }
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Kayıt", @"Kayıt işlemi sırasında aşağıdaki hata oluştu \n" + ex.Message);

                throw;
            }
         }

        private int KayitKontrol()
        {

            if (MOD==2 && txtTalepEden.Text.ToString() != AppParams.User.ToString())
            {
                AppParams.fnc.Mesaj_Uyari("Yetki dışı değişiklik", "Talep üzerinde sadece talebi oluşturan değişiklik yapabilir!");
                return 0;
            }

            if (txtProjeAdi.TextLength<3)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Proje adı alanı 3 karakterden kısa olamaz!");
                txtProjeAdi.Focus();
                return 0;
            }
            if (txtTalepSekli.Text == "Müşteri Talebi" && txtMusteriKodu.TextLength < 3)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Müşteri Kodu boş olamaz!");
                txtMusteriKodu.Focus();
                return 0;
            }
            if (txtTalepSekli.Text.Length == 0)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Talep şekli boş olamaz!");
                txtTalepSekli.Focus();
                return 0;
            }

            if (MOD==1 && txtTeslimTarihi.Value <= DateTime.Now)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Teslim tarihi bu gün olamaz!");
                txtTeslimTarihi.Focus();
                return 0;
            }

            if (txtTemFonk.TextLength < 3)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Beklenen Temel Fonksiyonlar alanı boş olamaz!");
                txtTemFonk.Focus();
                return 0;
            }

            if (txtFonkOzl.TextLength < 3)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Temel Fonksiyon ve Özellikler alanı boş olamaz!");
                txtFonkOzl.Focus();
                return 0;
            }

            if (cbTesisKodu.Text.Length < 1)
            {
                AppParams.fnc.Mesaj_Uyari("Eksik veya hatalı giriş", "Tesis Kodu boş olamaz!");
                cbTesisKodu.Focus();
                return 0;
            }
            if (txtTalepSekli.Text == "Müşteri Talebi" && decimal.Parse(txtTutar.Text) < 1)
            {
                AppParams.fnc.Mesaj_Uyari("Kayıt", "Müşteri talebine tutar girmelisiniz! \n");
                return 0;
            }

            return 1;
        }

        private string GetProjeNo()
        {
            int n = 0;
            string pn = "";
            try
            {
            n = int.Parse(AppParams.DbCon.GetDataTable("Select countnum from ARGCOUNTERS where COUNTNAME = 'DEMANDS' ").Rows[0][0].ToString());
            n++;
            pn = n.ToString();
            //pn = AppParams.DbCon.GetDataTable("Select CONVERT(VARCHAR(4),YEAR(GETDATE())) +RIGHT('0'+CONVERT(VARCHAR(4),MONTH(GETDATE())),2) + RIGHT('0' + CONVERT(VARCHAR(2),(ISNULL(SUM(1),0)+1)),2) AS A from DEMANDS WHERE YEAR(CREATEDATE)=YEAR(GETDATE()) AND MONTH(CREATEDATE)=MONTH(GETDATE()) ").Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje Numarsı alınamadı! " + ex);
            }

            return pn;
        }

        //------ Dosya işlemleri----
        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "PDF Dosyası|*.pdf|Metin Dosyası|*.txt|Resim Dosyası|*.png|Resim Dosyası|*.jpeg|Resim Dosyası|*.jpg|Zip Dosyası|*.zip|Excel Dosyası|*.xls*|Word Dosyası|*.doc*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(openFileDialog1.FileName);
                if ((ext != ".pdf") || (ext != ".txt") || (ext != ".png") || (ext != ".jpg") || (ext != ".jpeg") || (ext != ".zip"))
                {
                }
                txtSeciliDosya.Text = openFileDialog1.FileName.ToString();
                lbxBekleyenDosya.Items.Add(openFileDialog1.FileName.ToString());
            }

        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {
            try
            {
                lbxBekleyenDosya.Items.RemoveAt(lbxBekleyenDosya.SelectedIndex);
            }
            catch (Exception)
            {
            }

        }

        private void lbxBekleyDosya_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSeciliDosya.Text = lbxBekleyenDosya.SelectedItem.ToString();
            }
            catch (Exception)
            {
            }

        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {

        }

        public void FLSV()
        {
            foreach (string dosya in lbxBekleyenDosya.Items)
            {
                try
                {
                    Dosya.FLSV(txtProjeNo.Text,dosya,"Talep",this.FormCode);
                    //FileStream fStream = File.OpenRead(txtSeciliDosya.Text);
                    //byte[] contents = new byte[fStream.Length];
                    //fStream.Read(contents, 0, (int)fStream.Length);
                    //fStream.Close();
                    //string sendata = "" + ByteArrayToString(contents);
                    //string ext = Path.GetExtension(dosya);
                    //string fnm = Path.GetFileName(dosya);
                    //SqlCommand cmd = new SqlCommand(@"exec sp_executesql N'insert into DEMANDFILES (COMPANY,PRONUM,FILENAME,TYPE,FILEITEM,USERNAME)values(''01'',''" + txtProjeNo.Text + "'',''" + fnm + "'',''" + ext + "'', @data,''" + AppParams.User + "'')',N'@data varbinary(max) ',@data=0x" + sendata);
                    //var ss = cmd.CommandText;
                    //string ret = AppParams.DbCon.ExecCommand(cmd.CommandText, "");
                    //if (ret.Substring(0, 2) != "OK")
                    //{
                    //    if ((ret.Length > 50) && (ret.Substring(3, 11) == "-2146232060"))
                    //    {
                    //        AppParams.fnc.Mesaj_Hata("Kayıt Hatası: " + dosya, "Tekrarlayıcı kayıt girişimi. \r" + ret.Substring(16, 30) + "...");
                    //    }
                    //    else
                    //    {
                    //        AppParams.fnc.Mesaj_Hata("Kayıt Hatası", "Kayıt sırasında hata oluştu. \r" + ret.Substring(2, ret.Length - 2));
                    //    }
                    //    AppParams.fnc.LogWrite("Talep Dosya kayıt (db): " + ret, 0);
                    //}
                }
                catch (Exception ex)
                {
                    AppParams.fnc.LogWrite("Talep Dosya kayıt : " + ex.Message, 0);
                    MessageBox.Show(ex.Message);
                }
            }

        }
        
        //public string SVFL(string pronum, string filename)
        //{
        //    try
        //    {
        //    DataTable dt = AppParams.DbCon.GetDataTable("select FILEITEM,FILENAME from DEMANDFILES where PRONUM='" + txtProjeNo.Text + "' and FILENAME='" + filename + "' ");
        //    string ToSaveFileTo = Application.StartupPath.ToString() + "\\Temp\\" + dt.Rows[0]["FILENAME"].ToString();
        //    var sss = dt.Rows[0][0];
        //    byte[] fileData = (byte[])sss;
        //    System.IO.Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Temp\\");
        //    using (System.IO.FileStream fs = new System.IO.FileStream(ToSaveFileTo, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
        //    {

        //        using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
        //        {
        //            bw.Write(fileData);
        //            bw.Close();
        //        }
        //    }
        //    return ToSaveFileTo;
        //    }
        //    catch (Exception ex)
        //    {
        //        AppParams.fnc.Mesaj_Hata("Dosya Açma", "Dosya Açılamadı: " + ex.Message);
        //    }
        //    return "";
        //}


        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            if (SecilenDosya != "")
            {
                string dosyayolu = Dosya.SVFL(txtProjeNo.Text, SecilenDosya, "Talep");
                
            }
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
        }

        private void GrdDosyalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnDosyaAc.PerformClick();
        }

        //---------------


        private void bC_Button2_Click(object sender, EventArgs e)
        {
            string sqlConnection = "Persist Security Info=true; Application Name= TestArge ;Data Source=192.168.0.5;Initial Catalog=AlpArge;Password=" + AppParams.DBPwd + ";User ID=" + AppParams.DBUser;
            using (SqlConnection cn = new SqlConnection(sqlConnection))
            {
                cn.Open();
                FileStream fStream = File.OpenRead(txtSeciliDosya.Text);
                byte[] contents = new byte[fStream.Length];
                fStream.Read(contents, 0, (int)fStream.Length);
                fStream.Close();
             //   SqlCommand cmd = new SqlCommand("insert into DEMANDFILES " + "(COMPANY,PRONUM,FILENAME,TYPE,FILEITEM,USERNAME)values('01','123','test','.txt', @data'),'" + AppParams.User + "')",cn);

                using (SqlCommand cmd = new SqlCommand("insert into DEMANDFILES " + "(COMPANY,PRONUM,FILENAME,TYPE,FILEITEM,USERNAME)values('01','123','"+txtSeciliDosya.Text+"','.pdf', @data,'" + AppParams.User + "')", cn))
                {
                    //cmd.Parameters.Add("@data", contents);
                    cmd.Parameters.Add("@data", SqlDbType.VarBinary, contents.Length).Value = contents;
                    cmd.ExecuteNonQuery();
                }

            }
        }



    }
    
}
