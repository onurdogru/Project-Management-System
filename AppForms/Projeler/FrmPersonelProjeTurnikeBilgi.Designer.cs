namespace ALPARGE.AppForms.Projeler
{
    partial class FrmPersonelProjeTurnikeBilgi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GrdTurnike = new BaseControls.BC_DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTurnike)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdTurnike
            // 
            this.GrdTurnike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdTurnike.Location = new System.Drawing.Point(13, 27);
            this.GrdTurnike.MenuDeleteVisible = true;
            this.GrdTurnike.Name = "GrdTurnike";
            this.GrdTurnike.RowHeadersWidth = 25;
            this.GrdTurnike.Size = new System.Drawing.Size(688, 336);
            this.GrdTurnike.TabIndex = 0;
            // 
            // FrmPersonelProjeTurnikeBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 375);
            this.Controls.Add(this.GrdTurnike);
            this.Name = "FrmPersonelProjeTurnikeBilgi";
            this.Text = "Personel Turnike Bigileri";
            this.Load += new System.EventHandler(this.FrmPersonelProjeTurnikeBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTurnike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_DataGrid GrdTurnike;
    }
}