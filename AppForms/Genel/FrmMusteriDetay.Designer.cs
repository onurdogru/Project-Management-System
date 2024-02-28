namespace ALPARGE.AppForms.Genel
{
    partial class FrmMusteriDetay
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
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.txtMusteriKodu = new BaseControls.BC_TextBox();
            this.txtMusteriAdi = new BaseControls.BC_TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(429, 26);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMusteriKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMusteriKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMusteriKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMusteriKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMusteriKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMusteriKodu.Label = null;
            this.txtMusteriKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMusteriKodu.LabelText = "Müşteri Kodu";
            this.txtMusteriKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteriKodu.LabelTop = 3;
            this.txtMusteriKodu.LabelVisible = true;
            this.txtMusteriKodu.LabelWith = 100;
            this.txtMusteriKodu.Location = new System.Drawing.Point(141, 29);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.NumericBox = false;
            this.txtMusteriKodu.NumericDecimal = 0;
            this.txtMusteriKodu.ReferansTip = 0;
            this.txtMusteriKodu.Required = false;
            this.txtMusteriKodu.RequiredPass = true;
            this.txtMusteriKodu.Size = new System.Drawing.Size(248, 20);
            this.txtMusteriKodu.TabIndex = 1;
            this.txtMusteriKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteriKodu.WordWrap = false;
            this.txtMusteriKodu.TextChanged += new System.EventHandler(this.txtMusteriKodu_TextChanged);
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMusteriAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMusteriAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMusteriAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMusteriAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMusteriAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMusteriAdi.Label = null;
            this.txtMusteriAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMusteriAdi.LabelText = "Müşteri Ünvanı";
            this.txtMusteriAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteriAdi.LabelTop = 3;
            this.txtMusteriAdi.LabelVisible = true;
            this.txtMusteriAdi.LabelWith = 100;
            this.txtMusteriAdi.Location = new System.Drawing.Point(141, 65);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.NumericBox = false;
            this.txtMusteriAdi.NumericDecimal = 0;
            this.txtMusteriAdi.ReferansTip = 0;
            this.txtMusteriAdi.Required = false;
            this.txtMusteriAdi.RequiredPass = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(248, 20);
            this.txtMusteriAdi.TabIndex = 3;
            this.txtMusteriAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteriAdi.WordWrap = false;
            // 
            // FrmMusteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 170);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.txtMusteriKodu);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FrmMusteriDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Detayı";
            this.Load += new System.EventHandler(this.FrmMusteriDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_TextBox txtMusteriKodu;
        private BaseControls.BC_TextBox txtMusteriAdi;
    }
}