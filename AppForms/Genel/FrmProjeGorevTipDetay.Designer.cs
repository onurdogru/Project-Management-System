namespace ALPARGE.AppForms.Genel
{
    partial class FrmProjeGorevTipDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeGorevTipDetay));
            this.txtSira = new BaseControls.BC_TextBox();
            this.txtPasif = new BaseControls.BC_CheckBox();
            this.btnSil = new BaseControls.BC_Button(this.components);
            this.btnVazgec = new BaseControls.BC_Button(this.components);
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.txtDegisTarih = new BaseControls.BC_TextBox();
            this.txtDegistiren = new BaseControls.BC_TextBox();
            this.txtGorevAciklama = new BaseControls.BC_TextBox();
            this.txtGorevTipi = new BaseControls.BC_TextBox();
            this.SuspendLayout();
            // 
            // txtSira
            // 
            this.txtSira.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSira.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSira.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSira.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSira.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSira.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSira.Label = null;
            this.txtSira.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSira.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSira.LabelText = "Listeleme Sıra No";
            this.txtSira.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSira.LabelTop = 3;
            this.txtSira.LabelVisible = true;
            this.txtSira.LabelWith = 100;
            this.txtSira.Location = new System.Drawing.Point(120, 64);
            this.txtSira.MaxLength = 2;
            this.txtSira.Name = "txtSira";
            this.txtSira.NumericBox = true;
            this.txtSira.NumericDecimal = 0;
            this.txtSira.ReferansTip = 0;
            this.txtSira.Required = false;
            this.txtSira.RequiredPass = true;
            this.txtSira.Size = new System.Drawing.Size(107, 20);
            this.txtSira.TabIndex = 54;
            this.txtSira.Text = "10";
            this.txtSira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSira.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSira.WordWrap = false;
            // 
            // txtPasif
            // 
            this.txtPasif.AutoSize = true;
            this.txtPasif.Location = new System.Drawing.Point(400, 14);
            this.txtPasif.Name = "txtPasif";
            this.txtPasif.Size = new System.Drawing.Size(49, 17);
            this.txtPasif.TabIndex = 52;
            this.txtPasif.Text = "Pasif";
            this.txtPasif.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::ALPARGE.Properties.Resources.remove;
            this.btnSil.Location = new System.Drawing.Point(16, 136);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 34);
            this.btnSil.TabIndex = 47;
            this.btnSil.Text = "Görev Tipi Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(199, 136);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(119, 34);
            this.btnVazgec.TabIndex = 46;
            this.btnVazgec.Text = " Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(336, 136);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 34);
            this.btnKaydet.TabIndex = 45;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDegisTarih
            // 
            this.txtDegisTarih.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDegisTarih.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDegisTarih.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDegisTarih.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtDegisTarih.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtDegisTarih.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtDegisTarih.Enabled = false;
            this.txtDegisTarih.Label = null;
            this.txtDegisTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDegisTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDegisTarih.LabelText = "Değişiklik Tarihi";
            this.txtDegisTarih.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtDegisTarih.LabelTop = 3;
            this.txtDegisTarih.LabelVisible = true;
            this.txtDegisTarih.LabelWith = 100;
            this.txtDegisTarih.Location = new System.Drawing.Point(345, 97);
            this.txtDegisTarih.Name = "txtDegisTarih";
            this.txtDegisTarih.NumericBox = false;
            this.txtDegisTarih.NumericDecimal = 0;
            this.txtDegisTarih.ReferansTip = 0;
            this.txtDegisTarih.Required = false;
            this.txtDegisTarih.RequiredPass = true;
            this.txtDegisTarih.Size = new System.Drawing.Size(107, 20);
            this.txtDegisTarih.TabIndex = 7;
            this.txtDegisTarih.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtDegisTarih.WordWrap = false;
            // 
            // txtDegistiren
            // 
            this.txtDegistiren.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDegistiren.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDegistiren.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDegistiren.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtDegistiren.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtDegistiren.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtDegistiren.Enabled = false;
            this.txtDegistiren.Label = null;
            this.txtDegistiren.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDegistiren.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDegistiren.LabelText = "Değiştiren";
            this.txtDegistiren.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtDegistiren.LabelTop = 3;
            this.txtDegistiren.LabelVisible = true;
            this.txtDegistiren.LabelWith = 100;
            this.txtDegistiren.Location = new System.Drawing.Point(120, 97);
            this.txtDegistiren.Name = "txtDegistiren";
            this.txtDegistiren.NumericBox = false;
            this.txtDegistiren.NumericDecimal = 0;
            this.txtDegistiren.ReferansTip = 0;
            this.txtDegistiren.Required = false;
            this.txtDegistiren.RequiredPass = true;
            this.txtDegistiren.Size = new System.Drawing.Size(107, 20);
            this.txtDegistiren.TabIndex = 5;
            this.txtDegistiren.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtDegistiren.WordWrap = false;
            // 
            // txtGorevAciklama
            // 
            this.txtGorevAciklama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGorevAciklama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGorevAciklama.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGorevAciklama.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtGorevAciklama.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtGorevAciklama.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtGorevAciklama.Label = null;
            this.txtGorevAciklama.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorevAciklama.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGorevAciklama.LabelText = "Açıklama";
            this.txtGorevAciklama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtGorevAciklama.LabelTop = 3;
            this.txtGorevAciklama.LabelVisible = true;
            this.txtGorevAciklama.LabelWith = 100;
            this.txtGorevAciklama.Location = new System.Drawing.Point(120, 38);
            this.txtGorevAciklama.MaxLength = 100;
            this.txtGorevAciklama.Name = "txtGorevAciklama";
            this.txtGorevAciklama.NumericBox = false;
            this.txtGorevAciklama.NumericDecimal = 0;
            this.txtGorevAciklama.ReferansTip = 0;
            this.txtGorevAciklama.Required = false;
            this.txtGorevAciklama.RequiredPass = true;
            this.txtGorevAciklama.Size = new System.Drawing.Size(332, 20);
            this.txtGorevAciklama.TabIndex = 3;
            this.txtGorevAciklama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtGorevAciklama.WordWrap = false;
            // 
            // txtGorevTipi
            // 
            this.txtGorevTipi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGorevTipi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGorevTipi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGorevTipi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtGorevTipi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtGorevTipi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtGorevTipi.Label = null;
            this.txtGorevTipi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorevTipi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGorevTipi.LabelText = "Görev Tipi";
            this.txtGorevTipi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtGorevTipi.LabelTop = 3;
            this.txtGorevTipi.LabelVisible = true;
            this.txtGorevTipi.LabelWith = 100;
            this.txtGorevTipi.Location = new System.Drawing.Point(120, 12);
            this.txtGorevTipi.MaxLength = 50;
            this.txtGorevTipi.Name = "txtGorevTipi";
            this.txtGorevTipi.NumericBox = false;
            this.txtGorevTipi.NumericDecimal = 0;
            this.txtGorevTipi.ReferansTip = 0;
            this.txtGorevTipi.Required = false;
            this.txtGorevTipi.RequiredPass = true;
            this.txtGorevTipi.Size = new System.Drawing.Size(244, 20);
            this.txtGorevTipi.TabIndex = 0;
            this.txtGorevTipi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtGorevTipi.WordWrap = false;
            // 
            // FrmProjeGorevTipDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 190);
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.txtPasif);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtDegisTarih);
            this.Controls.Add(this.txtDegistiren);
            this.Controls.Add(this.txtGorevAciklama);
            this.Controls.Add(this.txtGorevTipi);
            this.Name = "FrmProjeGorevTipDetay";
            this.Text = "Görev Tipi Detayı";
            this.Load += new System.EventHandler(this.FrmProjeGorevTipDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtGorevTipi;
        private BaseControls.BC_TextBox txtGorevAciklama;
        private BaseControls.BC_TextBox txtDegistiren;
        private BaseControls.BC_TextBox txtDegisTarih;
        private BaseControls.BC_Button btnSil;
        private BaseControls.BC_Button btnVazgec;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_CheckBox txtPasif;
        private BaseControls.BC_TextBox txtSira;
    }
}