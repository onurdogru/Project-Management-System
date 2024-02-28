namespace ALPARGE.AppForms.Analizler
{
    partial class FrmProjeTamamlanmaOran
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
            this.btnOku = new BaseControls.BC_Button(this.components);
            this.GrdReport = new BaseControls.BC_DataGrid();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.txtPStatu = new BaseControls.BC_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Image = global::ALPARGE.Properties.Resources.search;
            this.btnOku.Location = new System.Drawing.Point(12, 14);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(99, 37);
            this.btnOku.TabIndex = 9;
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
            this.GrdReport.Location = new System.Drawing.Point(12, 57);
            this.GrdReport.MenuDeleteVisible = true;
            this.GrdReport.Name = "GrdReport";
            this.GrdReport.RowHeadersWidth = 25;
            this.GrdReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdReport.Size = new System.Drawing.Size(985, 443);
            this.GrdReport.TabIndex = 8;
            this.GrdReport.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdReport_RowEnter);
            this.GrdReport.DoubleClick += new System.EventHandler(this.GrdReport_DoubleClick);
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
            this.txtProjeNo.Location = new System.Drawing.Point(206, 19);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(108, 20);
            this.txtProjeNo.TabIndex = 14;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.ButtonClick += new System.EventHandler(this.txtProjeNo_ButtonClick);
            // 
            // txtPStatu
            // 
            this.txtPStatu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPStatu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtPStatu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtPStatu.FormattingEnabled = true;
            this.txtPStatu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPStatu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPStatu.LabelText = "Proje Statüsü";
            this.txtPStatu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtPStatu.LabelTop = 4;
            this.txtPStatu.LabelVisible = true;
            this.txtPStatu.LabelWith = 100;
            this.txtPStatu.Location = new System.Drawing.Point(447, 19);
            this.txtPStatu.Name = "txtPStatu";
            this.txtPStatu.Size = new System.Drawing.Size(246, 21);
            this.txtPStatu.TabIndex = 15;
            // 
            // FrmProjeTamamlanmaOran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 512);
            this.Controls.Add(this.txtPStatu);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.GrdReport);
            this.Name = "FrmProjeTamamlanmaOran";
            this.Text = "Proje Tamamlanma Oranları ";
            this.Load += new System.EventHandler(this.FrmProjeTamamlanmaOran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnOku;
        private BaseControls.BC_DataGrid GrdReport;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_ComboBox txtPStatu;
    }
}