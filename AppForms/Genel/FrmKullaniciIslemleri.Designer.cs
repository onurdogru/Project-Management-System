namespace ALPARGE.AppForms.Genel
{
    partial class FrmKullaniciIslemleri
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
            this.txtYeniSifre2 = new BaseControls.BC_TextBox();
            this.txtYeniSifre = new BaseControls.BC_TextBox();
            this.txtMevcutSifre = new BaseControls.BC_TextBox();
            this.BtnKaydet = new BaseControls.BC_Button(this.components);
            this.lblUser = new BaseControls.BC_Label();
            this.bC_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bC_GroupBox1
            // 
            this.bC_GroupBox1.Controls.Add(this.txtYeniSifre2);
            this.bC_GroupBox1.Controls.Add(this.txtYeniSifre);
            this.bC_GroupBox1.Controls.Add(this.txtMevcutSifre);
            this.bC_GroupBox1.Location = new System.Drawing.Point(13, 41);
            this.bC_GroupBox1.Name = "bC_GroupBox1";
            this.bC_GroupBox1.Size = new System.Drawing.Size(253, 116);
            this.bC_GroupBox1.TabIndex = 0;
            this.bC_GroupBox1.TabStop = false;
            this.bC_GroupBox1.Text = " Şifre Değişikliği ";
            // 
            // txtYeniSifre2
            // 
            this.txtYeniSifre2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtYeniSifre2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtYeniSifre2.BorderColor = System.Drawing.Color.DarkGray;
            this.txtYeniSifre2.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtYeniSifre2.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtYeniSifre2.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtYeniSifre2.Label = null;
            this.txtYeniSifre2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre2.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYeniSifre2.LabelText = "Yeni Şifre Tekrar";
            this.txtYeniSifre2.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtYeniSifre2.LabelTop = 3;
            this.txtYeniSifre2.LabelVisible = true;
            this.txtYeniSifre2.LabelWith = 100;
            this.txtYeniSifre2.Location = new System.Drawing.Point(122, 80);
            this.txtYeniSifre2.Name = "txtYeniSifre2";
            this.txtYeniSifre2.NumericBox = false;
            this.txtYeniSifre2.NumericDecimal = 0;
            this.txtYeniSifre2.PasswordChar = '*';
            this.txtYeniSifre2.ReferansTip = 0;
            this.txtYeniSifre2.Required = false;
            this.txtYeniSifre2.RequiredPass = true;
            this.txtYeniSifre2.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre2.TabIndex = 5;
            this.txtYeniSifre2.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtYeniSifre2.WordWrap = false;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtYeniSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtYeniSifre.BorderColor = System.Drawing.Color.DarkGray;
            this.txtYeniSifre.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtYeniSifre.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtYeniSifre.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtYeniSifre.Label = null;
            this.txtYeniSifre.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYeniSifre.LabelText = "Yeni Şifre";
            this.txtYeniSifre.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtYeniSifre.LabelTop = 3;
            this.txtYeniSifre.LabelVisible = true;
            this.txtYeniSifre.LabelWith = 100;
            this.txtYeniSifre.Location = new System.Drawing.Point(122, 54);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.NumericBox = false;
            this.txtYeniSifre.NumericDecimal = 0;
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.ReferansTip = 0;
            this.txtYeniSifre.Required = false;
            this.txtYeniSifre.RequiredPass = true;
            this.txtYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.txtYeniSifre.TabIndex = 3;
            this.txtYeniSifre.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtYeniSifre.WordWrap = false;
            // 
            // txtMevcutSifre
            // 
            this.txtMevcutSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMevcutSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMevcutSifre.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMevcutSifre.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMevcutSifre.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMevcutSifre.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMevcutSifre.Label = null;
            this.txtMevcutSifre.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMevcutSifre.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMevcutSifre.LabelText = "Mevcut Şifre";
            this.txtMevcutSifre.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMevcutSifre.LabelTop = 3;
            this.txtMevcutSifre.LabelVisible = true;
            this.txtMevcutSifre.LabelWith = 100;
            this.txtMevcutSifre.Location = new System.Drawing.Point(122, 28);
            this.txtMevcutSifre.Name = "txtMevcutSifre";
            this.txtMevcutSifre.NumericBox = false;
            this.txtMevcutSifre.NumericDecimal = 0;
            this.txtMevcutSifre.PasswordChar = '*';
            this.txtMevcutSifre.ReferansTip = 0;
            this.txtMevcutSifre.Required = false;
            this.txtMevcutSifre.RequiredPass = true;
            this.txtMevcutSifre.Size = new System.Drawing.Size(100, 20);
            this.txtMevcutSifre.TabIndex = 0;
            this.txtMevcutSifre.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMevcutSifre.WordWrap = false;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(191, 208);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 1;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.Location = new System.Drawing.Point(13, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // FrmKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 243);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.bC_GroupBox1);
            this.Name = "FrmKullaniciIslemleri";
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.FrmKullaniciIslemleri_Load);
            this.bC_GroupBox1.ResumeLayout(false);
            this.bC_GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_GroupBox bC_GroupBox1;
        private BaseControls.BC_TextBox txtYeniSifre2;
        private BaseControls.BC_TextBox txtYeniSifre;
        private BaseControls.BC_TextBox txtMevcutSifre;
        private BaseControls.BC_Button BtnKaydet;
        private BaseControls.BC_Label lblUser;
    }
}