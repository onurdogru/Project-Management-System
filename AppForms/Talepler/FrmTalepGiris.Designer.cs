namespace ALPARGE.AppForms.Talepler
{
    partial class FrmTalepGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTalepGiris));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bC_TabControl1 = new BaseControls.Forms.BC_TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtParaBirimi = new BaseControls.BC_TextBox();
            this.txtTutar = new BaseControls.BC_TextBox();
            this.txtParcaNo = new BaseControls.BC_TextBox();
            this.txtMiktar = new BaseControls.BC_TextBox();
            this.txtElkKomp = new BaseControls.BC_TextBox();
            this.txtElkOzl = new BaseControls.BC_TextBox();
            this.txtFonkOzl = new BaseControls.BC_TextBox();
            this.bC_Label3 = new BaseControls.BC_Label();
            this.bC_Label2 = new BaseControls.BC_Label();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtCatiProje = new BaseControls.BC_TextBox();
            this.cbTesisKodu = new BaseControls.BC_ComboBox();
            this.txtTalepEden = new BaseControls.BC_TextBox();
            this.txtTalepTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtTeslimTarihi = new BaseControls.Forms.BC_DateTime();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.cbProjeTipleri = new BaseControls.BC_ComboBox();
            this.txtProjeAdi = new BaseControls.BC_TextBox();
            this.txtMusteriKodu = new BaseControls.BC_TextBox();
            this.txtTalepSekli = new BaseControls.BC_ComboBox();
            this.bC_Label9 = new BaseControls.BC_Label();
            this.txtMekOzellik = new BaseControls.BC_TextBox();
            this.txtIlgiliStand = new BaseControls.BC_TextBox();
            this.txtTemFonk = new BaseControls.BC_TextBox();
            this.txtMusteriAdi = new BaseControls.BC_TextBox();
            this.bC_Label8 = new BaseControls.BC_Label();
            this.bC_Label7 = new BaseControls.BC_Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bC_Label5 = new BaseControls.BC_Label();
            this.txtDigerTalep = new BaseControls.BC_TextBox();
            this.txtYapIslem = new BaseControls.BC_TextBox();
            this.bC_Label4 = new BaseControls.BC_Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDosyaAc = new BaseControls.BC_Button(this.components);
            this.bC_Button2 = new BaseControls.BC_Button(this.components);
            this.bC_Label10 = new BaseControls.BC_Label();
            this.bC_Label6 = new BaseControls.BC_Label();
            this.GrdDosyalar = new BaseControls.BC_DataGrid();
            this.colFILENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDosyaSil = new BaseControls.BC_Button(this.components);
            this.lbxBekleyenDosya = new BaseControls.BC_ListBox();
            this.btnDosyaEkle = new BaseControls.BC_Button(this.components);
            this.txtSeciliDosya = new BaseControls.BC_TextBox();
            this.bC_ToolBox1 = new BaseControls.BC_ToolBox();
            this.btnIptal = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bC_TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDosyalar)).BeginInit();
            this.bC_ToolBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Proje";
            this.openFileDialog1.Filter = "Metin Dosyası|*.txt|Resim Dosyası|*.jpeg";
            // 
            // bC_TabControl1
            // 
            this.bC_TabControl1.Controls.Add(this.tabPage1);
            this.bC_TabControl1.Controls.Add(this.tabPage2);
            this.bC_TabControl1.Controls.Add(this.tabPage4);
            this.bC_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bC_TabControl1.Location = new System.Drawing.Point(0, 25);
            this.bC_TabControl1.Name = "bC_TabControl1";
            this.bC_TabControl1.SelectedIndex = 0;
            this.bC_TabControl1.Size = new System.Drawing.Size(1004, 552);
            this.bC_TabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.txtParaBirimi);
            this.tabPage1.Controls.Add(this.txtTutar);
            this.tabPage1.Controls.Add(this.txtParcaNo);
            this.tabPage1.Controls.Add(this.txtMiktar);
            this.tabPage1.Controls.Add(this.txtElkKomp);
            this.tabPage1.Controls.Add(this.txtElkOzl);
            this.tabPage1.Controls.Add(this.txtFonkOzl);
            this.tabPage1.Controls.Add(this.bC_Label3);
            this.tabPage1.Controls.Add(this.bC_Label2);
            this.tabPage1.Controls.Add(this.bC_Label1);
            this.tabPage1.Controls.Add(this.txtCatiProje);
            this.tabPage1.Controls.Add(this.cbTesisKodu);
            this.tabPage1.Controls.Add(this.txtTalepEden);
            this.tabPage1.Controls.Add(this.txtTalepTarihi);
            this.tabPage1.Controls.Add(this.txtTeslimTarihi);
            this.tabPage1.Controls.Add(this.txtProjeNo);
            this.tabPage1.Controls.Add(this.cbProjeTipleri);
            this.tabPage1.Controls.Add(this.txtProjeAdi);
            this.tabPage1.Controls.Add(this.txtMusteriKodu);
            this.tabPage1.Controls.Add(this.txtTalepSekli);
            this.tabPage1.Controls.Add(this.bC_Label9);
            this.tabPage1.Controls.Add(this.txtMekOzellik);
            this.tabPage1.Controls.Add(this.txtIlgiliStand);
            this.tabPage1.Controls.Add(this.txtTemFonk);
            this.tabPage1.Controls.Add(this.txtMusteriAdi);
            this.tabPage1.Controls.Add(this.bC_Label8);
            this.tabPage1.Controls.Add(this.bC_Label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel Bilgiler   ";
            // 
            // txtParaBirimi
            // 
            this.txtParaBirimi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtParaBirimi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtParaBirimi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtParaBirimi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtParaBirimi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtParaBirimi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtParaBirimi.Label = null;
            this.txtParaBirimi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaBirimi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParaBirimi.LabelText = "Para Birimi";
            this.txtParaBirimi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtParaBirimi.LabelTop = 3;
            this.txtParaBirimi.LabelVisible = true;
            this.txtParaBirimi.LabelWith = 80;
            this.txtParaBirimi.Location = new System.Drawing.Point(622, 126);
            this.txtParaBirimi.MaxLength = 5;
            this.txtParaBirimi.Name = "txtParaBirimi";
            this.txtParaBirimi.NumericBox = false;
            this.txtParaBirimi.NumericDecimal = 0;
            this.txtParaBirimi.ReferansTip = 0;
            this.txtParaBirimi.Required = false;
            this.txtParaBirimi.RequiredPass = true;
            this.txtParaBirimi.Size = new System.Drawing.Size(73, 20);
            this.txtParaBirimi.TabIndex = 124;
            this.txtParaBirimi.Text = "TL";
            this.txtParaBirimi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtParaBirimi.WordWrap = false;
            // 
            // txtTutar
            // 
            this.txtTutar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTutar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTutar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTutar.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTutar.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTutar.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTutar.Label = null;
            this.txtTutar.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTutar.LabelText = "Toplam Tutar";
            this.txtTutar.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTutar.LabelTop = 3;
            this.txtTutar.LabelVisible = true;
            this.txtTutar.LabelWith = 80;
            this.txtTutar.Location = new System.Drawing.Point(438, 126);
            this.txtTutar.MaxLength = 16;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.NumericBox = true;
            this.txtTutar.NumericDecimal = 2;
            this.txtTutar.ReferansTip = 0;
            this.txtTutar.Required = false;
            this.txtTutar.RequiredPass = true;
            this.txtTutar.Size = new System.Drawing.Size(73, 20);
            this.txtTutar.TabIndex = 122;
            this.txtTutar.Text = "0,00";
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTutar.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTutar.WordWrap = false;
            // 
            // txtParcaNo
            // 
            this.txtParcaNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtParcaNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtParcaNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtParcaNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtParcaNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtParcaNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtParcaNo.Label = null;
            this.txtParcaNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParcaNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParcaNo.LabelText = "Parça No";
            this.txtParcaNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtParcaNo.LabelTop = 3;
            this.txtParcaNo.LabelVisible = true;
            this.txtParcaNo.LabelWith = 80;
            this.txtParcaNo.Location = new System.Drawing.Point(622, 100);
            this.txtParcaNo.Name = "txtParcaNo";
            this.txtParcaNo.NumericBox = false;
            this.txtParcaNo.NumericDecimal = 0;
            this.txtParcaNo.ReferansTip = 0;
            this.txtParcaNo.Required = false;
            this.txtParcaNo.RequiredPass = true;
            this.txtParcaNo.Size = new System.Drawing.Size(73, 20);
            this.txtParcaNo.TabIndex = 101;
            this.txtParcaNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtParcaNo.WordWrap = false;
            // 
            // txtMiktar
            // 
            this.txtMiktar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMiktar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMiktar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMiktar.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMiktar.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMiktar.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMiktar.Label = null;
            this.txtMiktar.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMiktar.LabelText = "Miktar(Adet)";
            this.txtMiktar.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMiktar.LabelTop = 3;
            this.txtMiktar.LabelVisible = true;
            this.txtMiktar.LabelWith = 80;
            this.txtMiktar.Location = new System.Drawing.Point(438, 100);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.NumericBox = false;
            this.txtMiktar.NumericDecimal = 0;
            this.txtMiktar.ReferansTip = 0;
            this.txtMiktar.Required = false;
            this.txtMiktar.RequiredPass = true;
            this.txtMiktar.Size = new System.Drawing.Size(73, 20);
            this.txtMiktar.TabIndex = 98;
            this.txtMiktar.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMiktar.WordWrap = false;
            // 
            // txtElkKomp
            // 
            this.txtElkKomp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtElkKomp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtElkKomp.BorderColor = System.Drawing.Color.DarkGray;
            this.txtElkKomp.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtElkKomp.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtElkKomp.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtElkKomp.Label = null;
            this.txtElkKomp.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElkKomp.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtElkKomp.LabelText = null;
            this.txtElkKomp.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtElkKomp.LabelTop = 3;
            this.txtElkKomp.LabelVisible = false;
            this.txtElkKomp.LabelWith = 100;
            this.txtElkKomp.Location = new System.Drawing.Point(523, 427);
            this.txtElkKomp.MaxLength = 500;
            this.txtElkKomp.Multiline = true;
            this.txtElkKomp.Name = "txtElkKomp";
            this.txtElkKomp.NumericBox = false;
            this.txtElkKomp.NumericDecimal = 0;
            this.txtElkKomp.ReferansTip = 0;
            this.txtElkKomp.Required = false;
            this.txtElkKomp.RequiredPass = true;
            this.txtElkKomp.Size = new System.Drawing.Size(450, 80);
            this.txtElkKomp.TabIndex = 80;
            this.txtElkKomp.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // txtElkOzl
            // 
            this.txtElkOzl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtElkOzl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtElkOzl.BorderColor = System.Drawing.Color.DarkGray;
            this.txtElkOzl.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtElkOzl.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtElkOzl.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtElkOzl.Label = null;
            this.txtElkOzl.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtElkOzl.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtElkOzl.LabelText = null;
            this.txtElkOzl.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtElkOzl.LabelTop = 3;
            this.txtElkOzl.LabelVisible = false;
            this.txtElkOzl.LabelWith = 100;
            this.txtElkOzl.Location = new System.Drawing.Point(523, 323);
            this.txtElkOzl.MaxLength = 500;
            this.txtElkOzl.Multiline = true;
            this.txtElkOzl.Name = "txtElkOzl";
            this.txtElkOzl.NumericBox = false;
            this.txtElkOzl.NumericDecimal = 0;
            this.txtElkOzl.ReferansTip = 0;
            this.txtElkOzl.Required = false;
            this.txtElkOzl.RequiredPass = true;
            this.txtElkOzl.Size = new System.Drawing.Size(450, 80);
            this.txtElkOzl.TabIndex = 78;
            this.txtElkOzl.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // txtFonkOzl
            // 
            this.txtFonkOzl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFonkOzl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFonkOzl.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFonkOzl.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtFonkOzl.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtFonkOzl.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtFonkOzl.Label = null;
            this.txtFonkOzl.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFonkOzl.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFonkOzl.LabelText = null;
            this.txtFonkOzl.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtFonkOzl.LabelTop = 3;
            this.txtFonkOzl.LabelVisible = false;
            this.txtFonkOzl.LabelWith = 100;
            this.txtFonkOzl.Location = new System.Drawing.Point(523, 217);
            this.txtFonkOzl.MaxLength = 500;
            this.txtFonkOzl.Multiline = true;
            this.txtFonkOzl.Name = "txtFonkOzl";
            this.txtFonkOzl.NumericBox = false;
            this.txtFonkOzl.NumericDecimal = 0;
            this.txtFonkOzl.ReferansTip = 0;
            this.txtFonkOzl.Required = false;
            this.txtFonkOzl.RequiredPass = true;
            this.txtFonkOzl.Size = new System.Drawing.Size(450, 80);
            this.txtFonkOzl.TabIndex = 76;
            this.txtFonkOzl.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // bC_Label3
            // 
            this.bC_Label3.AutoSize = true;
            this.bC_Label3.Location = new System.Drawing.Point(523, 411);
            this.bC_Label3.Name = "bC_Label3";
            this.bC_Label3.Size = new System.Drawing.Size(207, 13);
            this.bC_Label3.TabIndex = 81;
            this.bC_Label3.Text = "Elektronik komponentler ile ilgili detaylı bilgi";
            // 
            // bC_Label2
            // 
            this.bC_Label2.AutoSize = true;
            this.bC_Label2.Location = new System.Drawing.Point(523, 307);
            this.bC_Label2.Name = "bC_Label2";
            this.bC_Label2.Size = new System.Drawing.Size(98, 13);
            this.bC_Label2.TabIndex = 79;
            this.bC_Label2.Text = "Elektriksel özellikler";
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(523, 201);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(153, 13);
            this.bC_Label1.TabIndex = 77;
            this.bC_Label1.Text = "Fonksiyonel ve teknik özellikler";
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
            this.txtCatiProje.Location = new System.Drawing.Point(836, 100);
            this.txtCatiProje.Name = "txtCatiProje";
            this.txtCatiProje.NumericBox = false;
            this.txtCatiProje.NumericDecimal = 0;
            this.txtCatiProje.ReferansTip = 0;
            this.txtCatiProje.Required = false;
            this.txtCatiProje.RequiredPass = true;
            this.txtCatiProje.Size = new System.Drawing.Size(122, 20);
            this.txtCatiProje.TabIndex = 13;
            this.txtCatiProje.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtCatiProje.Visible = false;
            this.txtCatiProje.WordWrap = false;
            // 
            // cbTesisKodu
            // 
            this.cbTesisKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.cbTesisKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.cbTesisKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.cbTesisKodu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTesisKodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTesisKodu.FormattingEnabled = true;
            this.cbTesisKodu.Items.AddRange(new object[] {
            "Müşteri Talebi",
            "İşletme Talebi"});
            this.cbTesisKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTesisKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.cbTesisKodu.LabelText = "Tesis Kodu";
            this.cbTesisKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.cbTesisKodu.LabelTop = 4;
            this.cbTesisKodu.LabelVisible = true;
            this.cbTesisKodu.LabelWith = 100;
            this.cbTesisKodu.Location = new System.Drawing.Point(836, 73);
            this.cbTesisKodu.Name = "cbTesisKodu";
            this.cbTesisKodu.Size = new System.Drawing.Size(122, 21);
            this.cbTesisKodu.TabIndex = 59;
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
            this.txtTalepEden.Location = new System.Drawing.Point(836, 47);
            this.txtTalepEden.Name = "txtTalepEden";
            this.txtTalepEden.NumericBox = false;
            this.txtTalepEden.NumericDecimal = 0;
            this.txtTalepEden.ReferansTip = 0;
            this.txtTalepEden.Required = false;
            this.txtTalepEden.RequiredPass = true;
            this.txtTalepEden.Size = new System.Drawing.Size(122, 20);
            this.txtTalepEden.TabIndex = 6;
            this.txtTalepEden.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalepEden.WordWrap = false;
            // 
            // txtTalepTarihi
            // 
            this.txtTalepTarihi.CustomFormat = "dd.MM.yyyy hh:mm";
            this.txtTalepTarihi.Enabled = false;
            this.txtTalepTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTalepTarihi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepTarihi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepTarihi.LabelText = "Talep Tarihi";
            this.txtTalepTarihi.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtTalepTarihi.LabelTop = 5;
            this.txtTalepTarihi.LabelVisible = true;
            this.txtTalepTarihi.LabelWith = 100;
            this.txtTalepTarihi.Location = new System.Drawing.Point(836, 21);
            this.txtTalepTarihi.Name = "txtTalepTarihi";
            this.txtTalepTarihi.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtTalepTarihi.Size = new System.Drawing.Size(122, 20);
            this.txtTalepTarihi.TabIndex = 2;
            this.txtTalepTarihi.Value = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
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
            this.txtTeslimTarihi.Location = new System.Drawing.Point(594, 21);
            this.txtTeslimTarihi.Name = "txtTeslimTarihi";
            this.txtTeslimTarihi.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtTeslimTarihi.Size = new System.Drawing.Size(101, 20);
            this.txtTeslimTarihi.TabIndex = 11;
            this.txtTeslimTarihi.Value = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
            // 
            // txtProjeNo
            // 
            this.txtProjeNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje No";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 60;
            this.txtProjeNo.Location = new System.Drawing.Point(394, 21);
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
            // cbProjeTipleri
            // 
            this.cbProjeTipleri.BorderColor = System.Drawing.Color.DarkGray;
            this.cbProjeTipleri.BorderFocusColor = System.Drawing.Color.Maroon;
            this.cbProjeTipleri.BorderSelectColor = System.Drawing.Color.Gray;
            this.cbProjeTipleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjeTipleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProjeTipleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProjeTipleri.FormattingEnabled = true;
            this.cbProjeTipleri.Items.AddRange(new object[] {
            "Müşteri Talebi",
            "İşletme Talebi"});
            this.cbProjeTipleri.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProjeTipleri.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.cbProjeTipleri.LabelText = "Proje Tipi";
            this.cbProjeTipleri.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.cbProjeTipleri.LabelTop = 4;
            this.cbProjeTipleri.LabelVisible = true;
            this.cbProjeTipleri.LabelWith = 100;
            this.cbProjeTipleri.Location = new System.Drawing.Point(118, 20);
            this.cbProjeTipleri.Name = "cbProjeTipleri";
            this.cbProjeTipleri.Size = new System.Drawing.Size(201, 21);
            this.cbProjeTipleri.TabIndex = 61;
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
            this.txtProjeAdi.Location = new System.Drawing.Point(118, 47);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.NumericBox = false;
            this.txtProjeAdi.NumericDecimal = 0;
            this.txtProjeAdi.ReferansTip = 0;
            this.txtProjeAdi.Required = false;
            this.txtProjeAdi.RequiredPass = true;
            this.txtProjeAdi.Size = new System.Drawing.Size(577, 20);
            this.txtProjeAdi.TabIndex = 5;
            this.txtProjeAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeAdi.WordWrap = false;
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMusteriKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMusteriKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMusteriKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMusteriKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMusteriKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.OnlySelect;
            this.txtMusteriKodu.Label = null;
            this.txtMusteriKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMusteriKodu.LabelText = "Müşteri ";
            this.txtMusteriKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteriKodu.LabelTop = 3;
            this.txtMusteriKodu.LabelVisible = true;
            this.txtMusteriKodu.LabelWith = 100;
            this.txtMusteriKodu.Location = new System.Drawing.Point(118, 73);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.NumericBox = false;
            this.txtMusteriKodu.NumericDecimal = 0;
            this.txtMusteriKodu.ReadOnly = true;
            this.txtMusteriKodu.ReferansTip = 0;
            this.txtMusteriKodu.Required = false;
            this.txtMusteriKodu.RequiredPass = true;
            this.txtMusteriKodu.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriKodu.TabIndex = 9;
            this.txtMusteriKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteriKodu.WordWrap = false;
            this.txtMusteriKodu.ButtonClick += new System.EventHandler(this.txtMusteriAdi_ButtonClick);
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
            this.txtTalepSekli.Location = new System.Drawing.Point(118, 99);
            this.txtTalepSekli.Name = "txtTalepSekli";
            this.txtTalepSekli.Size = new System.Drawing.Size(201, 21);
            this.txtTalepSekli.TabIndex = 56;
            // 
            // bC_Label9
            // 
            this.bC_Label9.AutoSize = true;
            this.bC_Label9.Location = new System.Drawing.Point(19, 307);
            this.bC_Label9.Name = "bC_Label9";
            this.bC_Label9.Size = new System.Drawing.Size(96, 13);
            this.bC_Label9.TabIndex = 43;
            this.bC_Label9.Text = "Mekanik Özellikler ";
            // 
            // txtMekOzellik
            // 
            this.txtMekOzellik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMekOzellik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMekOzellik.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMekOzellik.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMekOzellik.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMekOzellik.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMekOzellik.Label = null;
            this.txtMekOzellik.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMekOzellik.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMekOzellik.LabelText = null;
            this.txtMekOzellik.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMekOzellik.LabelTop = 3;
            this.txtMekOzellik.LabelVisible = false;
            this.txtMekOzellik.LabelWith = 100;
            this.txtMekOzellik.Location = new System.Drawing.Point(19, 323);
            this.txtMekOzellik.MaxLength = 500;
            this.txtMekOzellik.Multiline = true;
            this.txtMekOzellik.Name = "txtMekOzellik";
            this.txtMekOzellik.NumericBox = false;
            this.txtMekOzellik.NumericDecimal = 0;
            this.txtMekOzellik.ReferansTip = 0;
            this.txtMekOzellik.Required = false;
            this.txtMekOzellik.RequiredPass = true;
            this.txtMekOzellik.Size = new System.Drawing.Size(450, 80);
            this.txtMekOzellik.TabIndex = 42;
            this.txtMekOzellik.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // txtIlgiliStand
            // 
            this.txtIlgiliStand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtIlgiliStand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIlgiliStand.BorderColor = System.Drawing.Color.DarkGray;
            this.txtIlgiliStand.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtIlgiliStand.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtIlgiliStand.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtIlgiliStand.Label = null;
            this.txtIlgiliStand.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlgiliStand.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIlgiliStand.LabelText = null;
            this.txtIlgiliStand.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtIlgiliStand.LabelTop = 3;
            this.txtIlgiliStand.LabelVisible = false;
            this.txtIlgiliStand.LabelWith = 100;
            this.txtIlgiliStand.Location = new System.Drawing.Point(19, 427);
            this.txtIlgiliStand.MaxLength = 500;
            this.txtIlgiliStand.Multiline = true;
            this.txtIlgiliStand.Name = "txtIlgiliStand";
            this.txtIlgiliStand.NumericBox = false;
            this.txtIlgiliStand.NumericDecimal = 0;
            this.txtIlgiliStand.ReferansTip = 0;
            this.txtIlgiliStand.Required = false;
            this.txtIlgiliStand.RequiredPass = true;
            this.txtIlgiliStand.Size = new System.Drawing.Size(450, 80);
            this.txtIlgiliStand.TabIndex = 39;
            this.txtIlgiliStand.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // txtTemFonk
            // 
            this.txtTemFonk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTemFonk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTemFonk.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTemFonk.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTemFonk.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTemFonk.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTemFonk.Label = null;
            this.txtTemFonk.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTemFonk.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTemFonk.LabelText = null;
            this.txtTemFonk.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTemFonk.LabelTop = 3;
            this.txtTemFonk.LabelVisible = false;
            this.txtTemFonk.LabelWith = 100;
            this.txtTemFonk.Location = new System.Drawing.Point(19, 217);
            this.txtTemFonk.MaxLength = 500;
            this.txtTemFonk.Multiline = true;
            this.txtTemFonk.Name = "txtTemFonk";
            this.txtTemFonk.NumericBox = false;
            this.txtTemFonk.NumericDecimal = 0;
            this.txtTemFonk.ReferansTip = 0;
            this.txtTemFonk.Required = false;
            this.txtTemFonk.RequiredPass = true;
            this.txtTemFonk.Size = new System.Drawing.Size(450, 80);
            this.txtTemFonk.TabIndex = 36;
            this.txtTemFonk.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMusteriAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMusteriAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMusteriAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMusteriAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMusteriAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.OnlySelect;
            this.txtMusteriAdi.Label = null;
            this.txtMusteriAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMusteriAdi.LabelText = "Müşteri Adı";
            this.txtMusteriAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMusteriAdi.LabelTop = 3;
            this.txtMusteriAdi.LabelVisible = false;
            this.txtMusteriAdi.LabelWith = 60;
            this.txtMusteriAdi.Location = new System.Drawing.Point(224, 73);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.NumericBox = false;
            this.txtMusteriAdi.NumericDecimal = 0;
            this.txtMusteriAdi.ReadOnly = true;
            this.txtMusteriAdi.ReferansTip = 0;
            this.txtMusteriAdi.Required = false;
            this.txtMusteriAdi.RequiredPass = true;
            this.txtMusteriAdi.Size = new System.Drawing.Size(471, 20);
            this.txtMusteriAdi.TabIndex = 25;
            this.txtMusteriAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMusteriAdi.WordWrap = false;
            this.txtMusteriAdi.ButtonClick += new System.EventHandler(this.txtMusteriAdi_ButtonClick);
            // 
            // bC_Label8
            // 
            this.bC_Label8.AutoSize = true;
            this.bC_Label8.Location = new System.Drawing.Point(19, 411);
            this.bC_Label8.Name = "bC_Label8";
            this.bC_Label8.Size = new System.Drawing.Size(81, 13);
            this.bC_Label8.TabIndex = 40;
            this.bC_Label8.Text = "İlgili Standartlar ";
            // 
            // bC_Label7
            // 
            this.bC_Label7.AutoSize = true;
            this.bC_Label7.Location = new System.Drawing.Point(19, 201);
            this.bC_Label7.Name = "bC_Label7";
            this.bC_Label7.Size = new System.Drawing.Size(149, 13);
            this.bC_Label7.TabIndex = 37;
            this.bC_Label7.Text = "Beklenen Temel Fonksiyonlar:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.bC_Label5);
            this.tabPage2.Controls.Add(this.txtDigerTalep);
            this.tabPage2.Controls.Add(this.txtYapIslem);
            this.tabPage2.Controls.Add(this.bC_Label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Özellik Bilgileri ";
            // 
            // bC_Label5
            // 
            this.bC_Label5.AutoSize = true;
            this.bC_Label5.Location = new System.Drawing.Point(13, 139);
            this.bC_Label5.Name = "bC_Label5";
            this.bC_Label5.Size = new System.Drawing.Size(91, 13);
            this.bC_Label5.TabIndex = 14;
            this.bC_Label5.Text = "Diğer özel talepler";
            // 
            // txtDigerTalep
            // 
            this.txtDigerTalep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDigerTalep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDigerTalep.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDigerTalep.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtDigerTalep.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtDigerTalep.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtDigerTalep.Label = null;
            this.txtDigerTalep.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDigerTalep.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDigerTalep.LabelText = null;
            this.txtDigerTalep.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtDigerTalep.LabelTop = 3;
            this.txtDigerTalep.LabelVisible = false;
            this.txtDigerTalep.LabelWith = 100;
            this.txtDigerTalep.Location = new System.Drawing.Point(16, 155);
            this.txtDigerTalep.MaxLength = 500;
            this.txtDigerTalep.Multiline = true;
            this.txtDigerTalep.Name = "txtDigerTalep";
            this.txtDigerTalep.NumericBox = false;
            this.txtDigerTalep.NumericDecimal = 0;
            this.txtDigerTalep.ReferansTip = 0;
            this.txtDigerTalep.Required = false;
            this.txtDigerTalep.RequiredPass = true;
            this.txtDigerTalep.Size = new System.Drawing.Size(958, 60);
            this.txtDigerTalep.TabIndex = 13;
            this.txtDigerTalep.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // txtYapIslem
            // 
            this.txtYapIslem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtYapIslem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtYapIslem.BorderColor = System.Drawing.Color.DarkGray;
            this.txtYapIslem.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtYapIslem.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtYapIslem.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtYapIslem.Label = null;
            this.txtYapIslem.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYapIslem.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtYapIslem.LabelText = null;
            this.txtYapIslem.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtYapIslem.LabelTop = 3;
            this.txtYapIslem.LabelVisible = false;
            this.txtYapIslem.LabelWith = 100;
            this.txtYapIslem.Location = new System.Drawing.Point(16, 50);
            this.txtYapIslem.MaxLength = 500;
            this.txtYapIslem.Multiline = true;
            this.txtYapIslem.Name = "txtYapIslem";
            this.txtYapIslem.NumericBox = false;
            this.txtYapIslem.NumericDecimal = 0;
            this.txtYapIslem.ReferansTip = 0;
            this.txtYapIslem.Required = false;
            this.txtYapIslem.RequiredPass = true;
            this.txtYapIslem.Size = new System.Drawing.Size(958, 60);
            this.txtYapIslem.TabIndex = 10;
            this.txtYapIslem.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            // 
            // bC_Label4
            // 
            this.bC_Label4.AutoSize = true;
            this.bC_Label4.Location = new System.Drawing.Point(13, 34);
            this.bC_Label4.Name = "bC_Label4";
            this.bC_Label4.Size = new System.Drawing.Size(102, 13);
            this.bC_Label4.TabIndex = 11;
            this.bC_Label4.Text = "Yapılacak işlem tarifi";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDosyaAc);
            this.tabPage4.Controls.Add(this.bC_Button2);
            this.tabPage4.Controls.Add(this.bC_Label10);
            this.tabPage4.Controls.Add(this.bC_Label6);
            this.tabPage4.Controls.Add(this.GrdDosyalar);
            this.tabPage4.Controls.Add(this.btnDosyaSil);
            this.tabPage4.Controls.Add(this.lbxBekleyenDosya);
            this.tabPage4.Controls.Add(this.btnDosyaEkle);
            this.tabPage4.Controls.Add(this.txtSeciliDosya);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(996, 526);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = " Eklenen Dosyalar ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.Location = new System.Drawing.Point(24, 383);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(167, 23);
            this.btnDosyaAc.TabIndex = 15;
            this.btnDosyaAc.Text = "Dosyayı Aç";
            this.btnDosyaAc.UseVisualStyleBackColor = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // bC_Button2
            // 
            this.bC_Button2.Location = new System.Drawing.Point(889, 146);
            this.bC_Button2.Name = "bC_Button2";
            this.bC_Button2.Size = new System.Drawing.Size(75, 23);
            this.bC_Button2.TabIndex = 13;
            this.bC_Button2.Text = "Save Db";
            this.bC_Button2.UseVisualStyleBackColor = true;
            this.bC_Button2.Visible = false;
            this.bC_Button2.Click += new System.EventHandler(this.bC_Button2_Click);
            // 
            // bC_Label10
            // 
            this.bC_Label10.AutoSize = true;
            this.bC_Label10.Location = new System.Drawing.Point(21, 229);
            this.bC_Label10.Name = "bC_Label10";
            this.bC_Label10.Size = new System.Drawing.Size(78, 13);
            this.bC_Label10.TabIndex = 11;
            this.bC_Label10.Text = "Kayıtlı Dosyalar";
            // 
            // bC_Label6
            // 
            this.bC_Label6.AutoSize = true;
            this.bC_Label6.Location = new System.Drawing.Point(21, 31);
            this.bC_Label6.Name = "bC_Label6";
            this.bC_Label6.Size = new System.Drawing.Size(101, 13);
            this.bC_Label6.TabIndex = 10;
            this.bC_Label6.Text = "Kuyruktaki Dosyalar";
            // 
            // GrdDosyalar
            // 
            this.GrdDosyalar.AllowUserToAddRows = false;
            this.GrdDosyalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDosyalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFILENAME,
            this.colTYPE,
            this.colUSERNAME,
            this.colDate});
            this.GrdDosyalar.Location = new System.Drawing.Point(24, 245);
            this.GrdDosyalar.MenuDeleteVisible = true;
            this.GrdDosyalar.Name = "GrdDosyalar";
            this.GrdDosyalar.RowHeadersWidth = 25;
            this.GrdDosyalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDosyalar.Size = new System.Drawing.Size(940, 131);
            this.GrdDosyalar.TabIndex = 9;
            this.GrdDosyalar.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDosyalar_RowEnter);
            this.GrdDosyalar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GrdDosyalar_MouseDoubleClick);
            // 
            // colFILENAME
            // 
            this.colFILENAME.DataPropertyName = "FILENAME";
            this.colFILENAME.HeaderText = "Dosya Adı";
            this.colFILENAME.Name = "colFILENAME";
            this.colFILENAME.Width = 300;
            // 
            // colTYPE
            // 
            this.colTYPE.DataPropertyName = "TYPE";
            this.colTYPE.HeaderText = "Uzantı";
            this.colTYPE.Name = "colTYPE";
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.DataPropertyName = "USERNAME";
            this.colUSERNAME.HeaderText = "Kaydeden";
            this.colUSERNAME.Name = "colUSERNAME";
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DATE";
            this.colDate.HeaderText = "Kayıt Tarihi";
            this.colDate.Name = "colDate";
            // 
            // btnDosyaSil
            // 
            this.btnDosyaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaSil.Image")));
            this.btnDosyaSil.Location = new System.Drawing.Point(502, 146);
            this.btnDosyaSil.Name = "btnDosyaSil";
            this.btnDosyaSil.Size = new System.Drawing.Size(107, 24);
            this.btnDosyaSil.TabIndex = 5;
            this.btnDosyaSil.Text = "Seçileni Sil";
            this.btnDosyaSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaSil.UseVisualStyleBackColor = true;
            this.btnDosyaSil.Click += new System.EventHandler(this.btnDosyaSil_Click);
            // 
            // lbxBekleyenDosya
            // 
            this.lbxBekleyenDosya.FormattingEnabled = true;
            this.lbxBekleyenDosya.Location = new System.Drawing.Point(24, 47);
            this.lbxBekleyenDosya.Name = "lbxBekleyenDosya";
            this.lbxBekleyenDosya.Size = new System.Drawing.Size(586, 95);
            this.lbxBekleyenDosya.TabIndex = 3;
            this.lbxBekleyenDosya.SelectedIndexChanged += new System.EventHandler(this.lbxBekleyDosya_SelectedIndexChanged);
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaEkle.Image")));
            this.btnDosyaEkle.Location = new System.Drawing.Point(515, 18);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(95, 24);
            this.btnDosyaEkle.TabIndex = 2;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // txtSeciliDosya
            // 
            this.txtSeciliDosya.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSeciliDosya.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSeciliDosya.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSeciliDosya.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSeciliDosya.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSeciliDosya.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSeciliDosya.Label = this.bC_Label3;
            this.txtSeciliDosya.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeciliDosya.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSeciliDosya.LabelText = "Seçili Dosya";
            this.txtSeciliDosya.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSeciliDosya.LabelTop = 3;
            this.txtSeciliDosya.LabelVisible = true;
            this.txtSeciliDosya.LabelWith = 100;
            this.txtSeciliDosya.Location = new System.Drawing.Point(121, 148);
            this.txtSeciliDosya.Name = "txtSeciliDosya";
            this.txtSeciliDosya.NumericBox = false;
            this.txtSeciliDosya.NumericDecimal = 0;
            this.txtSeciliDosya.ReferansTip = 0;
            this.txtSeciliDosya.Required = false;
            this.txtSeciliDosya.RequiredPass = true;
            this.txtSeciliDosya.Size = new System.Drawing.Size(375, 20);
            this.txtSeciliDosya.TabIndex = 0;
            this.txtSeciliDosya.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSeciliDosya.WordWrap = false;
            // 
            // bC_ToolBox1
            // 
            this.bC_ToolBox1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bC_ToolBox1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIptal,
            this.btnKaydet,
            this.toolStripLabel1});
            this.bC_ToolBox1.Location = new System.Drawing.Point(0, 0);
            this.bC_ToolBox1.Name = "bC_ToolBox1";
            this.bC_ToolBox1.Size = new System.Drawing.Size(1004, 25);
            this.bC_ToolBox1.TabIndex = 1;
            this.bC_ToolBox1.Text = "bC_ToolBox1";
            // 
            // btnIptal
            // 
            this.btnIptal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIptal.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(63, 22);
            this.btnIptal.Text = "Vazgeç";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5, 1, 10, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(69, 22);
            this.btnKaydet.Text = "Kaydet ";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(222, 22);
            this.toolStripLabel1.Text = " Talep bilgilerini eksiksiz olarak doldurun!";
            // 
            // FrmTalepGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 577);
            this.Controls.Add(this.bC_TabControl1);
            this.Controls.Add(this.bC_ToolBox1);
            this.Name = "FrmTalepGiris";
            this.Text = "Talep Girişi";
            this.Load += new System.EventHandler(this.FrmTalepGiris_Load);
            this.bC_TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDosyalar)).EndInit();
            this.bC_ToolBox1.ResumeLayout(false);
            this.bC_ToolBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_ToolBox bC_ToolBox1;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnIptal;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private BaseControls.BC_Label bC_Label5;
        private BaseControls.BC_TextBox txtDigerTalep;
        private BaseControls.BC_TextBox txtYapIslem;
        private BaseControls.BC_Label bC_Label4;
        private System.Windows.Forms.TabPage tabPage1;
        private BaseControls.BC_Label bC_Label9;
        private BaseControls.BC_TextBox txtMekOzellik;
        private BaseControls.BC_TextBox txtIlgiliStand;
        private BaseControls.BC_TextBox txtTemFonk;
        private BaseControls.BC_TextBox txtMusteriAdi;
        private BaseControls.BC_TextBox txtMusteriKodu;
        private BaseControls.BC_TextBox txtTalepEden;
        private BaseControls.BC_TextBox txtProjeAdi;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_Label bC_Label8;
        private BaseControls.BC_Label bC_Label7;
        private BaseControls.Forms.BC_DateTime txtTeslimTarihi;
        private BaseControls.Forms.BC_DateTime txtTalepTarihi;
        private BaseControls.Forms.BC_TabControl bC_TabControl1;
        private BaseControls.BC_ComboBox cbProjeTipleri;
        private BaseControls.BC_ComboBox cbTesisKodu;
        private BaseControls.BC_ComboBox txtTalepSekli;
        private BaseControls.BC_TextBox txtCatiProje;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private BaseControls.BC_TextBox txtElkKomp;
        private BaseControls.BC_TextBox txtElkOzl;
        private BaseControls.BC_TextBox txtFonkOzl;
        private BaseControls.BC_Label bC_Label3;
        private BaseControls.BC_Label bC_Label2;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_ListBox lbxBekleyenDosya;
        private BaseControls.BC_Button btnDosyaEkle;
        private BaseControls.BC_TextBox txtSeciliDosya;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BaseControls.BC_Button btnDosyaSil;
        private BaseControls.BC_Label bC_Label10;
        private BaseControls.BC_Label bC_Label6;
        private BaseControls.BC_DataGrid GrdDosyalar;
        private BaseControls.BC_Button bC_Button2;
        private BaseControls.BC_TextBox txtParcaNo;
        private BaseControls.BC_TextBox txtMiktar;
        private BaseControls.BC_Button btnDosyaAc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFILENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private BaseControls.BC_TextBox txtParaBirimi;
        private BaseControls.BC_TextBox txtTutar;
    }
}