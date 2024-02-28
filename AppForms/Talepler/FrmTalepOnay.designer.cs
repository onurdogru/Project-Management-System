namespace ALPARGE.AppForms.Talepler
{
    partial class FrmTalepOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalepOnay));
            this.GrdProjeList = new BaseControls.BC_DataGrid();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.btnListele = new BaseControls.BC_Button(this.components);
            this.bC_Panel1 = new BaseControls.Forms.BC_Panel();
            this.btnRed = new BaseControls.BC_Button(this.components);
            this.txtAciklama = new BaseControls.BC_TextBox();
            this.txtSeciliProje = new BaseControls.BC_TextBox();
            this.btnOnay = new BaseControls.BC_Button(this.components);
            this.btnProjeBilgileri = new BaseControls.BC_Button(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).BeginInit();
            this.bC_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdProjeList
            // 
            this.GrdProjeList.AllowUserToAddRows = false;
            this.GrdProjeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdProjeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdProjeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProjeList.Location = new System.Drawing.Point(12, 41);
            this.GrdProjeList.MenuDeleteVisible = true;
            this.GrdProjeList.Name = "GrdProjeList";
            this.GrdProjeList.ReadOnly = true;
            this.GrdProjeList.RowHeadersWidth = 25;
            this.GrdProjeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdProjeList.Size = new System.Drawing.Size(968, 454);
            this.GrdProjeList.TabIndex = 9;
            this.GrdProjeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProjeList_RowEnter);
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje Kodu";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 100;
            this.txtProjeNo.Location = new System.Drawing.Point(743, 14);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 14;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            // 
            // btnListele
            // 
            this.btnListele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListele.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.Image")));
            this.btnListele.Location = new System.Drawing.Point(859, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 23);
            this.btnListele.TabIndex = 11;
            this.btnListele.Text = " Listeyi Yenile";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // bC_Panel1
            // 
            this.bC_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bC_Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bC_Panel1.Controls.Add(this.btnProjeBilgileri);
            this.bC_Panel1.Controls.Add(this.btnRed);
            this.bC_Panel1.Controls.Add(this.txtAciklama);
            this.bC_Panel1.Controls.Add(this.txtSeciliProje);
            this.bC_Panel1.Controls.Add(this.btnOnay);
            this.bC_Panel1.Location = new System.Drawing.Point(12, 494);
            this.bC_Panel1.Name = "bC_Panel1";
            this.bC_Panel1.Size = new System.Drawing.Size(968, 66);
            this.bC_Panel1.TabIndex = 10;
            // 
            // btnRed
            // 
            this.btnRed.Image = ((System.Drawing.Image)(resources.GetObject("btnRed.Image")));
            this.btnRed.Location = new System.Drawing.Point(812, 4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(134, 25);
            this.btnRed.TabIndex = 6;
            this.btnRed.Text = "  Talebi Reddet";
            this.btnRed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAciklama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAciklama.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAciklama.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtAciklama.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtAciklama.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtAciklama.Label = null;
            this.txtAciklama.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAciklama.LabelText = "Onay Red Açıklaması";
            this.txtAciklama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtAciklama.LabelTop = 3;
            this.txtAciklama.LabelVisible = true;
            this.txtAciklama.LabelWith = 120;
            this.txtAciklama.Location = new System.Drawing.Point(127, 32);
            this.txtAciklama.MaxLength = 200;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.NumericBox = false;
            this.txtAciklama.NumericDecimal = 0;
            this.txtAciklama.ReferansTip = 0;
            this.txtAciklama.Required = false;
            this.txtAciklama.RequiredPass = true;
            this.txtAciklama.Size = new System.Drawing.Size(819, 20);
            this.txtAciklama.TabIndex = 3;
            this.txtAciklama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtAciklama.WordWrap = false;
            // 
            // txtSeciliProje
            // 
            this.txtSeciliProje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSeciliProje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSeciliProje.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSeciliProje.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSeciliProje.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSeciliProje.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSeciliProje.Label = null;
            this.txtSeciliProje.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeciliProje.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSeciliProje.LabelText = "Proje Kodu";
            this.txtSeciliProje.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSeciliProje.LabelTop = 3;
            this.txtSeciliProje.LabelVisible = true;
            this.txtSeciliProje.LabelWith = 120;
            this.txtSeciliProje.Location = new System.Drawing.Point(127, 6);
            this.txtSeciliProje.Name = "txtSeciliProje";
            this.txtSeciliProje.NumericBox = false;
            this.txtSeciliProje.NumericDecimal = 0;
            this.txtSeciliProje.ReferansTip = 0;
            this.txtSeciliProje.Required = false;
            this.txtSeciliProje.RequiredPass = true;
            this.txtSeciliProje.Size = new System.Drawing.Size(124, 20);
            this.txtSeciliProje.TabIndex = 1;
            this.txtSeciliProje.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSeciliProje.WordWrap = false;
            // 
            // btnOnay
            // 
            this.btnOnay.Image = ((System.Drawing.Image)(resources.GetObject("btnOnay.Image")));
            this.btnOnay.Location = new System.Drawing.Point(639, 4);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(134, 25);
            this.btnOnay.TabIndex = 0;
            this.btnOnay.Text = "  Talebi Onayla";
            this.btnOnay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnProjeBilgileri
            // 
            this.btnProjeBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeBilgileri.Image")));
            this.btnProjeBilgileri.Location = new System.Drawing.Point(267, 4);
            this.btnProjeBilgileri.Name = "btnProjeBilgileri";
            this.btnProjeBilgileri.Size = new System.Drawing.Size(134, 25);
            this.btnProjeBilgileri.TabIndex = 9;
            this.btnProjeBilgileri.Text = "  Proje Bilgileri";
            this.btnProjeBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjeBilgileri.UseVisualStyleBackColor = true;
            this.btnProjeBilgileri.Click += new System.EventHandler(this.btnProjeBilgileri_Click);
            // 
            // FrmTalepOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 572);
            this.Controls.Add(this.GrdProjeList);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.bC_Panel1);
            this.Name = "FrmTalepOnay";
            this.Text = "Talep Onaylama";
            this.Load += new System.EventHandler(this.FrmProjeOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).EndInit();
            this.bC_Panel1.ResumeLayout(false);
            this.bC_Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdProjeList;
        private BaseControls.Forms.BC_Panel bC_Panel1;
        private BaseControls.BC_Button btnListele;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_TextBox txtAciklama;
        private BaseControls.BC_TextBox txtSeciliProje;
        private BaseControls.BC_Button btnOnay;
        private BaseControls.BC_Button btnRed;
        private BaseControls.BC_Button btnProjeBilgileri;
    }
}