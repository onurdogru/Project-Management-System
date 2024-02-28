namespace ALPARGE.AppForms.Genel
{
    partial class FrmSaatUcretleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaatUcretleri));
            this.GrdListe = new BaseControls.BC_DataGrid();
            this.btnListele = new BaseControls.BC_Button(this.components);
            this.txtKaynak = new BaseControls.BC_TextBox();
            this.btnYeni = new BaseControls.BC_Button(this.components);
            this.btnDuzenle = new BaseControls.BC_Button(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdListe
            // 
            this.GrdListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.GrdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListe.Location = new System.Drawing.Point(12, 41);
            this.GrdListe.MenuDeleteVisible = true;
            this.GrdListe.Name = "GrdListe";
            this.GrdListe.RowHeadersWidth = 25;
            this.GrdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListe.Size = new System.Drawing.Size(764, 418);
            this.GrdListe.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.Image")));
            this.btnListele.Location = new System.Drawing.Point(12, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 23);
            this.btnListele.TabIndex = 13;
            this.btnListele.Text = " Listeyi Yenile";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtKaynak
            // 
            this.txtKaynak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaynak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaynak.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKaynak.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKaynak.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKaynak.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKaynak.Label = null;
            this.txtKaynak.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynak.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaynak.LabelText = "Kaynak";
            this.txtKaynak.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKaynak.LabelTop = 3;
            this.txtKaynak.LabelVisible = true;
            this.txtKaynak.LabelWith = 100;
            this.txtKaynak.Location = new System.Drawing.Point(246, 15);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.NumericBox = false;
            this.txtKaynak.NumericDecimal = 0;
            this.txtKaynak.ReferansTip = 0;
            this.txtKaynak.Required = false;
            this.txtKaynak.RequiredPass = true;
            this.txtKaynak.Size = new System.Drawing.Size(149, 20);
            this.txtKaynak.TabIndex = 15;
            this.txtKaynak.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKaynak.WordWrap = false;
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.Image = global::ALPARGE.Properties.Resources.add;
            this.btnYeni.Location = new System.Drawing.Point(519, 15);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(121, 23);
            this.btnYeni.TabIndex = 17;
            this.btnYeni.Text = "Yeni Ücretlendirme";
            this.btnYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Image = global::ALPARGE.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(655, 15);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(121, 23);
            this.btnDuzenle.TabIndex = 18;
            this.btnDuzenle.Text = "Seçileni Düzenle";
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // FrmSaatUcretleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 471);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.GrdListe);
            this.Name = "FrmSaatUcretleri";
            this.Text = "Saat Ücretleri";
            this.Load += new System.EventHandler(this.FrmSaatUcretleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdListe;
        private BaseControls.BC_Button btnListele;
        private BaseControls.BC_TextBox txtKaynak;
        private BaseControls.BC_Button btnYeni;
        private BaseControls.BC_Button btnDuzenle;
    }
}