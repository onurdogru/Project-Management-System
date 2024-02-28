namespace ALPARGE.AppForms.Genel
{
    partial class FrmPersonelGCTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelGCTanim));
            this.btnVazgec = new BaseControls.BC_Button(this.components);
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.bC_GroupBox1 = new BaseControls.BC_GroupBox();
            this.txtPassword = new BaseControls.BC_TextBox();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtSifre = new BaseControls.BC_TextBox();
            this.txtSorgu = new BaseControls.BC_TextBox();
            this.txtKullanici = new BaseControls.BC_TextBox();
            this.txtVeritabani = new BaseControls.BC_TextBox();
            this.txtSunucu = new BaseControls.BC_TextBox();
            this.bC_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(283, 298);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(119, 34);
            this.btnVazgec.TabIndex = 12;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(420, 298);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 34);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bC_GroupBox1
            // 
            this.bC_GroupBox1.Controls.Add(this.txtPassword);
            this.bC_GroupBox1.Controls.Add(this.bC_Label1);
            this.bC_GroupBox1.Controls.Add(this.txtSifre);
            this.bC_GroupBox1.Controls.Add(this.txtSorgu);
            this.bC_GroupBox1.Controls.Add(this.txtKullanici);
            this.bC_GroupBox1.Controls.Add(this.txtVeritabani);
            this.bC_GroupBox1.Controls.Add(this.txtSunucu);
            this.bC_GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.bC_GroupBox1.Name = "bC_GroupBox1";
            this.bC_GroupBox1.Size = new System.Drawing.Size(524, 263);
            this.bC_GroupBox1.TabIndex = 0;
            this.bC_GroupBox1.TabStop = false;
            this.bC_GroupBox1.Text = " Bağlantı bilgileri ";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtPassword.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtPassword.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtPassword.Label = null;
            this.txtPassword.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.LabelText = "Veri Tabanı Şifresi";
            this.txtPassword.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtPassword.LabelTop = 3;
            this.txtPassword.LabelVisible = true;
            this.txtPassword.LabelWith = 100;
            this.txtPassword.Location = new System.Drawing.Point(371, 54);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NumericBox = false;
            this.txtPassword.NumericDecimal = 0;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReferansTip = 0;
            this.txtPassword.Required = false;
            this.txtPassword.RequiredPass = true;
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtPassword.WordWrap = false;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(18, 85);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(35, 13);
            this.bC_Label1.TabIndex = 10;
            this.bC_Label1.Text = "Sorgu";
            // 
            // txtSifre
            // 
            this.txtSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSifre.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSifre.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSifre.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSifre.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSifre.Label = null;
            this.txtSifre.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSifre.LabelText = "Veri Tabanı Şifresi";
            this.txtSifre.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSifre.LabelTop = 3;
            this.txtSifre.LabelVisible = false;
            this.txtSifre.LabelWith = 100;
            this.txtSifre.Location = new System.Drawing.Point(371, 78);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.NumericBox = false;
            this.txtSifre.NumericDecimal = 0;
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.ReferansTip = 0;
            this.txtSifre.Required = false;
            this.txtSifre.RequiredPass = true;
            this.txtSifre.Size = new System.Drawing.Size(129, 20);
            this.txtSifre.TabIndex = 7;
            this.txtSifre.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSifre.Visible = false;
            this.txtSifre.WordWrap = false;
            // 
            // txtSorgu
            // 
            this.txtSorgu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSorgu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSorgu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSorgu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSorgu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSorgu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSorgu.Label = null;
            this.txtSorgu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorgu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSorgu.LabelText = null;
            this.txtSorgu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSorgu.LabelTop = 3;
            this.txtSorgu.LabelVisible = false;
            this.txtSorgu.LabelWith = 100;
            this.txtSorgu.Location = new System.Drawing.Point(18, 99);
            this.txtSorgu.MaxLength = 1000;
            this.txtSorgu.Multiline = true;
            this.txtSorgu.Name = "txtSorgu";
            this.txtSorgu.NumericBox = false;
            this.txtSorgu.NumericDecimal = 0;
            this.txtSorgu.ReferansTip = 0;
            this.txtSorgu.Required = false;
            this.txtSorgu.RequiredPass = true;
            this.txtSorgu.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSorgu.Size = new System.Drawing.Size(482, 144);
            this.txtSorgu.TabIndex = 8;
            this.txtSorgu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSorgu.WordWrap = false;
            // 
            // txtKullanici
            // 
            this.txtKullanici.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKullanici.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKullanici.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKullanici.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKullanici.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKullanici.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKullanici.Label = null;
            this.txtKullanici.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKullanici.LabelText = "Kullanıcı Adı";
            this.txtKullanici.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKullanici.LabelTop = 3;
            this.txtKullanici.LabelVisible = true;
            this.txtKullanici.LabelWith = 100;
            this.txtKullanici.Location = new System.Drawing.Point(114, 54);
            this.txtKullanici.MaxLength = 50;
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.NumericBox = false;
            this.txtKullanici.NumericDecimal = 0;
            this.txtKullanici.ReferansTip = 0;
            this.txtKullanici.Required = false;
            this.txtKullanici.RequiredPass = true;
            this.txtKullanici.Size = new System.Drawing.Size(129, 20);
            this.txtKullanici.TabIndex = 5;
            this.txtKullanici.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKullanici.WordWrap = false;
            // 
            // txtVeritabani
            // 
            this.txtVeritabani.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVeritabani.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVeritabani.BorderColor = System.Drawing.Color.DarkGray;
            this.txtVeritabani.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtVeritabani.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtVeritabani.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtVeritabani.Label = null;
            this.txtVeritabani.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeritabani.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVeritabani.LabelText = "Veritabanı Adı";
            this.txtVeritabani.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtVeritabani.LabelTop = 3;
            this.txtVeritabani.LabelVisible = true;
            this.txtVeritabani.LabelWith = 100;
            this.txtVeritabani.Location = new System.Drawing.Point(371, 28);
            this.txtVeritabani.MaxLength = 50;
            this.txtVeritabani.Name = "txtVeritabani";
            this.txtVeritabani.NumericBox = false;
            this.txtVeritabani.NumericDecimal = 0;
            this.txtVeritabani.ReferansTip = 0;
            this.txtVeritabani.Required = false;
            this.txtVeritabani.RequiredPass = true;
            this.txtVeritabani.Size = new System.Drawing.Size(129, 20);
            this.txtVeritabani.TabIndex = 3;
            this.txtVeritabani.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtVeritabani.WordWrap = false;
            // 
            // txtSunucu
            // 
            this.txtSunucu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSunucu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSunucu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSunucu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSunucu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSunucu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSunucu.Label = null;
            this.txtSunucu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSunucu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSunucu.LabelText = "Sunucu Adresi";
            this.txtSunucu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSunucu.LabelTop = 3;
            this.txtSunucu.LabelVisible = true;
            this.txtSunucu.LabelWith = 100;
            this.txtSunucu.Location = new System.Drawing.Point(114, 28);
            this.txtSunucu.MaxLength = 50;
            this.txtSunucu.Name = "txtSunucu";
            this.txtSunucu.NumericBox = false;
            this.txtSunucu.NumericDecimal = 0;
            this.txtSunucu.ReferansTip = 0;
            this.txtSunucu.Required = false;
            this.txtSunucu.RequiredPass = true;
            this.txtSunucu.Size = new System.Drawing.Size(129, 20);
            this.txtSunucu.TabIndex = 0;
            this.txtSunucu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSunucu.WordWrap = false;
            // 
            // FrmPersonelGCTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.bC_GroupBox1);
            this.FormCode = "MEYERTANIM";
            this.FormName = "Meyer Bağlantı Tanımları";
            this.Name = "FrmPersonelGCTanim";
            this.Text = "Personel Giriş Çıkış Tanımları";
            this.Load += new System.EventHandler(this.FrmPersonelGCTanim_Load);
            this.bC_GroupBox1.ResumeLayout(false);
            this.bC_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_GroupBox bC_GroupBox1;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_TextBox txtSorgu;
        private BaseControls.BC_TextBox txtSifre;
        private BaseControls.BC_TextBox txtKullanici;
        private BaseControls.BC_TextBox txtVeritabani;
        private BaseControls.BC_TextBox txtSunucu;
        private BaseControls.BC_Button btnVazgec;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_TextBox txtPassword;
    }
}