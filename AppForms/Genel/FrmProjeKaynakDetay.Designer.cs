namespace ALPARGE.AppForms
{
    partial class FrmProjeKaynakDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeKaynakDetay));
            this.btnGruptanCikar = new BaseControls.BC_Button(this.components);
            this.btnGrubaEkle = new BaseControls.BC_Button(this.components);
            this.txtGrupSec = new BaseControls.BC_TextBox();
            this.bC_TextBox1 = new BaseControls.BC_TextBox();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.GrdGrup = new BaseControls.BC_DataGrid();
            this.colGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtKaynakKodu = new BaseControls.BC_TextBox();
            this.txtKaynakAdi = new BaseControls.BC_TextBox();
            this.btnVazgec = new BaseControls.BC_Button(this.components);
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.btnSil = new BaseControls.BC_Button(this.components);
            this.cbAktif = new BaseControls.BC_CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGrup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGruptanCikar
            // 
            this.btnGruptanCikar.Image = ((System.Drawing.Image)(resources.GetObject("btnGruptanCikar.Image")));
            this.btnGruptanCikar.Location = new System.Drawing.Point(319, 169);
            this.btnGruptanCikar.Name = "btnGruptanCikar";
            this.btnGruptanCikar.Size = new System.Drawing.Size(145, 24);
            this.btnGruptanCikar.TabIndex = 37;
            this.btnGruptanCikar.Text = "> Seçili Gruptan Çıkar";
            this.btnGruptanCikar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGruptanCikar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGruptanCikar.UseVisualStyleBackColor = true;
            this.btnGruptanCikar.Click += new System.EventHandler(this.btnGruptanCikar_Click);
            // 
            // btnGrubaEkle
            // 
            this.btnGrubaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnGrubaEkle.Image")));
            this.btnGrubaEkle.Location = new System.Drawing.Point(319, 139);
            this.btnGrubaEkle.Name = "btnGrubaEkle";
            this.btnGrubaEkle.Size = new System.Drawing.Size(145, 24);
            this.btnGrubaEkle.TabIndex = 36;
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
            this.txtGrupSec.Location = new System.Drawing.Point(320, 113);
            this.txtGrupSec.Name = "txtGrupSec";
            this.txtGrupSec.NumericBox = false;
            this.txtGrupSec.NumericDecimal = 0;
            this.txtGrupSec.ReadOnly = true;
            this.txtGrupSec.ReferansTip = 0;
            this.txtGrupSec.Required = false;
            this.txtGrupSec.RequiredPass = true;
            this.txtGrupSec.Size = new System.Drawing.Size(144, 20);
            this.txtGrupSec.TabIndex = 34;
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
            this.bC_TextBox1.Location = new System.Drawing.Point(320, 113);
            this.bC_TextBox1.Name = "bC_TextBox1";
            this.bC_TextBox1.NumericBox = false;
            this.bC_TextBox1.NumericDecimal = 0;
            this.bC_TextBox1.ReferansTip = 0;
            this.bC_TextBox1.Required = false;
            this.bC_TextBox1.RequiredPass = true;
            this.bC_TextBox1.Size = new System.Drawing.Size(144, 20);
            this.bC_TextBox1.TabIndex = 35;
            this.bC_TextBox1.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.bC_TextBox1.WordWrap = false;
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(29, 97);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(78, 13);
            this.bC_Label1.TabIndex = 33;
            this.bC_Label1.Text = "Kaynak Üyeleri";
            // 
            // GrdGrup
            // 
            this.GrdGrup.AllowUserToAddRows = false;
            this.GrdGrup.AllowUserToDeleteRows = false;
            this.GrdGrup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdGrup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdGrup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrup});
            this.GrdGrup.Location = new System.Drawing.Point(28, 113);
            this.GrdGrup.MenuDeleteVisible = true;
            this.GrdGrup.Name = "GrdGrup";
            this.GrdGrup.RowHeadersWidth = 25;
            this.GrdGrup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdGrup.Size = new System.Drawing.Size(285, 125);
            this.GrdGrup.TabIndex = 32;
            // 
            // colGrup
            // 
            this.colGrup.DataPropertyName = "USERNAME";
            this.colGrup.HeaderText = "Kullanıcı";
            this.colGrup.Name = "colGrup";
            // 
            // txtKaynakKodu
            // 
            this.txtKaynakKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaynakKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaynakKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKaynakKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKaynakKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKaynakKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKaynakKodu.Label = null;
            this.txtKaynakKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynakKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaynakKodu.LabelText = "Kaynak Kodu";
            this.txtKaynakKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKaynakKodu.LabelTop = 3;
            this.txtKaynakKodu.LabelVisible = true;
            this.txtKaynakKodu.LabelWith = 100;
            this.txtKaynakKodu.Location = new System.Drawing.Point(125, 23);
            this.txtKaynakKodu.MaxLength = 20;
            this.txtKaynakKodu.Name = "txtKaynakKodu";
            this.txtKaynakKodu.NumericBox = false;
            this.txtKaynakKodu.NumericDecimal = 0;
            this.txtKaynakKodu.ReferansTip = 0;
            this.txtKaynakKodu.Required = false;
            this.txtKaynakKodu.RequiredPass = true;
            this.txtKaynakKodu.Size = new System.Drawing.Size(120, 20);
            this.txtKaynakKodu.TabIndex = 39;
            this.txtKaynakKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKaynakKodu.WordWrap = false;
            // 
            // txtKaynakAdi
            // 
            this.txtKaynakAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaynakAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaynakAdi.BorderColor = System.Drawing.Color.DarkGray;
            this.txtKaynakAdi.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtKaynakAdi.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtKaynakAdi.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtKaynakAdi.Label = null;
            this.txtKaynakAdi.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynakAdi.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtKaynakAdi.LabelText = "Kaynak Açıklaması";
            this.txtKaynakAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKaynakAdi.LabelTop = 3;
            this.txtKaynakAdi.LabelVisible = true;
            this.txtKaynakAdi.LabelWith = 100;
            this.txtKaynakAdi.Location = new System.Drawing.Point(125, 49);
            this.txtKaynakAdi.MaxLength = 20;
            this.txtKaynakAdi.Name = "txtKaynakAdi";
            this.txtKaynakAdi.NumericBox = false;
            this.txtKaynakAdi.NumericDecimal = 0;
            this.txtKaynakAdi.ReferansTip = 0;
            this.txtKaynakAdi.Required = false;
            this.txtKaynakAdi.RequiredPass = true;
            this.txtKaynakAdi.Size = new System.Drawing.Size(345, 20);
            this.txtKaynakAdi.TabIndex = 41;
            this.txtKaynakAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtKaynakAdi.WordWrap = false;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(211, 260);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(119, 34);
            this.btnVazgec.TabIndex = 43;
            this.btnVazgec.Text = " Vazgeç";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(348, 260);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 34);
            this.btnKaydet.TabIndex = 42;
            this.btnKaydet.Text = " Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::ALPARGE.Properties.Resources.remove;
            this.btnSil.Location = new System.Drawing.Point(28, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 34);
            this.btnSil.TabIndex = 44;
            this.btnSil.Text = "Kaynak Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbAktif
            // 
            this.cbAktif.AutoSize = true;
            this.cbAktif.Checked = true;
            this.cbAktif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAktif.Location = new System.Drawing.Point(418, 23);
            this.cbAktif.Name = "cbAktif";
            this.cbAktif.Size = new System.Drawing.Size(52, 17);
            this.cbAktif.TabIndex = 45;
            this.cbAktif.Text = "Pasif ";
            this.cbAktif.UseVisualStyleBackColor = true;
            // 
            // FrmProjeKaynakDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 319);
            this.Controls.Add(this.cbAktif);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtKaynakAdi);
            this.Controls.Add(this.txtKaynakKodu);
            this.Controls.Add(this.btnGruptanCikar);
            this.Controls.Add(this.btnGrubaEkle);
            this.Controls.Add(this.txtGrupSec);
            this.Controls.Add(this.bC_TextBox1);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.GrdGrup);
            this.Name = "FrmProjeKaynakDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kaynak Detay  Bilgileri";
            this.Load += new System.EventHandler(this.FrmProjeKaynakDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdGrup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnGruptanCikar;
        private BaseControls.BC_Button btnGrubaEkle;
        private BaseControls.BC_TextBox txtGrupSec;
        private BaseControls.BC_TextBox bC_TextBox1;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_DataGrid GrdGrup;
        private BaseControls.BC_TextBox txtKaynakKodu;
        private BaseControls.BC_TextBox txtKaynakAdi;
        private BaseControls.BC_Button btnVazgec;
        private BaseControls.BC_Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrup;
        private BaseControls.BC_Button btnSil;
        private BaseControls.BC_CheckBox cbAktif;
    }
}