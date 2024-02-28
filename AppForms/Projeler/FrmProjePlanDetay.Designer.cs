namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjePlanDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjePlanDetay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.ButtonTextCell buttonTextCell1 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.NumericTextCell numericTextCell1 = new BaseControls.NumericTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bC_GroupBox1 = new BaseControls.BC_GroupBox();
            this.txtPlnTeslimTarihi = new BaseControls.Forms.BC_DateTime();
            this.btnOnayaGonder = new BaseControls.BC_Button(this.components);
            this.txtProjeSorumlusu = new BaseControls.BC_TextBox();
            this.txtTeslimTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtTalepEden = new BaseControls.BC_TextBox();
            this.txtMusteri = new BaseControls.BC_TextBox();
            this.txtProjeTipi = new BaseControls.BC_TextBox();
            this.txtProjeAdi = new BaseControls.BC_TextBox();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.bC_TabControl1 = new BaseControls.Forms.BC_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bC_Panel1 = new BaseControls.Forms.BC_Panel();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtToplamSure = new BaseControls.BC_TextBox();
            this.GrdPlan = new BaseControls.BC_DataGrid();
            this.colProjeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGorevTuru = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGorevTipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colKaynak = new BaseControls.ButtonTextColumn();
            this.colHours = new BaseControls.NumericTextColumn();
            this.colStartDate = new BaseControls.CalendarColumn();
            this.colStopDate = new BaseControls.CalendarColumn();
            this.colSaatUcreti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToplamUcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bC_Panel2 = new BaseControls.Forms.BC_Panel();
            this.bC_Label2 = new BaseControls.BC_Label();
            this.txtToplamMaliyet = new BaseControls.BC_TextBox();
            this.GrdMaliyet = new BaseControls.BC_DataGrid();
            this.colMaliyetTipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirim = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDovizCinsi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDovizFiyat = new BaseControls.NumericTextColumn();
            this.colDovizTutar = new BaseControls.NumericTextColumn();
            this.colDovizKuru = new BaseControls.NumericTextColumn();
            this.colTLTutar = new BaseControls.NumericTextColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtProjeBilgi = new BaseControls.BC_TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtHedeflenenKar = new BaseControls.BC_TextBox();
            this.txtSatisBedeli = new BaseControls.BC_TextBox();
            this.txtBToplamProje = new BaseControls.BC_TextBox();
            this.txtBToplamNakliye = new BaseControls.BC_TextBox();
            this.txtBToplamPatent = new BaseControls.BC_TextBox();
            this.txtBToplamEgitim = new BaseControls.BC_TextBox();
            this.txtBToplamSeyehat = new BaseControls.BC_TextBox();
            this.txtBToplamHizmet = new BaseControls.BC_TextBox();
            this.txtBToplamTest = new BaseControls.BC_TextBox();
            this.txtBToplamEkipman = new BaseControls.BC_TextBox();
            this.txtBToplamMaliyet = new BaseControls.BC_TextBox();
            this.txtBToplamMalzeme = new BaseControls.BC_TextBox();
            this.txtBToplamIscilik = new BaseControls.BC_TextBox();
            this.bC_GroupBox1.SuspendLayout();
            this.bC_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.bC_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlan)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.bC_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMaliyet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bC_GroupBox1
            // 
            this.bC_GroupBox1.Controls.Add(this.txtPlnTeslimTarihi);
            this.bC_GroupBox1.Controls.Add(this.btnOnayaGonder);
            this.bC_GroupBox1.Controls.Add(this.txtProjeSorumlusu);
            this.bC_GroupBox1.Controls.Add(this.txtTeslimTarihi);
            this.bC_GroupBox1.Controls.Add(this.txtTalepEden);
            this.bC_GroupBox1.Controls.Add(this.txtMusteri);
            this.bC_GroupBox1.Controls.Add(this.txtProjeTipi);
            this.bC_GroupBox1.Controls.Add(this.txtProjeAdi);
            this.bC_GroupBox1.Controls.Add(this.btnKaydet);
            this.bC_GroupBox1.Controls.Add(this.txtProjeNo);
            this.bC_GroupBox1.Location = new System.Drawing.Point(12, 13);
            this.bC_GroupBox1.Name = "bC_GroupBox1";
            this.bC_GroupBox1.Size = new System.Drawing.Size(963, 130);
            this.bC_GroupBox1.TabIndex = 1;
            this.bC_GroupBox1.TabStop = false;
            // 
            // txtPlnTeslimTarihi
            // 
            this.txtPlnTeslimTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtPlnTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPlnTeslimTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlnTeslimTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPlnTeslimTarihi.LabelText = "Planlanan Teslim Tarihi";
            this.txtPlnTeslimTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtPlnTeslimTarihi.LabelTop = 5;
            this.txtPlnTeslimTarihi.LabelVisible = true;
            this.txtPlnTeslimTarihi.LabelWith = 130;
            this.txtPlnTeslimTarihi.Location = new System.Drawing.Point(366, 96);
            this.txtPlnTeslimTarihi.Name = "txtPlnTeslimTarihi";
            this.txtPlnTeslimTarihi.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtPlnTeslimTarihi.Size = new System.Drawing.Size(198, 20);
            this.txtPlnTeslimTarihi.TabIndex = 39;
            this.txtPlnTeslimTarihi.Value = new System.DateTime(2022, 2, 3, 0, 0, 0, 0);
            // 
            // btnOnayaGonder
            // 
            this.btnOnayaGonder.Image = global::ALPARGE.Properties.Resources.edit;
            this.btnOnayaGonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnayaGonder.Location = new System.Drawing.Point(829, 87);
            this.btnOnayaGonder.Name = "btnOnayaGonder";
            this.btnOnayaGonder.Size = new System.Drawing.Size(117, 29);
            this.btnOnayaGonder.TabIndex = 22;
            this.btnOnayaGonder.Text = "   Onaya Gönder";
            this.btnOnayaGonder.UseVisualStyleBackColor = true;
            this.btnOnayaGonder.Click += new System.EventHandler(this.btnOnayaGonder_Click);
            // 
            // txtProjeSorumlusu
            // 
            this.txtProjeSorumlusu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeSorumlusu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeSorumlusu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeSorumlusu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeSorumlusu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeSorumlusu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeSorumlusu.Label = null;
            this.txtProjeSorumlusu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeSorumlusu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeSorumlusu.LabelText = "Proje Sorumlusu";
            this.txtProjeSorumlusu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeSorumlusu.LabelTop = 3;
            this.txtProjeSorumlusu.LabelVisible = true;
            this.txtProjeSorumlusu.LabelWith = 100;
            this.txtProjeSorumlusu.Location = new System.Drawing.Point(113, 97);
            this.txtProjeSorumlusu.Name = "txtProjeSorumlusu";
            this.txtProjeSorumlusu.NumericBox = false;
            this.txtProjeSorumlusu.NumericDecimal = 0;
            this.txtProjeSorumlusu.ReferansTip = 0;
            this.txtProjeSorumlusu.Required = false;
            this.txtProjeSorumlusu.RequiredPass = true;
            this.txtProjeSorumlusu.Size = new System.Drawing.Size(100, 20);
            this.txtProjeSorumlusu.TabIndex = 14;
            this.txtProjeSorumlusu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeSorumlusu.WordWrap = false;
            // 
            // txtTeslimTarihi
            // 
            this.txtTeslimTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtTeslimTarihi.Enabled = false;
            this.txtTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTeslimTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTeslimTarihi.LabelText = "Talep Teslim Tarihi";
            this.txtTeslimTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTeslimTarihi.LabelTop = 5;
            this.txtTeslimTarihi.LabelVisible = true;
            this.txtTeslimTarihi.LabelWith = 130;
            this.txtTeslimTarihi.Location = new System.Drawing.Point(366, 71);
            this.txtTeslimTarihi.Name = "txtTeslimTarihi";
            this.txtTeslimTarihi.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtTeslimTarihi.Size = new System.Drawing.Size(198, 20);
            this.txtTeslimTarihi.TabIndex = 11;
            this.txtTeslimTarihi.Value = new System.DateTime(2022, 2, 3, 0, 0, 0, 0);
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
            this.txtTalepEden.LabelWith = 100;
            this.txtTalepEden.Location = new System.Drawing.Point(113, 71);
            this.txtTalepEden.Name = "txtTalepEden";
            this.txtTalepEden.NumericBox = false;
            this.txtTalepEden.NumericDecimal = 0;
            this.txtTalepEden.ReferansTip = 0;
            this.txtTalepEden.Required = false;
            this.txtTalepEden.RequiredPass = true;
            this.txtTalepEden.Size = new System.Drawing.Size(100, 20);
            this.txtTalepEden.TabIndex = 10;
            this.txtTalepEden.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalepEden.WordWrap = false;
            // 
            // txtMusteri
            // 
            this.txtMusteri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMusteri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMusteri.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMusteri.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMusteri.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMusteri.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMusteri.Label = null;
            this.txtMusteri.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteri.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMusteri.LabelText = "Müşteri";
            this.txtMusteri.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteri.LabelTop = 3;
            this.txtMusteri.LabelVisible = true;
            this.txtMusteri.LabelWith = 100;
            this.txtMusteri.Location = new System.Drawing.Point(338, 45);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.NumericBox = false;
            this.txtMusteri.NumericDecimal = 0;
            this.txtMusteri.ReferansTip = 0;
            this.txtMusteri.Required = false;
            this.txtMusteri.RequiredPass = true;
            this.txtMusteri.Size = new System.Drawing.Size(226, 20);
            this.txtMusteri.TabIndex = 8;
            this.txtMusteri.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteri.WordWrap = false;
            // 
            // txtProjeTipi
            // 
            this.txtProjeTipi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeTipi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeTipi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeTipi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeTipi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeTipi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeTipi.Label = null;
            this.txtProjeTipi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeTipi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeTipi.LabelText = "Proje Tipi";
            this.txtProjeTipi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeTipi.LabelTop = 3;
            this.txtProjeTipi.LabelVisible = true;
            this.txtProjeTipi.LabelWith = 100;
            this.txtProjeTipi.Location = new System.Drawing.Point(113, 45);
            this.txtProjeTipi.Name = "txtProjeTipi";
            this.txtProjeTipi.NumericBox = false;
            this.txtProjeTipi.NumericDecimal = 0;
            this.txtProjeTipi.ReferansTip = 0;
            this.txtProjeTipi.Required = false;
            this.txtProjeTipi.RequiredPass = true;
            this.txtProjeTipi.Size = new System.Drawing.Size(100, 20);
            this.txtProjeTipi.TabIndex = 6;
            this.txtProjeTipi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeTipi.WordWrap = false;
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeAdi.Label = null;
            this.txtProjeAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeAdi.LabelText = "Proje Adı";
            this.txtProjeAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeAdi.LabelTop = 3;
            this.txtProjeAdi.LabelVisible = true;
            this.txtProjeAdi.LabelWith = 100;
            this.txtProjeAdi.Location = new System.Drawing.Point(338, 19);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.NumericBox = false;
            this.txtProjeAdi.NumericDecimal = 0;
            this.txtProjeAdi.ReferansTip = 0;
            this.txtProjeAdi.Required = false;
            this.txtProjeAdi.RequiredPass = true;
            this.txtProjeAdi.Size = new System.Drawing.Size(226, 20);
            this.txtProjeAdi.TabIndex = 4;
            this.txtProjeAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeAdi.WordWrap = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(829, 19);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 31);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje Kodu";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 100;
            this.txtProjeNo.Location = new System.Drawing.Point(113, 19);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 0;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            // 
            // bC_TabControl1
            // 
            this.bC_TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bC_TabControl1.Controls.Add(this.tabPage1);
            this.bC_TabControl1.Controls.Add(this.tabPage2);
            this.bC_TabControl1.Controls.Add(this.tabPage3);
            this.bC_TabControl1.Controls.Add(this.tabPage4);
            this.bC_TabControl1.Location = new System.Drawing.Point(12, 149);
            this.bC_TabControl1.Name = "bC_TabControl1";
            this.bC_TabControl1.SelectedIndex = 0;
            this.bC_TabControl1.Size = new System.Drawing.Size(967, 434);
            this.bC_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bC_Panel1);
            this.tabPage1.Controls.Add(this.GrdPlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proje Planı";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bC_Panel1
            // 
            this.bC_Panel1.Controls.Add(this.bC_Label1);
            this.bC_Panel1.Controls.Add(this.txtToplamSure);
            this.bC_Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bC_Panel1.Location = new System.Drawing.Point(3, 375);
            this.bC_Panel1.Name = "bC_Panel1";
            this.bC_Panel1.Size = new System.Drawing.Size(953, 30);
            this.bC_Panel1.TabIndex = 1;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bC_Label1.Location = new System.Drawing.Point(3, 8);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(32, 13);
            this.bC_Label1.TabIndex = 30;
            this.bC_Label1.Text = "Error:";
            // 
            // txtToplamSure
            // 
            this.txtToplamSure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToplamSure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtToplamSure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtToplamSure.BorderColor = System.Drawing.Color.DarkGray;
            this.txtToplamSure.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtToplamSure.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtToplamSure.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtToplamSure.Label = null;
            this.txtToplamSure.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamSure.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtToplamSure.LabelText = "Toplam Süre (Saat)";
            this.txtToplamSure.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtToplamSure.LabelTop = 3;
            this.txtToplamSure.LabelVisible = true;
            this.txtToplamSure.LabelWith = 100;
            this.txtToplamSure.Location = new System.Drawing.Point(850, 5);
            this.txtToplamSure.Name = "txtToplamSure";
            this.txtToplamSure.NumericBox = false;
            this.txtToplamSure.NumericDecimal = 0;
            this.txtToplamSure.ReferansTip = 0;
            this.txtToplamSure.Required = false;
            this.txtToplamSure.RequiredPass = true;
            this.txtToplamSure.Size = new System.Drawing.Size(100, 20);
            this.txtToplamSure.TabIndex = 0;
            this.txtToplamSure.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtToplamSure.WordWrap = false;
            // 
            // GrdPlan
            // 
            this.GrdPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjeNo,
            this.colGorevTuru,
            this.colGorevTipi,
            this.colKaynak,
            this.colHours,
            this.colStartDate,
            this.colStopDate,
            this.colSaatUcreti,
            this.colToplamUcret,
            this.colPlanAciklama});
            this.GrdPlan.Location = new System.Drawing.Point(6, 6);
            this.GrdPlan.MenuDeleteVisible = true;
            this.GrdPlan.Name = "GrdPlan";
            this.GrdPlan.RowHeadersWidth = 25;
            this.GrdPlan.Size = new System.Drawing.Size(947, 363);
            this.GrdPlan.TabIndex = 0;
            this.GrdPlan.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPlan_CellValidated);
            this.GrdPlan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPlan_CellValueChanged);
            this.GrdPlan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrdPlan_DataError);
            this.GrdPlan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPlan_RowEnter);
            this.GrdPlan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdPlan_KeyDown);
            // 
            // colProjeNo
            // 
            this.colProjeNo.DataPropertyName = "PRONUM";
            this.colProjeNo.HeaderText = "Proje No";
            this.colProjeNo.Name = "colProjeNo";
            this.colProjeNo.Visible = false;
            // 
            // colGorevTuru
            // 
            this.colGorevTuru.DataPropertyName = "STEP";
            this.colGorevTuru.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colGorevTuru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colGorevTuru.HeaderText = "Görev Türü";
            this.colGorevTuru.Name = "colGorevTuru";
            this.colGorevTuru.Width = 140;
            // 
            // colGorevTipi
            // 
            this.colGorevTipi.DataPropertyName = "process";
            this.colGorevTipi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colGorevTipi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colGorevTipi.HeaderText = "Görev Tipi";
            this.colGorevTipi.Name = "colGorevTipi";
            this.colGorevTipi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGorevTipi.Width = 180;
            // 
            // colKaynak
            // 
            this.colKaynak.ButtonType = BaseControls.TextBoxButtonType.ButtonType.OnlySelect;
            this.colKaynak.DataPropertyName = "SOURCE";
            buttonTextCell1.ErrorText = "";
            buttonTextCell1.Style = dataGridViewCellStyle2;
            buttonTextCell1.Value = "";
            buttonTextCell1.ValueType = typeof(string);
            dataGridViewCellStyle1.NullValue = buttonTextCell1;
            this.colKaynak.DefaultCellStyle = dataGridViewCellStyle1;
            this.colKaynak.HeaderText = "Kaynak";
            this.colKaynak.Name = "colKaynak";
            this.colKaynak.Width = 200;
            this.colKaynak.Button_Click += new System.EventHandler(this.colKaynak_Button_Click);
            // 
            // colHours
            // 
            this.colHours.DataPropertyName = "HOURS";
            this.colHours.DecimalPlace = 1;
            numericTextCell1.ErrorText = "";
            numericTextCell1.Style = dataGridViewCellStyle4;
            numericTextCell1.Value = "0";
            numericTextCell1.ValueType = typeof(string);
            dataGridViewCellStyle3.NullValue = numericTextCell1;
            this.colHours.DefaultCellStyle = dataGridViewCellStyle3;
            this.colHours.HeaderText = "Süre ( Saat)";
            this.colHours.Name = "colHours";
            this.colHours.Width = 70;
            // 
            // colStartDate
            // 
            this.colStartDate.CustomFormat = null;
            this.colStartDate.DataPropertyName = "STARTDATE";
            dataGridViewCellStyle5.NullValue = "1.1.2018 00:00:00";
            this.colStartDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.colStartDate.DefaultDate = new System.DateTime(((long)(0)));
            this.colStartDate.HeaderText = "Başlangıç Tarihi";
            this.colStartDate.Name = "colStartDate";
            // 
            // colStopDate
            // 
            this.colStopDate.CustomFormat = null;
            this.colStopDate.DataPropertyName = "STOPDATE";
            dataGridViewCellStyle6.NullValue = "1.1.2018 00:00:00";
            this.colStopDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.colStopDate.DefaultDate = new System.DateTime(((long)(0)));
            this.colStopDate.HeaderText = "Bitiş Tarihi";
            this.colStopDate.Name = "colStopDate";
            // 
            // colSaatUcreti
            // 
            this.colSaatUcreti.DataPropertyName = "HOURWAGES";
            this.colSaatUcreti.HeaderText = "Saat Ücreti";
            this.colSaatUcreti.Name = "colSaatUcreti";
            // 
            // colToplamUcret
            // 
            this.colToplamUcret.DataPropertyName = "TOTALWAGES";
            this.colToplamUcret.HeaderText = "Toplam Ücret";
            this.colToplamUcret.Name = "colToplamUcret";
            // 
            // colPlanAciklama
            // 
            this.colPlanAciklama.DataPropertyName = "DESCRIPTION";
            this.colPlanAciklama.HeaderText = "Açıklama";
            this.colPlanAciklama.MaxInputLength = 100;
            this.colPlanAciklama.Name = "colPlanAciklama";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bC_Panel2);
            this.tabPage2.Controls.Add(this.GrdMaliyet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gider Kalemleri ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bC_Panel2
            // 
            this.bC_Panel2.Controls.Add(this.bC_Label2);
            this.bC_Panel2.Controls.Add(this.txtToplamMaliyet);
            this.bC_Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bC_Panel2.Location = new System.Drawing.Point(3, 375);
            this.bC_Panel2.Name = "bC_Panel2";
            this.bC_Panel2.Size = new System.Drawing.Size(953, 30);
            this.bC_Panel2.TabIndex = 2;
            // 
            // bC_Label2
            // 
            this.bC_Label2.AutoSize = true;
            this.bC_Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bC_Label2.Location = new System.Drawing.Point(3, 8);
            this.bC_Label2.Name = "bC_Label2";
            this.bC_Label2.Size = new System.Drawing.Size(35, 13);
            this.bC_Label2.TabIndex = 22;
            this.bC_Label2.Text = " Error:";
            // 
            // txtToplamMaliyet
            // 
            this.txtToplamMaliyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToplamMaliyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtToplamMaliyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtToplamMaliyet.BorderColor = System.Drawing.Color.DarkGray;
            this.txtToplamMaliyet.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtToplamMaliyet.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtToplamMaliyet.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtToplamMaliyet.Label = null;
            this.txtToplamMaliyet.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamMaliyet.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtToplamMaliyet.LabelText = "Toplam Tutar (TL)";
            this.txtToplamMaliyet.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtToplamMaliyet.LabelTop = 3;
            this.txtToplamMaliyet.LabelVisible = true;
            this.txtToplamMaliyet.LabelWith = 100;
            this.txtToplamMaliyet.Location = new System.Drawing.Point(850, 5);
            this.txtToplamMaliyet.Name = "txtToplamMaliyet";
            this.txtToplamMaliyet.NumericBox = false;
            this.txtToplamMaliyet.NumericDecimal = 2;
            this.txtToplamMaliyet.ReferansTip = 0;
            this.txtToplamMaliyet.Required = false;
            this.txtToplamMaliyet.RequiredPass = true;
            this.txtToplamMaliyet.Size = new System.Drawing.Size(100, 20);
            this.txtToplamMaliyet.TabIndex = 0;
            this.txtToplamMaliyet.Text = "0,00";
            this.txtToplamMaliyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToplamMaliyet.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtToplamMaliyet.WordWrap = false;
            // 
            // GrdMaliyet
            // 
            this.GrdMaliyet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdMaliyet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMaliyet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaliyetTipi,
            this.colAciklama,
            this.colMiktar,
            this.colBirim,
            this.colDovizCinsi,
            this.colDovizFiyat,
            this.colDovizTutar,
            this.colDovizKuru,
            this.colTLTutar});
            this.GrdMaliyet.Location = new System.Drawing.Point(6, 6);
            this.GrdMaliyet.MenuDeleteVisible = true;
            this.GrdMaliyet.Name = "GrdMaliyet";
            this.GrdMaliyet.RowHeadersWidth = 25;
            this.GrdMaliyet.Size = new System.Drawing.Size(947, 363);
            this.GrdMaliyet.TabIndex = 1;
            this.GrdMaliyet.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMaliyet_CellValidated);
            this.GrdMaliyet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMaliyet_CellValueChanged);
            this.GrdMaliyet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrdMaliyet_DataError);
            this.GrdMaliyet.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdMaliyet_RowEnter);
            this.GrdMaliyet.Enter += new System.EventHandler(this.GrdMaliyet_Enter);
            this.GrdMaliyet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdMaliyet_KeyDown);
            // 
            // colMaliyetTipi
            // 
            this.colMaliyetTipi.DataPropertyName = "Costtype";
            this.colMaliyetTipi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colMaliyetTipi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colMaliyetTipi.HeaderText = "Maliyet Tipi";
            this.colMaliyetTipi.Name = "colMaliyetTipi";
            // 
            // colAciklama
            // 
            this.colAciklama.DataPropertyName = "COSTDESC";
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAciklama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAciklama.Width = 200;
            // 
            // colMiktar
            // 
            this.colMiktar.DataPropertyName = "QUANTITY";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.colMiktar.DefaultCellStyle = dataGridViewCellStyle7;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBirim
            // 
            this.colBirim.DataPropertyName = "UNIT";
            this.colBirim.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colBirim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colBirim.HeaderText = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBirim.ToolTipText = "Miktar Birimi";
            this.colBirim.Width = 60;
            // 
            // colDovizCinsi
            // 
            this.colDovizCinsi.DataPropertyName = "CURTYPE";
            this.colDovizCinsi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colDovizCinsi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colDovizCinsi.HeaderText = "Döviz";
            this.colDovizCinsi.Name = "colDovizCinsi";
            this.colDovizCinsi.ToolTipText = "Döviz Cinsi";
            this.colDovizCinsi.Width = 60;
            // 
            // colDovizFiyat
            // 
            this.colDovizFiyat.DataPropertyName = "PRICE";
            this.colDovizFiyat.DecimalPlace = 2;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colDovizFiyat.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDovizFiyat.HeaderText = "Döviz Fiyat";
            this.colDovizFiyat.Name = "colDovizFiyat";
            this.colDovizFiyat.ToolTipText = "Miktarın ana fiyatı";
            this.colDovizFiyat.Width = 70;
            // 
            // colDovizTutar
            // 
            this.colDovizTutar.DataPropertyName = "EXAMOUNT";
            this.colDovizTutar.DecimalPlace = 1;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colDovizTutar.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDovizTutar.HeaderText = "Döviz Tutar";
            this.colDovizTutar.Name = "colDovizTutar";
            this.colDovizTutar.Width = 80;
            // 
            // colDovizKuru
            // 
            this.colDovizKuru.DataPropertyName = "EXRATE";
            this.colDovizKuru.DecimalPlace = 4;
            dataGridViewCellStyle10.Format = "N4";
            dataGridViewCellStyle10.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colDovizKuru.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDovizKuru.HeaderText = "Döviz Kuru";
            this.colDovizKuru.Name = "colDovizKuru";
            this.colDovizKuru.Width = 80;
            // 
            // colTLTutar
            // 
            this.colTLTutar.DataPropertyName = "TOTALAMOUNT";
            this.colTLTutar.DecimalPlace = 1;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colTLTutar.DefaultCellStyle = dataGridViewCellStyle11;
            this.colTLTutar.HeaderText = "TL Tutar";
            this.colTLTutar.Name = "colTLTutar";
            this.colTLTutar.Width = 80;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtProjeBilgi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(959, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proje Bilgileri ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtProjeBilgi
            // 
            this.txtProjeBilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjeBilgi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeBilgi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeBilgi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeBilgi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeBilgi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeBilgi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeBilgi.Label = null;
            this.txtProjeBilgi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeBilgi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeBilgi.LabelText = null;
            this.txtProjeBilgi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeBilgi.LabelTop = 3;
            this.txtProjeBilgi.LabelVisible = false;
            this.txtProjeBilgi.LabelWith = 100;
            this.txtProjeBilgi.Location = new System.Drawing.Point(7, 7);
            this.txtProjeBilgi.Multiline = true;
            this.txtProjeBilgi.Name = "txtProjeBilgi";
            this.txtProjeBilgi.NumericBox = false;
            this.txtProjeBilgi.NumericDecimal = 0;
            this.txtProjeBilgi.ReferansTip = 0;
            this.txtProjeBilgi.Required = false;
            this.txtProjeBilgi.RequiredPass = true;
            this.txtProjeBilgi.Size = new System.Drawing.Size(946, 395);
            this.txtProjeBilgi.TabIndex = 0;
            this.txtProjeBilgi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeBilgi.WordWrap = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtHedeflenenKar);
            this.tabPage4.Controls.Add(this.txtSatisBedeli);
            this.tabPage4.Controls.Add(this.txtBToplamProje);
            this.tabPage4.Controls.Add(this.txtBToplamNakliye);
            this.tabPage4.Controls.Add(this.txtBToplamPatent);
            this.tabPage4.Controls.Add(this.txtBToplamEgitim);
            this.tabPage4.Controls.Add(this.txtBToplamSeyehat);
            this.tabPage4.Controls.Add(this.txtBToplamHizmet);
            this.tabPage4.Controls.Add(this.txtBToplamTest);
            this.tabPage4.Controls.Add(this.txtBToplamEkipman);
            this.tabPage4.Controls.Add(this.txtBToplamMaliyet);
            this.tabPage4.Controls.Add(this.txtBToplamMalzeme);
            this.tabPage4.Controls.Add(this.txtBToplamIscilik);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(959, 408);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bütçe ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtHedeflenenKar
            // 
            this.txtHedeflenenKar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtHedeflenenKar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtHedeflenenKar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtHedeflenenKar.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtHedeflenenKar.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtHedeflenenKar.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtHedeflenenKar.Label = null;
            this.txtHedeflenenKar.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHedeflenenKar.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHedeflenenKar.LabelText = "Hedeflenen Kar";
            this.txtHedeflenenKar.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtHedeflenenKar.LabelTop = 3;
            this.txtHedeflenenKar.LabelVisible = true;
            this.txtHedeflenenKar.LabelWith = 150;
            this.txtHedeflenenKar.Location = new System.Drawing.Point(168, 352);
            this.txtHedeflenenKar.Name = "txtHedeflenenKar";
            this.txtHedeflenenKar.NumericBox = true;
            this.txtHedeflenenKar.NumericDecimal = 0;
            this.txtHedeflenenKar.ReferansTip = 0;
            this.txtHedeflenenKar.Required = false;
            this.txtHedeflenenKar.RequiredPass = true;
            this.txtHedeflenenKar.Size = new System.Drawing.Size(131, 20);
            this.txtHedeflenenKar.TabIndex = 39;
            this.txtHedeflenenKar.Text = "0";
            this.txtHedeflenenKar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHedeflenenKar.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtHedeflenenKar.WordWrap = false;
            // 
            // txtSatisBedeli
            // 
            this.txtSatisBedeli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSatisBedeli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSatisBedeli.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSatisBedeli.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSatisBedeli.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSatisBedeli.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSatisBedeli.Label = null;
            this.txtSatisBedeli.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisBedeli.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSatisBedeli.LabelText = "Satış Bedeli";
            this.txtSatisBedeli.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSatisBedeli.LabelTop = 3;
            this.txtSatisBedeli.LabelVisible = true;
            this.txtSatisBedeli.LabelWith = 150;
            this.txtSatisBedeli.Location = new System.Drawing.Point(168, 326);
            this.txtSatisBedeli.Name = "txtSatisBedeli";
            this.txtSatisBedeli.NumericBox = true;
            this.txtSatisBedeli.NumericDecimal = 0;
            this.txtSatisBedeli.ReferansTip = 0;
            this.txtSatisBedeli.Required = false;
            this.txtSatisBedeli.RequiredPass = true;
            this.txtSatisBedeli.Size = new System.Drawing.Size(131, 20);
            this.txtSatisBedeli.TabIndex = 37;
            this.txtSatisBedeli.Text = "0";
            this.txtSatisBedeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSatisBedeli.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSatisBedeli.WordWrap = false;
            // 
            // txtBToplamProje
            // 
            this.txtBToplamProje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamProje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamProje.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamProje.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamProje.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamProje.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamProje.Label = null;
            this.txtBToplamProje.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamProje.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamProje.LabelText = "Arge Proje Maliyeti";
            this.txtBToplamProje.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamProje.LabelTop = 3;
            this.txtBToplamProje.LabelVisible = true;
            this.txtBToplamProje.LabelWith = 150;
            this.txtBToplamProje.Location = new System.Drawing.Point(168, 15);
            this.txtBToplamProje.Name = "txtBToplamProje";
            this.txtBToplamProje.NumericBox = true;
            this.txtBToplamProje.NumericDecimal = 0;
            this.txtBToplamProje.ReferansTip = 0;
            this.txtBToplamProje.Required = false;
            this.txtBToplamProje.RequiredPass = true;
            this.txtBToplamProje.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamProje.TabIndex = 24;
            this.txtBToplamProje.Text = "0";
            this.txtBToplamProje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamProje.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamProje.WordWrap = false;
            // 
            // txtBToplamNakliye
            // 
            this.txtBToplamNakliye.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamNakliye.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamNakliye.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamNakliye.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamNakliye.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamNakliye.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamNakliye.Label = null;
            this.txtBToplamNakliye.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamNakliye.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamNakliye.LabelText = "Nakliye Maliyeti";
            this.txtBToplamNakliye.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamNakliye.LabelTop = 3;
            this.txtBToplamNakliye.LabelVisible = true;
            this.txtBToplamNakliye.LabelWith = 150;
            this.txtBToplamNakliye.Location = new System.Drawing.Point(168, 249);
            this.txtBToplamNakliye.Name = "txtBToplamNakliye";
            this.txtBToplamNakliye.NumericBox = true;
            this.txtBToplamNakliye.NumericDecimal = 0;
            this.txtBToplamNakliye.ReferansTip = 0;
            this.txtBToplamNakliye.Required = false;
            this.txtBToplamNakliye.RequiredPass = true;
            this.txtBToplamNakliye.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamNakliye.TabIndex = 22;
            this.txtBToplamNakliye.Text = "0";
            this.txtBToplamNakliye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamNakliye.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamNakliye.WordWrap = false;
            // 
            // txtBToplamPatent
            // 
            this.txtBToplamPatent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamPatent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamPatent.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamPatent.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamPatent.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamPatent.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamPatent.Label = null;
            this.txtBToplamPatent.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamPatent.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamPatent.LabelText = "Patent/Yayın Maliyeti";
            this.txtBToplamPatent.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamPatent.LabelTop = 3;
            this.txtBToplamPatent.LabelVisible = true;
            this.txtBToplamPatent.LabelWith = 150;
            this.txtBToplamPatent.Location = new System.Drawing.Point(168, 223);
            this.txtBToplamPatent.Name = "txtBToplamPatent";
            this.txtBToplamPatent.NumericBox = true;
            this.txtBToplamPatent.NumericDecimal = 0;
            this.txtBToplamPatent.ReferansTip = 0;
            this.txtBToplamPatent.Required = false;
            this.txtBToplamPatent.RequiredPass = true;
            this.txtBToplamPatent.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamPatent.TabIndex = 20;
            this.txtBToplamPatent.Text = "0";
            this.txtBToplamPatent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamPatent.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamPatent.WordWrap = false;
            // 
            // txtBToplamEgitim
            // 
            this.txtBToplamEgitim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamEgitim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamEgitim.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamEgitim.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamEgitim.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamEgitim.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamEgitim.Label = null;
            this.txtBToplamEgitim.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamEgitim.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamEgitim.LabelText = "Eğitim Maliyeti";
            this.txtBToplamEgitim.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamEgitim.LabelTop = 3;
            this.txtBToplamEgitim.LabelVisible = true;
            this.txtBToplamEgitim.LabelWith = 150;
            this.txtBToplamEgitim.Location = new System.Drawing.Point(168, 197);
            this.txtBToplamEgitim.Name = "txtBToplamEgitim";
            this.txtBToplamEgitim.NumericBox = true;
            this.txtBToplamEgitim.NumericDecimal = 0;
            this.txtBToplamEgitim.ReferansTip = 0;
            this.txtBToplamEgitim.Required = false;
            this.txtBToplamEgitim.RequiredPass = true;
            this.txtBToplamEgitim.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamEgitim.TabIndex = 18;
            this.txtBToplamEgitim.Text = "0";
            this.txtBToplamEgitim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamEgitim.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamEgitim.WordWrap = false;
            // 
            // txtBToplamSeyehat
            // 
            this.txtBToplamSeyehat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamSeyehat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamSeyehat.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamSeyehat.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamSeyehat.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamSeyehat.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamSeyehat.Label = null;
            this.txtBToplamSeyehat.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamSeyehat.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamSeyehat.LabelText = "Seyahat Maliyeti";
            this.txtBToplamSeyehat.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamSeyehat.LabelTop = 3;
            this.txtBToplamSeyehat.LabelVisible = true;
            this.txtBToplamSeyehat.LabelWith = 150;
            this.txtBToplamSeyehat.Location = new System.Drawing.Point(168, 171);
            this.txtBToplamSeyehat.Name = "txtBToplamSeyehat";
            this.txtBToplamSeyehat.NumericBox = true;
            this.txtBToplamSeyehat.NumericDecimal = 0;
            this.txtBToplamSeyehat.ReferansTip = 0;
            this.txtBToplamSeyehat.Required = false;
            this.txtBToplamSeyehat.RequiredPass = true;
            this.txtBToplamSeyehat.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamSeyehat.TabIndex = 16;
            this.txtBToplamSeyehat.Text = "0";
            this.txtBToplamSeyehat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamSeyehat.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamSeyehat.WordWrap = false;
            // 
            // txtBToplamHizmet
            // 
            this.txtBToplamHizmet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamHizmet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamHizmet.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamHizmet.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamHizmet.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamHizmet.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamHizmet.Label = null;
            this.txtBToplamHizmet.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamHizmet.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamHizmet.LabelText = "Hizmet / Danışmanlık Maliyeti";
            this.txtBToplamHizmet.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamHizmet.LabelTop = 3;
            this.txtBToplamHizmet.LabelVisible = true;
            this.txtBToplamHizmet.LabelWith = 150;
            this.txtBToplamHizmet.Location = new System.Drawing.Point(168, 145);
            this.txtBToplamHizmet.Name = "txtBToplamHizmet";
            this.txtBToplamHizmet.NumericBox = true;
            this.txtBToplamHizmet.NumericDecimal = 0;
            this.txtBToplamHizmet.ReferansTip = 0;
            this.txtBToplamHizmet.Required = false;
            this.txtBToplamHizmet.RequiredPass = true;
            this.txtBToplamHizmet.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamHizmet.TabIndex = 14;
            this.txtBToplamHizmet.Text = "0";
            this.txtBToplamHizmet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamHizmet.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamHizmet.WordWrap = false;
            // 
            // txtBToplamTest
            // 
            this.txtBToplamTest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamTest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamTest.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamTest.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamTest.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamTest.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamTest.Label = null;
            this.txtBToplamTest.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamTest.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamTest.LabelText = "Test / Validasyon Maliyeti";
            this.txtBToplamTest.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamTest.LabelTop = 3;
            this.txtBToplamTest.LabelVisible = true;
            this.txtBToplamTest.LabelWith = 150;
            this.txtBToplamTest.Location = new System.Drawing.Point(168, 119);
            this.txtBToplamTest.Name = "txtBToplamTest";
            this.txtBToplamTest.NumericBox = true;
            this.txtBToplamTest.NumericDecimal = 0;
            this.txtBToplamTest.ReferansTip = 0;
            this.txtBToplamTest.Required = false;
            this.txtBToplamTest.RequiredPass = true;
            this.txtBToplamTest.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamTest.TabIndex = 12;
            this.txtBToplamTest.Text = "0";
            this.txtBToplamTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamTest.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamTest.WordWrap = false;
            // 
            // txtBToplamEkipman
            // 
            this.txtBToplamEkipman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamEkipman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamEkipman.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamEkipman.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamEkipman.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamEkipman.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamEkipman.Label = null;
            this.txtBToplamEkipman.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamEkipman.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamEkipman.LabelText = "Ekipman/Yazılım/Yayın Mal.";
            this.txtBToplamEkipman.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamEkipman.LabelTop = 3;
            this.txtBToplamEkipman.LabelVisible = true;
            this.txtBToplamEkipman.LabelWith = 150;
            this.txtBToplamEkipman.Location = new System.Drawing.Point(168, 93);
            this.txtBToplamEkipman.Name = "txtBToplamEkipman";
            this.txtBToplamEkipman.NumericBox = true;
            this.txtBToplamEkipman.NumericDecimal = 0;
            this.txtBToplamEkipman.ReferansTip = 0;
            this.txtBToplamEkipman.Required = false;
            this.txtBToplamEkipman.RequiredPass = true;
            this.txtBToplamEkipman.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamEkipman.TabIndex = 10;
            this.txtBToplamEkipman.Text = "0";
            this.txtBToplamEkipman.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamEkipman.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamEkipman.WordWrap = false;
            // 
            // txtBToplamMaliyet
            // 
            this.txtBToplamMaliyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamMaliyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamMaliyet.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamMaliyet.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamMaliyet.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamMaliyet.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamMaliyet.Label = null;
            this.txtBToplamMaliyet.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamMaliyet.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamMaliyet.LabelText = "Toplam Maliyet";
            this.txtBToplamMaliyet.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamMaliyet.LabelTop = 3;
            this.txtBToplamMaliyet.LabelVisible = true;
            this.txtBToplamMaliyet.LabelWith = 150;
            this.txtBToplamMaliyet.Location = new System.Drawing.Point(168, 300);
            this.txtBToplamMaliyet.Name = "txtBToplamMaliyet";
            this.txtBToplamMaliyet.NumericBox = true;
            this.txtBToplamMaliyet.NumericDecimal = 0;
            this.txtBToplamMaliyet.ReferansTip = 0;
            this.txtBToplamMaliyet.Required = false;
            this.txtBToplamMaliyet.RequiredPass = true;
            this.txtBToplamMaliyet.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamMaliyet.TabIndex = 5;
            this.txtBToplamMaliyet.Text = "0";
            this.txtBToplamMaliyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamMaliyet.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamMaliyet.WordWrap = false;
            // 
            // txtBToplamMalzeme
            // 
            this.txtBToplamMalzeme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamMalzeme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamMalzeme.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamMalzeme.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamMalzeme.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamMalzeme.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamMalzeme.Label = null;
            this.txtBToplamMalzeme.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamMalzeme.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamMalzeme.LabelText = "Malzeme Maliyeti";
            this.txtBToplamMalzeme.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamMalzeme.LabelTop = 3;
            this.txtBToplamMalzeme.LabelVisible = true;
            this.txtBToplamMalzeme.LabelWith = 150;
            this.txtBToplamMalzeme.Location = new System.Drawing.Point(168, 67);
            this.txtBToplamMalzeme.Name = "txtBToplamMalzeme";
            this.txtBToplamMalzeme.NumericBox = true;
            this.txtBToplamMalzeme.NumericDecimal = 0;
            this.txtBToplamMalzeme.ReferansTip = 0;
            this.txtBToplamMalzeme.Required = false;
            this.txtBToplamMalzeme.RequiredPass = true;
            this.txtBToplamMalzeme.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamMalzeme.TabIndex = 3;
            this.txtBToplamMalzeme.Text = "0";
            this.txtBToplamMalzeme.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamMalzeme.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamMalzeme.WordWrap = false;
            // 
            // txtBToplamIscilik
            // 
            this.txtBToplamIscilik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBToplamIscilik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBToplamIscilik.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBToplamIscilik.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtBToplamIscilik.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtBToplamIscilik.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtBToplamIscilik.Label = null;
            this.txtBToplamIscilik.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBToplamIscilik.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBToplamIscilik.LabelText = "İşcilik Maliyeti";
            this.txtBToplamIscilik.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtBToplamIscilik.LabelTop = 3;
            this.txtBToplamIscilik.LabelVisible = true;
            this.txtBToplamIscilik.LabelWith = 150;
            this.txtBToplamIscilik.Location = new System.Drawing.Point(168, 41);
            this.txtBToplamIscilik.Name = "txtBToplamIscilik";
            this.txtBToplamIscilik.NumericBox = true;
            this.txtBToplamIscilik.NumericDecimal = 0;
            this.txtBToplamIscilik.ReferansTip = 0;
            this.txtBToplamIscilik.Required = false;
            this.txtBToplamIscilik.RequiredPass = true;
            this.txtBToplamIscilik.Size = new System.Drawing.Size(131, 20);
            this.txtBToplamIscilik.TabIndex = 0;
            this.txtBToplamIscilik.Text = "0";
            this.txtBToplamIscilik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBToplamIscilik.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtBToplamIscilik.WordWrap = false;
            // 
            // FrmProjePlanDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 595);
            this.Controls.Add(this.bC_GroupBox1);
            this.Controls.Add(this.bC_TabControl1);
            this.Name = "FrmProjePlanDetay";
            this.Text = "Proje Planlama ve Bütçeleme";
            this.Load += new System.EventHandler(this.FrmProjePlanDetay_Load);
            this.bC_GroupBox1.ResumeLayout(false);
            this.bC_GroupBox1.PerformLayout();
            this.bC_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.bC_Panel1.ResumeLayout(false);
            this.bC_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.bC_Panel2.ResumeLayout(false);
            this.bC_Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMaliyet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.Forms.BC_TabControl bC_TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private BaseControls.BC_DataGrid GrdPlan;
        private BaseControls.BC_DataGrid GrdMaliyet;
        private BaseControls.BC_GroupBox bC_GroupBox1;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_TextBox txtProjeNo;
        private System.Windows.Forms.TabPage tabPage3;
        private BaseControls.BC_TextBox txtProjeBilgi;
        private BaseControls.Forms.BC_DateTime txtTeslimTarihi;
        private BaseControls.BC_TextBox txtTalepEden;
        private BaseControls.BC_TextBox txtMusteri;
        private BaseControls.BC_TextBox txtProjeTipi;
        private BaseControls.BC_TextBox txtProjeAdi;
        private BaseControls.BC_TextBox txtProjeSorumlusu;
        private BaseControls.BC_Label bC_Label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
        private BaseControls.BC_Button btnOnayaGonder;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.Forms.BC_Panel bC_Panel1;
        private BaseControls.BC_TextBox txtToplamSure;
        private BaseControls.Forms.BC_Panel bC_Panel2;
        private BaseControls.BC_TextBox txtToplamMaliyet;
        private BaseControls.Forms.BC_DateTime txtPlnTeslimTarihi;
        private System.Windows.Forms.TabPage tabPage4;
        private BaseControls.BC_TextBox txtBToplamMaliyet;
        private BaseControls.BC_TextBox txtBToplamMalzeme;
        private BaseControls.BC_TextBox txtBToplamIscilik;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaliyetTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiktar;
        private System.Windows.Forms.DataGridViewComboBoxColumn colBirim;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDovizCinsi;
        private BaseControls.NumericTextColumn colDovizFiyat;
        private BaseControls.NumericTextColumn colDovizTutar;
        private BaseControls.NumericTextColumn colDovizKuru;
        private BaseControls.NumericTextColumn colTLTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjeNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGorevTuru;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGorevTipi;
        private BaseControls.ButtonTextColumn colKaynak;
        private BaseControls.NumericTextColumn colHours;
        private BaseControls.CalendarColumn colStartDate;
        private BaseControls.CalendarColumn colStopDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaatUcreti;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToplamUcret;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanAciklama;
        private BaseControls.BC_TextBox txtBToplamPatent;
        private BaseControls.BC_TextBox txtBToplamEgitim;
        private BaseControls.BC_TextBox txtBToplamSeyehat;
        private BaseControls.BC_TextBox txtBToplamHizmet;
        private BaseControls.BC_TextBox txtBToplamTest;
        private BaseControls.BC_TextBox txtBToplamEkipman;
        private BaseControls.BC_TextBox txtBToplamNakliye;
        private BaseControls.BC_TextBox txtBToplamProje;
        private BaseControls.BC_TextBox txtHedeflenenKar;
        private BaseControls.BC_TextBox txtSatisBedeli;
    }
}