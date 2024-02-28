namespace ALPARGE.AppForms.Genel
{
    partial class FrmCatiProjeDetay
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
            BaseControls.ButtonTextCell buttonTextCell1 = new BaseControls.ButtonTextCell();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bC_Label2 = new BaseControls.BC_Label();
            this.bC_Label1 = new BaseControls.BC_Label();
            this.txtTesis = new BaseControls.BC_TextBox();
            this.txtAciklama = new BaseControls.BC_TextBox();
            this.txtProjeAdi = new BaseControls.BC_TextBox();
            this.txtProjeKodu = new BaseControls.BC_TextBox();
            this.btnKaydet = new BaseControls.BC_Button(this.components);
            this.GrdProjeler = new BaseControls.BC_DataGrid();
            this.colProjeNo = new BaseControls.ButtonTextColumn();
            this.colProjeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaliyetMerkezi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // bC_Label2
            // 
            this.bC_Label2.AutoSize = true;
            this.bC_Label2.Location = new System.Drawing.Point(27, 183);
            this.bC_Label2.Name = "bC_Label2";
            this.bC_Label2.Size = new System.Drawing.Size(68, 13);
            this.bC_Label2.TabIndex = 14;
            this.bC_Label2.Text = "Bağlı Projeler";
            // 
            // bC_Label1
            // 
            this.bC_Label1.AutoSize = true;
            this.bC_Label1.Location = new System.Drawing.Point(24, 96);
            this.bC_Label1.Name = "bC_Label1";
            this.bC_Label1.Size = new System.Drawing.Size(50, 13);
            this.bC_Label1.TabIndex = 12;
            this.bC_Label1.Text = "Açıklama";
            // 
            // txtTesis
            // 
            this.txtTesis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTesis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTesis.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTesis.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTesis.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTesis.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtTesis.Label = null;
            this.txtTesis.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTesis.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTesis.LabelText = "Tesis Kodu";
            this.txtTesis.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTesis.LabelTop = 3;
            this.txtTesis.LabelVisible = true;
            this.txtTesis.LabelWith = 100;
            this.txtTesis.Location = new System.Drawing.Point(377, 31);
            this.txtTesis.Name = "txtTesis";
            this.txtTesis.NumericBox = false;
            this.txtTesis.NumericDecimal = 0;
            this.txtTesis.ReferansTip = 0;
            this.txtTesis.Required = false;
            this.txtTesis.RequiredPass = true;
            this.txtTesis.Size = new System.Drawing.Size(134, 20);
            this.txtTesis.TabIndex = 11;
            this.txtTesis.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTesis.WordWrap = false;
            this.txtTesis.ButtonClick += new System.EventHandler(this.txtTesis_ButtonClick);
            // 
            // txtAciklama
            // 
            this.txtAciklama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAciklama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAciklama.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAciklama.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtAciklama.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtAciklama.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtAciklama.Label = null;
            this.txtAciklama.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAciklama.LabelText = null;
            this.txtAciklama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtAciklama.LabelTop = 3;
            this.txtAciklama.LabelVisible = false;
            this.txtAciklama.LabelWith = 100;
            this.txtAciklama.Location = new System.Drawing.Point(27, 112);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.NumericBox = false;
            this.txtAciklama.NumericDecimal = 0;
            this.txtAciklama.ReferansTip = 0;
            this.txtAciklama.Required = false;
            this.txtAciklama.RequiredPass = true;
            this.txtAciklama.Size = new System.Drawing.Size(593, 52);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtAciklama.WordWrap = false;
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
            this.txtProjeAdi.LabelText = "Çatı Proje Adı";
            this.txtProjeAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeAdi.LabelTop = 3;
            this.txtProjeAdi.LabelVisible = true;
            this.txtProjeAdi.LabelWith = 100;
            this.txtProjeAdi.Location = new System.Drawing.Point(122, 58);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.NumericBox = false;
            this.txtProjeAdi.NumericDecimal = 0;
            this.txtProjeAdi.ReferansTip = 0;
            this.txtProjeAdi.Required = false;
            this.txtProjeAdi.RequiredPass = true;
            this.txtProjeAdi.Size = new System.Drawing.Size(389, 20);
            this.txtProjeAdi.TabIndex = 7;
            this.txtProjeAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeAdi.WordWrap = false;
            // 
            // txtProjeKodu
            // 
            this.txtProjeKodu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeKodu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeKodu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeKodu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeKodu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeKodu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtProjeKodu.Label = null;
            this.txtProjeKodu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeKodu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeKodu.LabelText = "Çatı Proje Kodu";
            this.txtProjeKodu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeKodu.LabelTop = 3;
            this.txtProjeKodu.LabelVisible = true;
            this.txtProjeKodu.LabelWith = 100;
            this.txtProjeKodu.Location = new System.Drawing.Point(122, 32);
            this.txtProjeKodu.Name = "txtProjeKodu";
            this.txtProjeKodu.NumericBox = false;
            this.txtProjeKodu.NumericDecimal = 0;
            this.txtProjeKodu.ReferansTip = 0;
            this.txtProjeKodu.Required = false;
            this.txtProjeKodu.RequiredPass = true;
            this.txtProjeKodu.Size = new System.Drawing.Size(134, 20);
            this.txtProjeKodu.TabIndex = 6;
            this.txtProjeKodu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeKodu.WordWrap = false;
            this.txtProjeKodu.TextChanged += new System.EventHandler(this.txtProjeKodu_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(536, 29);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 37);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // GrdProjeler
            // 
            this.GrdProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProjeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjeNo,
            this.colProjeAdi,
            this.colMaliyetMerkezi});
            this.GrdProjeler.Location = new System.Drawing.Point(27, 199);
            this.GrdProjeler.MenuDeleteVisible = true;
            this.GrdProjeler.Name = "GrdProjeler";
            this.GrdProjeler.RowHeadersWidth = 25;
            this.GrdProjeler.Size = new System.Drawing.Size(593, 203);
            this.GrdProjeler.TabIndex = 19;
            this.GrdProjeler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrdProjeler_DataError);
            // 
            // colProjeNo
            // 
            this.colProjeNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.colProjeNo.DataPropertyName = "PRONUM";
            buttonTextCell1.ErrorText = "";
            buttonTextCell1.Style = dataGridViewCellStyle2;
            buttonTextCell1.Value = "";
            buttonTextCell1.ValueType = typeof(string);
            dataGridViewCellStyle1.NullValue = buttonTextCell1;
            this.colProjeNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colProjeNo.HeaderText = "Proje No";
            this.colProjeNo.Name = "colProjeNo";
            this.colProjeNo.Width = 150;
            this.colProjeNo.Button_Click += new System.EventHandler(this.colProjeKodu_Button_Click);
            // 
            // colProjeAdi
            // 
            this.colProjeAdi.DataPropertyName = "STEXT";
            this.colProjeAdi.HeaderText = "Proje Adı";
            this.colProjeAdi.Name = "colProjeAdi";
            this.colProjeAdi.Width = 250;
            // 
            // colMaliyetMerkezi
            // 
            this.colMaliyetMerkezi.DataPropertyName = "costcenter";
            this.colMaliyetMerkezi.HeaderText = "Maliyet Merkezi";
            this.colMaliyetMerkezi.MaxInputLength = 10;
            this.colMaliyetMerkezi.Name = "colMaliyetMerkezi";
            this.colMaliyetMerkezi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaliyetMerkezi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmCatiProjeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 425);
            this.Controls.Add(this.GrdProjeler);
            this.Controls.Add(this.bC_Label2);
            this.Controls.Add(this.bC_Label1);
            this.Controls.Add(this.txtTesis);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtProjeAdi);
            this.Controls.Add(this.txtProjeKodu);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FrmCatiProjeDetay";
            this.Text = "Çatı Proje Detayı";
            this.Load += new System.EventHandler(this.FrmCatiProjeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnKaydet;
        private BaseControls.BC_TextBox txtProjeAdi;
        private BaseControls.BC_TextBox txtProjeKodu;
        private BaseControls.BC_TextBox txtAciklama;
        private BaseControls.BC_TextBox txtTesis;
        private BaseControls.BC_Label bC_Label1;
        private BaseControls.BC_Label bC_Label2;
        private BaseControls.BC_DataGrid GrdProjeler;
        private BaseControls.ButtonTextColumn colProjeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaliyetMerkezi;
    }
}