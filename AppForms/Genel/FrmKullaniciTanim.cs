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
    public partial class FrmKullaniciTanim : BaseForm
    {
        string user = "";
        public FrmKullaniciTanim()
        {
            InitializeComponent();
            FormCode = "KULLANICILISTESI";
            FormName = "Kullanıcı Listesi";
        }

        private void FrmKullaniciTanim_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sql = "Select USERNAME KullaniciAdi,FULLNAME Isim,EMAIL MailAdresi,ONLINE SonOturumAcma,ACTIVE Aktif from ARGUSERS ";
            if (txtArama.Text != "") sql = sql + " where username like '%" + txtArama.Text + "%' or fullname like '%" + txtArama.Text + "%' ";
            sql = sql + " Order By UserName";
            try
            {
            GrdListe.DataSource = AppParams.DbCon.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                AppParams.fnc.Mesaj_Hata("Liste Yenilemede Hata!", ex.Message);
            }


        }

        private void GrdListe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            user = GrdListe.Rows[e.RowIndex].Cells["KullaniciAdi"].Value.ToString();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (user !="")
            {
                FrmKullaniciDetay frm = new FrmKullaniciDetay();
                frm.user = user;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    btnListele.PerformClick();
                }
                
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            FrmKullaniciDetay frm = new FrmKullaniciDetay();
            frm.user = "";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnListele.PerformClick();
            }
        }
    }
}
