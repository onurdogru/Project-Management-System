namespace ALPARGE.AppForms.Analizler
{
    partial class FrmPersonelCalismaPlan
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
            this.txtBasTarih = new BaseControls.Forms.BC_DateTime();
            this.txtPersonel = new BaseControls.BC_TextBox();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.btnOku = new BaseControls.BC_Button(this.components);
            this.GrdReport = new BaseControls.BC_DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBasTarih
            // 
            this.txtBasTarih.CustomFormat = "dd.MM.yyyy";
            this.txtBasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBasTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBasTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBasTarih.LabelText = "Başlangıç Tarihi";
            this.txtBasTarih.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtBasTarih.LabelTop = 5;
            this.txtBasTarih.LabelVisible = true;
            this.txtBasTarih.LabelWith = 80;
            this.txtBasTarih.Location = new System.Drawing.Point(709, 21);
            this.txtBasTarih.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.txtBasTarih.Name = "txtBasTarih";
            this.txtBasTarih.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtBasTarih.Size = new System.Drawing.Size(109, 20);
            this.txtBasTarih.TabIndex = 34;
            this.txtBasTarih.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // txtPersonel
            // 
            this.txtPersonel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPersonel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPersonel.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPersonel.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtPersonel.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtPersonel.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtPersonel.Label = null;
            this.txtPersonel.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonel.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPersonel.LabelText = "Çalışan";
            this.txtPersonel.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtPersonel.LabelTop = 3;
            this.txtPersonel.LabelVisible = true;
            this.txtPersonel.LabelWith = 60;
            this.txtPersonel.Location = new System.Drawing.Point(272, 24);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.NumericBox = false;
            this.txtPersonel.NumericDecimal = 0;
            this.txtPersonel.ReferansTip = 0;
            this.txtPersonel.Required = false;
            this.txtPersonel.RequiredPass = true;
            this.txtPersonel.Size = new System.Drawing.Size(108, 20);
            this.txtPersonel.TabIndex = 33;
            this.txtPersonel.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtPersonel.WordWrap = false;
            this.txtPersonel.ButtonClick += new System.EventHandler(this.txtPersonel_ButtonClick);
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
            this.txtProjeNo.Location = new System.Drawing.Point(476, 24);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(108, 20);
            this.txtProjeNo.TabIndex = 32;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.ButtonClick += new System.EventHandler(this.txtProjeNo_ButtonClick);
            this.txtProjeNo.TextChanged += new System.EventHandler(this.txtProjeNo_TextChanged);
            // 
            // btnOku
            // 
            this.btnOku.Image = global::ALPARGE.Properties.Resources.search;
            this.btnOku.Location = new System.Drawing.Point(16, 15);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(99, 37);
            this.btnOku.TabIndex = 11;
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
            this.GrdReport.Location = new System.Drawing.Point(16, 58);
            this.GrdReport.MenuDeleteVisible = true;
            this.GrdReport.Name = "GrdReport";
            this.GrdReport.RowHeadersWidth = 25;
            this.GrdReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdReport.Size = new System.Drawing.Size(804, 443);
            this.GrdReport.TabIndex = 10;
            // 
            // FrmPersonelCalismaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 517);
            this.Controls.Add(this.txtBasTarih);
            this.Controls.Add(this.txtPersonel);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.GrdReport);
            this.Name = "FrmPersonelCalismaPlan";
            this.Text = "Personel Çalışma Planı";
            this.Load += new System.EventHandler(this.FrmPersonelCalismaPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnOku;
        private BaseControls.BC_DataGrid GrdReport;
        private BaseControls.Forms.BC_DateTime txtBasTarih;
        private BaseControls.BC_TextBox txtPersonel;
        private BaseControls.BC_TextBox txtProjeNo;
    }
}