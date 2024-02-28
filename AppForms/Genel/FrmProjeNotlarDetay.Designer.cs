namespace ALPARGE.AppForms.Genel
{
    partial class FrmProjeNotlarDetay
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
            this.txtNotID = new BaseControls.BC_TextBox();
            this.cbSil = new BaseControls.BC_CheckBox();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtOlusturan = new BaseControls.BC_TextBox();
            this.txtIcerik = new BaseControls.BC_TextBox();
            this.txtKonu = new BaseControls.BC_TextBox();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.txtTarih = new BaseControls.Forms.BC_DateTime();
            this.SuspendLayout();
            // 
            // txtNotID
            // 
            this.txtNotID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNotID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNotID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNotID.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtNotID.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtNotID.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtNotID.Enabled = false;
            this.txtNotID.Label = null;
            this.txtNotID.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNotID.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNotID.LabelText = "Not Id";
            this.txtNotID.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtNotID.LabelTop = 3;
            this.txtNotID.LabelVisible = true;
            this.txtNotID.LabelWith = 50;
            this.txtNotID.Location = new System.Drawing.Point(788, 25);
            this.txtNotID.MaxLength = 50;
            this.txtNotID.Name = "txtNotID";
            this.txtNotID.NumericBox = false;
            this.txtNotID.NumericDecimal = 0;
            this.txtNotID.ReadOnly = true;
            this.txtNotID.ReferansTip = 0;
            this.txtNotID.Required = false;
            this.txtNotID.RequiredPass = true;
            this.txtNotID.Size = new System.Drawing.Size(37, 20);
            this.txtNotID.TabIndex = 36;
            this.txtNotID.UserSecurity = BaseControls.Functions.SecurityLevel.Read;
            this.txtNotID.WordWrap = false;
            // 
            // cbSil
            // 
            this.cbSil.AutoSize = true;
            this.cbSil.Enabled = false;
            this.cbSil.Location = new System.Drawing.Point(573, 320);
            this.cbSil.Name = "cbSil";
            this.cbSil.Size = new System.Drawing.Size(53, 17);
            this.cbSil.TabIndex = 34;
            this.cbSil.Text = "Silindi";
            this.cbSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::ALPARGE.Properties.Resources.save;
            this.btnKaydet.Location = new System.Drawing.Point(688, 315);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 25);
            this.btnKaydet.TabIndex = 33;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(23, 103);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(76, 13);
            this.bC_Label1.TabIndex = 32;
            this.bC_Label1.Text = "Not (Açıklama)";
            // 
            // txtOlusturan
            // 
            this.txtOlusturan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOlusturan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOlusturan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOlusturan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtOlusturan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtOlusturan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtOlusturan.Enabled = false;
            this.txtOlusturan.Label = null;
            this.txtOlusturan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlusturan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOlusturan.LabelText = "Oluşturan";
            this.txtOlusturan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtOlusturan.LabelTop = 3;
            this.txtOlusturan.LabelVisible = true;
            this.txtOlusturan.LabelWith = 100;
            this.txtOlusturan.Location = new System.Drawing.Point(123, 320);
            this.txtOlusturan.MaxLength = 50;
            this.txtOlusturan.Name = "txtOlusturan";
            this.txtOlusturan.NumericBox = false;
            this.txtOlusturan.NumericDecimal = 0;
            this.txtOlusturan.ReadOnly = true;
            this.txtOlusturan.ReferansTip = 0;
            this.txtOlusturan.Required = false;
            this.txtOlusturan.RequiredPass = true;
            this.txtOlusturan.Size = new System.Drawing.Size(150, 20);
            this.txtOlusturan.TabIndex = 26;
            this.txtOlusturan.UserSecurity = BaseControls.Functions.SecurityLevel.Read;
            this.txtOlusturan.WordWrap = false;
            // 
            // txtIcerik
            // 
            this.txtIcerik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIcerik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIcerik.BorderColor = System.Drawing.Color.DarkGray;
            this.txtIcerik.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtIcerik.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtIcerik.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtIcerik.Label = null;
            this.txtIcerik.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIcerik.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIcerik.LabelText = null;
            this.txtIcerik.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtIcerik.LabelTop = 3;
            this.txtIcerik.LabelVisible = false;
            this.txtIcerik.LabelWith = 100;
            this.txtIcerik.Location = new System.Drawing.Point(26, 119);
            this.txtIcerik.MaxLength = 1000;
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.NumericBox = false;
            this.txtIcerik.NumericDecimal = 0;
            this.txtIcerik.ReferansTip = 0;
            this.txtIcerik.Required = false;
            this.txtIcerik.RequiredPass = true;
            this.txtIcerik.Size = new System.Drawing.Size(799, 191);
            this.txtIcerik.TabIndex = 25;
            this.txtIcerik.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtIcerik.WordWrap = false;
            // 
            // txtKonu
            // 
            this.txtKonu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKonu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKonu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKonu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKonu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKonu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKonu.Label = null;
            this.txtKonu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKonu.LabelText = "Not Konusu";
            this.txtKonu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKonu.LabelTop = 3;
            this.txtKonu.LabelVisible = true;
            this.txtKonu.LabelWith = 100;
            this.txtKonu.Location = new System.Drawing.Point(123, 70);
            this.txtKonu.MaxLength = 50;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.NumericBox = false;
            this.txtKonu.NumericDecimal = 0;
            this.txtKonu.ReferansTip = 0;
            this.txtKonu.Required = false;
            this.txtKonu.RequiredPass = true;
            this.txtKonu.Size = new System.Drawing.Size(702, 20);
            this.txtKonu.TabIndex = 24;
            this.txtKonu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKonu.WordWrap = false;
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje No";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 100;
            this.txtProjeNo.Location = new System.Drawing.Point(123, 25);
            this.txtProjeNo.MaxLength = 20;
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(150, 20);
            this.txtProjeNo.TabIndex = 23;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.ButtonClick += new System.EventHandler(this.txtProjeNo_ButtonClick);
            // 
            // txtTarih
            // 
            this.txtTarih.CustomFormat = "dd.MM.yyyy";
            this.txtTarih.Enabled = false;
            this.txtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTarih.LabelText = "Tarih";
            this.txtTarih.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTarih.LabelTop = 5;
            this.txtTarih.LabelVisible = true;
            this.txtTarih.LabelWith = 100;
            this.txtTarih.Location = new System.Drawing.Point(430, 22);
            this.txtTarih.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtTarih.Size = new System.Drawing.Size(150, 20);
            this.txtTarih.TabIndex = 22;
            this.txtTarih.Value = new System.DateTime(2018, 10, 15, 0, 0, 0, 0);
            // 
            // FrmProjeNotlarDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 352);
            this.Controls.Add(this.txtNotID);
            this.Controls.Add(this.cbSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.txtOlusturan);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.txtTarih);
            this.Name = "FrmProjeNotlarDetay";
            this.Text = "Text Not Detayı";
            this.Load += new System.EventHandler(this.FrmProjeNotlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtOlusturan;
        private BaseControls.BC_TextBox txtIcerik;
        private BaseControls.BC_TextBox txtKonu;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.Forms.BC_DateTime txtTarih;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_CheckBox cbSil;
        private BaseControls.BC_TextBox txtNotID;
    }
}