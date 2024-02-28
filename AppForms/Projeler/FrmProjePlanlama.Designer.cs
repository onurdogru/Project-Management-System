namespace ALPARGE.AppForms.Projeler
{
    partial class FrmProjePlanlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjePlanlama));
            this.txtSorumlu = new BaseControls.BC_TextBox();
            this.txtCatiProje = new BaseControls.BC_TextBox();
            this.btnDuzenle = new BaseControls.BC_Button(this.components);
            this.btnAra = new BaseControls.BC_Button(this.components);
            this.GrdProjeList = new BaseControls.BC_DataGrid();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSorumlu
            // 
            this.txtSorumlu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSorumlu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSorumlu.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSorumlu.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSorumlu.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSorumlu.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSorumlu.Label = null;
            this.txtSorumlu.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSorumlu.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSorumlu.LabelText = "Proje Sorumlusu";
            this.txtSorumlu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSorumlu.LabelTop = 3;
            this.txtSorumlu.LabelVisible = true;
            this.txtSorumlu.LabelWith = 100;
            this.txtSorumlu.Location = new System.Drawing.Point(192, 8);
            this.txtSorumlu.Name = "txtSorumlu";
            this.txtSorumlu.NumericBox = false;
            this.txtSorumlu.NumericDecimal = 0;
            this.txtSorumlu.ReferansTip = 0;
            this.txtSorumlu.Required = false;
            this.txtSorumlu.RequiredPass = true;
            this.txtSorumlu.Size = new System.Drawing.Size(100, 20);
            this.txtSorumlu.TabIndex = 14;
            this.txtSorumlu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSorumlu.WordWrap = false;
            // 
            // txtCatiProje
            // 
            this.txtCatiProje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCatiProje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCatiProje.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCatiProje.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtCatiProje.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtCatiProje.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtCatiProje.Label = null;
            this.txtCatiProje.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCatiProje.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCatiProje.LabelText = "Çatı Proje";
            this.txtCatiProje.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtCatiProje.LabelTop = 3;
            this.txtCatiProje.LabelVisible = true;
            this.txtCatiProje.LabelWith = 100;
            this.txtCatiProje.Location = new System.Drawing.Point(636, 8);
            this.txtCatiProje.Name = "txtCatiProje";
            this.txtCatiProje.NumericBox = false;
            this.txtCatiProje.NumericDecimal = 0;
            this.txtCatiProje.ReferansTip = 0;
            this.txtCatiProje.Required = false;
            this.txtCatiProje.RequiredPass = true;
            this.txtCatiProje.Size = new System.Drawing.Size(100, 20);
            this.txtCatiProje.TabIndex = 12;
            this.txtCatiProje.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtCatiProje.WordWrap = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(778, 6);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(102, 23);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(12, 5);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(71, 23);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // GrdProjeList
            // 
            this.GrdProjeList.AllowUserToAddRows = false;
            this.GrdProjeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdProjeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdProjeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdProjeList.Location = new System.Drawing.Point(12, 34);
            this.GrdProjeList.MenuDeleteVisible = true;
            this.GrdProjeList.Name = "GrdProjeList";
            this.GrdProjeList.ReadOnly = true;
            this.GrdProjeList.RowHeadersWidth = 25;
            this.GrdProjeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdProjeList.Size = new System.Drawing.Size(868, 476);
            this.GrdProjeList.TabIndex = 8;
            this.GrdProjeList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdProjeList_CellMouseDoubleClick);
            this.GrdProjeList.DoubleClick += new System.EventHandler(this.GrdProjeList_DoubleClick);
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
            this.txtProjeNo.LabelWith = 100;
            this.txtProjeNo.Location = new System.Drawing.Point(413, 7);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(100, 20);
            this.txtProjeNo.TabIndex = 7;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
            // 
            // FrmProjePlanlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 522);
            this.Controls.Add(this.txtSorumlu);
            this.Controls.Add(this.txtCatiProje);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.GrdProjeList);
            this.Controls.Add(this.txtProjeNo);
            this.Name = "FrmProjePlanlama";
            this.Text = "Proje Planlama";
            this.Load += new System.EventHandler(this.FrmProjePlanlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProjeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_Button btnDuzenle;
        private BaseControls.BC_Button btnAra;
        private BaseControls.BC_DataGrid GrdProjeList;
        private BaseControls.BC_TextBox txtProjeNo;
        private BaseControls.BC_TextBox txtCatiProje;
        private BaseControls.BC_TextBox txtSorumlu;
    }
}