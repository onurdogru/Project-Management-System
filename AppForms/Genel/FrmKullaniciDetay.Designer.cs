namespace ALPARGE.AppForms.Genel
{
    partial class FrmKullaniciDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciDetay));
            this.txtCompany = new BaseControls.BC_TextBox();
            this.txtClient = new BaseControls.BC_TextBox();
            this.btnGruptanCikar = new BaseControls.BC_Button(this.components);
            this.btnGrubaEkle = new BaseControls.BC_Button(this.components);
            this.txtGrupSec = new BaseControls.BC_TextBox();
            this.bC_TextBox1 = new BaseControls.BC_TextBox();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.GrdGrup = new BaseControls.BC_DataGrid();
            this.colGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPersonel = new BaseControls.BC_CheckBox();
            this.cbSorumlu = new BaseControls.BC_CheckBox();
            this.txtTesis = new BaseControls.BC_TextBox();
            this.txtGorev = new BaseControls.BC_TextBox();
            this.btnVazgec = new BaseControls.BC_Button(this.components);
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.cbAktif = new BaseControls.BC_CheckBox();
            this.txtMail = new BaseControls.BC_TextBox();
            this.txtTamAdi = new BaseControls.BC_TextBox();
            this.txtSifre = new BaseControls.BC_TextBox();
            this.txtUserName = new BaseControls.BC_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGrup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompany
            // 
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCompany.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCompany.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtCompany.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtCompany.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtCompany.Label = null;
            this.txtCompany.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompany.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCompany.LabelText = "Tesis Kodu";
            this.txtCompany.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtCompany.LabelTop = 3;
            this.txtCompany.LabelVisible = false;
            this.txtCompany.LabelWith = 100;
            this.txtCompany.Location = new System.Drawing.Point(242, 127);
            this.txtCompany.MaxLength = 3;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.NumericBox = false;
            this.txtCompany.NumericDecimal = 0;
            this.txtCompany.ReferansTip = 0;
            this.txtCompany.Required = false;
            this.txtCompany.RequiredPass = true;
            this.txtCompany.Size = new System.Drawing.Size(35, 20);
            this.txtCompany.TabIndex = 49;
            this.txtCompany.Text = "01";
            this.txtCompany.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtCompany.Visible = false;
            this.txtCompany.WordWrap = false;
            // 
            // txtClient
            // 
            this.txtClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtClient.BorderColor = System.Drawing.Color.DarkGray;
            this.txtClient.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtClient.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtClient.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtClient.Label = null;
            this.txtClient.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtClient.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtClient.LabelText = "Tesis Kodu";
            this.txtClient.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtClient.LabelTop = 3;
            this.txtClient.LabelVisible = false;
            this.txtClient.LabelWith = 100;
            this.txtClient.Location = new System.Drawing.Point(201, 127);
            this.txtClient.MaxLength = 3;
            this.txtClient.Name = "txtClient";
            this.txtClient.NumericBox = false;
            this.txtClient.NumericDecimal = 0;
            this.txtClient.ReferansTip = 0;
            this.txtClient.Required = false;
            this.txtClient.RequiredPass = true;
            this.txtClient.Size = new System.Drawing.Size(35, 20);
            this.txtClient.TabIndex = 38;
            this.txtClient.Text = "00";
            this.txtClient.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtClient.Visible = false;
            this.txtClient.WordWrap = false;
            // 
            // btnGruptanCikar
            // 
            this.btnGruptanCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnGruptanCikar.Image")));
            this.btnGruptanCikar.Location = new System.Drawing.Point(321, 249);
            this.btnGruptanCikar.Name = "btnGruptanCikar";
            this.btnGruptanCikar.Size = new System.Drawing.Size(145, 24);
            this.btnGruptanCikar.TabIndex = 29;
            this.btnGruptanCikar.Text = "> Seçili Gruptan Çıkar";
            this.btnGruptanCikar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGruptanCikar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGruptanCikar.UseVisualStyleBackColor = true;
            this.btnGruptanCikar.Click += new System.EventHandler(this.btnGruptanCikar_Click);
            // 
            // btnGrubaEkle
            // 
            this.btnGrubaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnGrubaEkle.Image")));
            this.btnGrubaEkle.Location = new System.Drawing.Point(321, 219);
            this.btnGrubaEkle.Name = "btnGrubaEkle";
            this.btnGrubaEkle.Size = new System.Drawing.Size(145, 24);
            this.btnGrubaEkle.TabIndex = 28;
            this.btnGrubaEkle.Text = "< Seçili Gruba Ekle";
            this.btnGrubaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrubaEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGrubaEkle.UseVisualStyleBackColor = true;
            this.btnGrubaEkle.Click += new System.EventHandler(this.btnGrubaEkle_Click);
            // 
            // txtGrupSec
            // 
            this.txtGrupSec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGrupSec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGrupSec.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGrupSec.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtGrupSec.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtGrupSec.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtGrupSec.Label = null;
            this.txtGrupSec.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrupSec.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGrupSec.LabelText = null;
            this.txtGrupSec.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtGrupSec.LabelTop = 3;
            this.txtGrupSec.LabelVisible = false;
            this.txtGrupSec.LabelWith = 100;
            this.txtGrupSec.Location = new System.Drawing.Point(322, 193);
            this.txtGrupSec.Name = "txtGrupSec";
            this.txtGrupSec.NumericBox = false;
            this.txtGrupSec.NumericDecimal = 0;
            this.txtGrupSec.ReadOnly = true;
            this.txtGrupSec.ReferansTip = 0;
            this.txtGrupSec.Required = false;
            this.txtGrupSec.RequiredPass = true;
            this.txtGrupSec.Size = new System.Drawing.Size(144, 20);
            this.txtGrupSec.TabIndex = 26;
            this.txtGrupSec.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtGrupSec.WordWrap = false;
            this.txtGrupSec.ButtonClick += new System.EventHandler(this.txtGrupSec_ButtonClick);
            // 
            // bC_TextBox1
            // 
            this.bC_TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bC_TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.bC_TextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.bC_TextBox1.BorderFocusColor = System.Drawing.Color.Maroon;
            this.bC_TextBox1.BorderSelectColor = System.Drawing.Color.Gray;
            this.bC_TextBox1.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.bC_TextBox1.Label = null;
            this.bC_TextBox1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bC_TextBox1.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bC_TextBox1.LabelText = null;
            this.bC_TextBox1.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.bC_TextBox1.LabelTop = 3;
            this.bC_TextBox1.LabelVisible = false;
            this.bC_TextBox1.LabelWith = 100;
            this.bC_TextBox1.Location = new System.Drawing.Point(322, 193);
            this.bC_TextBox1.Name = "bC_TextBox1";
            this.bC_TextBox1.NumericBox = false;
            this.bC_TextBox1.NumericDecimal = 0;
            this.bC_TextBox1.ReferansTip = 0;
            this.bC_TextBox1.Required = false;
            this.bC_TextBox1.RequiredPass = true;
            this.bC_TextBox1.Size = new System.Drawing.Size(144, 20);
            this.bC_TextBox1.TabIndex = 26;
            this.bC_TextBox1.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.bC_TextBox1.WordWrap = false;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(31, 177);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(96, 13);
            this.bC_Label1.TabIndex = 24;
            this.bC_Label1.Text = "Üye olduğu gruplar";
            // 
            // GrdGrup
            // 
            this.GrdGrup.AllowUserToAddRows = false;
            this.GrdGrup.AllowUserToDeleteRows = false;
            this.GrdGrup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdGrup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdGrup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrup});
            this.GrdGrup.Location = new System.Drawing.Point(30, 193);
            this.GrdGrup.MenuDeleteVisible = true;
            this.GrdGrup.Name = "GrdGrup";
            this.GrdGrup.RowHeadersWidth = 25;
            this.GrdGrup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdGrup.Size = new System.Drawing.Size(285, 101);
            this.GrdGrup.TabIndex = 23;
            // 
            // colGrup
            // 
            this.colGrup.DataPropertyName = "GROUPCODE";
            this.colGrup.HeaderText = "Kullanıcı Grubu";
            this.colGrup.Name = "colGrup";
            // 
            // cbPersonel
            // 
            this.cbPersonel.AutoSize = true;
            this.cbPersonel.Location = new System.Drawing.Point(406, 130);
            this.cbPersonel.Name = "cbPersonel";
            this.cbPersonel.Size = new System.Drawing.Size(96, 17);
            this.cbPersonel.TabIndex = 16;
            this.cbPersonel.Text = "Proje Personeli";
            this.cbPersonel.UseVisualStyleBackColor = true;
            // 
            // cbSorumlu
            // 
            this.cbSorumlu.AutoSize = true;
            this.cbSorumlu.Location = new System.Drawing.Point(406, 153);
            this.cbSorumlu.Name = "cbSorumlu";
            this.cbSorumlu.Size = new System.Drawing.Size(102, 17);
            this.cbSorumlu.TabIndex = 15;
            this.cbSorumlu.Text = "Proje Sorumlusu";
            this.cbSorumlu.UseVisualStyleBackColor = true;
            // 
            // txtTesis
            // 
            this.txtTesis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTesis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTesis.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTesis.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTesis.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTesis.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTesis.Label = null;
            this.txtTesis.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTesis.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTesis.LabelText = "Tesis Kodu";
            this.txtTesis.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTesis.LabelTop = 3;
            this.txtTesis.LabelVisible = true;
            this.txtTesis.LabelWith = 100;
            this.txtTesis.Location = new System.Drawing.Point(125, 127);
            this.txtTesis.MaxLength = 3;
            this.txtTesis.Name = "txtTesis";
            this.txtTesis.NumericBox = false;
            this.txtTesis.NumericDecimal = 0;
            this.txtTesis.ReferansTip = 0;
            this.txtTesis.Required = false;
            this.txtTesis.RequiredPass = true;
            this.txtTesis.Size = new System.Drawing.Size(37, 20);
            this.txtTesis.TabIndex = 14;
            this.txtTesis.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTesis.WordWrap = false;
            // 
            // txtGorev
            // 
            this.txtGorev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGorev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGorev.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGorev.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtGorev.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtGorev.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtGorev.Label = null;
            this.txtGorev.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGorev.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGorev.LabelText = "Görev - Ünvan";
            this.txtGorev.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtGorev.LabelTop = 3;
            this.txtGorev.LabelVisible = true;
            this.txtGorev.LabelWith = 100;
            this.txtGorev.Location = new System.Drawing.Point(125, 101);
            this.txtGorev.MaxLength = 50;
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.NumericBox = false;
            this.txtGorev.NumericDecimal = 0;
            this.txtGorev.ReferansTip = 0;
            this.txtGorev.Required = false;
            this.txtGorev.RequiredPass = true;
            this.txtGorev.Size = new System.Drawing.Size(397, 20);
            this.txtGorev.TabIndex = 12;
            this.txtGorev.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtGorev.WordWrap = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(269, 307);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(119, 34);
            this.btnVazgec.TabIndex = 10;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(406, 307);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 34);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbAktif
            // 
            this.cbAktif.AutoSize = true;
            this.cbAktif.Checked = true;
            this.cbAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktif.Location = new System.Drawing.Point(30, 317);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(89, 17);
            this.cbAktif.TabIndex = 8;
            this.cbAktif.Text = "Kullanıcı Aktif";
            this.cbAktif.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMail.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtMail.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtMail.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtMail.Label = null;
            this.txtMail.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMail.LabelText = "Mail Adresi";
            this.txtMail.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtMail.LabelTop = 3;
            this.txtMail.LabelVisible = true;
            this.txtMail.LabelWith = 100;
            this.txtMail.Location = new System.Drawing.Point(125, 75);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.NumericBox = false;
            this.txtMail.NumericDecimal = 0;
            this.txtMail.ReferansTip = 0;
            this.txtMail.Required = false;
            this.txtMail.RequiredPass = true;
            this.txtMail.Size = new System.Drawing.Size(397, 20);
            this.txtMail.TabIndex = 7;
            this.txtMail.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtMail.WordWrap = false;
            // 
            // txtTamAdi
            // 
            this.txtTamAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTamAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTamAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTamAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTamAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTamAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTamAdi.Label = null;
            this.txtTamAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTamAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTamAdi.LabelText = "Tam İsim";
            this.txtTamAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTamAdi.LabelTop = 3;
            this.txtTamAdi.LabelVisible = true;
            this.txtTamAdi.LabelWith = 100;
            this.txtTamAdi.Location = new System.Drawing.Point(125, 49);
            this.txtTamAdi.MaxLength = 50;
            this.txtTamAdi.Name = "txtTamAdi";
            this.txtTamAdi.NumericBox = false;
            this.txtTamAdi.NumericDecimal = 0;
            this.txtTamAdi.ReferansTip = 0;
            this.txtTamAdi.Required = false;
            this.txtTamAdi.RequiredPass = true;
            this.txtTamAdi.Size = new System.Drawing.Size(397, 20);
            this.txtTamAdi.TabIndex = 5;
            this.txtTamAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTamAdi.WordWrap = false;
            // 
            // txtSifre
            // 
            this.txtSifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSifre.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSifre.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSifre.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSifre.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSifre.Label = null;
            this.txtSifre.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSifre.LabelText = "Şifre";
            this.txtSifre.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSifre.LabelTop = 3;
            this.txtSifre.LabelVisible = true;
            this.txtSifre.LabelWith = 100;
            this.txtSifre.Location = new System.Drawing.Point(387, 23);
            this.txtSifre.MaxLength = 10;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.NumericBox = false;
            this.txtSifre.NumericDecimal = 0;
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.ReferansTip = 0;
            this.txtSifre.Required = false;
            this.txtSifre.RequiredPass = true;
            this.txtSifre.Size = new System.Drawing.Size(135, 20);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSifre.WordWrap = false;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtUserName.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtUserName.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtUserName.Label = null;
            this.txtUserName.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.LabelText = "Kullanıcı Adı";
            this.txtUserName.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtUserName.LabelTop = 3;
            this.txtUserName.LabelVisible = true;
            this.txtUserName.LabelWith = 100;
            this.txtUserName.Location = new System.Drawing.Point(125, 23);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.NumericBox = false;
            this.txtUserName.NumericDecimal = 0;
            this.txtUserName.ReferansTip = 0;
            this.txtUserName.Required = false;
            this.txtUserName.RequiredPass = true;
            this.txtUserName.Size = new System.Drawing.Size(120, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtUserName.WordWrap = false;
            // 
            // FrmKullaniciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnGruptanCikar);
            this.Controls.Add(this.btnGrubaEkle);
            this.Controls.Add(this.txtGrupSec);
            this.Controls.Add(this.bC_TextBox1);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.GrdGrup);
            this.Controls.Add(this.cbPersonel);
            this.Controls.Add(this.cbSorumlu);
            this.Controls.Add(this.txtTesis);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cbAktif);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTamAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtUserName);
            this.Name = "FrmKullaniciDetay";
            this.Text = "Kullanıcı Bilgileri";
            this.Load += new System.EventHandler(this.FrmKullaniciDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdGrup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtUserName;
        private BaseControls.BC_TextBox txtSifre;
        private BaseControls.BC_TextBox txtTamAdi;
        private BaseControls.BC_TextBox txtMail;
        private BaseControls.BC_CheckBox cbAktif;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_Button btnVazgec;
        private BaseControls.BC_TextBox txtGorev;
        private BaseControls.BC_TextBox txtTesis;
        private BaseControls.BC_CheckBox cbSorumlu;
        private BaseControls.BC_CheckBox cbPersonel;
        private BaseControls.BC_DataGrid GrdGrup;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_TextBox bC_TextBox1;
        private BaseControls.BC_Button btnGrubaEkle;
        private BaseControls.BC_Button btnGruptanCikar;
        private BaseControls.BC_TextBox txtClient;
        private BaseControls.BC_TextBox txtGrupSec;
        private BaseControls.BC_TextBox txtCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrup;
    }
}