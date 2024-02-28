namespace ALPARGE.AppForms.Analizler
{
    partial class FrmProjePlanUyumSureleri
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
            this.cbTamEsleme = new BaseControls.BC_CheckBox();
            this.cbGorevTip = new BaseControls.BC_CheckBox();
            this.txtKaynak = new BaseControls.BC_TextBox();
            this.cbKaynak = new BaseControls.BC_CheckBox();
            this.txtSorumlu = new BaseControls.BC_TextBox();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.txtBitTarih = new BaseControls.Forms.BC_DateTime();
            this.txtBasTarih = new BaseControls.Forms.BC_DateTime();
            this.btnOku = new BaseControls.BC_Button(this.components);
            this.GrdReport = new BaseControls.BC_DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTamEsleme
            // 
            this.cbTamEsleme.Checked = true;
            this.cbTamEsleme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTamEsleme.Location = new System.Drawing.Point(499, 32);
            this.cbTamEsleme.Name = "cbTamEsleme";
            this.cbTamEsleme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTamEsleme.Size = new System.Drawing.Size(161, 18);
            this.cbTamEsleme.TabIndex = 33;
            this.cbTamEsleme.Text = "Sadece Tam Eşleşenler";
            this.cbTamEsleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbTamEsleme.UseVisualStyleBackColor = true;
            // 
            // cbGorevTip
            // 
            this.cbGorevTip.Checked = true;
            this.cbGorevTip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGorevTip.Location = new System.Drawing.Point(128, 32);
            this.cbGorevTip.Name = "cbGorevTip";
            this.cbGorevTip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbGorevTip.Size = new System.Drawing.Size(161, 18);
            this.cbGorevTip.TabIndex = 27;
            this.cbGorevTip.Text = "Görev Tiplerini Eşleştir";
            this.cbGorevTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbGorevTip.UseVisualStyleBackColor = true;
            // 
            // txtKaynak
            // 
            this.txtKaynak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaynak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaynak.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKaynak.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKaynak.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKaynak.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtKaynak.Label = null;
            this.txtKaynak.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynak.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaynak.LabelText = "Kaynak";
            this.txtKaynak.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKaynak.LabelTop = 3;
            this.txtKaynak.LabelVisible = true;
            this.txtKaynak.LabelWith = 60;
            this.txtKaynak.Location = new System.Drawing.Point(374, 11);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.NumericBox = false;
            this.txtKaynak.NumericDecimal = 0;
            this.txtKaynak.ReferansTip = 0;
            this.txtKaynak.Required = false;
            this.txtKaynak.RequiredPass = true;
            this.txtKaynak.Size = new System.Drawing.Size(100, 20);
            this.txtKaynak.TabIndex = 14;
            this.txtKaynak.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKaynak.WordWrap = false;
            this.txtKaynak.ButtonClick += new System.EventHandler(this.txtKaynak_ButtonClick);
            // 
            // cbKaynak
            // 
            this.cbKaynak.Checked = true;
            this.cbKaynak.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKaynak.Location = new System.Drawing.Point(313, 32);
            this.cbKaynak.Name = "cbKaynak";
            this.cbKaynak.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbKaynak.Size = new System.Drawing.Size(161, 18);
            this.cbKaynak.TabIndex = 26;
            this.cbKaynak.Text = "Kaynakları Eşleştir";
            this.cbKaynak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbKaynak.UseVisualStyleBackColor = true;
            // 
            // txtSorumlu
            // 
            this.txtSorumlu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSorumlu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSorumlu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSorumlu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSorumlu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSorumlu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtSorumlu.Label = null;
            this.txtSorumlu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorumlu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSorumlu.LabelText = "Sorumlu";
            this.txtSorumlu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSorumlu.LabelTop = 3;
            this.txtSorumlu.LabelVisible = true;
            this.txtSorumlu.LabelWith = 60;
            this.txtSorumlu.Location = new System.Drawing.Point(560, 11);
            this.txtSorumlu.Name = "txtSorumlu";
            this.txtSorumlu.NumericBox = false;
            this.txtSorumlu.NumericDecimal = 0;
            this.txtSorumlu.ReferansTip = 0;
            this.txtSorumlu.Required = false;
            this.txtSorumlu.RequiredPass = true;
            this.txtSorumlu.Size = new System.Drawing.Size(100, 20);
            this.txtSorumlu.TabIndex = 20;
            this.txtSorumlu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSorumlu.WordWrap = false;
            this.txtSorumlu.ButtonClick += new System.EventHandler(this.txtSorumlu_ButtonClick);
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje No";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 60;
            this.txtProjeNo.Location = new System.Drawing.Point(189, 11);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 12;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.ButtonClick += new System.EventHandler(this.txtProjeNo_ButtonClick);
            // 
            // txtBitTarih
            // 
            this.txtBitTarih.CustomFormat = "dd.MM.yyyy";
            this.txtBitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBitTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBitTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBitTarih.LabelText = null;
            this.txtBitTarih.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtBitTarih.LabelTop = 5;
            this.txtBitTarih.LabelVisible = false;
            this.txtBitTarih.LabelWith = 100;
            this.txtBitTarih.Location = new System.Drawing.Point(875, 11);
            this.txtBitTarih.Name = "txtBitTarih";
            this.txtBitTarih.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtBitTarih.Size = new System.Drawing.Size(109, 20);
            this.txtBitTarih.TabIndex = 11;
            this.txtBitTarih.Value = new System.DateTime(2018, 7, 26, 0, 0, 0, 0);
            // 
            // txtBasTarih
            // 
            this.txtBasTarih.CustomFormat = "dd.MM.yyyy";
            this.txtBasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBasTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBasTarih.LabelText = "Tarih Aralığı";
            this.txtBasTarih.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtBasTarih.LabelTop = 5;
            this.txtBasTarih.LabelVisible = true;
            this.txtBasTarih.LabelWith = 80;
            this.txtBasTarih.Location = new System.Drawing.Point(760, 11);
            this.txtBasTarih.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.txtBasTarih.Name = "txtBasTarih";
            this.txtBasTarih.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtBasTarih.Size = new System.Drawing.Size(109, 20);
            this.txtBasTarih.TabIndex = 8;
            this.txtBasTarih.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // btnOku
            // 
            this.btnOku.Image = global::ALPARGE.Properties.Resources.search;
            this.btnOku.Location = new System.Drawing.Point(13, 10);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(99, 37);
            this.btnOku.TabIndex = 7;
            this.btnOku.Text = "YENİLE";
            this.btnOku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // GrdReport
            // 
            this.GrdReport.AllowUserToAddRows = false;
            this.GrdReport.AllowUserToDeleteRows = false;
            this.GrdReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdReport.Location = new System.Drawing.Point(13, 53);
            this.GrdReport.MenuDeleteVisible = true;
            this.GrdReport.Name = "GrdReport";
            this.GrdReport.RowHeadersWidth = 25;
            this.GrdReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdReport.Size = new System.Drawing.Size(974, 532);
            this.GrdReport.TabIndex = 0;
            this.GrdReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdReport_CellContentClick);
            // 
            // FrmProjePlanUyumSureleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 597);
            this.Controls.Add(this.cbTamEsleme);
            this.Controls.Add(this.cbGorevTip);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.cbKaynak);
            this.Controls.Add(this.txtSorumlu);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.txtBitTarih);
            this.Controls.Add(this.txtBasTarih);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.GrdReport);
            this.Name = "FrmProjePlanUyumSureleri";
            this.Text = "Proje Plan Uyum Süreleri";
            this.Load += new System.EventHandler(this.FrmProjePlanUyumSureleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdReport;
        private BaseControls.BC_Button btnOku;
        private BaseControls.Forms.BC_DateTime txtBasTarih;
        private BaseControls.Forms.BC_DateTime txtBitTarih;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_TextBox txtKaynak;
        private BaseControls.BC_TextBox txtSorumlu;
        private BaseControls.BC_CheckBox cbKaynak;
        private BaseControls.BC_CheckBox cbGorevTip;
        private BaseControls.BC_CheckBox cbTamEsleme;
    }
}