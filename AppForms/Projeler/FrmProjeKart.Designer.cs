namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjeKart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.NumericTextCell numericTextCell1 = new BaseControls.NumericTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.ButtonTextCell buttonTextCell1 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.NumericTextCell numericTextCell2 = new BaseControls.NumericTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.ButtonTextCell buttonTextCell2 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.ButtonTextCell buttonTextCell3 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeKart));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabProjects = new BaseControls.Forms.BC_TabControl();
            this.tabTalep = new System.Windows.Forms.TabPage();
            this.txtTesisKodu = new BaseControls.BC_TextBox();
            this.txtCatiProje = new BaseControls.BC_TextBox();
            this.txtTalepEden = new BaseControls.BC_TextBox();
            this.txtTalepSekli = new BaseControls.BC_ComboBox();
            this.txtMusteriKodu = new BaseControls.BC_TextBox();
            this.txtMusteriAdi = new BaseControls.BC_TextBox();
            this.txtProjeBilgi = new BaseControls.BC_TextBox();
            this.tabOnOnay = new System.Windows.Forms.TabPage();
            this.txtTalepOnayAciklama = new BaseControls.BC_TextBox();
            this.txtTalepOnayTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtTalebiOnaylayan = new BaseControls.BC_TextBox();
            this.tabProjeSorumlusu = new System.Windows.Forms.TabPage();
            this.txtSorumluatayan = new BaseControls.BC_TextBox();
            this.txtSorumluatamatarihi = new BaseControls.Forms.BC_DateTime();
            this.txtProjesorumlusu = new BaseControls.BC_TextBox();
            this.tabButcePlan = new System.Windows.Forms.TabPage();
            this.txtIscilikMaliyeti = new BaseControls.BC_TextBox();
            this.txtToplamMaliyet = new BaseControls.BC_TextBox();
            this.bC_Label2 = new BaseControls.BC_Label();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.GrdMaliyet = new BaseControls.BC_DataGrid();
            this.colMaliyetTipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiktar = new BaseControls.NumericTextColumn();
            this.colBirim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDovizCinsi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDovizFiyat = new BaseControls.NumericTextColumn();
            this.colDovizTutar = new BaseControls.NumericTextColumn();
            this.colDovizKuru = new BaseControls.NumericTextColumn();
            this.colTLTutar = new BaseControls.NumericTextColumn();
            this.GrdPlan = new BaseControls.BC_DataGrid();
            this.colProjeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGorevTuru = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGorevTipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colKaynak = new BaseControls.ButtonTextColumn();
            this.HOURS = new BaseControls.NumericTextColumn();
            this.STARTDATE = new BaseControls.CalendarColumn();
            this.STOPDATE = new BaseControls.CalendarColumn();
            this.tabButceOnay = new System.Windows.Forms.TabPage();
            this.txtButceonayaciklama = new BaseControls.BC_TextBox();
            this.txtButceonaytarihi = new BaseControls.Forms.BC_DateTime();
            this.txtButceonaylayan = new BaseControls.BC_TextBox();
            this.tabProjeIslem = new System.Windows.Forms.TabPage();
            this.GrdPersonelSure = new BaseControls.BC_DataGrid();
            this.colWorkDate = new BaseControls.CalendarColumn();
            this.colPersonel = new BaseControls.ButtonTextColumn();
            this.colKonum = new BaseControls.TextBoxButtonColumn();
            this.dataGridViewComboBoxColumn1 = new BaseControls.TextBoxButtonColumn();
            this.colProjeKodu = new BaseControls.ButtonTextColumn();
            this.colBaslangicSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSure = new BaseControls.NumericTextColumn();
            this.colBasSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProjeBitis = new System.Windows.Forms.TabPage();
            this.cbKapanisDurum = new BaseControls.BC_CheckBox();
            this.txtKapanisNotu = new BaseControls.BC_TextBox();
            this.txtKapanisHzTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtKapanisHazirlayan = new BaseControls.BC_TextBox();
            this.txtKapanisTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtKapanisOnaylayan = new BaseControls.BC_TextBox();
            this.tabProjeDosyalar = new System.Windows.Forms.TabPage();
            this.bC_GroupBox2 = new BaseControls.BC_GroupBox();
            this.txtSecilenDosya = new BaseControls.BC_TextBox();
            this.btnDosyaSil = new BaseControls.BC_Button(this.components);
            this.btnDosyaEkle = new BaseControls.BC_Button(this.components);
            this.btnDosyaAc = new BaseControls.BC_Button(this.components);
            this.GrdDosyalar = new BaseControls.BC_DataGrid();
            this.colDosyaKaynak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFILENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAnaliz = new System.Windows.Forms.TabPage();
            this.tabYonetici = new System.Windows.Forms.TabPage();
            this.txtSatisTutar = new BaseControls.BC_TextBox();
            this.txtTotalMaliyet = new BaseControls.BC_TextBox();
            this.bC_Label3 = new BaseControls.BC_Label();
            this.txtLogs = new BaseControls.BC_TextBox();
            this.btnSorumluDegistir = new BaseControls.BC_Button(this.components);
            this.txtProjeSorumlusu2 = new BaseControls.BC_TextBox();
            this.txtYeniStatu = new BaseControls.BC_ComboBox();
            this.btnStatuDegistir = new BaseControls.BC_Button(this.components);
            this.bC_GroupBox1 = new BaseControls.BC_GroupBox();
            this.txtProjeStatu = new BaseControls.BC_ComboBox();
            this.txtProjeTipi = new BaseControls.BC_TextBox();
            this.txtTalepTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtTeslimTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtProjeadi = new BaseControls.BC_TextBox();
            this.txtProjekodu = new BaseControls.BC_TextBox();
            this.txtKarMarji = new BaseControls.BC_TextBox();
            this.btnEkKarGuncelle = new BaseControls.BC_Button(this.components);
            this.tabProjects.SuspendLayout();
            this.tabTalep.SuspendLayout();
            this.tabOnOnay.SuspendLayout();
            this.tabProjeSorumlusu.SuspendLayout();
            this.tabButcePlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlan)).BeginInit();
            this.tabButceOnay.SuspendLayout();
            this.tabProjeIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPersonelSure)).BeginInit();
            this.tabProjeBitis.SuspendLayout();
            this.tabProjeDosyalar.SuspendLayout();
            this.bC_GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDosyalar)).BeginInit();
            this.tabYonetici.SuspendLayout();
            this.bC_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.tabTalep);
            this.tabProjects.Controls.Add(this.tabOnOnay);
            this.tabProjects.Controls.Add(this.tabProjeSorumlusu);
            this.tabProjects.Controls.Add(this.tabButcePlan);
            this.tabProjects.Controls.Add(this.tabButceOnay);
            this.tabProjects.Controls.Add(this.tabProjeIslem);
            this.tabProjects.Controls.Add(this.tabProjeBitis);
            this.tabProjects.Controls.Add(this.tabProjeDosyalar);
            this.tabProjects.Controls.Add(this.tabAnaliz);
            this.tabProjects.Controls.Add(this.tabYonetici);
            this.tabProjects.Location = new System.Drawing.Point(13, 118);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.SelectedIndex = 0;
            this.tabProjects.Size = new System.Drawing.Size(979, 432);
            this.tabProjects.TabIndex = 2;
            this.tabProjects.TabStop = false;
            // 
            // tabTalep
            // 
            this.tabTalep.Controls.Add(this.txtTesisKodu);
            this.tabTalep.Controls.Add(this.txtCatiProje);
            this.tabTalep.Controls.Add(this.txtTalepEden);
            this.tabTalep.Controls.Add(this.txtTalepSekli);
            this.tabTalep.Controls.Add(this.txtMusteriKodu);
            this.tabTalep.Controls.Add(this.txtMusteriAdi);
            this.tabTalep.Controls.Add(this.txtProjeBilgi);
            this.tabTalep.Location = new System.Drawing.Point(4, 22);
            this.tabTalep.Name = "tabTalep";
            this.tabTalep.Padding = new System.Windows.Forms.Padding(3);
            this.tabTalep.Size = new System.Drawing.Size(971, 406);
            this.tabTalep.TabIndex = 0;
            this.tabTalep.Text = "Talep Bilgileri";
            this.tabTalep.UseVisualStyleBackColor = true;
            // 
            // txtTesisKodu
            // 
            this.txtTesisKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTesisKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTesisKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTesisKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTesisKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTesisKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTesisKodu.Label = null;
            this.txtTesisKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTesisKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTesisKodu.LabelText = "Tesis Kodu";
            this.txtTesisKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTesisKodu.LabelTop = 3;
            this.txtTesisKodu.LabelVisible = true;
            this.txtTesisKodu.LabelWith = 100;
            this.txtTesisKodu.Location = new System.Drawing.Point(826, 44);
            this.txtTesisKodu.Name = "txtTesisKodu";
            this.txtTesisKodu.NumericBox = false;
            this.txtTesisKodu.NumericDecimal = 0;
            this.txtTesisKodu.ReferansTip = 0;
            this.txtTesisKodu.Required = false;
            this.txtTesisKodu.RequiredPass = true;
            this.txtTesisKodu.Size = new System.Drawing.Size(122, 20);
            this.txtTesisKodu.TabIndex = 72;
            this.txtTesisKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTesisKodu.WordWrap = false;
            // 
            // txtCatiProje
            // 
            this.txtCatiProje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCatiProje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCatiProje.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCatiProje.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtCatiProje.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtCatiProje.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtCatiProje.Label = null;
            this.txtCatiProje.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCatiProje.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCatiProje.LabelText = "Çatı Proje";
            this.txtCatiProje.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtCatiProje.LabelTop = 3;
            this.txtCatiProje.LabelVisible = true;
            this.txtCatiProje.LabelWith = 100;
            this.txtCatiProje.Location = new System.Drawing.Point(826, 71);
            this.txtCatiProje.Name = "txtCatiProje";
            this.txtCatiProje.NumericBox = false;
            this.txtCatiProje.NumericDecimal = 0;
            this.txtCatiProje.ReferansTip = 0;
            this.txtCatiProje.Required = false;
            this.txtCatiProje.RequiredPass = true;
            this.txtCatiProje.Size = new System.Drawing.Size(122, 20);
            this.txtCatiProje.TabIndex = 63;
            this.txtCatiProje.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtCatiProje.WordWrap = false;
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
            this.txtTalepEden.Location = new System.Drawing.Point(826, 18);
            this.txtTalepEden.Name = "txtTalepEden";
            this.txtTalepEden.NumericBox = false;
            this.txtTalepEden.NumericDecimal = 0;
            this.txtTalepEden.ReferansTip = 0;
            this.txtTalepEden.Required = false;
            this.txtTalepEden.RequiredPass = true;
            this.txtTalepEden.Size = new System.Drawing.Size(122, 20);
            this.txtTalepEden.TabIndex = 62;
            this.txtTalepEden.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalepEden.WordWrap = false;
            // 
            // txtTalepSekli
            // 
            this.txtTalepSekli.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTalepSekli.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTalepSekli.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTalepSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTalepSekli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTalepSekli.FormattingEnabled = true;
            this.txtTalepSekli.Items.AddRange(new object[] {
            "Müşteri Talebi",
            "İşletme Talebi"});
            this.txtTalepSekli.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepSekli.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepSekli.LabelText = "Talep Şekli";
            this.txtTalepSekli.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTalepSekli.LabelTop = 4;
            this.txtTalepSekli.LabelVisible = true;
            this.txtTalepSekli.LabelWith = 100;
            this.txtTalepSekli.Location = new System.Drawing.Point(112, 44);
            this.txtTalepSekli.Name = "txtTalepSekli";
            this.txtTalepSekli.Size = new System.Drawing.Size(201, 21);
            this.txtTalepSekli.TabIndex = 58;
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
            this.txtMusteriKodu.LabelText = "Müşteri ";
            this.txtMusteriKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteriKodu.LabelTop = 3;
            this.txtMusteriKodu.LabelVisible = true;
            this.txtMusteriKodu.LabelWith = 100;
            this.txtMusteriKodu.Location = new System.Drawing.Point(112, 18);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.NumericBox = false;
            this.txtMusteriKodu.NumericDecimal = 0;
            this.txtMusteriKodu.ReferansTip = 0;
            this.txtMusteriKodu.Required = false;
            this.txtMusteriKodu.RequiredPass = true;
            this.txtMusteriKodu.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriKodu.TabIndex = 27;
            this.txtMusteriKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteriKodu.WordWrap = false;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMusteriAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMusteriAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMusteriAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMusteriAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMusteriAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtMusteriAdi.Label = null;
            this.txtMusteriAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMusteriAdi.LabelText = "Müşteri Adı";
            this.txtMusteriAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteriAdi.LabelTop = 3;
            this.txtMusteriAdi.LabelVisible = false;
            this.txtMusteriAdi.LabelWith = 60;
            this.txtMusteriAdi.Location = new System.Drawing.Point(218, 18);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.NumericBox = false;
            this.txtMusteriAdi.NumericDecimal = 0;
            this.txtMusteriAdi.ReferansTip = 0;
            this.txtMusteriAdi.Required = false;
            this.txtMusteriAdi.RequiredPass = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(471, 20);
            this.txtMusteriAdi.TabIndex = 28;
            this.txtMusteriAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteriAdi.WordWrap = false;
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
            this.txtProjeBilgi.Location = new System.Drawing.Point(6, 157);
            this.txtProjeBilgi.Multiline = true;
            this.txtProjeBilgi.Name = "txtProjeBilgi";
            this.txtProjeBilgi.NumericBox = false;
            this.txtProjeBilgi.NumericDecimal = 0;
            this.txtProjeBilgi.ReferansTip = 0;
            this.txtProjeBilgi.Required = false;
            this.txtProjeBilgi.RequiredPass = true;
            this.txtProjeBilgi.Size = new System.Drawing.Size(959, 243);
            this.txtProjeBilgi.TabIndex = 2;
            this.txtProjeBilgi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeBilgi.WordWrap = false;
            // 
            // tabOnOnay
            // 
            this.tabOnOnay.Controls.Add(this.txtTalepOnayAciklama);
            this.tabOnOnay.Controls.Add(this.txtTalepOnayTarihi);
            this.tabOnOnay.Controls.Add(this.txtTalebiOnaylayan);
            this.tabOnOnay.Location = new System.Drawing.Point(4, 22);
            this.tabOnOnay.Name = "tabOnOnay";
            this.tabOnOnay.Padding = new System.Windows.Forms.Padding(3);
            this.tabOnOnay.Size = new System.Drawing.Size(971, 406);
            this.tabOnOnay.TabIndex = 1;
            this.tabOnOnay.Text = "Talep Onayı";
            this.tabOnOnay.UseVisualStyleBackColor = true;
            // 
            // txtTalepOnayAciklama
            // 
            this.txtTalepOnayAciklama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTalepOnayAciklama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTalepOnayAciklama.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTalepOnayAciklama.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTalepOnayAciklama.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTalepOnayAciklama.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTalepOnayAciklama.Label = null;
            this.txtTalepOnayAciklama.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepOnayAciklama.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepOnayAciklama.LabelText = "Onay Açıklaması";
            this.txtTalepOnayAciklama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTalepOnayAciklama.LabelTop = 3;
            this.txtTalepOnayAciklama.LabelVisible = true;
            this.txtTalepOnayAciklama.LabelWith = 100;
            this.txtTalepOnayAciklama.Location = new System.Drawing.Point(125, 73);
            this.txtTalepOnayAciklama.Name = "txtTalepOnayAciklama";
            this.txtTalepOnayAciklama.NumericBox = false;
            this.txtTalepOnayAciklama.NumericDecimal = 0;
            this.txtTalepOnayAciklama.ReferansTip = 0;
            this.txtTalepOnayAciklama.Required = false;
            this.txtTalepOnayAciklama.RequiredPass = true;
            this.txtTalepOnayAciklama.Size = new System.Drawing.Size(525, 20);
            this.txtTalepOnayAciklama.TabIndex = 5;
            this.txtTalepOnayAciklama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalepOnayAciklama.WordWrap = false;
            // 
            // txtTalepOnayTarihi
            // 
            this.txtTalepOnayTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtTalepOnayTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTalepOnayTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepOnayTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepOnayTarihi.LabelText = "Onay Tarihi";
            this.txtTalepOnayTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTalepOnayTarihi.LabelTop = 5;
            this.txtTalepOnayTarihi.LabelVisible = true;
            this.txtTalepOnayTarihi.LabelWith = 100;
            this.txtTalepOnayTarihi.Location = new System.Drawing.Point(125, 47);
            this.txtTalepOnayTarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtTalepOnayTarihi.Name = "txtTalepOnayTarihi";
            this.txtTalepOnayTarihi.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtTalepOnayTarihi.Size = new System.Drawing.Size(200, 20);
            this.txtTalepOnayTarihi.TabIndex = 2;
            this.txtTalepOnayTarihi.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtTalebiOnaylayan
            // 
            this.txtTalebiOnaylayan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTalebiOnaylayan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTalebiOnaylayan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTalebiOnaylayan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTalebiOnaylayan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTalebiOnaylayan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTalebiOnaylayan.Label = null;
            this.txtTalebiOnaylayan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalebiOnaylayan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalebiOnaylayan.LabelText = "Talebi Onaylayan";
            this.txtTalebiOnaylayan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTalebiOnaylayan.LabelTop = 3;
            this.txtTalebiOnaylayan.LabelVisible = true;
            this.txtTalebiOnaylayan.LabelWith = 100;
            this.txtTalebiOnaylayan.Location = new System.Drawing.Point(125, 20);
            this.txtTalebiOnaylayan.Name = "txtTalebiOnaylayan";
            this.txtTalebiOnaylayan.NumericBox = false;
            this.txtTalebiOnaylayan.NumericDecimal = 0;
            this.txtTalebiOnaylayan.ReferansTip = 0;
            this.txtTalebiOnaylayan.Required = false;
            this.txtTalebiOnaylayan.RequiredPass = true;
            this.txtTalebiOnaylayan.Size = new System.Drawing.Size(200, 20);
            this.txtTalebiOnaylayan.TabIndex = 0;
            this.txtTalebiOnaylayan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalebiOnaylayan.WordWrap = false;
            // 
            // tabProjeSorumlusu
            // 
            this.tabProjeSorumlusu.Controls.Add(this.txtSorumluatayan);
            this.tabProjeSorumlusu.Controls.Add(this.txtSorumluatamatarihi);
            this.tabProjeSorumlusu.Controls.Add(this.txtProjesorumlusu);
            this.tabProjeSorumlusu.Location = new System.Drawing.Point(4, 22);
            this.tabProjeSorumlusu.Name = "tabProjeSorumlusu";
            this.tabProjeSorumlusu.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjeSorumlusu.Size = new System.Drawing.Size(971, 406);
            this.tabProjeSorumlusu.TabIndex = 2;
            this.tabProjeSorumlusu.Text = "Proje Sorumlusu";
            this.tabProjeSorumlusu.UseVisualStyleBackColor = true;
            // 
            // txtSorumluatayan
            // 
            this.txtSorumluatayan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSorumluatayan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSorumluatayan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSorumluatayan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSorumluatayan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSorumluatayan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSorumluatayan.Label = null;
            this.txtSorumluatayan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorumluatayan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSorumluatayan.LabelText = "Sorumlu Atayan";
            this.txtSorumluatayan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSorumluatayan.LabelTop = 3;
            this.txtSorumluatayan.LabelVisible = true;
            this.txtSorumluatayan.LabelWith = 100;
            this.txtSorumluatayan.Location = new System.Drawing.Point(125, 73);
            this.txtSorumluatayan.Name = "txtSorumluatayan";
            this.txtSorumluatayan.NumericBox = false;
            this.txtSorumluatayan.NumericDecimal = 0;
            this.txtSorumluatayan.ReferansTip = 0;
            this.txtSorumluatayan.Required = false;
            this.txtSorumluatayan.RequiredPass = true;
            this.txtSorumluatayan.Size = new System.Drawing.Size(200, 20);
            this.txtSorumluatayan.TabIndex = 11;
            this.txtSorumluatayan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSorumluatayan.WordWrap = false;
            // 
            // txtSorumluatamatarihi
            // 
            this.txtSorumluatamatarihi.CustomFormat = "dd.MM.yyyy";
            this.txtSorumluatamatarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSorumluatamatarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorumluatamatarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSorumluatamatarihi.LabelText = "Değiştirme Tarihi";
            this.txtSorumluatamatarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtSorumluatamatarihi.LabelTop = 5;
            this.txtSorumluatamatarihi.LabelVisible = true;
            this.txtSorumluatamatarihi.LabelWith = 100;
            this.txtSorumluatamatarihi.Location = new System.Drawing.Point(125, 47);
            this.txtSorumluatamatarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtSorumluatamatarihi.Name = "txtSorumluatamatarihi";
            this.txtSorumluatamatarihi.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtSorumluatamatarihi.Size = new System.Drawing.Size(200, 20);
            this.txtSorumluatamatarihi.TabIndex = 10;
            this.txtSorumluatamatarihi.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtProjesorumlusu
            // 
            this.txtProjesorumlusu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjesorumlusu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjesorumlusu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjesorumlusu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjesorumlusu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjesorumlusu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjesorumlusu.Label = null;
            this.txtProjesorumlusu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjesorumlusu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjesorumlusu.LabelText = "Proje Sorumlusu";
            this.txtProjesorumlusu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjesorumlusu.LabelTop = 3;
            this.txtProjesorumlusu.LabelVisible = true;
            this.txtProjesorumlusu.LabelWith = 100;
            this.txtProjesorumlusu.Location = new System.Drawing.Point(125, 20);
            this.txtProjesorumlusu.Name = "txtProjesorumlusu";
            this.txtProjesorumlusu.NumericBox = false;
            this.txtProjesorumlusu.NumericDecimal = 0;
            this.txtProjesorumlusu.ReferansTip = 0;
            this.txtProjesorumlusu.Required = false;
            this.txtProjesorumlusu.RequiredPass = true;
            this.txtProjesorumlusu.Size = new System.Drawing.Size(200, 20);
            this.txtProjesorumlusu.TabIndex = 9;
            this.txtProjesorumlusu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjesorumlusu.WordWrap = false;
            // 
            // tabButcePlan
            // 
            this.tabButcePlan.Controls.Add(this.btnEkKarGuncelle);
            this.tabButcePlan.Controls.Add(this.txtKarMarji);
            this.tabButcePlan.Controls.Add(this.txtIscilikMaliyeti);
            this.tabButcePlan.Controls.Add(this.txtToplamMaliyet);
            this.tabButcePlan.Controls.Add(this.bC_Label2);
            this.tabButcePlan.Controls.Add(this.bC_Label1);
            this.tabButcePlan.Controls.Add(this.GrdMaliyet);
            this.tabButcePlan.Controls.Add(this.GrdPlan);
            this.tabButcePlan.Location = new System.Drawing.Point(4, 22);
            this.tabButcePlan.Name = "tabButcePlan";
            this.tabButcePlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabButcePlan.Size = new System.Drawing.Size(971, 406);
            this.tabButcePlan.TabIndex = 3;
            this.tabButcePlan.Text = "Bütçe Planlama";
            this.tabButcePlan.UseVisualStyleBackColor = true;
            this.tabButcePlan.Click += new System.EventHandler(this.tabButcePlan_Click);
            // 
            // txtIscilikMaliyeti
            // 
            this.txtIscilikMaliyeti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIscilikMaliyeti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIscilikMaliyeti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIscilikMaliyeti.BorderColor = System.Drawing.Color.DarkGray;
            this.txtIscilikMaliyeti.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtIscilikMaliyeti.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtIscilikMaliyeti.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtIscilikMaliyeti.Label = null;
            this.txtIscilikMaliyeti.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIscilikMaliyeti.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIscilikMaliyeti.LabelText = "Toplam İşçilik Tutarı (TL)";
            this.txtIscilikMaliyeti.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtIscilikMaliyeti.LabelTop = 3;
            this.txtIscilikMaliyeti.LabelVisible = true;
            this.txtIscilikMaliyeti.LabelWith = 150;
            this.txtIscilikMaliyeti.Location = new System.Drawing.Point(856, 188);
            this.txtIscilikMaliyeti.Name = "txtIscilikMaliyeti";
            this.txtIscilikMaliyeti.NumericBox = false;
            this.txtIscilikMaliyeti.NumericDecimal = 2;
            this.txtIscilikMaliyeti.ReferansTip = 0;
            this.txtIscilikMaliyeti.Required = false;
            this.txtIscilikMaliyeti.RequiredPass = true;
            this.txtIscilikMaliyeti.Size = new System.Drawing.Size(100, 20);
            this.txtIscilikMaliyeti.TabIndex = 9;
            this.txtIscilikMaliyeti.Text = "0,00";
            this.txtIscilikMaliyeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIscilikMaliyeti.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtIscilikMaliyeti.WordWrap = false;
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
            this.txtToplamMaliyet.LabelText = "Toplam Maliyet Tutarı (TL)";
            this.txtToplamMaliyet.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtToplamMaliyet.LabelTop = 3;
            this.txtToplamMaliyet.LabelVisible = true;
            this.txtToplamMaliyet.LabelWith = 150;
            this.txtToplamMaliyet.Location = new System.Drawing.Point(856, 381);
            this.txtToplamMaliyet.Name = "txtToplamMaliyet";
            this.txtToplamMaliyet.NumericBox = false;
            this.txtToplamMaliyet.NumericDecimal = 2;
            this.txtToplamMaliyet.ReferansTip = 0;
            this.txtToplamMaliyet.Required = false;
            this.txtToplamMaliyet.RequiredPass = true;
            this.txtToplamMaliyet.Size = new System.Drawing.Size(100, 20);
            this.txtToplamMaliyet.TabIndex = 6;
            this.txtToplamMaliyet.Text = "0,00";
            this.txtToplamMaliyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToplamMaliyet.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtToplamMaliyet.WordWrap = false;
            // 
            // bC_Label2
            // 
            this.bC_Label2.AutoSize = true;
            this.bC_Label2.Location = new System.Drawing.Point(12, 202);
            this.bC_Label2.Name = "bC_Label2";
            this.bC_Label2.Size = new System.Drawing.Size(99, 13);
            this.bC_Label2.TabIndex = 4;
            this.bC_Label2.Text = "Bütçe-Maliyet Planlı";
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(12, 11);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(107, 13);
            this.bC_Label1.TabIndex = 3;
            this.bC_Label1.Text = "Zaman-Kaynak Planlı";
            // 
            // GrdMaliyet
            // 
            this.GrdMaliyet.AllowUserToAddRows = false;
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
            this.GrdMaliyet.Location = new System.Drawing.Point(12, 218);
            this.GrdMaliyet.MenuDeleteVisible = true;
            this.GrdMaliyet.Name = "GrdMaliyet";
            this.GrdMaliyet.RowHeadersWidth = 25;
            this.GrdMaliyet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdMaliyet.Size = new System.Drawing.Size(944, 157);
            this.GrdMaliyet.TabIndex = 2;
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
            this.colMiktar.DecimalPlace = 1;
            numericTextCell1.ErrorText = "";
            numericTextCell1.Style = dataGridViewCellStyle2;
            numericTextCell1.Value = "0";
            numericTextCell1.ValueType = typeof(string);
            dataGridViewCellStyle1.NullValue = numericTextCell1;
            this.colMiktar.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMiktar.HeaderText = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.ToolTipText = "Maliyet Miktarı";
            this.colMiktar.Width = 80;
            // 
            // colBirim
            // 
            this.colBirim.DataPropertyName = "UNIT";
            this.colBirim.HeaderText = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBirim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.colDovizFiyat.DecimalPlace = 1;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colDovizFiyat.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDovizFiyat.HeaderText = "Döviz Fiyat";
            this.colDovizFiyat.Name = "colDovizFiyat";
            this.colDovizFiyat.ToolTipText = "Miktarın ana fiyatı";
            this.colDovizFiyat.Width = 70;
            // 
            // colDovizTutar
            // 
            this.colDovizTutar.DataPropertyName = "EXAMOUNT";
            this.colDovizTutar.DecimalPlace = 1;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colDovizTutar.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDovizTutar.HeaderText = "Döviz Tutar";
            this.colDovizTutar.Name = "colDovizTutar";
            this.colDovizTutar.ReadOnly = true;
            this.colDovizTutar.Width = 80;
            // 
            // colDovizKuru
            // 
            this.colDovizKuru.DataPropertyName = "EXRATE";
            this.colDovizKuru.DecimalPlace = 1;
            dataGridViewCellStyle5.Format = "N4";
            dataGridViewCellStyle5.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colDovizKuru.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDovizKuru.HeaderText = "Döviz Kuru";
            this.colDovizKuru.Name = "colDovizKuru";
            this.colDovizKuru.Width = 80;
            // 
            // colTLTutar
            // 
            this.colTLTutar.DataPropertyName = "TOTALAMOUNT";
            this.colTLTutar.DecimalPlace = 1;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "DataGridViewTextBoxCell { ColumnIndex=-1, RowIndex=-1 }";
            this.colTLTutar.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTLTutar.HeaderText = "TL Tutar";
            this.colTLTutar.Name = "colTLTutar";
            this.colTLTutar.ReadOnly = true;
            this.colTLTutar.Width = 80;
            // 
            // GrdPlan
            // 
            this.GrdPlan.AllowUserToAddRows = false;
            this.GrdPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjeNo,
            this.colGorevTuru,
            this.colGorevTipi,
            this.colKaynak,
            this.HOURS,
            this.STARTDATE,
            this.STOPDATE});
            this.GrdPlan.Location = new System.Drawing.Point(12, 30);
            this.GrdPlan.MenuDeleteVisible = true;
            this.GrdPlan.Name = "GrdPlan";
            this.GrdPlan.RowHeadersWidth = 25;
            this.GrdPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPlan.Size = new System.Drawing.Size(944, 152);
            this.GrdPlan.TabIndex = 1;
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
            this.colGorevTipi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGorevTipi.Width = 180;
            // 
            // colKaynak
            // 
            this.colKaynak.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.colKaynak.DataPropertyName = "SOURCE";
            buttonTextCell1.ErrorText = "";
            buttonTextCell1.Style = dataGridViewCellStyle8;
            buttonTextCell1.Tag = "111";
            buttonTextCell1.Value = "11";
            buttonTextCell1.ValueType = typeof(string);
            dataGridViewCellStyle7.NullValue = buttonTextCell1;
            this.colKaynak.DefaultCellStyle = dataGridViewCellStyle7;
            this.colKaynak.HeaderText = "Kaynak";
            this.colKaynak.Name = "colKaynak";
            this.colKaynak.Width = 120;
            // 
            // HOURS
            // 
            this.HOURS.DataPropertyName = "HOURS";
            this.HOURS.DecimalPlace = 1;
            numericTextCell2.ErrorText = "";
            numericTextCell2.Style = dataGridViewCellStyle10;
            numericTextCell2.Value = "0";
            numericTextCell2.ValueType = typeof(string);
            dataGridViewCellStyle9.NullValue = numericTextCell2;
            this.HOURS.DefaultCellStyle = dataGridViewCellStyle9;
            this.HOURS.HeaderText = "Süre ( Saat)";
            this.HOURS.Name = "HOURS";
            this.HOURS.Width = 70;
            // 
            // STARTDATE
            // 
            this.STARTDATE.CustomFormat = null;
            this.STARTDATE.DataPropertyName = "STARTDATE";
            dataGridViewCellStyle11.NullValue = new System.DateTime(((long)(0)));
            this.STARTDATE.DefaultCellStyle = dataGridViewCellStyle11;
            this.STARTDATE.DefaultDate = new System.DateTime(((long)(0)));
            this.STARTDATE.HeaderText = "Başlangıç Tarihi";
            this.STARTDATE.Name = "STARTDATE";
            // 
            // STOPDATE
            // 
            this.STOPDATE.CustomFormat = null;
            this.STOPDATE.DataPropertyName = "STOPDATE";
            dataGridViewCellStyle12.NullValue = new System.DateTime(((long)(0)));
            this.STOPDATE.DefaultCellStyle = dataGridViewCellStyle12;
            this.STOPDATE.DefaultDate = new System.DateTime(((long)(0)));
            this.STOPDATE.HeaderText = "Bitiş Tarihi";
            this.STOPDATE.Name = "STOPDATE";
            // 
            // tabButceOnay
            // 
            this.tabButceOnay.Controls.Add(this.txtButceonayaciklama);
            this.tabButceOnay.Controls.Add(this.txtButceonaytarihi);
            this.tabButceOnay.Controls.Add(this.txtButceonaylayan);
            this.tabButceOnay.Location = new System.Drawing.Point(4, 22);
            this.tabButceOnay.Name = "tabButceOnay";
            this.tabButceOnay.Padding = new System.Windows.Forms.Padding(3);
            this.tabButceOnay.Size = new System.Drawing.Size(971, 406);
            this.tabButceOnay.TabIndex = 4;
            this.tabButceOnay.Text = "Bütçe Onayı";
            this.tabButceOnay.UseVisualStyleBackColor = true;
            // 
            // txtButceonayaciklama
            // 
            this.txtButceonayaciklama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtButceonayaciklama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtButceonayaciklama.BorderColor = System.Drawing.Color.DarkGray;
            this.txtButceonayaciklama.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtButceonayaciklama.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtButceonayaciklama.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtButceonayaciklama.Label = null;
            this.txtButceonayaciklama.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtButceonayaciklama.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtButceonayaciklama.LabelText = "Onay Açıklaması";
            this.txtButceonayaciklama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtButceonayaciklama.LabelTop = 3;
            this.txtButceonayaciklama.LabelVisible = true;
            this.txtButceonayaciklama.LabelWith = 100;
            this.txtButceonayaciklama.Location = new System.Drawing.Point(125, 73);
            this.txtButceonayaciklama.Name = "txtButceonayaciklama";
            this.txtButceonayaciklama.NumericBox = false;
            this.txtButceonayaciklama.NumericDecimal = 0;
            this.txtButceonayaciklama.ReferansTip = 0;
            this.txtButceonayaciklama.Required = false;
            this.txtButceonayaciklama.RequiredPass = true;
            this.txtButceonayaciklama.Size = new System.Drawing.Size(525, 20);
            this.txtButceonayaciklama.TabIndex = 11;
            this.txtButceonayaciklama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtButceonayaciklama.WordWrap = false;
            // 
            // txtButceonaytarihi
            // 
            this.txtButceonaytarihi.CustomFormat = "dd.MM.yyyy";
            this.txtButceonaytarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtButceonaytarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtButceonaytarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtButceonaytarihi.LabelText = "Onay Tarihi";
            this.txtButceonaytarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtButceonaytarihi.LabelTop = 5;
            this.txtButceonaytarihi.LabelVisible = true;
            this.txtButceonaytarihi.LabelWith = 100;
            this.txtButceonaytarihi.Location = new System.Drawing.Point(125, 47);
            this.txtButceonaytarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtButceonaytarihi.Name = "txtButceonaytarihi";
            this.txtButceonaytarihi.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtButceonaytarihi.Size = new System.Drawing.Size(200, 20);
            this.txtButceonaytarihi.TabIndex = 10;
            this.txtButceonaytarihi.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtButceonaylayan
            // 
            this.txtButceonaylayan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtButceonaylayan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtButceonaylayan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtButceonaylayan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtButceonaylayan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtButceonaylayan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtButceonaylayan.Label = null;
            this.txtButceonaylayan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtButceonaylayan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtButceonaylayan.LabelText = "Projeyi Onaylayan";
            this.txtButceonaylayan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtButceonaylayan.LabelTop = 3;
            this.txtButceonaylayan.LabelVisible = true;
            this.txtButceonaylayan.LabelWith = 100;
            this.txtButceonaylayan.Location = new System.Drawing.Point(125, 20);
            this.txtButceonaylayan.Name = "txtButceonaylayan";
            this.txtButceonaylayan.NumericBox = false;
            this.txtButceonaylayan.NumericDecimal = 0;
            this.txtButceonaylayan.ReferansTip = 0;
            this.txtButceonaylayan.Required = false;
            this.txtButceonaylayan.RequiredPass = true;
            this.txtButceonaylayan.Size = new System.Drawing.Size(200, 20);
            this.txtButceonaylayan.TabIndex = 9;
            this.txtButceonaylayan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtButceonaylayan.WordWrap = false;
            // 
            // tabProjeIslem
            // 
            this.tabProjeIslem.Controls.Add(this.GrdPersonelSure);
            this.tabProjeIslem.Location = new System.Drawing.Point(4, 22);
            this.tabProjeIslem.Name = "tabProjeIslem";
            this.tabProjeIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjeIslem.Size = new System.Drawing.Size(971, 406);
            this.tabProjeIslem.TabIndex = 5;
            this.tabProjeIslem.Text = "Proje İşlemleri";
            this.tabProjeIslem.UseVisualStyleBackColor = true;
            // 
            // GrdPersonelSure
            // 
            this.GrdPersonelSure.AllowUserToAddRows = false;
            this.GrdPersonelSure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdPersonelSure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPersonelSure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWorkDate,
            this.colPersonel,
            this.colKonum,
            this.dataGridViewComboBoxColumn1,
            this.colProjeKodu,
            this.colBaslangicSaati,
            this.colSure,
            this.colBasSaati,
            this.colBitisSaati,
            this.dataGridViewTextBoxColumn1});
            this.GrdPersonelSure.Location = new System.Drawing.Point(6, 6);
            this.GrdPersonelSure.MenuDeleteVisible = true;
            this.GrdPersonelSure.Name = "GrdPersonelSure";
            this.GrdPersonelSure.RowHeadersVisible = false;
            this.GrdPersonelSure.RowHeadersWidth = 25;
            this.GrdPersonelSure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GrdPersonelSure.Size = new System.Drawing.Size(959, 394);
            this.GrdPersonelSure.TabIndex = 2;
            // 
            // colWorkDate
            // 
            this.colWorkDate.CustomFormat = null;
            this.colWorkDate.DataPropertyName = "WORKDATE";
            dataGridViewCellStyle13.NullValue = new System.DateTime(((long)(0)));
            this.colWorkDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.colWorkDate.DefaultDate = new System.DateTime(((long)(0)));
            this.colWorkDate.HeaderText = "Çalışma Tarihi";
            this.colWorkDate.Name = "colWorkDate";
            this.colWorkDate.ReadOnly = true;
            // 
            // colPersonel
            // 
            this.colPersonel.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.colPersonel.DataPropertyName = "WORKER";
            buttonTextCell2.ErrorText = "";
            buttonTextCell2.Style = dataGridViewCellStyle15;
            buttonTextCell2.Value = "";
            buttonTextCell2.ValueType = typeof(string);
            dataGridViewCellStyle14.NullValue = buttonTextCell2;
            this.colPersonel.DefaultCellStyle = dataGridViewCellStyle14;
            this.colPersonel.HeaderText = "Personel";
            this.colPersonel.Name = "colPersonel";
            // 
            // colKonum
            // 
            this.colKonum.DataPropertyName = "STATUS";
            this.colKonum.HeaderText = "Konum/ Durum";
            this.colKonum.Name = "colKonum";
            this.colKonum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colKonum.Width = 150;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "PROCESS";
            this.dataGridViewComboBoxColumn1.HeaderText = "Görev Tipi";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.Width = 150;
            // 
            // colProjeKodu
            // 
            this.colProjeKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.colProjeKodu.DataPropertyName = "PRONUM";
            buttonTextCell3.ErrorText = "";
            buttonTextCell3.Style = dataGridViewCellStyle17;
            buttonTextCell3.Value = "";
            buttonTextCell3.ValueType = typeof(string);
            dataGridViewCellStyle16.NullValue = buttonTextCell3;
            this.colProjeKodu.DefaultCellStyle = dataGridViewCellStyle16;
            this.colProjeKodu.HeaderText = "Proje Kodu";
            this.colProjeKodu.Name = "colProjeKodu";
            this.colProjeKodu.Visible = false;
            this.colProjeKodu.Width = 120;
            // 
            // colBaslangicSaati
            // 
            this.colBaslangicSaati.DataPropertyName = "STARTTIME";
            dataGridViewCellStyle18.Format = "t";
            dataGridViewCellStyle18.NullValue = "00:00";
            this.colBaslangicSaati.DefaultCellStyle = dataGridViewCellStyle18;
            this.colBaslangicSaati.HeaderText = "Başlangıç Saati";
            this.colBaslangicSaati.MaxInputLength = 8;
            this.colBaslangicSaati.Name = "colBaslangicSaati";
            this.colBaslangicSaati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBaslangicSaati.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBaslangicSaati.Width = 90;
            // 
            // colSure
            // 
            this.colSure.DataPropertyName = "DURATION";
            this.colSure.DecimalPlace = 1;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = "0";
            this.colSure.DefaultCellStyle = dataGridViewCellStyle19;
            this.colSure.HeaderText = "Süre";
            this.colSure.Name = "colSure";
            this.colSure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSure.Width = 50;
            // 
            // colBasSaati
            // 
            this.colBasSaati.DataPropertyName = "STARTTIME";
            dataGridViewCellStyle20.Format = "t";
            dataGridViewCellStyle20.NullValue = null;
            this.colBasSaati.DefaultCellStyle = dataGridViewCellStyle20;
            this.colBasSaati.HeaderText = "Başlama Saati";
            this.colBasSaati.Name = "colBasSaati";
            this.colBasSaati.Visible = false;
            // 
            // colBitisSaati
            // 
            this.colBitisSaati.DataPropertyName = "STOPTIME";
            dataGridViewCellStyle21.Format = "t";
            dataGridViewCellStyle21.NullValue = "00:00";
            this.colBitisSaati.DefaultCellStyle = dataGridViewCellStyle21;
            this.colBitisSaati.HeaderText = "Bitiş Saati";
            this.colBitisSaati.MaxInputLength = 8;
            this.colBitisSaati.Name = "colBitisSaati";
            this.colBitisSaati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBitisSaati.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBitisSaati.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DESCRIPTION";
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn1.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // tabProjeBitis
            // 
            this.tabProjeBitis.Controls.Add(this.cbKapanisDurum);
            this.tabProjeBitis.Controls.Add(this.txtKapanisNotu);
            this.tabProjeBitis.Controls.Add(this.txtKapanisHzTarihi);
            this.tabProjeBitis.Controls.Add(this.txtKapanisHazirlayan);
            this.tabProjeBitis.Controls.Add(this.txtKapanisTarihi);
            this.tabProjeBitis.Controls.Add(this.txtKapanisOnaylayan);
            this.tabProjeBitis.Location = new System.Drawing.Point(4, 22);
            this.tabProjeBitis.Name = "tabProjeBitis";
            this.tabProjeBitis.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjeBitis.Size = new System.Drawing.Size(971, 406);
            this.tabProjeBitis.TabIndex = 6;
            this.tabProjeBitis.Text = "Proje Bitiş Onayı";
            this.tabProjeBitis.UseVisualStyleBackColor = true;
            // 
            // cbKapanisDurum
            // 
            this.cbKapanisDurum.AutoSize = true;
            this.cbKapanisDurum.Enabled = false;
            this.cbKapanisDurum.Location = new System.Drawing.Point(128, 88);
            this.cbKapanisDurum.Name = "cbKapanisDurum";
            this.cbKapanisDurum.Size = new System.Drawing.Size(93, 17);
            this.cbKapanisDurum.TabIndex = 21;
            this.cbKapanisDurum.Text = "Proje Kapatıldı";
            this.cbKapanisDurum.UseVisualStyleBackColor = true;
            // 
            // txtKapanisNotu
            // 
            this.txtKapanisNotu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKapanisNotu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKapanisNotu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKapanisNotu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKapanisNotu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKapanisNotu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKapanisNotu.Label = null;
            this.txtKapanisNotu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKapanisNotu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKapanisNotu.LabelText = "Kapanışı Notu";
            this.txtKapanisNotu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKapanisNotu.LabelTop = 3;
            this.txtKapanisNotu.LabelVisible = true;
            this.txtKapanisNotu.LabelWith = 100;
            this.txtKapanisNotu.Location = new System.Drawing.Point(128, 167);
            this.txtKapanisNotu.Name = "txtKapanisNotu";
            this.txtKapanisNotu.NumericBox = false;
            this.txtKapanisNotu.NumericDecimal = 0;
            this.txtKapanisNotu.ReferansTip = 0;
            this.txtKapanisNotu.Required = false;
            this.txtKapanisNotu.RequiredPass = true;
            this.txtKapanisNotu.Size = new System.Drawing.Size(704, 20);
            this.txtKapanisNotu.TabIndex = 20;
            this.txtKapanisNotu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKapanisNotu.WordWrap = false;
            // 
            // txtKapanisHzTarihi
            // 
            this.txtKapanisHzTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtKapanisHzTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtKapanisHzTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKapanisHzTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKapanisHzTarihi.LabelText = "Değiştirme Tarihi";
            this.txtKapanisHzTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtKapanisHzTarihi.LabelTop = 5;
            this.txtKapanisHzTarihi.LabelVisible = true;
            this.txtKapanisHzTarihi.LabelWith = 100;
            this.txtKapanisHzTarihi.Location = new System.Drawing.Point(632, 51);
            this.txtKapanisHzTarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtKapanisHzTarihi.Name = "txtKapanisHzTarihi";
            this.txtKapanisHzTarihi.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtKapanisHzTarihi.Size = new System.Drawing.Size(200, 20);
            this.txtKapanisHzTarihi.TabIndex = 18;
            this.txtKapanisHzTarihi.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtKapanisHazirlayan
            // 
            this.txtKapanisHazirlayan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKapanisHazirlayan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKapanisHazirlayan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKapanisHazirlayan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKapanisHazirlayan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKapanisHazirlayan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKapanisHazirlayan.Label = null;
            this.txtKapanisHazirlayan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKapanisHazirlayan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKapanisHazirlayan.LabelText = "Kapanışı Hazırlayan";
            this.txtKapanisHazirlayan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKapanisHazirlayan.LabelTop = 3;
            this.txtKapanisHazirlayan.LabelVisible = true;
            this.txtKapanisHazirlayan.LabelWith = 100;
            this.txtKapanisHazirlayan.Location = new System.Drawing.Point(632, 24);
            this.txtKapanisHazirlayan.Name = "txtKapanisHazirlayan";
            this.txtKapanisHazirlayan.NumericBox = false;
            this.txtKapanisHazirlayan.NumericDecimal = 0;
            this.txtKapanisHazirlayan.ReferansTip = 0;
            this.txtKapanisHazirlayan.Required = false;
            this.txtKapanisHazirlayan.RequiredPass = true;
            this.txtKapanisHazirlayan.Size = new System.Drawing.Size(200, 20);
            this.txtKapanisHazirlayan.TabIndex = 17;
            this.txtKapanisHazirlayan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKapanisHazirlayan.WordWrap = false;
            // 
            // txtKapanisTarihi
            // 
            this.txtKapanisTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtKapanisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtKapanisTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKapanisTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKapanisTarihi.LabelText = "Onay Tarihi";
            this.txtKapanisTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtKapanisTarihi.LabelTop = 5;
            this.txtKapanisTarihi.LabelVisible = true;
            this.txtKapanisTarihi.LabelWith = 100;
            this.txtKapanisTarihi.Location = new System.Drawing.Point(128, 51);
            this.txtKapanisTarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.txtKapanisTarihi.Name = "txtKapanisTarihi";
            this.txtKapanisTarihi.NullDate = BaseControls.Forms.NullDateValue.MinDate;
            this.txtKapanisTarihi.Size = new System.Drawing.Size(200, 20);
            this.txtKapanisTarihi.TabIndex = 14;
            this.txtKapanisTarihi.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtKapanisOnaylayan
            // 
            this.txtKapanisOnaylayan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKapanisOnaylayan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKapanisOnaylayan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKapanisOnaylayan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKapanisOnaylayan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKapanisOnaylayan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKapanisOnaylayan.Label = null;
            this.txtKapanisOnaylayan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKapanisOnaylayan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKapanisOnaylayan.LabelText = "Kapanışı Onaylayan";
            this.txtKapanisOnaylayan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKapanisOnaylayan.LabelTop = 3;
            this.txtKapanisOnaylayan.LabelVisible = true;
            this.txtKapanisOnaylayan.LabelWith = 100;
            this.txtKapanisOnaylayan.Location = new System.Drawing.Point(128, 24);
            this.txtKapanisOnaylayan.Name = "txtKapanisOnaylayan";
            this.txtKapanisOnaylayan.NumericBox = false;
            this.txtKapanisOnaylayan.NumericDecimal = 0;
            this.txtKapanisOnaylayan.ReferansTip = 0;
            this.txtKapanisOnaylayan.Required = false;
            this.txtKapanisOnaylayan.RequiredPass = true;
            this.txtKapanisOnaylayan.Size = new System.Drawing.Size(200, 20);
            this.txtKapanisOnaylayan.TabIndex = 13;
            this.txtKapanisOnaylayan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKapanisOnaylayan.WordWrap = false;
            // 
            // tabProjeDosyalar
            // 
            this.tabProjeDosyalar.Controls.Add(this.bC_GroupBox2);
            this.tabProjeDosyalar.Location = new System.Drawing.Point(4, 22);
            this.tabProjeDosyalar.Name = "tabProjeDosyalar";
            this.tabProjeDosyalar.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjeDosyalar.Size = new System.Drawing.Size(971, 406);
            this.tabProjeDosyalar.TabIndex = 8;
            this.tabProjeDosyalar.Text = "Proje Dosyaları";
            this.tabProjeDosyalar.UseVisualStyleBackColor = true;
            // 
            // bC_GroupBox2
            // 
            this.bC_GroupBox2.Controls.Add(this.txtSecilenDosya);
            this.bC_GroupBox2.Controls.Add(this.btnDosyaSil);
            this.bC_GroupBox2.Controls.Add(this.btnDosyaEkle);
            this.bC_GroupBox2.Controls.Add(this.btnDosyaAc);
            this.bC_GroupBox2.Controls.Add(this.GrdDosyalar);
            this.bC_GroupBox2.Location = new System.Drawing.Point(20, 18);
            this.bC_GroupBox2.Name = "bC_GroupBox2";
            this.bC_GroupBox2.Size = new System.Drawing.Size(800, 344);
            this.bC_GroupBox2.TabIndex = 27;
            this.bC_GroupBox2.TabStop = false;
            this.bC_GroupBox2.Text = " Kayıtlı Dosyalar ";
            // 
            // txtSecilenDosya
            // 
            this.txtSecilenDosya.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecilenDosya.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSecilenDosya.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSecilenDosya.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSecilenDosya.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSecilenDosya.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSecilenDosya.Label = null;
            this.txtSecilenDosya.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilenDosya.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSecilenDosya.LabelText = "Seçili Dosya";
            this.txtSecilenDosya.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSecilenDosya.LabelTop = 3;
            this.txtSecilenDosya.LabelVisible = true;
            this.txtSecilenDosya.LabelWith = 100;
            this.txtSecilenDosya.Location = new System.Drawing.Point(114, 303);
            this.txtSecilenDosya.Name = "txtSecilenDosya";
            this.txtSecilenDosya.NumericBox = false;
            this.txtSecilenDosya.NumericDecimal = 0;
            this.txtSecilenDosya.ReferansTip = 0;
            this.txtSecilenDosya.Required = false;
            this.txtSecilenDosya.RequiredPass = true;
            this.txtSecilenDosya.Size = new System.Drawing.Size(320, 20);
            this.txtSecilenDosya.TabIndex = 29;
            this.txtSecilenDosya.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSecilenDosya.WordWrap = false;
            // 
            // btnCLRFL
            // 
            this.btnDosyaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaSil.Image")));
            this.btnDosyaSil.Location = new System.Drawing.Point(590, 300);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(95, 24);
            this.btnDosyaSil.TabIndex = 27;
            this.btnDosyaSil.Text = "Dosya Sil";
            this.btnDosyaSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaEkle.Image")));
            this.btnDosyaEkle.Location = new System.Drawing.Point(691, 300);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(95, 24);
            this.btnDosyaEkle.TabIndex = 25;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaAc.Image")));
            this.btnDosyaAc.Location = new System.Drawing.Point(459, 301);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(112, 24);
            this.btnDosyaAc.TabIndex = 26;
            this.btnDosyaAc.Text = "Dosyayı Aç";
            this.btnDosyaAc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDosyaAc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // GrdDosyalar
            // 
            this.GrdDosyalar.AllowUserToAddRows = false;
            this.GrdDosyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDosyalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDosyaKaynak,
            this.colFILENAME,
            this.colTYPE,
            this.colUSERNAME,
            this.colDate});
            this.GrdDosyalar.Location = new System.Drawing.Point(17, 19);
            this.GrdDosyalar.MenuDeleteVisible = true;
            this.GrdDosyalar.Name = "GrdDosyalar";
            this.GrdDosyalar.ReadOnly = true;
            this.GrdDosyalar.RowHeadersWidth = 25;
            this.GrdDosyalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDosyalar.Size = new System.Drawing.Size(769, 275);
            this.GrdDosyalar.TabIndex = 25;
            this.GrdDosyalar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDosyalar_RowEnter);
            // 
            // colDosyaKaynak
            // 
            this.colDosyaKaynak.DataPropertyName = "SOURCE";
            this.colDosyaKaynak.HeaderText = "Kaynak";
            this.colDosyaKaynak.Name = "colDosyaKaynak";
            this.colDosyaKaynak.ReadOnly = true;
            this.colDosyaKaynak.Width = 120;
            // 
            // colFILENAME
            // 
            this.colFILENAME.DataPropertyName = "FILENAME";
            this.colFILENAME.HeaderText = "Dosya Adı";
            this.colFILENAME.Name = "colFILENAME";
            this.colFILENAME.ReadOnly = true;
            this.colFILENAME.Width = 350;
            // 
            // colTYPE
            // 
            this.colTYPE.DataPropertyName = "TYPE";
            this.colTYPE.HeaderText = "Uzantı";
            this.colTYPE.Name = "colTYPE";
            this.colTYPE.ReadOnly = true;
            this.colTYPE.Width = 50;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.DataPropertyName = "USERNAME";
            this.colUSERNAME.HeaderText = "Kaydeden";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DATE";
            this.colDate.HeaderText = "Kayıt Tarihi";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // tabAnaliz
            // 
            this.tabAnaliz.Location = new System.Drawing.Point(4, 22);
            this.tabAnaliz.Name = "tabAnaliz";
            this.tabAnaliz.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnaliz.Size = new System.Drawing.Size(971, 406);
            this.tabAnaliz.TabIndex = 7;
            this.tabAnaliz.Text = "Analiz";
            this.tabAnaliz.UseVisualStyleBackColor = true;
            // 
            // tabYonetici
            // 
            this.tabYonetici.Controls.Add(this.txtSatisTutar);
            this.tabYonetici.Controls.Add(this.txtTotalMaliyet);
            this.tabYonetici.Controls.Add(this.bC_Label3);
            this.tabYonetici.Controls.Add(this.txtLogs);
            this.tabYonetici.Controls.Add(this.btnSorumluDegistir);
            this.tabYonetici.Controls.Add(this.txtProjeSorumlusu2);
            this.tabYonetici.Controls.Add(this.txtYeniStatu);
            this.tabYonetici.Controls.Add(this.btnStatuDegistir);
            this.tabYonetici.Location = new System.Drawing.Point(4, 22);
            this.tabYonetici.Name = "tabYonetici";
            this.tabYonetici.Size = new System.Drawing.Size(971, 406);
            this.tabYonetici.TabIndex = 9;
            this.tabYonetici.Text = "Yönetici";
            this.tabYonetici.UseVisualStyleBackColor = true;
            this.tabYonetici.Click += new System.EventHandler(this.tabYonetici_Click);
            this.tabYonetici.Enter += new System.EventHandler(this.tabYonetici_Click);
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSatisTutar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSatisTutar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSatisTutar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSatisTutar.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSatisTutar.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSatisTutar.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSatisTutar.Label = null;
            this.txtSatisTutar.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisTutar.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSatisTutar.LabelText = "Satış Tutar (TL)";
            this.txtSatisTutar.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSatisTutar.LabelTop = 3;
            this.txtSatisTutar.LabelVisible = true;
            this.txtSatisTutar.LabelWith = 120;
            this.txtSatisTutar.Location = new System.Drawing.Point(843, 20);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.NumericBox = false;
            this.txtSatisTutar.NumericDecimal = 2;
            this.txtSatisTutar.ReferansTip = 0;
            this.txtSatisTutar.Required = false;
            this.txtSatisTutar.RequiredPass = true;
            this.txtSatisTutar.Size = new System.Drawing.Size(100, 20);
            this.txtSatisTutar.TabIndex = 24;
            this.txtSatisTutar.Text = "0,00";
            this.txtSatisTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSatisTutar.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSatisTutar.WordWrap = false;
            // 
            // txtTotalMaliyet
            // 
            this.txtTotalMaliyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMaliyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalMaliyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTotalMaliyet.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTotalMaliyet.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTotalMaliyet.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTotalMaliyet.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTotalMaliyet.Label = null;
            this.txtTotalMaliyet.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalMaliyet.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalMaliyet.LabelText = "Toplam Maliyet (TL)";
            this.txtTotalMaliyet.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTotalMaliyet.LabelTop = 3;
            this.txtTotalMaliyet.LabelVisible = true;
            this.txtTotalMaliyet.LabelWith = 120;
            this.txtTotalMaliyet.Location = new System.Drawing.Point(843, 46);
            this.txtTotalMaliyet.Name = "txtTotalMaliyet";
            this.txtTotalMaliyet.NumericBox = false;
            this.txtTotalMaliyet.NumericDecimal = 2;
            this.txtTotalMaliyet.ReferansTip = 0;
            this.txtTotalMaliyet.Required = false;
            this.txtTotalMaliyet.RequiredPass = true;
            this.txtTotalMaliyet.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMaliyet.TabIndex = 22;
            this.txtTotalMaliyet.Text = "0,00";
            this.txtTotalMaliyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalMaliyet.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTotalMaliyet.WordWrap = false;
            // 
            // bC_Label3
            // 
            this.bC_Label3.AutoSize = true;
            this.bC_Label3.Location = new System.Drawing.Point(25, 110);
            this.bC_Label3.Name = "bC_Label3";
            this.bC_Label3.Size = new System.Drawing.Size(36, 13);
            this.bC_Label3.TabIndex = 17;
            this.bC_Label3.Text = "Loglar";
            // 
            // txtLogs
            // 
            this.txtLogs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLogs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLogs.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLogs.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtLogs.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtLogs.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtLogs.Label = null;
            this.txtLogs.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLogs.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogs.LabelText = null;
            this.txtLogs.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtLogs.LabelTop = 3;
            this.txtLogs.LabelVisible = true;
            this.txtLogs.LabelWith = 100;
            this.txtLogs.Location = new System.Drawing.Point(25, 129);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.NumericBox = false;
            this.txtLogs.NumericDecimal = 0;
            this.txtLogs.ReferansTip = 0;
            this.txtLogs.Required = false;
            this.txtLogs.RequiredPass = true;
            this.txtLogs.Size = new System.Drawing.Size(918, 260);
            this.txtLogs.TabIndex = 15;
            this.txtLogs.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtLogs.WordWrap = false;
            // 
            // btnSorumluDegistir
            // 
            this.btnSorumluDegistir.Enabled = false;
            this.btnSorumluDegistir.Location = new System.Drawing.Point(378, 20);
            this.btnSorumluDegistir.Name = "btnSorumluDegistir";
            this.btnSorumluDegistir.Size = new System.Drawing.Size(315, 28);
            this.btnSorumluDegistir.TabIndex = 12;
            this.btnSorumluDegistir.Text = "Proje Sorumlusunu Değiştir";
            this.btnSorumluDegistir.UseVisualStyleBackColor = true;
            this.btnSorumluDegistir.Click += new System.EventHandler(this.btnSorumluDegistir_Click);
            // 
            // txtProjeSorumlusu2
            // 
            this.txtProjeSorumlusu2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeSorumlusu2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeSorumlusu2.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeSorumlusu2.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeSorumlusu2.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeSorumlusu2.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtProjeSorumlusu2.Label = null;
            this.txtProjeSorumlusu2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeSorumlusu2.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeSorumlusu2.LabelText = "Proje Sorumlusu";
            this.txtProjeSorumlusu2.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeSorumlusu2.LabelTop = 3;
            this.txtProjeSorumlusu2.LabelVisible = true;
            this.txtProjeSorumlusu2.LabelWith = 100;
            this.txtProjeSorumlusu2.Location = new System.Drawing.Point(476, 54);
            this.txtProjeSorumlusu2.Name = "txtProjeSorumlusu2";
            this.txtProjeSorumlusu2.NumericBox = false;
            this.txtProjeSorumlusu2.NumericDecimal = 0;
            this.txtProjeSorumlusu2.ReferansTip = 0;
            this.txtProjeSorumlusu2.Required = false;
            this.txtProjeSorumlusu2.RequiredPass = true;
            this.txtProjeSorumlusu2.Size = new System.Drawing.Size(217, 20);
            this.txtProjeSorumlusu2.TabIndex = 11;
            this.txtProjeSorumlusu2.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeSorumlusu2.WordWrap = false;
            this.txtProjeSorumlusu2.ButtonClick += new System.EventHandler(this.txtProjeSorumlusu2_ButtonClick);
            // 
            // txtYeniStatu
            // 
            this.txtYeniStatu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtYeniStatu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtYeniStatu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtYeniStatu.FormattingEnabled = true;
            this.txtYeniStatu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniStatu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYeniStatu.LabelText = null;
            this.txtYeniStatu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtYeniStatu.LabelTop = 4;
            this.txtYeniStatu.LabelVisible = false;
            this.txtYeniStatu.LabelWith = 100;
            this.txtYeniStatu.Location = new System.Drawing.Point(25, 54);
            this.txtYeniStatu.Name = "txtYeniStatu";
            this.txtYeniStatu.Size = new System.Drawing.Size(315, 21);
            this.txtYeniStatu.TabIndex = 7;
            this.txtYeniStatu.Enter += new System.EventHandler(this.txtYeniStatu_Enter);
            // 
            // btnStatuDegistir
            // 
            this.btnStatuDegistir.Enabled = false;
            this.btnStatuDegistir.Location = new System.Drawing.Point(25, 20);
            this.btnStatuDegistir.Name = "btnStatuDegistir";
            this.btnStatuDegistir.Size = new System.Drawing.Size(315, 28);
            this.btnStatuDegistir.TabIndex = 6;
            this.btnStatuDegistir.Text = "Proje Statüsünü Değiştir";
            this.btnStatuDegistir.UseVisualStyleBackColor = true;
            this.btnStatuDegistir.Click += new System.EventHandler(this.btnStatuDegistir_Click);
            // 
            // bC_GroupBox1
            // 
            this.bC_GroupBox1.Controls.Add(this.txtProjeStatu);
            this.bC_GroupBox1.Controls.Add(this.txtProjeTipi);
            this.bC_GroupBox1.Controls.Add(this.txtTalepTarihi);
            this.bC_GroupBox1.Controls.Add(this.txtTeslimTarihi);
            this.bC_GroupBox1.Controls.Add(this.txtProjeadi);
            this.bC_GroupBox1.Controls.Add(this.txtProjekodu);
            this.bC_GroupBox1.Location = new System.Drawing.Point(13, 13);
            this.bC_GroupBox1.Name = "bC_GroupBox1";
            this.bC_GroupBox1.Size = new System.Drawing.Size(979, 81);
            this.bC_GroupBox1.TabIndex = 0;
            this.bC_GroupBox1.TabStop = false;
            // 
            // txtProjeStatu
            // 
            this.txtProjeStatu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeStatu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeStatu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeStatu.FormattingEnabled = true;
            this.txtProjeStatu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeStatu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeStatu.LabelText = "Statü";
            this.txtProjeStatu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeStatu.LabelTop = 4;
            this.txtProjeStatu.LabelVisible = true;
            this.txtProjeStatu.LabelWith = 60;
            this.txtProjeStatu.Location = new System.Drawing.Point(782, 18);
            this.txtProjeStatu.Name = "txtProjeStatu";
            this.txtProjeStatu.Size = new System.Drawing.Size(180, 21);
            this.txtProjeStatu.TabIndex = 91;
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
            this.txtProjeTipi.LabelWith = 80;
            this.txtProjeTipi.Location = new System.Drawing.Point(317, 17);
            this.txtProjeTipi.Name = "txtProjeTipi";
            this.txtProjeTipi.NumericBox = false;
            this.txtProjeTipi.NumericDecimal = 0;
            this.txtProjeTipi.ReferansTip = 0;
            this.txtProjeTipi.Required = false;
            this.txtProjeTipi.RequiredPass = true;
            this.txtProjeTipi.Size = new System.Drawing.Size(165, 20);
            this.txtProjeTipi.TabIndex = 90;
            this.txtProjeTipi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeTipi.WordWrap = false;
            // 
            // txtTalepTarihi
            // 
            this.txtTalepTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtTalepTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTalepTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepTarihi.LabelText = "Talep Tarihi";
            this.txtTalepTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTalepTarihi.LabelTop = 5;
            this.txtTalepTarihi.LabelVisible = true;
            this.txtTalepTarihi.LabelWith = 80;
            this.txtTalepTarihi.Location = new System.Drawing.Point(575, 18);
            this.txtTalepTarihi.Name = "txtTalepTarihi";
            this.txtTalepTarihi.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtTalepTarihi.Size = new System.Drawing.Size(122, 20);
            this.txtTalepTarihi.TabIndex = 88;
            this.txtTalepTarihi.Value = new System.DateTime(2019, 1, 17, 0, 0, 0, 0);
            // 
            // txtTeslimTarihi
            // 
            this.txtTeslimTarihi.CustomFormat = "dd.MM.yyyy";
            this.txtTeslimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTeslimTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTeslimTarihi.LabelText = "Teslim Tarihi";
            this.txtTeslimTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTeslimTarihi.LabelTop = 5;
            this.txtTeslimTarihi.LabelVisible = true;
            this.txtTeslimTarihi.LabelWith = 80;
            this.txtTeslimTarihi.Location = new System.Drawing.Point(575, 44);
            this.txtTeslimTarihi.Name = "txtTeslimTarihi";
            this.txtTeslimTarihi.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtTeslimTarihi.Size = new System.Drawing.Size(122, 20);
            this.txtTeslimTarihi.TabIndex = 89;
            this.txtTeslimTarihi.Value = new System.DateTime(2019, 1, 17, 0, 0, 0, 0);
            // 
            // txtProjeadi
            // 
            this.txtProjeadi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeadi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeadi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeadi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeadi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeadi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeadi.Label = null;
            this.txtProjeadi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeadi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeadi.LabelText = "Proje Adı";
            this.txtProjeadi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeadi.LabelTop = 3;
            this.txtProjeadi.LabelVisible = true;
            this.txtProjeadi.LabelWith = 80;
            this.txtProjeadi.Location = new System.Drawing.Point(89, 44);
            this.txtProjeadi.Name = "txtProjeadi";
            this.txtProjeadi.NumericBox = false;
            this.txtProjeadi.NumericDecimal = 0;
            this.txtProjeadi.ReferansTip = 0;
            this.txtProjeadi.Required = false;
            this.txtProjeadi.RequiredPass = true;
            this.txtProjeadi.Size = new System.Drawing.Size(393, 20);
            this.txtProjeadi.TabIndex = 87;
            this.txtProjeadi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeadi.WordWrap = false;
            // 
            // txtProjekodu
            // 
            this.txtProjekodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjekodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjekodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjekodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjekodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjekodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjekodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjekodu.Label = null;
            this.txtProjekodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjekodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjekodu.LabelText = "Proje No";
            this.txtProjekodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjekodu.LabelTop = 3;
            this.txtProjekodu.LabelVisible = true;
            this.txtProjekodu.LabelWith = 80;
            this.txtProjekodu.Location = new System.Drawing.Point(89, 17);
            this.txtProjekodu.Name = "txtProjekodu";
            this.txtProjekodu.NumericBox = false;
            this.txtProjekodu.NumericDecimal = 0;
            this.txtProjekodu.ReferansTip = 0;
            this.txtProjekodu.Required = false;
            this.txtProjekodu.RequiredPass = true;
            this.txtProjekodu.Size = new System.Drawing.Size(117, 20);
            this.txtProjekodu.TabIndex = 86;
            this.txtProjekodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjekodu.WordWrap = false;
            // 
            // txtKarMarji
            // 
            this.txtKarMarji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKarMarji.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKarMarji.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKarMarji.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKarMarji.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKarMarji.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKarMarji.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKarMarji.Label = null;
            this.txtKarMarji.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKarMarji.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKarMarji.LabelText = "Kar Marjı (TL)";
            this.txtKarMarji.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKarMarji.LabelTop = 3;
            this.txtKarMarji.LabelVisible = true;
            this.txtKarMarji.LabelWith = 120;
            this.txtKarMarji.Location = new System.Drawing.Point(130, 381);
            this.txtKarMarji.Name = "txtKarMarji";
            this.txtKarMarji.NumericBox = false;
            this.txtKarMarji.NumericDecimal = 2;
            this.txtKarMarji.ReferansTip = 0;
            this.txtKarMarji.Required = false;
            this.txtKarMarji.RequiredPass = true;
            this.txtKarMarji.Size = new System.Drawing.Size(100, 20);
            this.txtKarMarji.TabIndex = 28;
            this.txtKarMarji.Text = "0,00";
            this.txtKarMarji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKarMarji.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKarMarji.WordWrap = false;
            // 
            // btnEkKarGuncelle
            // 
            this.btnEkKarGuncelle.Image = global::ALPARGE.Properties.Resources.save;
            this.btnEkKarGuncelle.Location = new System.Drawing.Point(236, 380);
            this.btnEkKarGuncelle.Name = "btnEkKarGuncelle";
            this.btnEkKarGuncelle.Size = new System.Drawing.Size(28, 23);
            this.btnEkKarGuncelle.TabIndex = 29;
            this.btnEkKarGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkKarGuncelle.UseVisualStyleBackColor = true;
            this.btnEkKarGuncelle.Click += new System.EventHandler(this.btnEkKarGuncelle_Click);
            // 
            // FrmProjeKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 560);
            this.Controls.Add(this.tabProjects);
            this.Controls.Add(this.bC_GroupBox1);
            this.FormCode = "PROJEKARTI";
            this.FormName = "Proje Kartı";
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.Name = "FrmProjeKart";
            this.Text = "Proje Kartı";
            this.Load += new System.EventHandler(this.FrmProjeKart_Load);
            this.tabProjects.ResumeLayout(false);
            this.tabTalep.ResumeLayout(false);
            this.tabTalep.PerformLayout();
            this.tabOnOnay.ResumeLayout(false);
            this.tabOnOnay.PerformLayout();
            this.tabProjeSorumlusu.ResumeLayout(false);
            this.tabProjeSorumlusu.PerformLayout();
            this.tabButcePlan.ResumeLayout(false);
            this.tabButcePlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlan)).EndInit();
            this.tabButceOnay.ResumeLayout(false);
            this.tabButceOnay.PerformLayout();
            this.tabProjeIslem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPersonelSure)).EndInit();
            this.tabProjeBitis.ResumeLayout(false);
            this.tabProjeBitis.PerformLayout();
            this.tabProjeDosyalar.ResumeLayout(false);
            this.bC_GroupBox2.ResumeLayout(false);
            this.bC_GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDosyalar)).EndInit();
            this.tabYonetici.ResumeLayout(false);
            this.tabYonetici.PerformLayout();
            this.bC_GroupBox1.ResumeLayout(false);
            this.bC_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_GroupBox bC_GroupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BaseControls.BC_ComboBox txtProjeStatu;
        private BaseControls.BC_TextBox txtProjeTipi;
        private BaseControls.Forms.BC_DateTime txtTalepTarihi;
        private BaseControls.Forms.BC_DateTime txtTeslimTarihi;
        private BaseControls.BC_TextBox txtProjeadi;
        private BaseControls.BC_TextBox txtProjekodu;
        private BaseControls.Forms.BC_TabControl tabProjects;
        private System.Windows.Forms.TabPage tabTalep;
        private BaseControls.BC_TextBox txtTesisKodu;
        private BaseControls.BC_TextBox txtCatiProje;
        private BaseControls.BC_TextBox txtTalepEden;
        private BaseControls.BC_ComboBox txtTalepSekli;
        private BaseControls.BC_TextBox txtMusteriKodu;
        private BaseControls.BC_TextBox txtMusteriAdi;
        private BaseControls.BC_TextBox txtProjeBilgi;
        private System.Windows.Forms.TabPage tabOnOnay;
        private BaseControls.BC_TextBox txtTalepOnayAciklama;
        private BaseControls.Forms.BC_DateTime txtTalepOnayTarihi;
        private BaseControls.BC_TextBox txtTalebiOnaylayan;
        private System.Windows.Forms.TabPage tabProjeSorumlusu;
        private BaseControls.BC_TextBox txtSorumluatayan;
        private BaseControls.Forms.BC_DateTime txtSorumluatamatarihi;
        private BaseControls.BC_TextBox txtProjesorumlusu;
        private System.Windows.Forms.TabPage tabButcePlan;
        private BaseControls.BC_Label bC_Label2;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_DataGrid GrdMaliyet;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaliyetTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private BaseControls.NumericTextColumn colMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirim;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDovizCinsi;
        private BaseControls.NumericTextColumn colDovizFiyat;
        private BaseControls.NumericTextColumn colDovizTutar;
        private BaseControls.NumericTextColumn colDovizKuru;
        private BaseControls.NumericTextColumn colTLTutar;
        private BaseControls.BC_DataGrid GrdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjeNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGorevTuru;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGorevTipi;
        private BaseControls.ButtonTextColumn colKaynak;
        private BaseControls.NumericTextColumn HOURS;
        private BaseControls.CalendarColumn STARTDATE;
        private BaseControls.CalendarColumn STOPDATE;
        private System.Windows.Forms.TabPage tabButceOnay;
        private BaseControls.BC_TextBox txtButceonayaciklama;
        private BaseControls.Forms.BC_DateTime txtButceonaytarihi;
        private BaseControls.BC_TextBox txtButceonaylayan;
        private System.Windows.Forms.TabPage tabProjeIslem;
        private BaseControls.BC_DataGrid GrdPersonelSure;
        private BaseControls.CalendarColumn colWorkDate;
        private BaseControls.ButtonTextColumn colPersonel;
        private BaseControls.TextBoxButtonColumn colKonum;
        private BaseControls.TextBoxButtonColumn dataGridViewComboBoxColumn1;
        private BaseControls.ButtonTextColumn colProjeKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaslangicSaati;
        private BaseControls.NumericTextColumn colSure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBasSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabProjeBitis;
        private BaseControls.BC_CheckBox cbKapanisDurum;
        private BaseControls.BC_TextBox txtKapanisNotu;
        private BaseControls.Forms.BC_DateTime txtKapanisHzTarihi;
        private BaseControls.BC_TextBox txtKapanisHazirlayan;
        private BaseControls.Forms.BC_DateTime txtKapanisTarihi;
        private BaseControls.BC_TextBox txtKapanisOnaylayan;
        private System.Windows.Forms.TabPage tabProjeDosyalar;
        private BaseControls.BC_GroupBox bC_GroupBox2;
        private BaseControls.BC_TextBox txtSecilenDosya;
        private BaseControls.BC_Button btnDosyaSil;
        private BaseControls.BC_Button btnDosyaEkle;
        private BaseControls.BC_Button btnDosyaAc;
        private BaseControls.BC_DataGrid GrdDosyalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDosyaKaynak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFILENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.TabPage tabAnaliz;
        private System.Windows.Forms.TabPage tabYonetici;
        private BaseControls.BC_ComboBox txtYeniStatu;
        private BaseControls.BC_Button btnStatuDegistir;
        private BaseControls.BC_TextBox txtToplamMaliyet;
        private BaseControls.BC_Button btnSorumluDegistir;
        private BaseControls.BC_TextBox txtProjeSorumlusu2;
        private BaseControls.BC_Label bC_Label3;
        private BaseControls.BC_TextBox txtLogs;
        private BaseControls.BC_TextBox txtIscilikMaliyeti;
        private BaseControls.BC_TextBox txtTotalMaliyet;
        private BaseControls.BC_TextBox txtSatisTutar;
        private BaseControls.BC_TextBox txtKarMarji;
        private BaseControls.BC_Button btnEkKarGuncelle;
    }
}