namespace ALPARGE.AppForms.Genel
{
    partial class FrmKullaniciGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGrup));
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.bC_Label2 = new BaseControls.BC_Label();
            this.grdYetki = new BaseControls.BC_DataGrid();
            this.colFormCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYetkiSeviyesi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtGrupAdi = new BaseControls.BC_TextBox();
            this.txtGrupKodu = new BaseControls.BC_TextBox();
            this.grdUsers = new BaseControls.BC_DataGrid();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdGrups = new BaseControls.BC_DataGrid();
            this.colGruplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrupSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrups)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.Location = new System.Drawing.Point(580, 31);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(28, 21);
            this.btnYeni.TabIndex = 13;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(672, 29);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Değişiklikleri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // bC_Label2
            // 
            this.bC_Label2.AutoSize = true;
            this.bC_Label2.Location = new System.Drawing.Point(13, 246);
            this.bC_Label2.Name = "bC_Label2";
            this.bC_Label2.Size = new System.Drawing.Size(115, 13);
            this.bC_Label2.TabIndex = 9;
            this.bC_Label2.Text = "Gruba Bağlı Kullanıcılar";
            // 
            // grdYetki
            // 
            this.grdYetki.AllowUserToAddRows = false;
            this.grdYetki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdYetki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYetki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFormCode,
            this.colFormName,
            this.colYetkiSeviyesi});
            this.grdYetki.Location = new System.Drawing.Point(287, 102);
            this.grdYetki.MenuDeleteVisible = true;
            this.grdYetki.Name = "grdYetki";
            this.grdYetki.RowHeadersWidth = 25;
            this.grdYetki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdYetki.Size = new System.Drawing.Size(521, 373);
            this.grdYetki.TabIndex = 13;
            // 
            // colFormCode
            // 
            this.colFormCode.DataPropertyName = "FormCode";
            this.colFormCode.HeaderText = "Modül Kodu";
            this.colFormCode.Name = "colFormCode";
            this.colFormCode.ReadOnly = true;
            this.colFormCode.Visible = false;
            this.colFormCode.Width = 200;
            // 
            // colFormName
            // 
            this.colFormName.DataPropertyName = "FormName";
            this.colFormName.HeaderText = "Form Adı";
            this.colFormName.Name = "colFormName";
            this.colFormName.Width = 300;
            // 
            // colYetkiSeviyesi
            // 
            this.colYetkiSeviyesi.DataPropertyName = "FORMRIGHT";
            this.colYetkiSeviyesi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colYetkiSeviyesi.HeaderText = "Yetki Seviyesi";
            this.colYetkiSeviyesi.Name = "colYetkiSeviyesi";
            this.colYetkiSeviyesi.Width = 150;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(13, 15);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(85, 13);
            this.bC_Label1.TabIndex = 7;
            this.bC_Label1.Text = "Kullanıcı Grupları";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGrupAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGrupAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGrupAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtGrupAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtGrupAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtGrupAdi.Label = null;
            this.txtGrupAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrupAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGrupAdi.LabelText = "Grup Adı";
            this.txtGrupAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtGrupAdi.LabelTop = 3;
            this.txtGrupAdi.LabelVisible = true;
            this.txtGrupAdi.LabelWith = 100;
            this.txtGrupAdi.Location = new System.Drawing.Point(382, 58);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.NumericBox = false;
            this.txtGrupAdi.NumericDecimal = 0;
            this.txtGrupAdi.ReferansTip = 0;
            this.txtGrupAdi.Required = false;
            this.txtGrupAdi.RequiredPass = true;
            this.txtGrupAdi.Size = new System.Drawing.Size(198, 20);
            this.txtGrupAdi.TabIndex = 5;
            this.txtGrupAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtGrupAdi.WordWrap = false;
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGrupKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGrupKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtGrupKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtGrupKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtGrupKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtGrupKodu.Label = null;
            this.txtGrupKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGrupKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGrupKodu.LabelText = "Grup Kodu";
            this.txtGrupKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtGrupKodu.LabelTop = 3;
            this.txtGrupKodu.LabelVisible = true;
            this.txtGrupKodu.LabelWith = 100;
            this.txtGrupKodu.Location = new System.Drawing.Point(382, 32);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.NumericBox = false;
            this.txtGrupKodu.NumericDecimal = 0;
            this.txtGrupKodu.ReferansTip = 0;
            this.txtGrupKodu.Required = false;
            this.txtGrupKodu.RequiredPass = true;
            this.txtGrupKodu.Size = new System.Drawing.Size(198, 20);
            this.txtGrupKodu.TabIndex = 3;
            this.txtGrupKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtGrupKodu.WordWrap = false;
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToAddRows = false;
            this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            this.grdUsers.Location = new System.Drawing.Point(12, 262);
            this.grdUsers.MenuDeleteVisible = true;
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.ReadOnly = true;
            this.grdUsers.RowHeadersWidth = 25;
            this.grdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsers.Size = new System.Drawing.Size(253, 215);
            this.grdUsers.TabIndex = 2;
            this.grdUsers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsers_RowEnter);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Kullanıcı ";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 200;
            // 
            // grdGrups
            // 
            this.grdGrups.AllowUserToAddRows = false;
            this.grdGrups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGrups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGruplar,
            this.colGrupAdi});
            this.grdGrups.Location = new System.Drawing.Point(12, 31);
            this.grdGrups.MenuDeleteVisible = true;
            this.grdGrups.Name = "grdGrups";
            this.grdGrups.ReadOnly = true;
            this.grdGrups.RowHeadersWidth = 25;
            this.grdGrups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGrups.Size = new System.Drawing.Size(253, 195);
            this.grdGrups.TabIndex = 1;
            this.grdGrups.AllowUserToAddRowsChanged += new System.EventHandler(this.grdGrups_AllowUserToAddRowsChanged);
            this.grdGrups.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGrups_RowEnter);
            // 
            // colGruplar
            // 
            this.colGruplar.DataPropertyName = "GROUPCODE";
            this.colGruplar.HeaderText = "Kayıtlı Gruplar";
            this.colGruplar.Name = "colGruplar";
            this.colGruplar.ReadOnly = true;
            this.colGruplar.Width = 200;
            // 
            // colGrupAdi
            // 
            this.colGrupAdi.DataPropertyName = "GROUPNAME";
            this.colGrupAdi.HeaderText = "Grup Adı";
            this.colGrupAdi.Name = "colGrupAdi";
            this.colGrupAdi.ReadOnly = true;
            this.colGrupAdi.Visible = false;
            // 
            // btnGrupSil
            // 
            this.btnGrupSil.Location = new System.Drawing.Point(672, 58);
            this.btnGrupSil.Name = "btnGrupSil";
            this.btnGrupSil.Size = new System.Drawing.Size(136, 23);
            this.btnGrupSil.TabIndex = 16;
            this.btnGrupSil.Text = "Seçili Grubu Sil";
            this.btnGrupSil.UseVisualStyleBackColor = true;
            this.btnGrupSil.Click += new System.EventHandler(this.btnGrupSil_Click);
            // 
            // FrmKullaniciGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 487);
            this.Controls.Add(this.btnGrupSil);
            this.Controls.Add(this.grdYetki);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.bC_Label2);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.txtGrupAdi);
            this.Controls.Add(this.txtGrupKodu);
            this.Controls.Add(this.grdUsers);
            this.Controls.Add(this.grdGrups);
            this.Name = "FrmKullaniciGrup";
            this.Text = "Kullanıcı Grupları";
            this.Load += new System.EventHandler(this.FrmKullaniciGrup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGrups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid grdGrups;
        private BaseControls.BC_DataGrid grdUsers;
        private BaseControls.BC_TextBox txtGrupKodu;
        private BaseControls.BC_TextBox txtGrupAdi;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_Label bC_Label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private BaseControls.BC_DataGrid grdYetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colYetkiSeviyesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGruplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupAdi;
        private System.Windows.Forms.Button btnGrupSil;
    }
}