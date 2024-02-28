namespace ALPARGE.AppForms.Sistem
{
    partial class BaseRecordList
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
            this.btnEkle = new BaseControls.BC_Button(this.components);
            this.btnDegistir = new BaseControls.BC_Button(this.components);
            this.btnSil = new BaseControls.BC_Button(this.components);
            this.GrdList = new BaseControls.BC_DataGrid();
            this.txtSearch = new BaseControls.BC_TextBox();
            this.btnAra = new BaseControls.BC_Button(this.components);
            this.cbfilterfield = new BaseControls.BC_ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 13);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yeni Kayıt";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(94, 13);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(175, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // GrdList
            // 
            this.GrdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdList.Location = new System.Drawing.Point(13, 43);
            this.GrdList.MenuDeleteVisible = true;
            this.GrdList.Name = "GrdList";
            this.GrdList.RowHeadersWidth = 25;
            this.GrdList.Size = new System.Drawing.Size(685, 411);
            this.GrdList.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSearch.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSearch.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSearch.Label = null;
            this.txtSearch.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.LabelText = null;
            this.txtSearch.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSearch.LabelTop = 3;
            this.txtSearch.LabelVisible = false;
            this.txtSearch.LabelWith = 100;
            this.txtSearch.Location = new System.Drawing.Point(493, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NumericBox = false;
            this.txtSearch.NumericDecimal = 0;
            this.txtSearch.ReferansTip = 0;
            this.txtSearch.Required = false;
            this.txtSearch.RequiredPass = true;
            this.txtSearch.Size = new System.Drawing.Size(124, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSearch.WordWrap = false;
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Location = new System.Drawing.Point(623, 13);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cbfilterfield
            // 
            this.cbfilterfield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbfilterfield.BorderColor = System.Drawing.Color.DarkGray;
            this.cbfilterfield.BorderFocusColor = System.Drawing.Color.Maroon;
            this.cbfilterfield.BorderSelectColor = System.Drawing.Color.Gray;
            this.cbfilterfield.FormattingEnabled = true;
            this.cbfilterfield.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbfilterfield.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.cbfilterfield.LabelText = null;
            this.cbfilterfield.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.cbfilterfield.LabelTop = 4;
            this.cbfilterfield.LabelVisible = false;
            this.cbfilterfield.LabelWith = 100;
            this.cbfilterfield.Location = new System.Drawing.Point(366, 15);
            this.cbfilterfield.Name = "cbfilterfield";
            this.cbfilterfield.Size = new System.Drawing.Size(121, 21);
            this.cbfilterfield.TabIndex = 7;
            // 
            // BaseRecordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 466);
            this.Controls.Add(this.cbfilterfield);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.GrdList);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Name = "BaseRecordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kayıt Listesi";
            this.Load += new System.EventHandler(this.BaseRecordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnEkle;
        private BaseControls.BC_Button btnDegistir;
        private BaseControls.BC_Button btnSil;
        private BaseControls.BC_TextBox txtSearch;
        private BaseControls.BC_Button btnAra;
        private BaseControls.BC_ComboBox cbfilterfield;
        public BaseControls.BC_DataGrid GrdList;
    }
}