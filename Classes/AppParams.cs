using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE
{
    public static class AppParams

    {   
        public static DbControls.DbConnection DbCon = new DbControls.DbConnection();
        public static Functions fnc = new Functions();
        public static BaseControls.BC_StatusStrip InfoBar = new BaseControls.BC_StatusStrip();
        public static string User;
        public static string LangCode ="TR";
        public static string ServerName;
        public static string DBName;
        public static string DBUser;
        public static string DBPwd;
        public static string AppVersion = "1.002";
        public static string ArgeAdmin = "DEROL";
        public static string ArgeAdmin2 = "ADMIN";
        public static string ViaPs { get; set; }

        public static void StartConnection(string ConStr)
        {
            string VKey = "ProjeAjans.com";
            DbCon.SetVia(VKey);
            string[] Param={};
            DbCon.SetConnectionProperty(DbControls.DbConnection.ConnectionTypes.MSSQL, ConStr, Param);
        }

    }


    //-----------------------------------------------------------------------------------------------------
    public class ComboItem
    {
        public int Deger        {   get;  set;  }
        public string Aciklama  {   get;  set;  }
    }



    public class IslemDurum
    {
        public List<ComboItem> Liste = new List<ComboItem>();
        public IslemDurum()
        {
            ekle(0, "Beklemede");
            ekle(1, "Başladı");
            ekle(2, "Tamamlandı");
            ekle(3, "İptal");
        }

        void ekle(int value, string Aciklama)
        {
            ComboItem A = new ComboItem();
            A.Deger = value;
            A.Aciklama = Aciklama;
            Liste.Add(A);
        }
    }


    public enum TextBoxReferansTipi
    {
        Yok = 0,
        VergiDairesi=9,
        PersonelGrubu=10,
    }

}
