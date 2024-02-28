namespace ALPARGE.AppForms
{
    partial class FrmDbConfig
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
            this.lbSunuc = new BaseControls.BC_Label();
            this.lbVt = new BaseControls.BC_Label();
            this.txtServer = new BaseControls.BC_TextBox();
            this.txtDbName = new BaseControls.BC_TextBox();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.btnVazgec = new BaseControls.BC_Button(this.components);
            this.txtUserName = new BaseControls.BC_TextBox();
            this.lbKullanici = new BaseControls.BC_Label();
            this.txtPassword = new BaseControls.BC_TextBox();
            this.lbSifre = new BaseControls.BC_Label();
            this.txtParametre = new BaseControls.BC_TextBox();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.bC_GroupBox2 = new BaseControls.BC_GroupBox();
            this.bC_GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSunuc
            // 
            this.lbSunuc.AutoSize = true;
            this.lbSunuc.Location = new System.Drawing.Point(16, 28);
            this.lbSunuc.Name = "lbSunuc";
            this.lbSunuc.Size = new System.Drawing.Size(65, 13);
            this.lbSunuc.TabIndex = 0;
            this.lbSunuc.Text = "Sunucu Adı:";
            // 
            // lbVt
            // 
            this.lbVt.AutoSize = true;
            this.lbVt.Location = new System.Drawing.Point(16, 54);
            this.lbVt.Name = "lbVt";
            this.lbVt.Size = new System.Drawing.Size(61, 13);
            this.lbVt.TabIndex = 1;
            this.lbVt.Text = "Veri Tabanı";
            // 
            // txtServer
            // 
            this.txtServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtServer.BorderColor = System.Drawing.Color.DarkGray;
            this.txtServer.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtServer.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtServer.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtServer.Label = null;
            this.txtServer.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtServer.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServer.LabelText = null;
            this.txtServer.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtServer.LabelTop = 5;
            this.txtServer.LabelVisible = false;
            this.txtServer.LabelWith = 100;
            this.txtServer.Location = new System.Drawing.Point(95, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.NumericBox = false;
            this.txtServer.NumericDecimal = 0;
            this.txtServer.ReferansTip = 0;
            this.txtServer.Required = false;
            this.txtServer.RequiredPass = true;
            this.txtServer.Size = new System.Drawing.Size(196, 20);
            this.txtServer.TabIndex = 2;
            this.txtServer.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtServer.WordWrap = false;
            // 
            // txtDbName
            // 
            this.txtDbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDbName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDbName.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtDbName.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtDbName.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtDbName.Label = null;
            this.txtDbName.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDbName.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDbName.LabelText = null;
            this.txtDbName.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtDbName.LabelTop = 5;
            this.txtDbName.LabelVisible = false;
            this.txtDbName.LabelWith = 100;
            this.txtDbName.Location = new System.Drawing.Point(95, 51);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.NumericBox = false;
            this.txtDbName.NumericDecimal = 0;
            this.txtDbName.ReferansTip = 0;
            this.txtDbName.Required = false;
            this.txtDbName.RequiredPass = true;
            this.txtDbName.Size = new System.Drawing.Size(196, 20);
            this.txtDbName.TabIndex = 3;
            this.txtDbName.Text = "STSDB";
            this.txtDbName.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtDbName.WordWrap = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(67, 169);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(96, 27);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(195, 169);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(96, 27);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtUserName.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtUserName.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtUserName.Label = null;
            this.txtUserName.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.LabelText = null;
            this.txtUserName.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtUserName.LabelTop = 5;
            this.txtUserName.LabelVisible = false;
            this.txtUserName.LabelWith = 100;
            this.txtUserName.Location = new System.Drawing.Point(95, 77);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NumericBox = false;
            this.txtUserName.NumericDecimal = 0;
            this.txtUserName.ReferansTip = 0;
            this.txtUserName.Required = false;
            this.txtUserName.RequiredPass = true;
            this.txtUserName.Size = new System.Drawing.Size(196, 20);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "sa";
            this.txtUserName.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtUserName.WordWrap = false;
            // 
            // lbKullanici
            // 
            this.lbKullanici.AutoSize = true;
            this.lbKullanici.Location = new System.Drawing.Point(16, 80);
            this.lbKullanici.Name = "lbKullanici";
            this.lbKullanici.Size = new System.Drawing.Size(64, 13);
            this.lbKullanici.TabIndex = 6;
            this.lbKullanici.Text = "Kullanıcı Adı";
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
            this.txtPassword.LabelText = null;
            this.txtPassword.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtPassword.LabelTop = 5;
            this.txtPassword.LabelVisible = false;
            this.txtPassword.LabelWith = 100;
            this.txtPassword.Location = new System.Drawing.Point(95, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NumericBox = false;
            this.txtPassword.NumericDecimal = 0;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReferansTip = 0;
            this.txtPassword.Required = false;
            this.txtPassword.RequiredPass = true;
            this.txtPassword.Size = new System.Drawing.Size(196, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtPassword.WordWrap = false;
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Location = new System.Drawing.Point(16, 106);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(28, 13);
            this.lbSifre.TabIndex = 8;
            this.lbSifre.Text = "Şifre";
            // 
            // txtParametre
            // 
            this.txtParametre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtParametre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtParametre.BorderColor = System.Drawing.Color.DarkGray;
            this.txtParametre.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtParametre.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtParametre.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtParametre.Label = null;
            this.txtParametre.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParametre.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParametre.LabelText = null;
            this.txtParametre.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtParametre.LabelTop = 5;
            this.txtParametre.LabelVisible = false;
            this.txtParametre.LabelWith = 100;
            this.txtParametre.Location = new System.Drawing.Point(95, 129);
            this.txtParametre.Name = "txtParametre";
            this.txtParametre.NumericBox = false;
            this.txtParametre.NumericDecimal = 0;
            this.txtParametre.ReferansTip = 0;
            this.txtParametre.Required = false;
            this.txtParametre.RequiredPass = true;
            this.txtParametre.Size = new System.Drawing.Size(196, 20);
            this.txtParametre.TabIndex = 13;
            this.txtParametre.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtParametre.WordWrap = false;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(16, 132);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(55, 13);
            this.bC_Label1.TabIndex = 12;
            this.bC_Label1.Text = "Parametre";
            // 
            // bC_GroupBox2
            // 
            this.bC_GroupBox2.Controls.Add(this.lbSunuc);
            this.bC_GroupBox2.Controls.Add(this.btnKaydet);
            this.bC_GroupBox2.Controls.Add(this.btnVazgec);
            this.bC_GroupBox2.Controls.Add(this.lbVt);
            this.bC_GroupBox2.Controls.Add(this.txtParametre);
            this.bC_GroupBox2.Controls.Add(this.txtServer);
            this.bC_GroupBox2.Controls.Add(this.bC_Label1);
            this.bC_GroupBox2.Controls.Add(this.txtDbName);
            this.bC_GroupBox2.Controls.Add(this.txtPassword);
            this.bC_GroupBox2.Controls.Add(this.lbKullanici);
            this.bC_GroupBox2.Controls.Add(this.lbSifre);
            this.bC_GroupBox2.Controls.Add(this.txtUserName);
            this.bC_GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.bC_GroupBox2.Name = "bC_GroupBox2";
            this.bC_GroupBox2.Size = new System.Drawing.Size(312, 196);
            this.bC_GroupBox2.TabIndex = 15;
            this.bC_GroupBox2.TabStop = false;
            this.bC_GroupBox2.Text = " Veri Tabanı Bağlantısı ";
            // 
            // FrmDbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(329, 225);
            this.Controls.Add(this.bC_GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDbConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "   Veri Tabanı Bağlantı Ayarları";
            this.Load += new System.EventHandler(this.FrmDbConfig_Load);
            this.bC_GroupBox2.ResumeLayout(false);
            this.bC_GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_Label lbSunuc;
        private BaseControls.BC_Label lbVt;
        private BaseControls.BC_TextBox txtServer;
        private BaseControls.BC_TextBox txtDbName;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_Button btnVazgec;
        private BaseControls.BC_TextBox txtUserName;
        private BaseControls.BC_Label lbKullanici;
        private BaseControls.BC_TextBox txtPassword;
        private BaseControls.BC_Label lbSifre;
        private BaseControls.BC_TextBox txtParametre;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_GroupBox bC_GroupBox2;
    }
}