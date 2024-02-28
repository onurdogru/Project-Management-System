namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjeKapamaOnay
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
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.txtProjeAdı = new BaseControls.BC_TextBox();
            this.txtNot = new BaseControls.BC_TextBox();
            this.btnProjeKapat = new BaseControls.BC_Button(this.components);
            this.btnClose = new BaseControls.BC_Button(this.components);
            this.txtSorumlu = new BaseControls.BC_TextBox();
            this.SuspendLayout();
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeNo.Enabled = false;
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje No";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 100;
            this.txtProjeNo.Location = new System.Drawing.Point(108, 19);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 1;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            // 
            // txtProjeAdı
            // 
            this.txtProjeAdı.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeAdı.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeAdı.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeAdı.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeAdı.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeAdı.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeAdı.Enabled = false;
            this.txtProjeAdı.Label = null;
            this.txtProjeAdı.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeAdı.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeAdı.LabelText = "Proje Adı";
            this.txtProjeAdı.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeAdı.LabelTop = 3;
            this.txtProjeAdı.LabelVisible = true;
            this.txtProjeAdı.LabelWith = 100;
            this.txtProjeAdı.Location = new System.Drawing.Point(108, 45);
            this.txtProjeAdı.Name = "txtProjeAdı";
            this.txtProjeAdı.NumericBox = false;
            this.txtProjeAdı.NumericDecimal = 0;
            this.txtProjeAdı.ReferansTip = 0;
            this.txtProjeAdı.Required = false;
            this.txtProjeAdı.RequiredPass = true;
            this.txtProjeAdı.Size = new System.Drawing.Size(338, 20);
            this.txtProjeAdı.TabIndex = 5;
            this.txtProjeAdı.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeAdı.WordWrap = false;
            // 
            // txtNot
            // 
            this.txtNot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNot.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNot.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtNot.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtNot.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtNot.Label = null;
            this.txtNot.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNot.LabelText = "Kapanış Notu";
            this.txtNot.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtNot.LabelTop = 3;
            this.txtNot.LabelVisible = true;
            this.txtNot.LabelWith = 100;
            this.txtNot.Location = new System.Drawing.Point(108, 113);
            this.txtNot.Name = "txtNot";
            this.txtNot.NumericBox = false;
            this.txtNot.NumericDecimal = 0;
            this.txtNot.ReferansTip = 0;
            this.txtNot.Required = false;
            this.txtNot.RequiredPass = true;
            this.txtNot.Size = new System.Drawing.Size(338, 20);
            this.txtNot.TabIndex = 7;
            this.txtNot.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtNot.WordWrap = false;
            // 
            // btnProjeKapat
            // 
            this.btnProjeKapat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnProjeKapat.Image = global::ALPARGE.Properties.Resources.confirm;
            this.btnProjeKapat.Location = new System.Drawing.Point(329, 148);
            this.btnProjeKapat.Name = "btnProjeKapat";
            this.btnProjeKapat.Size = new System.Drawing.Size(117, 24);
            this.btnProjeKapat.TabIndex = 27;
            this.btnProjeKapat.Text = "Projeyi Kapat";
            this.btnProjeKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjeKapat.UseVisualStyleBackColor = true;
            this.btnProjeKapat.Click += new System.EventHandler(this.btnProjeKapat_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::ALPARGE.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(190, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 24);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Vazgeç";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtSorumlu
            // 
            this.txtSorumlu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSorumlu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSorumlu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSorumlu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSorumlu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSorumlu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSorumlu.Enabled = false;
            this.txtSorumlu.Label = null;
            this.txtSorumlu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorumlu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSorumlu.LabelText = "Proje Sorumlusu";
            this.txtSorumlu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSorumlu.LabelTop = 3;
            this.txtSorumlu.LabelVisible = true;
            this.txtSorumlu.LabelWith = 100;
            this.txtSorumlu.Location = new System.Drawing.Point(346, 19);
            this.txtSorumlu.Name = "txtSorumlu";
            this.txtSorumlu.NumericBox = false;
            this.txtSorumlu.NumericDecimal = 0;
            this.txtSorumlu.ReferansTip = 0;
            this.txtSorumlu.Required = false;
            this.txtSorumlu.RequiredPass = true;
            this.txtSorumlu.Size = new System.Drawing.Size(100, 20);
            this.txtSorumlu.TabIndex = 30;
            this.txtSorumlu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSorumlu.WordWrap = false;
            // 
            // FrmProjeKapamaOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 193);
            this.Controls.Add(this.txtSorumlu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProjeKapat);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.txtProjeAdı);
            this.Controls.Add(this.txtProjeNo);
            this.FormCode = "PROJEKAPAMAONAY";
            this.FormName = "Proje Kapatma Onayı";
            this.Name = "FrmProjeKapamaOnay";
            this.Text = "Proje Kapatma Onayı";
            this.Load += new System.EventHandler(this.FrmProjeKapamaOnay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_TextBox txtProjeAdı;
        private BaseControls.BC_TextBox txtNot;
        private BaseControls.BC_Button btnProjeKapat;
        private BaseControls.BC_Button btnClose;
        private BaseControls.BC_TextBox txtSorumlu;
    }
}