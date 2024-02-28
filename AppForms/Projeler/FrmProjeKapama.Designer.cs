namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjeKapama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeKapama));
            this.btnProjeKart = new BaseControls.BC_Button(this.components);
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.btnYenile = new BaseControls.BC_Button(this.components);
            this.GrdProjeList = new BaseControls.BC_DataGrid();
            this.btnProjeKapat = new BaseControls.BC_Button(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjeKart
            // 
            this.btnProjeKart.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeKart.Image")));
            this.btnProjeKart.Location = new System.Drawing.Point(806, 7);
            this.btnProjeKart.Name = "btnProjeKart";
            this.btnProjeKart.Size = new System.Drawing.Size(124, 24);
            this.btnProjeKart.TabIndex = 24;
            this.btnProjeKart.Text = "Proje Detayı";
            this.btnProjeKart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjeKart.UseVisualStyleBackColor = true;
            this.btnProjeKart.Click += new System.EventHandler(this.btnProjeKart_Click);
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
            this.txtProjeNo.LabelText = "Proje No";
            this.txtProjeNo.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeNo.LabelTop = 3;
            this.txtProjeNo.LabelVisible = true;
            this.txtProjeNo.LabelWith = 80;
            this.txtProjeNo.Location = new System.Drawing.Point(99, 7);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 23;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.TextChanged += new System.EventHandler(this.txtProjeNo_TextChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(215, 5);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(102, 24);
            this.btnYenile.TabIndex = 22;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // GrdProjeList
            // 
            this.GrdProjeList.AllowUserToAddRows = false;
            this.GrdProjeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdProjeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdProjeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProjeList.Location = new System.Drawing.Point(12, 34);
            this.GrdProjeList.MenuDeleteVisible = true;
            this.GrdProjeList.Name = "GrdProjeList";
            this.GrdProjeList.ReadOnly = true;
            this.GrdProjeList.RowHeadersWidth = 25;
            this.GrdProjeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdProjeList.Size = new System.Drawing.Size(918, 498);
            this.GrdProjeList.TabIndex = 20;
            this.GrdProjeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProjeList_RowEnter);
            this.GrdProjeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GrdProjeList_MouseDoubleClick);
            // 
            // btnProjeKapat
            // 
            this.btnProjeKapat.Image = global::ALPARGE.Properties.Resources.confirm;
            this.btnProjeKapat.Location = new System.Drawing.Point(668, 7);
            this.btnProjeKapat.Name = "btnProjeKapat";
            this.btnProjeKapat.Size = new System.Drawing.Size(117, 24);
            this.btnProjeKapat.TabIndex = 26;
            this.btnProjeKapat.Text = "Projeyi Kapat";
            this.btnProjeKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjeKapat.UseVisualStyleBackColor = true;
            this.btnProjeKapat.Click += new System.EventHandler(this.btnProjeKapat_Click);
            // 
            // FrmProjeKapama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 538);
            this.Controls.Add(this.btnProjeKapat);
            this.Controls.Add(this.btnProjeKart);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.GrdProjeList);
            this.Name = "FrmProjeKapama";
            this.Text = "Proje Kapatma";
            this.Load += new System.EventHandler(this.FrmProjeKapama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnProjeKart;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_Button btnYenile;
        private BaseControls.BC_DataGrid GrdProjeList;
        private BaseControls.BC_Button btnProjeKapat;
    }
}