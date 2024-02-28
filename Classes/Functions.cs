using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BaseControls;
using System.Data;
using System.Management;
using System.IO;
using System.Configuration;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Reflection;

namespace ALPARGE
{
    
    public class Functions :BaseControls.Functions
    {
        BaseControls.Functions Func = new BaseControls.Functions();
        public void MesajGoster(string Mesaj,string Baslik,BaseControls.Functions.MesajTipi MesajTipi)
        {
            Func.Mesaj_Goster(Baslik, Mesaj, "", MesajTipi, 0);
        }

        /// <summary>
        /// DB Log Kaydı
        /// </summary>
        /// <param name="message"></param>
        public void WriteLog(string message,string pronum, string form)
        {
            try
            {
                if (message.Length > 250) message = message.Substring(0, 250);
                string cmd = "INSERT INTO LOGS (DATE,USERNAME,MESSAGE,PRONUM,FORM)Values('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','"+AppParams.User+"','"+message+"','"+pronum+"','"+form+"')";
                AppParams.DbCon.ExecCommand(cmd, "");
            }
            catch (Exception)
            {  }
        }

        public string getDataCell(string sql)
        {
            try
            {
            return AppParams.DbCon.GetDataTable(sql).Rows[0][0].ToString();
            }
            catch (Exception)
            {
                return "";
            }

        }
        //-------------------------------------------------------------------------------------------------------
        //public void RaporGoster(DataSet DSet, string TableName, string RaporYolu)
        //{
        //    BaseForms.ReportForm RpForm = new BaseForms.ReportForm();
        //    RpForm.LoadReport(DSet,TableName, RaporYolu);
        //    RpForm.PrintReport();
        //    RpForm.ShowDialog();
        //}
        //-------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------
        public bool ConfirmDelete(string Key)
        {
            bool Ret = false;
            if (MessageBox.Show("Bu kayıt silinecek, onaylıyor musunuz?","Silme Onayı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ret = true;
            }
            return Ret;
        }

        public bool SoruSor(string Soru)
        {
            bool Ret = false;
            if (MessageBox.Show(Soru, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ret = true;
            }
            return Ret;
        }
        //-------------------------------------------------------------------------------------------------------
        public string EvrakNoGetir(string Tablo, string Alan)
        {
           // return FuncApp.EvrakNoGetir(Tablo, Alan);
            return "";
        }
        //-------------------------------------------------------------------------------------------------------
        public int Authority(string Modul)
        {
            int ret = 0;
            try
            {
                if (AppParams.DbCon.ConnectionStarted==true)
            ret = int.Parse( AppParams.DbCon.GetDataTable("  Select ISNULL(MAX(FORMRIGHT),0)FORMRIGHT from ARGUSERGROUPS G INNER JOIN ARGROUPRIGTS R ON G.GROUPCODE=R.GROUPCODE where USERNAME='"+AppParams.User+"' AND R.FORMCODE='"+Modul+"'").Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                LogWrite(ex.Message, 0);
            }

            if (AppParams.User=="ADMIN")
            { return 2; }
            return ret;
        }
        //-------------------------------------------------------------------------------------------------------
        public void SetConnectionProperty(DbControls.DbConnection dbConnection, DbControls.DbConnection.ConnectionTypes ConnectionType, string ConnectionString)
        {
            dbConnection.SetVia("ProjeAjans.com");
            string[] ExtraParam = { };
            dbConnection.SetConnectionProperty(ConnectionType, ConnectionString, ExtraParam);
        }

        public string getUserMail(string username)
        {
            string mail = "";
            try
            {
            mail = AppParams.DbCon.GetDataTable("Select EMAIL from ARGUSERS where username = '"+username+"' ").Rows[0][0].ToString();
            }
            catch (Exception)
            {
            }
            return mail;
        }

        public void Sndm( string AliciEmail,string modul, string konu, string MailIcerigi, bool HtmlFormat,bool msgshow)
        {
            try
            {            
                string body = getHtmlFormat();
            body = (body.Replace("@Modul", modul)).Replace("@Mesaj", MailIcerigi);
            string GonderenAdSoyad = "AlpArge Uygulaması";
            string GonderenEmail = "arge@alpplas.com";
            string SmtpSunucu = "smtp.alpplas.com";
            string GonderimiYapacakEmail = "arge@alpplas.com";
            string GonderimiYapacakEmailSifresi = "2607"+"-AG";
            System.Net.Mail.MailAddress gonderen = new System.Net.Mail.MailAddress(GonderenEmail, GonderenAdSoyad);
            System.Net.Mail.MailAddress alan = new System.Net.Mail.MailAddress(AliciEmail, "");
            System.Net.Mail.MailMessage eposta = new System.Net.Mail.MailMessage(gonderen, alan);
            eposta.IsBodyHtml = HtmlFormat;
            eposta.Subject = konu;
            eposta.Body = body;
            System.Net.NetworkCredential auth = new System.Net.NetworkCredential(GonderimiYapacakEmail, GonderimiYapacakEmailSifresi);
            System.Net.Mail.SmtpClient SMTP = new System.Net.Mail.SmtpClient();
            SMTP.Host = SmtpSunucu;
            SMTP.UseDefaultCredentials = false;
            SMTP.Credentials = auth;
            SMTP.EnableSsl = false;
            SMTP.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

                SMTP.Send(eposta);
            }
            catch (Exception ex)
            {
                WriteLog("Mail Gönderilemedi! "+ex.Message, "*", modul);
                if (msgshow)
                MessageBox.Show("Bilgilendirme maili gönderilemedi! \n"+ex.Message);
            }

        }

        string getHtmlFormat()
        {
            string text = @"<html style=" + (char)34 + "font-family: Arial, Helvetica, sans-serif; font-size: medium;" + (char)34 + "><head>    <meta charset=" + (char)34 + "utf-8" + (char)34 + " />    <title></title></head><body>    <div style=" + (char)34 + "padding: 15px; font-size:medium; width: 620px;" + (char)34 + "> AlpArge Bilgilendirme:<br /> " +
        "<br />  <div style=" + (char)34 + "border-width: thin; border-style: ridge; background-color: #B8CDDE; max-width: 600px;" + (char)34 + "> <div style=" + (char)34 + "padding: 8px;" + (char)34 + ">  <p style=" + (char)34 + " margin: 0px" + (char)34 + "> Modül: @Modul</p> " +
        "</div>  <div style=" + (char)34 + "padding: 8px;" + (char)34 + "> <p style=" + (char)34 + " margin: 0px" + (char)34 + "> Mesaj: @Mesaj </p>    </div>   <br />   </div>  <br />  <br />" +
        "<br />  <hr align=" + (char)34 + "left" + (char)34 + " max-width=" + (char)34 + "600px" + (char)34 + " />   <p style=" + (char)34 + "font-size: xx-small" + (char)34 + "> Bu mail size AlpArge Uygulaması tarafından otomatik olarak gönderilmiştir. Lütfen cevaplamayın!</p>  </div></body></html>";

            text = @"<html style=" + (char)34 + "font-family:Calibri,sans-serif; font-size: 11.0pt;" + (char)34 + "> <style>p.MsoNormal, li.MsoNormal, div.MsoNormal	{margin:0cm;	margin-bottom:.0001pt;	font-size:11.0pt;	font-family:" + (char)34 + "Calibri" + (char)34 + "," + (char)34 + "sans-serif" + (char)34 + ";	mso-fareast-language:EN-US;}</style> <head>    <meta charset=" + (char)34 + "utf-8" + (char)34 + " />    <title>Alp Arge Bilgilendirme Maili</title></head><body>  <div class=WordSection1><p class=MsoNormal><u>Bilgilendirme:<o:p></o:p></u></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0 style='background:#DBE5F1;border-collapse:collapse;border:none'><tr><td width=636 valign=top style='width:477.3pt;border:solid #548DD4 1.0pt;border-bottom:none;padding:2.85pt 7.1pt 8.5pt 7.1pt'><p class=MsoNormal>Modül: @Modul <o:p></o:p></p></td></tr><tr><td width=636 valign=top style='width:477.3pt;border:solid #548DD4 1.0pt;border-top:none;padding:2.85pt 7.1pt 8.5pt 7.1pt'><p class=MsoNormal>Mesaj:  @Mesaj <o:p></o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p></td></tr></table><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><p class=MsoNormal><o:p>&nbsp;</o:p></p><div class=MsoNormal><span style='font-size:13.5pt;font-family:" + (char)34 + "Arial" + (char)34 + "," + (char)34 + "sans-serif" + (char)34 + "'><hr size=2 width=" + (char)34 + "100%" + (char)34 + " align=left></span></div><p class=MsoNormal><span style='font-size:7.0pt;font-family:" + (char)34 + "Arial" + (char)34 + "," + (char)34 + "sans-serif" + (char)34 + "'>Bu mail size Alp-Arge Uygulaması tarafından otomatik olarak gönderilmiştir. Lütfen cevaplamayın!<o:p></o:p></span></p></div></body></html>";
            return text;
        }

        public DataTable GetExternalData( string ServerName, string DbName,string User,string Pwd,string SqlDataTable)
        {
            DataTable dt = new DataTable();
            using (DbControls.DbConnection DbCon2 = new DbControls.DbConnection())
            {
                try
                {
                    if (DbCon2.ConnectionStarted == true) AppParams.DbCon.ConnectionClose();
                    string constr = "Persist Security Info=true; Application Name= AlpArge_" + AppParams.User + " ;Data Source=" + ServerName +
                        ";MultipleActiveResultSets=True;Initial Catalog=" + DbName + ";Password=" + Pwd + ";User ID=" + User + ";Connection Timeout=10";
                    if (DbCon2.ConnectionStarted == false)
                    {
                        AppParams.fnc.SetConnectionProperty(DbCon2, DbControls.DbConnection.ConnectionTypes.MSSQL, constr);

                        bool status = DbCon2.ConnectionOpen();
                    }
                    if (DbCon2.ConnectionStarted==true)
                    {
                             dt = DbCon2.GetDataTable(SqlDataTable);               
                    }

                    DbCon2.ConnectionClose();
                }
                catch (Exception ex)
                {
                    AppParams.fnc.Mesaj_Hata("Bağlantı Hatası!", ex.Message);
                    return dt;
                }
            }
            return dt;
        }
        public string GetString(object obje)
        {
            if (obje == null)
            { return ""; }
            else
            {
                return obje.ToString();
            }
        }
    }

    public class Items
    {

    }
}
