namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjeListesi
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
            this.btnProjeKart = new BaseControls.BC_Button(this.components);
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.btnYenile = new BaseControls.BC_Button(this.components);
            this.cbProjeTips = new BaseControls.BC_ComboBox();
            this.GrdProjeList = new BaseControls.BC_DataGrid();
            this.txtProjeSorumlusu = new BaseControls.BC_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjeKart
            // 
            this.btnProjeKart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjeKart.Location = new System.Drawing.Point(899, 5);
            this.btnProjeKart.Name = "btnProjeKart";
            this.btnProjeKart.Size = new System.Drawing.Size(124, 23);
            this.btnProjeKart.TabIndex = 17;
            this.btnProjeKart.Text = "Proje Kartı";
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
            this.txtProjeNo.Location = new System.Drawing.Point(529, 5);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 14;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            this.txtProjeNo.TextChanged += new System.EventHandler(this.txtProjeNo_TextChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(12, 5);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(102, 23);
            this.btnYenile.TabIndex = 13;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // cbProjeTips
            // 
            this.cbProjeTips.BorderColor = System.Drawing.Color.DarkGray;
            this.cbProjeTips.BorderFocusColor = System.Drawing.Color.Maroon;
            this.cbProjeTips.BorderSelectColor = System.Drawing.Color.Gray;
            this.cbProjeTips.FormattingEnabled = true;
            this.cbProjeTips.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbProjeTips.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.cbProjeTips.LabelText = "Proje Statüsü";
            this.cbProjeTips.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.cbProjeTips.LabelTop = 4;
            this.cbProjeTips.LabelVisible = true;
            this.cbProjeTips.LabelWith = 100;
            this.cbProjeTips.Location = new System.Drawing.Point(224, 5);
            this.cbProjeTips.Name = "cbProjeTips";
            this.cbProjeTips.Size = new System.Drawing.Size(200, 21);
            this.cbProjeTips.TabIndex = 11;
            this.cbProjeTips.SelectedIndexChanged += new System.EventHandler(this.cbProjeTips_SelectedIndexChanged);
            // 
            // GrdProjeList
            // 
            this.GrdProjeList.AllowUserToAddRows = false;
            this.GrdProjeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdProjeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdProjeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProjeList.Location = new System.Drawing.Point(12, 32);
            this.GrdProjeList.MenuDeleteVisible = true;
            this.GrdProjeList.Name = "GrdProjeList";
            this.GrdProjeList.ReadOnly = true;
            this.GrdProjeList.RowHeadersWidth = 25;
            this.GrdProjeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdProjeList.Size = new System.Drawing.Size(1011, 498);
            this.GrdProjeList.TabIndex = 10;
            this.GrdProjeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProjeList_CellContentClick);
            this.GrdProjeList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProjeList_RowEnter);
            this.GrdProjeList.DoubleClick += new System.EventHandler(this.GrdProjeList_DoubleClick);
            this.GrdProjeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GrdProjeList_MouseDoubleClick);
            // 
            // txtProjeSorumlusu
            // 
            this.txtProjeSorumlusu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtProjeSorumlusu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProjeSorumlusu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProjeSorumlusu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtProjeSorumlusu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtProjeSorumlusu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.txtProjeSorumlusu.Label = null;
            this.txtProjeSorumlusu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjeSorumlusu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProjeSorumlusu.LabelText = "Sorumlu";
            this.txtProjeSorumlusu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeSorumlusu.LabelTop = 3;
            this.txtProjeSorumlusu.LabelVisible = true;
            this.txtProjeSorumlusu.LabelWith = 80;
            this.txtProjeSorumlusu.Location = new System.Drawing.Point(742, 5);
            this.txtProjeSorumlusu.Name = "txtProjeSorumlusu";
            this.txtProjeSorumlusu.NumericBox = false;
            this.txtProjeSorumlusu.NumericDecimal = 0;
            this.txtProjeSorumlusu.ReferansTip = 0;
            this.txtProjeSorumlusu.Required = false;
            this.txtProjeSorumlusu.RequiredPass = true;
            this.txtProjeSorumlusu.Size = new System.Drawing.Size(100, 20);
            this.txtProjeSorumlusu.TabIndex = 21;
            this.txtProjeSorumlusu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeSorumlusu.WordWrap = false;
            this.txtProjeSorumlusu.ButtonClick += new System.EventHandler(this.txtProjeSorumlusu_ButtonClick);
            // 
            // FrmProjeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 542);
            this.Controls.Add(this.txtProjeSorumlusu);
            this.Controls.Add(this.btnProjeKart);
            this.Controls.Add(this.txtProjeNo);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.cbProjeTips);
            this.Controls.Add(this.GrdProjeList);
            this.Name = "FrmProjeListesi";
            this.Text = "Tüm Projeler";
            this.Load += new System.EventHandler(this.FrmProjeListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdProjeList;
        private BaseControls.BC_ComboBox cbProjeTips;
        private BaseControls.BC_Button btnYenile;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_Button btnProjeKart;
        private BaseControls.BC_TextBox txtProjeSorumlusu;
    }
}