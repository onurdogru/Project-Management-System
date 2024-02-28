namespace ALPARGE.AppForms.Projeler
{
    partial class FrmPersonelProjeCalisma
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
            this.btnDetay = new BaseControls.BC_Button(this.components);
            this.btnYenile = new BaseControls.BC_Button(this.components);
            this.GrdListe = new BaseControls.BC_DataGrid();
            this.colTarih = new BaseControls.CalendarColumn();
            this.colTesis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetay
            // 
            this.btnDetay.Location = new System.Drawing.Point(138, 12);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(93, 23);
            this.btnDetay.TabIndex = 3;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btn_Detay_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(12, 12);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(93, 23);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // GrdListe
            // 
            this.GrdListe.AllowUserToAddRows = false;
            this.GrdListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTarih,
            this.colTesis,
            this.colCalisan});
            this.GrdListe.Location = new System.Drawing.Point(12, 46);
            this.GrdListe.MenuDeleteVisible = true;
            this.GrdListe.Name = "GrdListe";
            this.GrdListe.RowHeadersWidth = 25;
            this.GrdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListe.Size = new System.Drawing.Size(834, 513);
            this.GrdListe.TabIndex = 1;
            this.GrdListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdListe_CellContentClick);
            this.GrdListe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GrdListe_MouseDoubleClick);
            // 
            // colTarih
            // 
            this.colTarih.CustomFormat = null;
            this.colTarih.DataPropertyName = "Tarih";
            dataGridViewCellStyle1.NullValue = new System.DateTime(((long)(0)));
            this.colTarih.DefaultCellStyle = dataGridViewCellStyle1;
            this.colTarih.DefaultDate = new System.DateTime(((long)(0)));
            this.colTarih.HeaderText = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Width = 37;
            // 
            // colTesis
            // 
            this.colTesis.DataPropertyName = "Tesis";
            this.colTesis.HeaderText = "Tesis";
            this.colTesis.Name = "colTesis";
            this.colTesis.Width = 57;
            // 
            // colCalisan
            // 
            this.colCalisan.DataPropertyName = "Calisan";
            this.colCalisan.HeaderText = "Çalışan Sayısı";
            this.colCalisan.Name = "colCalisan";
            this.colCalisan.Width = 96;
            // 
            // FrmPersonelProjeCalisma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 571);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.GrdListe);
            this.Name = "FrmPersonelProjeCalisma";
            this.Text = "Personel Çalışmaları";
            this.Load += new System.EventHandler(this.FrmPersonelProjeCalisma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.BC_DataGrid GrdListe;
        private BaseControls.BC_Button btnYenile;
        private BaseControls.BC_Button btnDetay;
        private BaseControls.CalendarColumn colTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTesis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCalisan;
    }
}