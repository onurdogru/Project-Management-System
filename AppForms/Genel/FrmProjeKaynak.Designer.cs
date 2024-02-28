namespace ALPARGE.AppForms.Genel
{
    partial class FrmProjeKaynak
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.GrdKaynakListe = new BaseControls.BC_DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GrdKaynakListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::ALPARGE.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(102, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Değiştir";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::ALPARGE.Properties.Resources.add;
            this.btnEkle.Location = new System.Drawing.Point(12, 8);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // GrdKaynakListe
            // 
            this.GrdKaynakListe.AllowUserToAddRows = false;
            this.GrdKaynakListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdKaynakListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdKaynakListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdKaynakListe.Location = new System.Drawing.Point(12, 37);
            this.GrdKaynakListe.MenuDeleteVisible = true;
            this.GrdKaynakListe.Name = "GrdKaynakListe";
            this.GrdKaynakListe.RowHeadersWidth = 25;
            this.GrdKaynakListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdKaynakListe.Size = new System.Drawing.Size(525, 318);
            this.GrdKaynakListe.TabIndex = 1;
            this.GrdKaynakListe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKaynakListe_RowEnter);
            // 
            // FrmProjeKaynak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 367);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.GrdKaynakListe);
            this.FormCode = "PROJEKAYNAK";
            this.FormName = "Proje Kaynakları";
            this.Name = "FrmProjeKaynak";
            this.Text = "Proje Kaynakları";
            this.Load += new System.EventHandler(this.FrmProjeKaynak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdKaynakListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_DataGrid GrdKaynakListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnEdit;
    }
}