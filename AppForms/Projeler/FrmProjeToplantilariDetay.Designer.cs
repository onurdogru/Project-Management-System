namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjeToplantilariDetay
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
            this.txtDegisTarihi = new BaseControls.BC_TextBox();
            this.txtDegistiren = new BaseControls.BC_TextBox();
            this.txtTalepEden = new BaseControls.BC_TextBox();
            this.txtKatilimcilar = new BaseControls.BC_TextBox();
            this.txtToplantiYeri = new BaseControls.BC_TextBox();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.bC_Label2 = new BaseControls.BC_Label();
            this.txtSonuc = new BaseControls.BC_TextBox();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtIcerik = new BaseControls.BC_TextBox();
            this.txtKonu = new BaseControls.BC_TextBox();
            this.txtID = new BaseControls.BC_TextBox();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.txtTarih = new BaseControls.Forms.BC_DateTime();
            this.SuspendLayout();
            // 
            // txtDegisTarihi
            // 
            this.txtDegisTarihi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDegisTarihi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDegisTarihi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDegisTarihi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtDegisTarihi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtDegisTarihi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtDegisTarihi.Enabled = false;
            this.txtDegisTarihi.Label = null;
            this.txtDegisTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDegisTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDegisTarihi.LabelText = "Değişiklik Tarihi";
            this.txtDegisTarihi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtDegisTarihi.LabelTop = 3;
            this.txtDegisTarihi.LabelVisible = true;
            this.txtDegisTarihi.LabelWith = 100;
            this.txtDegisTarihi.Location = new System.Drawing.Point(405, 496);
            this.txtDegisTarihi.Name = "txtDegisTarihi";
            this.txtDegisTarihi.NumericBox = false;
            this.txtDegisTarihi.NumericDecimal = 0;
            this.txtDegisTarihi.ReferansTip = 0;
            this.txtDegisTarihi.Required = false;
            this.txtDegisTarihi.RequiredPass = true;
            this.txtDegisTarihi.Size = new System.Drawing.Size(131, 20);
            this.txtDegisTarihi.TabIndex = 33;
            this.txtDegisTarihi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtDegisTarihi.WordWrap = false;
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
            this.txtDegistiren.LabelText = "Son Değiştiren";
            this.txtDegistiren.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtDegistiren.LabelTop = 3;
            this.txtDegistiren.LabelVisible = true;
            this.txtDegistiren.LabelWith = 100;
            this.txtDegistiren.Location = new System.Drawing.Point(122, 496);
            this.txtDegistiren.Name = "txtDegistiren";
            this.txtDegistiren.NumericBox = false;
            this.txtDegistiren.NumericDecimal = 0;
            this.txtDegistiren.ReferansTip = 0;
            this.txtDegistiren.Required = false;
            this.txtDegistiren.RequiredPass = true;
            this.txtDegistiren.Size = new System.Drawing.Size(127, 20);
            this.txtDegistiren.TabIndex = 30;
            this.txtDegistiren.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtDegistiren.WordWrap = false;
            // 
            // txtTalepEden
            // 
            this.txtTalepEden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTalepEden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTalepEden.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTalepEden.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTalepEden.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTalepEden.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTalepEden.Label = null;
            this.txtTalepEden.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepEden.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepEden.LabelText = "Talep Eden";
            this.txtTalepEden.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTalepEden.LabelTop = 3;
            this.txtTalepEden.LabelVisible = true;
            this.txtTalepEden.LabelWith = 80;
            this.txtTalepEden.Location = new System.Drawing.Point(393, 49);
            this.txtTalepEden.MaxLength = 50;
            this.txtTalepEden.Name = "txtTalepEden";
            this.txtTalepEden.NumericBox = false;
            this.txtTalepEden.NumericDecimal = 0;
            this.txtTalepEden.ReferansTip = 0;
            this.txtTalepEden.Required = false;
            this.txtTalepEden.RequiredPass = true;
            this.txtTalepEden.Size = new System.Drawing.Size(241, 20);
            this.txtTalepEden.TabIndex = 20;
            this.txtTalepEden.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalepEden.WordWrap = false;
            // 
            // txtKatilimcilar
            // 
            this.txtKatilimcilar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKatilimcilar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKatilimcilar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKatilimcilar.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKatilimcilar.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKatilimcilar.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKatilimcilar.Label = null;
            this.txtKatilimcilar.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKatilimcilar.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKatilimcilar.LabelText = "Katılımcılar";
            this.txtKatilimcilar.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKatilimcilar.LabelTop = 3;
            this.txtKatilimcilar.LabelVisible = true;
            this.txtKatilimcilar.LabelWith = 80;
            this.txtKatilimcilar.Location = new System.Drawing.Point(393, 75);
            this.txtKatilimcilar.MaxLength = 100;
            this.txtKatilimcilar.Name = "txtKatilimcilar";
            this.txtKatilimcilar.NumericBox = false;
            this.txtKatilimcilar.NumericDecimal = 0;
            this.txtKatilimcilar.ReferansTip = 0;
            this.txtKatilimcilar.Required = false;
            this.txtKatilimcilar.RequiredPass = true;
            this.txtKatilimcilar.Size = new System.Drawing.Size(431, 20);
            this.txtKatilimcilar.TabIndex = 18;
            this.txtKatilimcilar.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKatilimcilar.WordWrap = false;
            // 
            // txtToplantiYeri
            // 
            this.txtToplantiYeri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtToplantiYeri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtToplantiYeri.BorderColor = System.Drawing.Color.DarkGray;
            this.txtToplantiYeri.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtToplantiYeri.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtToplantiYeri.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtToplantiYeri.Label = null;
            this.txtToplantiYeri.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplantiYeri.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtToplantiYeri.LabelText = "Toplantı Yeri";
            this.txtToplantiYeri.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtToplantiYeri.LabelTop = 3;
            this.txtToplantiYeri.LabelVisible = true;
            this.txtToplantiYeri.LabelWith = 100;
            this.txtToplantiYeri.Location = new System.Drawing.Point(122, 75);
            this.txtToplantiYeri.MaxLength = 50;
            this.txtToplantiYeri.Name = "txtToplantiYeri";
            this.txtToplantiYeri.NumericBox = false;
            this.txtToplantiYeri.NumericDecimal = 0;
            this.txtToplantiYeri.ReferansTip = 0;
            this.txtToplantiYeri.Required = false;
            this.txtToplantiYeri.RequiredPass = true;
            this.txtToplantiYeri.Size = new System.Drawing.Size(150, 20);
            this.txtToplantiYeri.TabIndex = 16;
            this.txtToplantiYeri.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtToplantiYeri.WordWrap = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::ALPARGE.Properties.Resources.save;
            this.btnKaydet.Location = new System.Drawing.Point(737, 18);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 34);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bC_Label2
            // 
            this.bC_Label2.AutoSize = true;
            this.bC_Label2.Location = new System.Drawing.Point(21, 333);
            this.bC_Label2.Name = "bC_Label2";
            this.bC_Label2.Size = new System.Drawing.Size(132, 13);
            this.bC_Label2.TabIndex = 13;
            this.bC_Label2.Text = "Toplantı Sonucu / Kararlar";
            // 
            // txtSonuc
            // 
            this.txtSonuc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSonuc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSonuc.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSonuc.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSonuc.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSonuc.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSonuc.Label = null;
            this.txtSonuc.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSonuc.LabelText = null;
            this.txtSonuc.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSonuc.LabelTop = 3;
            this.txtSonuc.LabelVisible = false;
            this.txtSonuc.LabelWith = 100;
            this.txtSonuc.Location = new System.Drawing.Point(21, 352);
            this.txtSonuc.MaxLength = 1000;
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.NumericBox = false;
            this.txtSonuc.NumericDecimal = 0;
            this.txtSonuc.ReferansTip = 0;
            this.txtSonuc.Required = false;
            this.txtSonuc.RequiredPass = true;
            this.txtSonuc.Size = new System.Drawing.Size(803, 138);
            this.txtSonuc.TabIndex = 12;
            this.txtSonuc.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSonuc.WordWrap = false;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(21, 146);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(76, 13);
            this.bC_Label1.TabIndex = 10;
            this.bC_Label1.Text = "Toplantı İçeriği";
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
            this.txtIcerik.Location = new System.Drawing.Point(21, 165);
            this.txtIcerik.MaxLength = 1000;
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.NumericBox = false;
            this.txtIcerik.NumericDecimal = 0;
            this.txtIcerik.ReferansTip = 0;
            this.txtIcerik.Required = false;
            this.txtIcerik.RequiredPass = true;
            this.txtIcerik.Size = new System.Drawing.Size(803, 138);
            this.txtIcerik.TabIndex = 8;
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
            this.txtKonu.LabelText = "Toplantı Konusu";
            this.txtKonu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKonu.LabelTop = 3;
            this.txtKonu.LabelVisible = true;
            this.txtKonu.LabelWith = 100;
            this.txtKonu.Location = new System.Drawing.Point(122, 107);
            this.txtKonu.MaxLength = 100;
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.NumericBox = false;
            this.txtKonu.NumericDecimal = 0;
            this.txtKonu.ReferansTip = 0;
            this.txtKonu.Required = false;
            this.txtKonu.RequiredPass = true;
            this.txtKonu.Size = new System.Drawing.Size(702, 20);
            this.txtKonu.TabIndex = 6;
            this.txtKonu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKonu.WordWrap = false;
            // 
            // txtID
            // 
            this.txtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtID.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtID.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtID.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtID.Label = null;
            this.txtID.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.LabelText = "Toplantı No";
            this.txtID.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtID.LabelTop = 3;
            this.txtID.LabelVisible = true;
            this.txtID.LabelWith = 80;
            this.txtID.Location = new System.Drawing.Point(393, 23);
            this.txtID.Name = "txtID";
            this.txtID.NumericBox = false;
            this.txtID.NumericDecimal = 0;
            this.txtID.ReadOnly = true;
            this.txtID.ReferansTip = 0;
            this.txtID.Required = false;
            this.txtID.RequiredPass = true;
            this.txtID.Size = new System.Drawing.Size(54, 20);
            this.txtID.TabIndex = 4;
            this.txtID.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtID.WordWrap = false;
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
            this.txtProjeNo.Location = new System.Drawing.Point(122, 49);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReadOnly = true;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(150, 20);
            this.txtProjeNo.TabIndex = 2;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.ButtonClick += new System.EventHandler(this.txtProjeNo_ButtonClick);
            // 
            // txtTarih
            // 
            this.txtTarih.CustomFormat = "dd.MM.yyyy";
            this.txtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTarih.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTarih.LabelText = "Toplantı Tarihi";
            this.txtTarih.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTarih.LabelTop = 5;
            this.txtTarih.LabelVisible = true;
            this.txtTarih.LabelWith = 100;
            this.txtTarih.Location = new System.Drawing.Point(122, 23);
            this.txtTarih.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtTarih.Size = new System.Drawing.Size(150, 20);
            this.txtTarih.TabIndex = 0;
            this.txtTarih.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // FrmProjeToplantilariDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 528);
            this.Controls.Add(this.txtDegisTarihi);
            this.Controls.Add(this.txtDegistiren);
            this.Controls.Add(this.txtTalepEden);
            this.Controls.Add(this.txtKatilimcilar);
            this.Controls.Add(this.txtToplantiYeri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.bC_Label2);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.txtTarih);
            this.Name = "FrmProjeToplantilariDetay";
            this.Text = "Proje Toplantısı";
            this.Load += new System.EventHandler(this.FrmProjeToplantilariDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.Forms.BC_DateTime txtTarih;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_TextBox txtID;
        private BaseControls.BC_TextBox txtKonu;
        private BaseControls.BC_TextBox txtIcerik;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_Label bC_Label2;
        private BaseControls.BC_TextBox txtSonuc;
        private BaseControls.BC_TextBox txtToplantiYeri;
        private BaseControls.BC_TextBox txtKatilimcilar;
        private BaseControls.BC_TextBox txtTalepEden;
        private BaseControls.BC_TextBox txtDegistiren;
        private BaseControls.BC_TextBox txtDegisTarihi;
        public BaseControls.BC_Button btnKaydet;
    }
}