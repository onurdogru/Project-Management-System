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
    public partial class FrmPersonelProjeTurnikeBilgi : BaseForm
    {
        public FrmPersonelProjeTurnikeBilgi()
        {
            InitializeComponent();
        }

        private void FrmPersonelProjeTurnikeBilgi_Load(object sender, EventArgs e)
        {
            DataTable dt = AppParams.DbCon.GetDataTable("Select * from SYS_EXTERNAL WHERE ID=1");
            GrdTurnike.DataSource = AppParams.fnc.GetExternalData(dt.Rows[0]["SERVER"].ToString(), dt.Rows[0]["DBNAME"].ToString(), dt.Rows[0]["USERNAME"].ToString(), AppParams.fnc.TextSifreCoz(dt.Rows[0]["PASSWORD"].ToString(), "+pwd"), dt.Rows[0]["QUERY"].ToString());
        }
    }
}
