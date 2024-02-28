namespace ALPARGE.AppForms.Genel
{
    partial class FrmSaatUcretleriDetay
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
            this.bC_GroupBox1 = new BaseControls.BC_GroupBox();
            this.txtParaBirimi = new BaseControls.BC_ComboBox();
            this.txtUcret = new BaseControls.BC_TextBox();
            this.txtBitTarih = new BaseControls.Forms.BC_DateTime();
            this.txtBasTarih = new BaseControls.Forms.BC_DateTime();
            this.txtAciklama = new BaseControls.BC_TextBox();
            this.txtKaynak = new BaseControls.BC_TextBox();
            this.BtnKaydet = new BaseControls.BC_Button(this.components);
            this.btnIptal = new BaseControls.BC_Button(this.components);
            this.btnSil = new BaseControls.BC_Button(this.components);
            this.bC_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bC_GroupBox1
            // 
            this.bC_GroupBox1.Controls.Add(this.txtParaBirimi);
            this.bC_GroupBox1.Controls.Add(this.txtUcret);
            this.bC_GroupBox1.Controls.Add(this.txtBitTarih);
            this.bC_GroupBox1.Controls.Add(this.txtBasTarih);
            this.bC_GroupBox1.Controls.Add(this.txtAciklama);
            this.bC_GroupBox1.Controls.Add(this.txtKaynak);
            this.bC_GroupBox1.Location = new System.Drawing.Point(13, 13);
            this.bC_GroupBox1.Name = "bC_GroupBox1";
            this.bC_GroupBox1.Size = new System.Drawing.Size(423, 217);
            this.bC_GroupBox1.TabIndex = 0;
            this.bC_GroupBox1.TabStop = false;
            this.bC_GroupBox1.Text = " Kaynak Saat Ücreti";
            // 
            // txtParaBirimi
            // 
            this.txtParaBirimi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtParaBirimi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtParaBirimi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtParaBirimi.Enabled = false;
            this.txtParaBirimi.FormattingEnabled = true;
            this.txtParaBirimi.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EUR"});
            this.txtParaBirimi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaBirimi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParaBirimi.LabelText = "Para Birimi";
            this.txtParaBirimi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtParaBirimi.LabelTop = 4;
            this.txtParaBirimi.LabelVisible = true;
            this.txtParaBirimi.LabelWith = 100;
            this.txtParaBirimi.Location = new System.Drawing.Point(122, 170);
            this.txtParaBirimi.Name = "txtParaBirimi";
            this.txtParaBirimi.Size = new System.Drawing.Size(121, 21);
            this.txtParaBirimi.TabIndex = 10;
            // 
            // txtUcret
            // 
            this.txtUcret.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUcret.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUcret.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUcret.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtUcret.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtUcret.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtUcret.Label = null;
            this.txtUcret.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUcret.LabelText = "Saat Ücreti";
            this.txtUcret.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtUcret.LabelTop = 3;
            this.txtUcret.LabelVisible = true;
            this.txtUcret.LabelWith = 100;
            this.txtUcret.Location = new System.Drawing.Point(122, 143);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.NumericBox = true;
            this.txtUcret.NumericDecimal = 2;
            this.txtUcret.ReferansTip = 0;
            this.txtUcret.Required = false;
            this.txtUcret.RequiredPass = true;
            this.txtUcret.Size = new System.Drawing.Size(122, 20);
            this.txtUcret.TabIndex = 8;
            this.txtUcret.Text = "0,00";
            this.txtUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUcret.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtUcret.WordWrap = false;
            // 
            // txtBitTarih
            // 
            this.txtBitTarih.CustomFormat = "dd.MM.yyyy";
            this.txtBitTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBitTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBitTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBitTarih.LabelText = "Başlangıç Tarihi";
            this.txtBitTarih.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtBitTarih.LabelTop = 5;
            this.txtBitTarih.LabelVisible = true;
            this.txtBitTarih.LabelWith = 100;
            this.txtBitTarih.Location = new System.Drawing.Point(122, 116);
            this.txtBitTarih.Name = "txtBitTarih";
            this.txtBitTarih.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtBitTarih.Size = new System.Drawing.Size(122, 20);
            this.txtBitTarih.TabIndex = 7;
            this.txtBitTarih.Value = new System.DateTime(2018, 12, 28, 0, 0, 0, 0);
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
            this.txtBasTarih.LabelWith = 100;
            this.txtBasTarih.Location = new System.Drawing.Point(122, 90);
            this.txtBasTarih.Name = "txtBasTarih";
            this.txtBasTarih.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtBasTarih.Size = new System.Drawing.Size(122, 20);
            this.txtBasTarih.TabIndex = 4;
            this.txtBasTarih.Value = new System.DateTime(2018, 12, 28, 0, 0, 0, 0);
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
            this.txtAciklama.LabelText = "Kaynak Açıklama";
            this.txtAciklama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtAciklama.LabelTop = 3;
            this.txtAciklama.LabelVisible = true;
            this.txtAciklama.LabelWith = 100;
            this.txtAciklama.Location = new System.Drawing.Point(122, 64);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.NumericBox = false;
            this.txtAciklama.NumericDecimal = 0;
            this.txtAciklama.ReferansTip = 0;
            this.txtAciklama.Required = false;
            this.txtAciklama.RequiredPass = true;
            this.txtAciklama.Size = new System.Drawing.Size(280, 20);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtAciklama.WordWrap = false;
            // 
            // txtKaynak
            // 
            this.txtKaynak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaynak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaynak.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKaynak.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKaynak.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKaynak.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtKaynak.Enabled = false;
            this.txtKaynak.Label = null;
            this.txtKaynak.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynak.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaynak.LabelText = "Kaynak";
            this.txtKaynak.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKaynak.LabelTop = 3;
            this.txtKaynak.LabelVisible = true;
            this.txtKaynak.LabelWith = 100;
            this.txtKaynak.Location = new System.Drawing.Point(122, 38);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.NumericBox = false;
            this.txtKaynak.NumericDecimal = 0;
            this.txtKaynak.ReferansTip = 0;
            this.txtKaynak.Required = false;
            this.txtKaynak.RequiredPass = true;
            this.txtKaynak.Size = new System.Drawing.Size(280, 20);
            this.txtKaynak.TabIndex = 0;
            this.txtKaynak.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKaynak.WordWrap = false;
            this.txtKaynak.ButtonClick += new System.EventHandler(this.txtKaynak_ButtonClick);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.Image = global::ALPARGE.Properties.Resources.add;
            this.BtnKaydet.Location = new System.Drawing.Point(346, 244);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(90, 24);
            this.BtnKaydet.TabIndex = 18;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Image = global::ALPARGE.Properties.Resources.cancel;
            this.btnIptal.Location = new System.Drawing.Point(241, 244);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 24);
            this.btnIptal.TabIndex = 19;
            this.btnIptal.Text = "Vazgeç";
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Enabled = false;
            this.btnSil.Image = global::ALPARGE.Properties.Resources.remove;
            this.btnSil.Location = new System.Drawing.Point(13, 244);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 24);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FrmSaatUcretleriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 279);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.bC_GroupBox1);
            this.Name = "FrmSaatUcretleriDetay";
            this.Text = "Proje Kaynak Saat Ücreti";
            this.Load += new System.EventHandler(this.FrmSaatUcretleriDetay_Load);
            this.bC_GroupBox1.ResumeLayout(false);
            this.bC_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_GroupBox bC_GroupBox1;
        private BaseControls.BC_ComboBox txtParaBirimi;
        private BaseControls.BC_TextBox txtUcret;
        private BaseControls.Forms.BC_DateTime txtBitTarih;
        private BaseControls.Forms.BC_DateTime txtBasTarih;
        private BaseControls.BC_TextBox txtAciklama;
        private BaseControls.BC_TextBox txtKaynak;
        private BaseControls.BC_Button BtnKaydet;
        private BaseControls.BC_Button btnIptal;
        private BaseControls.BC_Button btnSil;
    }
}