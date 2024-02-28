namespace ALPARGE.AppForms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lbSts = new BaseControls.BC_Label();
            this.btnConfig = new BaseControls.BC_Button(this.components);
            this.lbSifre = new BaseControls.BC_Label();
            this.lbKullanici = new BaseControls.BC_Label();
            this.btnOk = new BaseControls.BC_Button(this.components);
            this.btnCancel = new BaseControls.BC_Button(this.components);
            this.txtPassword = new BaseControls.BC_TextBox();
            this.txtUserName = new BaseControls.BC_TextBox();
            this.pcLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSts
            // 
            this.lbSts.AutoSize = true;
            this.lbSts.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbSts.Location = new System.Drawing.Point(270, 9);
            this.lbSts.Name = "lbSts";
            this.lbSts.Size = new System.Drawing.Size(116, 24);
            this.lbSts.TabIndex = 8;
            this.lbSts.Text = "ALP ARGE";
            // 
            // btnConfig
            // 
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.Location = new System.Drawing.Point(12, 133);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(44, 41);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TabStop = false;
            this.btnConfig.Text = " ";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSifre.Location = new System.Drawing.Point(165, 100);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(38, 15);
            this.lbSifre.TabIndex = 6;
            this.lbSifre.Text = "Şifre :";
            // 
            // lbKullanici
            // 
            this.lbKullanici.AutoSize = true;
            this.lbKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbKullanici.Location = new System.Drawing.Point(165, 70);
            this.lbKullanici.Name = "lbKullanici";
            this.lbKullanici.Size = new System.Drawing.Size(80, 15);
            this.lbKullanici.TabIndex = 5;
            this.lbKullanici.Text = "Kullanıcı Adı :";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(274, 133);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 33);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = " Giriş";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(168, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = " Vazgeç";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtPassword.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtPassword.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Label = null;
            this.txtPassword.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.LabelText = null;
            this.txtPassword.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtPassword.LabelTop = 5;
            this.txtPassword.LabelVisible = false;
            this.txtPassword.LabelWith = 100;
            this.txtPassword.Location = new System.Drawing.Point(250, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NumericBox = false;
            this.txtPassword.NumericDecimal = 5;
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReferansTip = 0;
            this.txtPassword.Required = false;
            this.txtPassword.RequiredPass = true;
            this.txtPassword.Size = new System.Drawing.Size(124, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtPassword.WordWrap = false;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(244)))));
            this.txtUserName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtUserName.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtUserName.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Label = null;
            this.txtUserName.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.LabelText = null;
            this.txtUserName.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtUserName.LabelTop = 5;
            this.txtUserName.LabelVisible = false;
            this.txtUserName.LabelWith = 100;
            this.txtUserName.Location = new System.Drawing.Point(250, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NumericBox = false;
            this.txtUserName.NumericDecimal = 0;
            this.txtUserName.ReferansTip = 0;
            this.txtUserName.Required = false;
            this.txtUserName.RequiredPass = true;
            this.txtUserName.Size = new System.Drawing.Size(124, 21);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtUserName.WordWrap = false;
            // 
            // pcLogin
            // 
            this.pcLogin.Image = ((System.Drawing.Image)(resources.GetObject("pcLogin.Image")));
            this.pcLogin.Location = new System.Drawing.Point(12, 0);
            this.pcLogin.Name = "pcLogin";
            this.pcLogin.Size = new System.Drawing.Size(131, 141);
            this.pcLogin.TabIndex = 0;
            this.pcLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 186);
            this.Controls.Add(this.lbSts);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.lbKullanici);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pcLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.Text = " Proje Takip Sistemi";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.FrmLogin_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLogin;
        private BaseControls.BC_TextBox txtUserName;
        private BaseControls.BC_TextBox txtPassword;
        private BaseControls.BC_Button btnCancel;
        private BaseControls.BC_Button btnOk;
        private BaseControls.BC_Label lbKullanici;
        private BaseControls.BC_Label lbSifre;
        private BaseControls.BC_Button btnConfig;
        private BaseControls.BC_Label lbSts;
    }
}