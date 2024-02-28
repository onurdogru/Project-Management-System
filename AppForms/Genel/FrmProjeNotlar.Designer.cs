namespace ALPARGE.AppForms.Genel
{
    partial class FrmProjeNotlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtOlusturan = new BaseControls.BC_TextBox();
            this.btnDuzenle = new BaseControls.BC_Button(this.components);
            this.btkYeni = new BaseControls.BC_Button(this.components);
            this.btnAra = new BaseControls.BC_Button(this.components);
            this.txtKonu = new BaseControls.BC_TextBox();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.GrdNotlar = new BaseControls.BC_DataGrid();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPRONUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNDATE = new BaseControls.CalendarColumn();
            this.colUSERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSUBJECT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCHANGEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOlusturan
            // 
            this.txtOlusturan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOlusturan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOlusturan.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOlusturan.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtOlusturan.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtOlusturan.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtOlusturan.Label = null;
            this.txtOlusturan.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOlusturan.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOlusturan.LabelText = "Oluşturan";
            this.txtOlusturan.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtOlusturan.LabelTop = 3;
            this.txtOlusturan.LabelVisible = true;
            this.txtOlusturan.LabelWith = 100;
            this.txtOlusturan.Location = new System.Drawing.Point(347, 12);
            this.txtOlusturan.Name = "txtOlusturan";
            this.txtOlusturan.NumericBox = false;
            this.txtOlusturan.NumericDecimal = 0;
            this.txtOlusturan.ReferansTip = 0;
            this.txtOlusturan.Required = false;
            this.txtOlusturan.RequiredPass = true;
            this.txtOlusturan.Size = new System.Drawing.Size(100, 20);
            this.txtOlusturan.TabIndex = 24;
            this.txtOlusturan.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtOlusturan.WordWrap = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = global::ALPARGE.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(671, 47);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(137, 25);
            this.btnDuzenle.TabIndex = 23;
            this.btnDuzenle.Text = "Notu incele";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btkYeni
            // 
            this.btkYeni.Image = global::ALPARGE.Properties.Resources.add;
            this.btkYeni.Location = new System.Drawing.Point(504, 47);
            this.btkYeni.Name = "btkYeni";
            this.btkYeni.Size = new System.Drawing.Size(137, 25);
            this.btkYeni.TabIndex = 22;
            this.btkYeni.Text = " Yeni Not Oluştur";
            this.btkYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btkYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btkYeni.UseVisualStyleBackColor = true;
            this.btkYeni.Click += new System.EventHandler(this.btkYeni_Click);
            // 
            // btnAra
            // 
            this.btnAra.Image = global::ALPARGE.Properties.Resources.search;
            this.btnAra.Location = new System.Drawing.Point(12, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(102, 25);
            this.btnAra.TabIndex = 21;
            this.btnAra.Text = " Kayıt Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
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
            this.txtKonu.LabelText = "Konu";
            this.txtKonu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtKonu.LabelTop = 3;
            this.txtKonu.LabelVisible = true;
            this.txtKonu.LabelWith = 50;
            this.txtKonu.Location = new System.Drawing.Point(553, 12);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.NumericBox = false;
            this.txtKonu.NumericDecimal = 0;
            this.txtKonu.ReferansTip = 0;
            this.txtKonu.Required = false;
            this.txtKonu.RequiredPass = true;
            this.txtKonu.Size = new System.Drawing.Size(255, 20);
            this.txtKonu.TabIndex = 20;
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
            this.txtProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeNo.Label = null;
            this.txtProjeNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeNo.LabelText = "Proje Numarası";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 100;
            this.txtProjeNo.Location = new System.Drawing.Point(112, 12);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 19;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            // 
            // GrdNotlar
            // 
            this.GrdNotlar.AllowUserToAddRows = false;
            this.GrdNotlar.AllowUserToDeleteRows = false;
            this.GrdNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdNotlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colPRONUM,
            this.colNDATE,
            this.colUSERNAME,
            this.colSUBJECT,
            this.colCHANGEDATE});
            this.GrdNotlar.Location = new System.Drawing.Point(12, 78);
            this.GrdNotlar.MenuDeleteVisible = true;
            this.GrdNotlar.MultiSelect = false;
            this.GrdNotlar.Name = "GrdNotlar";
            this.GrdNotlar.ReadOnly = true;
            this.GrdNotlar.RowHeadersWidth = 25;
            this.GrdNotlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdNotlar.Size = new System.Drawing.Size(800, 353);
            this.GrdNotlar.TabIndex = 18;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "No";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 40;
            // 
            // colPRONUM
            // 
            this.colPRONUM.DataPropertyName = "PRONUM";
            this.colPRONUM.HeaderText = "Proje No";
            this.colPRONUM.Name = "colPRONUM";
            this.colPRONUM.ReadOnly = true;
            // 
            // colNDATE
            // 
            this.colNDATE.CustomFormat = null;
            this.colNDATE.DataPropertyName = "NDATE";
            dataGridViewCellStyle1.NullValue = new System.DateTime(((long)(0)));
            this.colNDATE.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNDATE.DefaultDate = new System.DateTime(((long)(0)));
            this.colNDATE.HeaderText = "Tarih";
            this.colNDATE.Name = "colNDATE";
            this.colNDATE.ReadOnly = true;
            this.colNDATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUSERNAME
            // 
            this.colUSERNAME.DataPropertyName = "USERNAME";
            this.colUSERNAME.HeaderText = "Oluşturan";
            this.colUSERNAME.Name = "colUSERNAME";
            this.colUSERNAME.ReadOnly = true;
            // 
            // colSUBJECT
            // 
            this.colSUBJECT.DataPropertyName = "SUBJECT";
            this.colSUBJECT.HeaderText = "Konu";
            this.colSUBJECT.Name = "colSUBJECT";
            this.colSUBJECT.ReadOnly = true;
            this.colSUBJECT.Width = 300;
            // 
            // colCHANGEDATE
            // 
            this.colCHANGEDATE.DataPropertyName = "CHANGEDATE";
            dataGridViewCellStyle2.Format = "MM/dd/yyyy HH:mm";
            this.colCHANGEDATE.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCHANGEDATE.HeaderText = "Değiştirme";
            this.colCHANGEDATE.Name = "colCHANGEDATE";
            this.colCHANGEDATE.ReadOnly = true;
            this.colCHANGEDATE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCHANGEDATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmProjeNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 443);
            this.Controls.Add(this.txtOlusturan);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btkYeni);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.GrdNotlar);
            this.Name = "FrmProjeNotlar";
            this.Text = "Proje Notları";
            this.Load += new System.EventHandler(this.FrmProjeNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdNotlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtOlusturan;
        private BaseControls.BC_Button btnDuzenle;
        private BaseControls.BC_Button btkYeni;
        private BaseControls.BC_Button btnAra;
        private BaseControls.BC_TextBox txtKonu;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_DataGrid GrdNotlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRONUM;
        private BaseControls.CalendarColumn colNDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSUBJECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCHANGEDATE;
    }
}