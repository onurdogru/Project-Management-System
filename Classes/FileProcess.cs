using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.Classes
{
    class FileProcess
    {
        public bool  FLSV(string Klasor, string dosya, string kaynak,string formcode)
        {
            try
            {
                FileStream fStream = File.OpenRead(dosya);
                byte[] contents = new byte[fStream.Length];
                fStream.Read(contents, 0, (int)fStream.Length);
                fStream.Close();
                long length = new System.IO.FileInfo(dosya).Length;
                double size = Math.Round(((length / 1024) / 1024.0), 2);
                string sendata = "" + ByteArrayToString(contents);
                string ext = Path.GetExtension(dosya);
                string fnm = Path.GetFileName(dosya);
                if (AppParams.DbCon.GetDataTable("select FILEITEM,FILENAME from ARGFILES where FOLDERNO='" + Klasor + "' and FILENAME='" + fnm + "' and SOURCE like '"+kaynak+"%' ").Rows.Count > 0)
                {
                    AppParams.fnc.Mesaj_Uyari("Kayıt yapılamadı", "Belirttiğiniz klasörde seçtğiniz isimde bir dosya zaten var!");
                    return false ;
                }
                if (size > 10)
                {
                    AppParams.fnc.Mesaj_Uyari("Kayıt yapılamadı", "Dosya boyutu 10 MB'tan büyük olamaz!");
                    return false;
                }

                SqlCommand cmd = new SqlCommand(@"exec sp_executesql N'insert into ARGFILES (COMPANY,FOLDERNO,FILENAME,SOURCE,TYPE,FILEITEM,SIZE,USERNAME)values(''01'',''" + Klasor + "'',''" + fnm + "'',''"+kaynak+"'',''" + ext + "'', @data,''" + size.ToString().Replace(",", ".") + "'',''" + AppParams.User + "'')',N'@data varbinary(max) ',@data=0x" + sendata);
                var ss = cmd.CommandText;
                string ret = AppParams.DbCon.ExecCommand(cmd.CommandText, "");
                if (ret.Substring(0, 2) != "OK")
                {
                    if ((ret.Length > 50) && (ret.Substring(3, 11) == "-2146232060"))
                    {
                        AppParams.fnc.Mesaj_Hata("Kayıt Hatası: " + dosya, "Tekrarlayıcı kayıt girişimi. \r" + ret.Substring(16, 30) + "...");
                    }
                    else
                    {
                        AppParams.fnc.Mesaj_Hata("Kayıt Hatası", "Kayıt sırasında hata oluştu. \r" + ret.Substring(2, ret.Length - 2));
                    }
                    AppParams.fnc.LogWrite("Talep Dosya kayıt (db): " + ret, 0);
                }
            }
            catch (Exception ex)
            {
                AppParams.fnc.LogWrite("Klasör Dosya Kaydı : " + ex.Message, 0);
                AppParams.fnc.WriteLog(Klasor + " nolu klasöre dosya kaydedilemedi", "", formcode);
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool CLRFL(string Klasor, string dosya, string kaynak, string formcode)
        {
            try
            {
               if( AppParams.fnc.SoruSor("Kalör:"+Klasor+" Dosya: "+dosya +" silinecek! Onaylıyor musunuz?"))
               {
                  string RET = AppParams.DbCon.ExecCommand("Delete from ARGFILES where FOLDERNO='"+Klasor+"' AND FILENAME='"+dosya+"' AND SOURCE = '"+kaynak+"' ", "");
               }

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public string SVFL(string Klasor, string dosya,string kaynak)
        {
            try
            {
                DataTable dt = AppParams.DbCon.GetDataTable("select FILEITEM,FILENAME from ARGFILES where FOLDERNO='" + Klasor + "' and FILENAME='" + dosya + "' AND SOURCE like '"+kaynak+"%' ");
                string ToSaveFileTo = Application.StartupPath.ToString() + "\\Temp\\" + dt.Rows[0]["FILENAME"].ToString();
                var sss = dt.Rows[0][0];
                byte[] fileData = (byte[])sss;
                System.IO.Directory.CreateDirectory(Application.StartupPath.ToString() + "\\Temp\\");
                using (System.IO.FileStream fs = new System.IO.FileStream(ToSaveFileTo, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                {

                    using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                    {
                        bw.Write(fileData);
                        bw.Close();
                    }
                }
                System.Diagnostics.Process.Start(ToSaveFileTo);
                return ToSaveFileTo;
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Dosya Açma", "Dosya Açılamadı: " + ex.Message);
            }
            return "";
        }

        public static string ByteArrayToString(byte[] bt)
        {
            StringBuilder hex = new StringBuilder(bt.Length * 2);
            foreach (byte b in bt)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }



    }
}
