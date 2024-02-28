namespace ALPARGE.AppForms.Genel
{
    partial class FrmKullaniciTanim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciTanim));
            this.btnDetay = new BaseControls.BC_Button(this.components);
            this.btnYeni = new BaseControls.BC_Button(this.components);
            this.txtArama = new BaseControls.BC_TextBox();
            this.btnListele = new BaseControls.BC_Button(this.components);
            this.GrdListe = new BaseControls.BC_DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetay
            // 
            this.btnDetay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetay.Image = ((System.Drawing.Image)(resources.GetObject("btnDetay.Image")));
            this.btnDetay.Location = new System.Drawing.Point(714, 17);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(107, 23);
            this.btnDetay.TabIndex = 16;
            this.btnDetay.Text = "Kullanıcı Detayı";
            this.btnDetay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.Location = new System.Drawing.Point(578, 17);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(107, 23);
            this.btnYeni.TabIndex = 15;
            this.btnYeni.Text = "Yeni Kullanıcı";
            this.btnYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtArama
            // 
            this.txtArama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtArama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtArama.BorderColor = System.Drawing.Color.DarkGray;
            this.txtArama.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtArama.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtArama.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtArama.Label = null;
            this.txtArama.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtArama.LabelText = "Kullanıcı ismi";
            this.txtArama.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtArama.LabelTop = 3;
            this.txtArama.LabelVisible = true;
            this.txtArama.LabelWith = 100;
            this.txtArama.Location = new System.Drawing.Point(244, 20);
            this.txtArama.Name = "txtArama";
            this.txtArama.NumericBox = false;
            this.txtArama.NumericDecimal = 0;
            this.txtArama.ReferansTip = 0;
            this.txtArama.Required = false;
            this.txtArama.RequiredPass = true;
            this.txtArama.Size = new System.Drawing.Size(149, 20);
            this.txtArama.TabIndex = 13;
            this.txtArama.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtArama.WordWrap = false;
            // 
            // btnListele
            // 
            this.btnListele.Image = ((System.Drawing.Image)(resources.GetObject("btnListele.Image")));
            this.btnListele.Location = new System.Drawing.Point(12, 17);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = " Listeyi Yenile";
            this.btnListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // GrdListe
            // 
            this.GrdListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.GrdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListe.Location = new System.Drawing.Point(13, 46);
            this.GrdListe.MenuDeleteVisible = true;
            this.GrdListe.Name = "GrdListe";
            this.GrdListe.RowHeadersWidth = 25;
            this.GrdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListe.Size = new System.Drawing.Size(808, 404);
            this.GrdListe.TabIndex = 0;
            this.GrdListe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdListe_RowEnter);
            // 
            // FrmKullaniciTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 462);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.GrdListe);
            this.Name = "FrmKullaniciTanim";
            this.Text = "Kullanıcı Tanımları";
            this.Load += new System.EventHandler(this.FrmKullaniciTanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdListe;
        private BaseControls.BC_Button btnListele;
        private BaseControls.BC_TextBox txtArama;
        private BaseControls.BC_Button btnYeni;
        private BaseControls.BC_Button btnDetay;
    }
}