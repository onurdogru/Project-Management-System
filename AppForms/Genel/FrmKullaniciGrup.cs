using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALPARGE.AppForms.Genel
{
    public partial class FrmKullaniciGrup : BaseForm
    {
        int mode = 0;
        string seciligrup = "";
        string secilikullanici = "";
        IList<Items> itemlist = new List<Items>();
        public FrmKullaniciGrup()
        {
            InitializeComponent();
            FormCode = "KGRUPYETKI";
            FormName = "Kullanıcı Grup Yetkileri";
        }

        private void FrmKullaniciGrup_Load(object sender, EventArgs e)
        {
            grdGrups.AutoGenerateColumns = false;
            grdUsers.AutoGenerateColumns = false;
            grdYetki.AutoGenerateColumns = false;
            Items i = new Items();
            i.ID = 0;
            i.Aciklama = "Yok";
            itemlist.Add(i);
            Items i2 = new Items();
            i2.ID = 1;
            i2.Aciklama = "Okuma";
            itemlist.Add(i2);
            Items i3 = new Items();
            i3.ID = 2;
            i3.Aciklama = "OkumaYazma";
            itemlist.Add(i3);
            loadgroup();
            colYetkiSeviyesi.DataSource = itemlist;
            colYetkiSeviyesi.ValueMember = "ID";
            colYetkiSeviyesi.DisplayMember = "Aciklama";
            colYetkiSeviyesi.DataSource = itemlist;
            txtGrupKodu.ReadOnly = true;
        }

        void loadgroup()
        {
            grdGrups.DataSource = AppParams.DbCon.GetDataTable("Select * from ARGROUPS");
            
        }



        private void btnYeni_Click(object sender, EventArgs e)
        {
            mode = 1;
            txtGrupKodu.ReadOnly = false;
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string Sql = "";
            if (mode==1) 
            {
                Sql="INSERT INTO ARGROUPS (GROUPCODE,GROUPNAME) values ('"+txtGrupKodu.Text+"','"+txtGrupAdi.Text+"')";
            }

            if (mode == 0)
            {
                Sql = "UPDATE ARGROUPS SET GROUPNAME='" + txtGrupAdi.Text + "' WHERE GROUPCODE='" + txtGrupKodu.Text + "' ";
            }
            Sql = Sql + (char)13 + "Delete From ARGROUPRIGTS where GroupCode='"+seciligrup+"' ";
            foreach (DataGridViewRow dr in grdYetki.Rows)
            {
                string Formcode = dr.Cells["colFormCode"].Value.ToString();
                string right = dr.Cells["colYetkiSeviyesi"].Value.ToString();
                Sql = Sql + (char)13 + "INSERT INTO ARGROUPRIGTS (GROUPCODE,FORMCODE,FORMRIGHT,CHANGEDATE,CHANGEDBY) "+
                    "values ('" + seciligrup + "','" + Formcode + "','" + right + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + AppParams.User + "' )  ";
            }
                try
                {
                    AppParams.DbCon.ExecCommand( Sql, "");
                }
                catch (Exception ex)
                {
                    AppParams.fnc.Mesaj_Hata("Kayıt Hatası", "Kaydetme sırasında hata oluştu! " + ex.Message);
                    return;
                }
            
                loadgroup();
                loadusers(txtGrupKodu.Text);

        }

        private void grdGrups_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            seciligrup = grdGrups.Rows[e.RowIndex].Cells["colGruplar"].Value.ToString();
            txtGrupAdi.Text =  grdGrups.Rows[e.RowIndex].Cells["colGrupAdi"].Value.ToString();
            txtGrupKodu.Text = seciligrup;
            txtGrupKodu.ReadOnly = true;
            mode = 0;
            loadusers(seciligrup);
            loadrights(seciligrup);
        }

        void loadusers(string grup)
        {
            grdUsers.DataSource = AppParams.DbCon.GetDataTable("Select * from ARGUSERGROUPS where GroupCode='" + grup + "'"); 
        }

        void loadrights(string grup)
        {
            grdYetki.DataSource = AppParams.DbCon.GetDataTable("Select ARGFORMS.FORMCODE,ARGFORMS.FORMNAME,FORMRIGHT,ISNULL(FORMRIGHT,0) FR from ARGFORMS Left join ARGROUPRIGTS on ARGFORMS.FORMCODE=ARGROUPRIGTS.FORMCODE AND GROUPCODE='" + grup + "' ");

        }


        private void grdUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdGrups_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void btnGrupSil_Click(object sender, EventArgs e)
        {
            if (grdGrups.SelectedRows.Count > 0 && AppParams.fnc.SoruSor("Seçili grubu silmek istediğinize emin misiniz?") == true)
            {
                string gr = grdGrups.SelectedRows[0].Cells[0].Value.ToString();
                AppParams.DbCon.ExecCommand("DELETE FROM ARGROUPS WHERE groupcode='" + gr + "' " +(char)13 + "DELETE FROM ARGUSERGROUPS where GroupCode='" + gr + "'", "");
                loadgroup();
            }
        }
    }

    class Items
    {
       public int ID{get; set;}
       public  string Aciklama{get; set;}
    }
}
