namespace ALPARGE.AppForms.Genel
{
    partial class FrmDosyalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrdKlasor = new BaseControls.BC_DataGrid();
            this.colKlasorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKlasorAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDosyaSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOlusturan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOPDATE = new BaseControls.CalendarColumn();
            this.txtKlasorNo = new BaseControls.BC_TextBox();
            this.txtKlasorAdi = new BaseControls.BC_TextBox();
            this.txtKlasorOlusturan = new BaseControls.BC_TextBox();
            this.btnDuzenle = new BaseControls.BC_Button(this.components);
            this.btkYeniKlasor = new BaseControls.BC_Button(this.components);
            this.btnAra = new BaseControls.BC_Button(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdKlasor)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdKlasor
            // 
            this.GrdKlasor.AllowUserToAddRows = false;
            this.GrdKlasor.AllowUserToDeleteRows = false;
            this.GrdKlasor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdKlasor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdKlasor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKlasorNo,
            this.colKlasorAdi,
            this.colDosyaSayisi,
            this.colOlusturan,
            this.STOPDATE});
            this.GrdKlasor.Location = new System.Drawing.Point(12, 92);
            this.GrdKlasor.MenuDeleteVisible = true;
            this.GrdKlasor.Name = "GrdKlasor";
            this.GrdKlasor.RowHeadersWidth = 25;
            this.GrdKlasor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdKlasor.Size = new System.Drawing.Size(796, 365);
            this.GrdKlasor.TabIndex = 2;
            this.GrdKlasor.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKlasor_RowEnter);
            // 
            // colKlasorNo
            // 
            this.colKlasorNo.DataPropertyName = "FOLDERNO";
            this.colKlasorNo.HeaderText = "Klasör No";
            this.colKlasorNo.Name = "colKlasorNo";
            // 
            // colKlasorAdi
            // 
            this.colKlasorAdi.DataPropertyName = "FOLDERNAME";
            this.colKlasorAdi.HeaderText = "Klasör Adı";
            this.colKlasorAdi.Name = "colKlasorAdi";
            this.colKlasorAdi.Width = 250;
            // 
            // colDosyaSayisi
            // 
            this.colDosyaSayisi.DataPropertyName = "FILENUMBER";
            this.colDosyaSayisi.HeaderText = "Dosya Sayisi";
            this.colDosyaSayisi.Name = "colDosyaSayisi";
            // 
            // colOlusturan
            // 
            this.colOlusturan.DataPropertyName = "CREATEDBY";
            this.colOlusturan.HeaderText = "Oluşturan";
            this.colOlusturan.Name = "colOlusturan";
            // 
            // STOPDATE
            // 
            this.STOPDATE.CustomFormat = null;
            this.STOPDATE.DataPropertyName = "CREATEDATE";
            dataGridViewCellStyle2.NullValue = new System.DateTime(((long)(0)));
            this.STOPDATE.DefaultCellStyle = dataGridViewCellStyle2;
            this.STOPDATE.DefaultDate = new System.DateTime(((long)(0)));
            this.STOPDATE.HeaderText = "Oluşturma Tarihi";
            this.STOPDATE.Name = "STOPDATE";
            // 
            // txtKlasorNo
            // 
            this.txtKlasorNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKlasorNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKlasorNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKlasorNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKlasorNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKlasorNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKlasorNo.Label = null;
            this.txtKlasorNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlasorNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKlasorNo.LabelText = "Klasör Numarası";
            this.txtKlasorNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorNo.LabelTop = 3;
            this.txtKlasorNo.LabelVisible = true;
            this.txtKlasorNo.LabelWith = 100;
            this.txtKlasorNo.Location = new System.Drawing.Point(112, 26);
            this.txtKlasorNo.Name = "txtKlasorNo";
            this.txtKlasorNo.NumericBox = false;
            this.txtKlasorNo.NumericDecimal = 0;
            this.txtKlasorNo.ReferansTip = 0;
            this.txtKlasorNo.Required = false;
            this.txtKlasorNo.RequiredPass = true;
            this.txtKlasorNo.Size = new System.Drawing.Size(100, 20);
            this.txtKlasorNo.TabIndex = 3;
            this.txtKlasorNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorNo.WordWrap = false;
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
            this.txtKlasorAdi.LabelText = "Klasör / Dosya Adı";
            this.txtKlasorAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorAdi.LabelTop = 3;
            this.txtKlasorAdi.LabelVisible = true;
            this.txtKlasorAdi.LabelWith = 100;
            this.txtKlasorAdi.Location = new System.Drawing.Point(332, 26);
            this.txtKlasorAdi.Name = "txtKlasorAdi";
            this.txtKlasorAdi.NumericBox = false;
            this.txtKlasorAdi.NumericDecimal = 0;
            this.txtKlasorAdi.ReferansTip = 0;
            this.txtKlasorAdi.Required = false;
            this.txtKlasorAdi.RequiredPass = true;
            this.txtKlasorAdi.Size = new System.Drawing.Size(255, 20);
            this.txtKlasorAdi.TabIndex = 6;
            this.txtKlasorAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorAdi.WordWrap = false;
            this.txtKlasorAdi.TextChanged += new System.EventHandler(this.txtKlasorAdi_TextChanged);
            // 
            // txtKlasorOlusturan
            // 
            this.txtKlasorOlusturan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKlasorOlusturan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKlasorOlusturan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKlasorOlusturan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKlasorOlusturan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKlasorOlusturan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKlasorOlusturan.Label = null;
            this.txtKlasorOlusturan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlasorOlusturan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKlasorOlusturan.LabelText = "Klasörü Oluşturan";
            this.txtKlasorOlusturan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorOlusturan.LabelTop = 3;
            this.txtKlasorOlusturan.LabelVisible = true;
            this.txtKlasorOlusturan.LabelWith = 100;
            this.txtKlasorOlusturan.Location = new System.Drawing.Point(708, 26);
            this.txtKlasorOlusturan.Name = "txtKlasorOlusturan";
            this.txtKlasorOlusturan.NumericBox = false;
            this.txtKlasorOlusturan.NumericDecimal = 0;
            this.txtKlasorOlusturan.ReferansTip = 0;
            this.txtKlasorOlusturan.Required = false;
            this.txtKlasorOlusturan.RequiredPass = true;
            this.txtKlasorOlusturan.Size = new System.Drawing.Size(100, 20);
            this.txtKlasorOlusturan.TabIndex = 14;
            this.txtKlasorOlusturan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorOlusturan.WordWrap = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = global::ALPARGE.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(671, 61);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(137, 25);
            this.btnDuzenle.TabIndex = 12;
            this.btnDuzenle.Text = " Klasöre Gir";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btkYeniKlasor
            // 
            this.btkYeniKlasor.Image = global::ALPARGE.Properties.Resources.add;
            this.btkYeniKlasor.Location = new System.Drawing.Point(504, 61);
            this.btkYeniKlasor.Name = "btkYeniKlasor";
            this.btkYeniKlasor.Size = new System.Drawing.Size(137, 25);
            this.btkYeniKlasor.TabIndex = 11;
            this.btkYeniKlasor.Text = " Yeni Klasör Oluştur";
            this.btkYeniKlasor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btkYeniKlasor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btkYeniKlasor.UseVisualStyleBackColor = true;
            this.btkYeniKlasor.Click += new System.EventHandler(this.btkYeniKlasor_Click);
            // 
            // btnAra
            // 
            this.btnAra.Image = global::ALPARGE.Properties.Resources.search;
            this.btnAra.Location = new System.Drawing.Point(12, 61);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(102, 25);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = " Kayıt Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmDosyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 469);
            this.Controls.Add(this.txtKlasorOlusturan);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btkYeniKlasor);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKlasorAdi);
            this.Controls.Add(this.txtKlasorNo);
            this.Controls.Add(this.GrdKlasor);
            this.Name = "FrmDosyalar";
            this.Text = "Dosya Yönetimi";
            this.Load += new System.EventHandler(this.FrmDosyalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdKlasor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdKlasor;
        private BaseControls.BC_TextBox txtKlasorNo;
        private BaseControls.BC_TextBox txtKlasorAdi;
        private BaseControls.BC_Button btnAra;
        private BaseControls.BC_Button btkYeniKlasor;
        private BaseControls.BC_Button btnDuzenle;
        private BaseControls.BC_TextBox txtKlasorOlusturan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKlasorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKlasorAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosyaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOlusturan;
        private BaseControls.CalendarColumn STOPDATE;
    }
}