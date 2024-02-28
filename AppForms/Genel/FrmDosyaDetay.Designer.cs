namespace ALPARGE.AppForms.Genel
{
    partial class FrmDosyaDetay
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDosyaAc = new BaseControls.BC_Button(this.components);
            this.btnDosyaEkle = new BaseControls.BC_Button(this.components);
            this.txtKlasorAdi = new BaseControls.BC_TextBox();
            this.txtKlasorNo = new BaseControls.BC_TextBox();
            this.GrdDosyalar = new BaseControls.BC_DataGrid();
            this.txtSecilenDosya = new BaseControls.BC_TextBox();
            this.btnDosyaSil = new BaseControls.BC_Button(this.components);
            this.btnKlasorSil = new BaseControls.BC_Button(this.components);
            this.btnKlasorGuncelle = new BaseControls.BC_Button(this.components);
            this.colFILENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDosyalar)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Image = global::ALPARGE.Properties.Resources.search;
            this.btnDosyaAc.Location = new System.Drawing.Point(641, 436);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(144, 23);
            this.btnDosyaAc.TabIndex = 16;
            this.btnDosyaAc.Text = "Dosyayı Aç";
            this.btnDosyaAc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaAc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Image = global::ALPARGE.Properties.Resources.add;
            this.btnDosyaEkle.Location = new System.Drawing.Point(12, 60);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(95, 23);
            this.btnDosyaEkle.TabIndex = 15;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // txtKlasorAdi
            // 
            this.txtKlasorAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKlasorAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKlasorAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKlasorAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKlasorAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKlasorAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKlasorAdi.Label = null;
            this.txtKlasorAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlasorAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKlasorAdi.LabelText = "Klasör Adı";
            this.txtKlasorAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorAdi.LabelTop = 3;
            this.txtKlasorAdi.LabelVisible = true;
            this.txtKlasorAdi.LabelWith = 100;
            this.txtKlasorAdi.Location = new System.Drawing.Point(431, 22);
            this.txtKlasorAdi.Name = "txtKlasorAdi";
            this.txtKlasorAdi.NumericBox = false;
            this.txtKlasorAdi.NumericDecimal = 0;
            this.txtKlasorAdi.ReferansTip = 0;
            this.txtKlasorAdi.Required = false;
            this.txtKlasorAdi.RequiredPass = true;
            this.txtKlasorAdi.Size = new System.Drawing.Size(328, 20);
            this.txtKlasorAdi.TabIndex = 14;
            this.txtKlasorAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorAdi.WordWrap = false;
            // 
            // txtKlasorNo
            // 
            this.txtKlasorNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKlasorNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKlasorNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKlasorNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKlasorNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKlasorNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtKlasorNo.Label = null;
            this.txtKlasorNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlasorNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKlasorNo.LabelText = "Klasör Numarası";
            this.txtKlasorNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorNo.LabelTop = 3;
            this.txtKlasorNo.LabelVisible = true;
            this.txtKlasorNo.LabelWith = 100;
            this.txtKlasorNo.Location = new System.Drawing.Point(112, 22);
            this.txtKlasorNo.Name = "txtKlasorNo";
            this.txtKlasorNo.NumericBox = false;
            this.txtKlasorNo.NumericDecimal = 0;
            this.txtKlasorNo.ReadOnly = true;
            this.txtKlasorNo.ReferansTip = 0;
            this.txtKlasorNo.Required = false;
            this.txtKlasorNo.RequiredPass = true;
            this.txtKlasorNo.Size = new System.Drawing.Size(203, 20);
            this.txtKlasorNo.TabIndex = 13;
            this.txtKlasorNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorNo.WordWrap = false;
            // 
            // GrdDosyalar
            // 
            this.GrdDosyalar.AllowUserToAddRows = false;
            this.GrdDosyalar.AllowUserToDeleteRows = false;
            this.GrdDosyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDosyalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFILENAME,
            this.colTYPE,
            this.colSize,
            this.colUSERNAME,
            this.colDate});
            this.GrdDosyalar.Location = new System.Drawing.Point(12, 89);
            this.GrdDosyalar.MenuDeleteVisible = true;
            this.GrdDosyalar.Name = "GrdDosyalar";
            this.GrdDosyalar.RowHeadersWidth = 25;
            this.GrdDosyalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDosyalar.Size = new System.Drawing.Size(773, 338);
            this.GrdDosyalar.TabIndex = 10;
            this.GrdDosyalar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDosyalar_RowEnter);
            // 
            // txtSecilenDosya
            // 
            this.txtSecilenDosya.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecilenDosya.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSecilenDosya.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSecilenDosya.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSecilenDosya.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSecilenDosya.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSecilenDosya.Label = null;
            this.txtSecilenDosya.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilenDosya.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSecilenDosya.LabelText = "Seçili Dosya";
            this.txtSecilenDosya.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSecilenDosya.LabelTop = 3;
            this.txtSecilenDosya.LabelVisible = true;
            this.txtSecilenDosya.LabelWith = 100;
            this.txtSecilenDosya.Location = new System.Drawing.Point(112, 436);
            this.txtSecilenDosya.Name = "txtSecilenDosya";
            this.txtSecilenDosya.NumericBox = false;
            this.txtSecilenDosya.NumericDecimal = 0;
            this.txtSecilenDosya.ReadOnly = true;
            this.txtSecilenDosya.ReferansTip = 0;
            this.txtSecilenDosya.Required = false;
            this.txtSecilenDosya.RequiredPass = true;
            this.txtSecilenDosya.Size = new System.Drawing.Size(257, 20);
            this.txtSecilenDosya.TabIndex = 20;
            this.txtSecilenDosya.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSecilenDosya.WordWrap = false;
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Image = global::ALPARGE.Properties.Resources.remove;
            this.btnDosyaSil.Location = new System.Drawing.Point(402, 436);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(149, 23);
            this.btnDosyaSil.TabIndex = 21;
            this.btnDosyaSil.Text = " Seçili Dosyayı Sil";
            this.btnDosyaSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // btnKlasorSil
            // 
            this.btnKlasorSil.Image = global::ALPARGE.Properties.Resources.remove;
            this.btnKlasorSil.Location = new System.Drawing.Point(692, 48);
            this.btnKlasorSil.Name = "btnKlasorSil";
            this.btnKlasorSil.Size = new System.Drawing.Size(95, 25);
            this.btnKlasorSil.TabIndex = 22;
            this.btnKlasorSil.Text = " Klasörü Sil";
            this.btnKlasorSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKlasorSil.UseVisualStyleBackColor = true;
            this.btnKlasorSil.Click += new System.EventHandler(this.btnKlasorSil_Click);
            // 
            // btnKlasorGuncelle
            // 
            this.btnKlasorGuncelle.Image = global::ALPARGE.Properties.Resources.save;
            this.btnKlasorGuncelle.Location = new System.Drawing.Point(759, 20);
            this.btnKlasorGuncelle.Name = "btnKlasorGuncelle";
            this.btnKlasorGuncelle.Size = new System.Drawing.Size(28, 23);
            this.btnKlasorGuncelle.TabIndex = 23;
            this.btnKlasorGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKlasorGuncelle.UseVisualStyleBackColor = true;
            this.btnKlasorGuncelle.Click += new System.EventHandler(this.btnKlasorGuncelle_Click);
            // 
            // colFILENAME
            // 
            this.colFILENAME.DataPropertyName = "FILENAME";
            this.colFILENAME.HeaderText = "Dosya Adı";
            this.colFILENAME.Name = "colFILENAME";
            this.colFILENAME.Width = 300;
            // 
            // colTYPE
            // 
            this.colTYPE.DataPropertyName = "TYPE";
            this.colTYPE.HeaderText = "Uzantı";
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.Width = 80;
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "SIZE";
            this.colSize.HeaderText = "Boyut( MB)";
            this.colSize.Name = "colSize";
            this.colSize.Width = 90;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.DataPropertyName = "USERNAME";
            this.colUSERNAME.HeaderText = "Kaydeden";
            this.colUSERNAME.Name = "colUSERNAME";
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DATE";
            this.colDate.HeaderText = "Kayıt Tarihi";
            this.colDate.Name = "colDate";
            // 
            // FrmDosyaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 468);
            this.Controls.Add(this.btnKlasorGuncelle);
            this.Controls.Add(this.btnKlasorSil);
            this.Controls.Add(this.btnDosyaSil);
            this.Controls.Add(this.txtSecilenDosya);
            this.Controls.Add(this.btnDosyaAc);
            this.Controls.Add(this.btnDosyaEkle);
            this.Controls.Add(this.txtKlasorAdi);
            this.Controls.Add(this.txtKlasorNo);
            this.Controls.Add(this.GrdDosyalar);
            this.Name = "FrmDosyaDetay";
            this.Text = "Klasör Dosyaları";
            this.Load += new System.EventHandler(this.FrmDosyaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDosyalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdDosyalar;
        private BaseControls.BC_TextBox txtKlasorAdi;
        private BaseControls.BC_TextBox txtKlasorNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BaseControls.BC_Button btnDosyaEkle;
        private BaseControls.BC_Button btnDosyaAc;
        private BaseControls.BC_TextBox txtSecilenDosya;
        private BaseControls.BC_Button btnDosyaSil;
        private BaseControls.BC_Button btnKlasorSil;
        private BaseControls.BC_Button btnKlasorGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFILENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}