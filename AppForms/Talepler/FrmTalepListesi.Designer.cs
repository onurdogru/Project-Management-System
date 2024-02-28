namespace ALPARGE.AppForms.Talepler
{
    partial class FrmTalepListesi
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
            this.btnTalepDuzenle = new BaseControls.BC_Button(this.components);
            this.btnYeniTalep = new BaseControls.BC_Button(this.components);
            this.btnAra = new BaseControls.BC_Button(this.components);
            this.GrdTalepList = new BaseControls.BC_DataGrid();
            this.txtTalepNo = new BaseControls.BC_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdTalepList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTalepDuzenle
            // 
            this.btnTalepDuzenle.Location = new System.Drawing.Point(154, 12);
            this.btnTalepDuzenle.Name = "btnTalepDuzenle";
            this.btnTalepDuzenle.Size = new System.Drawing.Size(102, 23);
            this.btnTalepDuzenle.TabIndex = 5;
            this.btnTalepDuzenle.Text = "Talebi Düzenle";
            this.btnTalepDuzenle.UseVisualStyleBackColor = true;
            this.btnTalepDuzenle.Click += new System.EventHandler(this.btnTalepDuzenle_Click);
            // 
            // btnYeniTalep
            // 
            this.btnYeniTalep.Location = new System.Drawing.Point(12, 12);
            this.btnYeniTalep.Name = "btnYeniTalep";
            this.btnYeniTalep.Size = new System.Drawing.Size(121, 23);
            this.btnYeniTalep.TabIndex = 4;
            this.btnYeniTalep.Text = "Yeni Talep Oluştur";
            this.btnYeniTalep.UseVisualStyleBackColor = true;
            this.btnYeniTalep.Click += new System.EventHandler(this.btnYeniTalep_Click);
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAra.Location = new System.Drawing.Point(684, 13);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(34, 21);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // GrdTalepList
            // 
            this.GrdTalepList.AllowUserToAddRows = false;
            this.GrdTalepList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdTalepList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdTalepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdTalepList.Location = new System.Drawing.Point(12, 39);
            this.GrdTalepList.MenuDeleteVisible = true;
            this.GrdTalepList.Name = "GrdTalepList";
            this.GrdTalepList.ReadOnly = true;
            this.GrdTalepList.RowHeadersWidth = 25;
            this.GrdTalepList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdTalepList.Size = new System.Drawing.Size(707, 480);
            this.GrdTalepList.TabIndex = 2;
            this.GrdTalepList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdTalepList_CellContentClick);
            this.GrdTalepList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdTalepList_RowEnter);
            // 
            // txtTalepNo
            // 
            this.txtTalepNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTalepNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTalepNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTalepNo.BorderColor = System.Drawing.Color.DarkGray;
            this.txtTalepNo.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtTalepNo.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtTalepNo.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtTalepNo.Label = null;
            this.txtTalepNo.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepNo.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTalepNo.LabelText = "Talep No";
            this.txtTalepNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtTalepNo.LabelTop = 3;
            this.txtTalepNo.LabelVisible = true;
            this.txtTalepNo.LabelWith = 100;
            this.txtTalepNo.Location = new System.Drawing.Point(577, 14);
            this.txtTalepNo.Name = "txtTalepNo";
            this.txtTalepNo.NumericBox = false;
            this.txtTalepNo.NumericDecimal = 0;
            this.txtTalepNo.ReferansTip = 0;
            this.txtTalepNo.Required = false;
            this.txtTalepNo.RequiredPass = true;
            this.txtTalepNo.Size = new System.Drawing.Size(100, 20);
            this.txtTalepNo.TabIndex = 0;
            this.txtTalepNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtTalepNo.WordWrap = false;
            // 
            // FrmTalepListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 531);
            this.Controls.Add(this.btnTalepDuzenle);
            this.Controls.Add(this.btnYeniTalep);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.GrdTalepList);
            this.Controls.Add(this.txtTalepNo);
            this.Name = "FrmTalepListesi";
            this.Text = "Talep Listesi";
            this.Load += new System.EventHandler(this.FrmTalepListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdTalepList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtTalepNo;
        private BaseControls.BC_DataGrid GrdTalepList;
        private BaseControls.BC_Button btnAra;
        private BaseControls.BC_Button btnYeniTalep;
        private BaseControls.BC_Button btnTalepDuzenle;
    }
}