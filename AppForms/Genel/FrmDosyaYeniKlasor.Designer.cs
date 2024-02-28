namespace ALPARGE.AppForms.Genel
{
    partial class FrmDosyaYeniKlasor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDosyaYeniKlasor));
            this.txtKlasorNo = new BaseControls.BC_TextBox();
            this.txtKlasorAdi = new BaseControls.BC_TextBox();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.btnVazgec = new BaseControls.BC_Button(this.components);
            this.SuspendLayout();
            // 
            // txtKlasorNo
            // 
            this.txtKlasorNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKlasorNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKlasorNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKlasorNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKlasorNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKlasorNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtKlasorNo.Label = null;
            this.txtKlasorNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlasorNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKlasorNo.LabelText = "Klasör Numarası";
            this.txtKlasorNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorNo.LabelTop = 3;
            this.txtKlasorNo.LabelVisible = true;
            this.txtKlasorNo.LabelWith = 100;
            this.txtKlasorNo.Location = new System.Drawing.Point(116, 26);
            this.txtKlasorNo.Name = "txtKlasorNo";
            this.txtKlasorNo.NumericBox = false;
            this.txtKlasorNo.NumericDecimal = 0;
            this.txtKlasorNo.ReadOnly = true;
            this.txtKlasorNo.ReferansTip = 0;
            this.txtKlasorNo.Required = false;
            this.txtKlasorNo.RequiredPass = true;
            this.txtKlasorNo.Size = new System.Drawing.Size(321, 20);
            this.txtKlasorNo.TabIndex = 2;
            this.txtKlasorNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorNo.WordWrap = false;
            this.txtKlasorNo.ButtonClick += new System.EventHandler(this.txtKlasorNo_ButtonClick);
            // 
            // txtKlasorAdi
            // 
            this.txtKlasorAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKlasorAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKlasorAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKlasorAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKlasorAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKlasorAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKlasorAdi.Label = null;
            this.txtKlasorAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlasorAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKlasorAdi.LabelText = "Klasör Adı";
            this.txtKlasorAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKlasorAdi.LabelTop = 3;
            this.txtKlasorAdi.LabelVisible = true;
            this.txtKlasorAdi.LabelWith = 100;
            this.txtKlasorAdi.Location = new System.Drawing.Point(116, 53);
            this.txtKlasorAdi.Name = "txtKlasorAdi";
            this.txtKlasorAdi.NumericBox = false;
            this.txtKlasorAdi.NumericDecimal = 0;
            this.txtKlasorAdi.ReferansTip = 0;
            this.txtKlasorAdi.Required = false;
            this.txtKlasorAdi.RequiredPass = true;
            this.txtKlasorAdi.Size = new System.Drawing.Size(321, 20);
            this.txtKlasorAdi.TabIndex = 4;
            this.txtKlasorAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKlasorAdi.WordWrap = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(321, 91);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 25);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = global::ALPARGE.Properties.Resources.cancel;
            this.btnVazgec.Location = new System.Drawing.Point(165, 91);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(116, 25);
            this.btnVazgec.TabIndex = 11;
            this.btnVazgec.Text = " Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // FrmDosyaYeniKlasor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 132);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKlasorAdi);
            this.Controls.Add(this.txtKlasorNo);
            this.Name = "FrmDosyaYeniKlasor";
            this.Text = "Yeni Klasör Oluşturma";
            this.Load += new System.EventHandler(this.FrmDosyaYeniKlasor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtKlasorNo;
        private BaseControls.BC_TextBox txtKlasorAdi;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_Button btnVazgec;
    }
}