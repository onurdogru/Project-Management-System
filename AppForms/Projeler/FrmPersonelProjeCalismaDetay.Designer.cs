namespace ALPARGE.AppForms.Projeler
{
    partial class FrmPersonelProjeCalismaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelProjeCalismaDetay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.ButtonTextCell buttonTextCell1 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BaseControls.ButtonTextCell buttonTextCell2 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOtoGetir = new BaseControls.BC_Button(this.components);
            this.btnPastEx = new BaseControls.BC_Button(this.components);
            this.lbPersonel = new BaseControls.BC_Label();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.btnListele = new BaseControls.BC_Button(this.components);
            this.txtGun = new BaseControls.Forms.BC_DateTime();
            this.GrdKayit = new BaseControls.BC_DataGrid();
            this.colPersonel = new BaseControls.ButtonTextColumn();
            this.colKonum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colGorevTipi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colProjeKodu = new BaseControls.ButtonTextColumn();
            this.colBaslangicSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBitisSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkDate = new BaseControls.CalendarColumn();
            this.colBasSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGCBilgileri = new BaseControls.BC_Button(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtoGetir
            // 
            this.btnOtoGetir.Location = new System.Drawing.Point(398, 17);
            this.btnOtoGetir.Name = "btnOtoGetir";
            this.btnOtoGetir.Size = new System.Drawing.Size(157, 23);
            this.btnOtoGetir.TabIndex = 14;
            this.btnOtoGetir.Text = "Önceki Günden Oluştur";
            this.btnOtoGetir.UseVisualStyleBackColor = true;
            this.btnOtoGetir.Click += new System.EventHandler(this.btnOtoGetir_Click);
            // 
            // btnPastEx
            // 
            this.btnPastEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPastEx.Enabled = false;
            this.btnPastEx.Location = new System.Drawing.Point(886, 554);
            this.btnPastEx.Name = "btnPastEx";
            this.btnPastEx.Size = new System.Drawing.Size(109, 23);
            this.btnPastEx.TabIndex = 12;
            this.btnPastEx.Text = "Excelden Yapıştır";
            this.btnPastEx.UseVisualStyleBackColor = true;
            this.btnPastEx.Click += new System.EventHandler(this.btnPastEx_Click);
            // 
            // lbPersonel
            // 
            this.lbPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPersonel.AutoSize = true;
            this.lbPersonel.Location = new System.Drawing.Point(9, 559);
            this.lbPersonel.Name = "lbPersonel";
            this.lbPersonel.Size = new System.Drawing.Size(13, 13);
            this.lbPersonel.TabIndex = 10;
            this.lbPersonel.Text = ">";
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(12, 40);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(58, 13);
            this.bC_Label1.TabIndex = 8;
            this.bC_Label1.Text = "bC_Label1";
            this.bC_Label1.Visible = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(895, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 37);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = " KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(261, 17);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(95, 22);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Yenile";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtGun
            // 
            this.txtGun.CustomFormat = "dd.MM.yyyy";
            this.txtGun.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtGun.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGun.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGun.LabelText = "Çalışma Günü";
            this.txtGun.LabelTextAllign = System.Drawing.ContentAlignment.TopLeft;
            this.txtGun.LabelTop = 5;
            this.txtGun.LabelVisible = true;
            this.txtGun.LabelWith = 100;
            this.txtGun.Location = new System.Drawing.Point(111, 18);
            this.txtGun.Name = "txtGun";
            this.txtGun.NullDate = BaseControls.Forms.NullDateValue.Now;
            this.txtGun.Size = new System.Drawing.Size(144, 20);
            this.txtGun.TabIndex = 2;
            this.txtGun.Value = new System.DateTime(2019, 12, 16, 0, 0, 0, 0);
            // 
            // GrdKayit
            // 
            this.GrdKayit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdKayit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonel,
            this.colKonum,
            this.colGorevTipi,
            this.colProjeKodu,
            this.colBaslangicSaati,
            this.colSure,
            this.colBitisSaati,
            this.colAciklama,
            this.colWorkDate,
            this.colBasSaati});
            this.GrdKayit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GrdKayit.Location = new System.Drawing.Point(12, 56);
            this.GrdKayit.MenuDeleteVisible = true;
            this.GrdKayit.Name = "GrdKayit";
            this.GrdKayit.RowHeadersWidth = 25;
            this.GrdKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GrdKayit.Size = new System.Drawing.Size(983, 494);
            this.GrdKayit.TabIndex = 1;
            this.GrdKayit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKayit_CellContentClick);
            this.GrdKayit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKayit_CellEnter);
            this.GrdKayit.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKayit_CellValueChanged);
            this.GrdKayit.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrdKayit_DataError);
            this.GrdKayit.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdKayit_RowEnter);
            this.GrdKayit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdKayit_KeyDown);
            // 
            // colPersonel
            // 
            this.colPersonel.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.colPersonel.DataPropertyName = "WORKER";
            buttonTextCell1.ErrorText = "";
            buttonTextCell1.Style = dataGridViewCellStyle2;
            buttonTextCell1.Value = "";
            buttonTextCell1.ValueType = typeof(string);
            dataGridViewCellStyle1.NullValue = buttonTextCell1;
            this.colPersonel.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPersonel.HeaderText = "Personel";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.Button_Click += new System.EventHandler(this.colPersonel_Button_Click);
            // 
            // colKonum
            // 
            this.colKonum.DataPropertyName = "STATUS";
            this.colKonum.HeaderText = "Konum/ Durum";
            this.colKonum.Name = "colKonum";
            this.colKonum.Width = 150;
            // 
            // colGorevTipi
            // 
            this.colGorevTipi.DataPropertyName = "PROCESS";
            this.colGorevTipi.HeaderText = "Görev Tipi";
            this.colGorevTipi.Name = "colGorevTipi";
            this.colGorevTipi.Width = 150;
            // 
            // colProjeKodu
            // 
            this.colProjeKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.colProjeKodu.DataPropertyName = "PRONUM";
            buttonTextCell2.ErrorText = "";
            buttonTextCell2.Style = dataGridViewCellStyle4;
            buttonTextCell2.Value = "";
            buttonTextCell2.ValueType = typeof(string);
            dataGridViewCellStyle3.NullValue = buttonTextCell2;
            this.colProjeKodu.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProjeKodu.HeaderText = "Proje Kodu";
            this.colProjeKodu.Name = "colProjeKodu";
            this.colProjeKodu.Width = 120;
            this.colProjeKodu.Button_Click += new System.EventHandler(this.colProjeKodu_Button_Click);
            // 
            // colBaslangicSaati
            // 
            this.colBaslangicSaati.DataPropertyName = "STARTTIME";
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = "00:00";
            this.colBaslangicSaati.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBaslangicSaati.HeaderText = "Başlangıç Saati";
            this.colBaslangicSaati.MaxInputLength = 8;
            this.colBaslangicSaati.Name = "colBaslangicSaati";
            this.colBaslangicSaati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBaslangicSaati.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBaslangicSaati.Width = 90;
            // 
            // colSure
            // 
            this.colSure.DataPropertyName = "DURATION2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = "00:00";
            this.colSure.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSure.HeaderText = "Süre";
            this.colSure.MaxInputLength = 8;
            this.colSure.Name = "colSure";
            this.colSure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSure.Width = 50;
            // 
            // colBitisSaati
            // 
            this.colBitisSaati.DataPropertyName = "STOPTIME";
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = "00:00";
            this.colBitisSaati.DefaultCellStyle = dataGridViewCellStyle7;
            this.colBitisSaati.HeaderText = "Bitiş Saati";
            this.colBitisSaati.MaxInputLength = 8;
            this.colBitisSaati.Name = "colBitisSaati";
            this.colBitisSaati.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBitisSaati.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBitisSaati.Width = 90;
            // 
            // colAciklama
            // 
            this.colAciklama.DataPropertyName = "DESCRIPTION";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAciklama.DefaultCellStyle = dataGridViewCellStyle8;
            this.colAciklama.HeaderText = "Açıklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAciklama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colAciklama.Width = 400;
            // 
            // colWorkDate
            // 
            this.colWorkDate.CustomFormat = null;
            this.colWorkDate.DataPropertyName = "WORKDATE";
            dataGridViewCellStyle9.NullValue = new System.DateTime(((long)(0)));
            this.colWorkDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.colWorkDate.DefaultDate = new System.DateTime(((long)(0)));
            this.colWorkDate.HeaderText = "Çalışma Tarihi";
            this.colWorkDate.Name = "colWorkDate";
            this.colWorkDate.ReadOnly = true;
            // 
            // colBasSaati
            // 
            this.colBasSaati.DataPropertyName = "STARTTIME";
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.colBasSaati.DefaultCellStyle = dataGridViewCellStyle10;
            this.colBasSaati.HeaderText = "Başlama Saati";
            this.colBasSaati.Name = "colBasSaati";
            this.colBasSaati.Visible = false;
            // 
            // btnGCBilgileri
            // 
            this.btnGCBilgileri.Location = new System.Drawing.Point(598, 17);
            this.btnGCBilgileri.Name = "btnGCBilgileri";
            this.btnGCBilgileri.Size = new System.Drawing.Size(111, 23);
            this.btnGCBilgileri.TabIndex = 16;
            this.btnGCBilgileri.Text = "Turnike Bilgileri";
            this.btnGCBilgileri.UseVisualStyleBackColor = true;
            this.btnGCBilgileri.Click += new System.EventHandler(this.btnGCBilgileri_Click);
            // 
            // FrmPersonelProjeCalismaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 581);
            this.Controls.Add(this.btnGCBilgileri);
            this.Controls.Add(this.btnOtoGetir);
            this.Controls.Add(this.btnPastEx);
            this.Controls.Add(this.lbPersonel);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.GrdKayit);
            this.Name = "FrmPersonelProjeCalismaDetay";
            this.Text = "Personel Proje Çalışma Süreleri";
            this.Load += new System.EventHandler(this.FrmPersonelProjeCalismaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdKayit;
        private BaseControls.Forms.BC_DateTime txtGun;
        private BaseControls.BC_Button btnListele;
        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_Label lbPersonel;
        private BaseControls.BC_Button btnPastEx;
        private BaseControls.BC_Button btnOtoGetir;
        private BaseControls.BC_Button btnGCBilgileri;
        private BaseControls.ButtonTextColumn colPersonel;
        private System.Windows.Forms.DataGridViewComboBoxColumn colKonum;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGorevTipi;
        private BaseControls.ButtonTextColumn colProjeKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaslangicSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSure;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBitisSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAciklama;
        private BaseControls.CalendarColumn colWorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBasSaati;
    }
}