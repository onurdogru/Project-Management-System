namespace ALPARGE.AppForms.Analizler
{
    partial class FrmProjeTamamlanmaDetay
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdPlan = new BaseControls.BC_DataGrid();
            this.GrdCalisma = new BaseControls.BC_DataGrid();
            this.bC_Panel1 = new BaseControls.Forms.BC_Panel();
            this.txtProjeNo = new BaseControls.BC_TextBox();
            this.txtProjeAdi = new BaseControls.BC_TextBox();
            this.cbDetay = new BaseControls.BC_CheckBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCalisma)).BeginInit();
            this.bC_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GrdPlan);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GrdCalisma);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 523);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 20;
            // 
            // GrdPlan
            // 
            this.GrdPlan.AllowUserToAddRows = false;
            this.GrdPlan.AllowUserToDeleteRows = false;
            this.GrdPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdPlan.Location = new System.Drawing.Point(5, 5);
            this.GrdPlan.MenuDeleteVisible = true;
            this.GrdPlan.Name = "GrdPlan";
            this.GrdPlan.RowHeadersWidth = 25;
            this.GrdPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdPlan.Size = new System.Drawing.Size(1061, 249);
            this.GrdPlan.TabIndex = 19;
            this.GrdPlan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdPlan_RowEnter);
            // 
            // GrdCalisma
            // 
            this.GrdCalisma.AllowUserToAddRows = false;
            this.GrdCalisma.AllowUserToDeleteRows = false;
            this.GrdCalisma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdCalisma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdCalisma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdCalisma.Location = new System.Drawing.Point(5, 5);
            this.GrdCalisma.MenuDeleteVisible = true;
            this.GrdCalisma.Name = "GrdCalisma";
            this.GrdCalisma.RowHeadersWidth = 25;
            this.GrdCalisma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdCalisma.Size = new System.Drawing.Size(1061, 250);
            this.GrdCalisma.TabIndex = 20;
            // 
            // bC_Panel1
            // 
            this.bC_Panel1.Controls.Add(this.cbDetay);
            this.bC_Panel1.Controls.Add(this.txtProjeAdi);
            this.bC_Panel1.Controls.Add(this.txtProjeNo);
            this.bC_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bC_Panel1.Location = new System.Drawing.Point(0, 0);
            this.bC_Panel1.Name = "bC_Panel1";
            this.bC_Panel1.Size = new System.Drawing.Size(1071, 46);
            this.bC_Panel1.TabIndex = 19;
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
            this.txtProjeNo.LabelWith = 60;
            this.txtProjeNo.Location = new System.Drawing.Point(82, 12);
            this.txtProjeNo.Name = "txtProjeNo";
            this.txtProjeNo.NumericBox = false;
            this.txtProjeNo.NumericDecimal = 0;
            this.txtProjeNo.ReferansTip = 0;
            this.txtProjeNo.Required = false;
            this.txtProjeNo.RequiredPass = true;
            this.txtProjeNo.Size = new System.Drawing.Size(113, 20);
            this.txtProjeNo.TabIndex = 18;
            this.txtProjeNo.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeNo.WordWrap = false;
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
            this.txtProjeAdi.LabelText = "Açıklama";
            this.txtProjeAdi.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeAdi.LabelTop = 3;
            this.txtProjeAdi.LabelVisible = true;
            this.txtProjeAdi.LabelWith = 60;
            this.txtProjeAdi.Location = new System.Drawing.Point(313, 12);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.NumericBox = false;
            this.txtProjeAdi.NumericDecimal = 0;
            this.txtProjeAdi.ReferansTip = 0;
            this.txtProjeAdi.Required = false;
            this.txtProjeAdi.RequiredPass = true;
            this.txtProjeAdi.Size = new System.Drawing.Size(454, 20);
            this.txtProjeAdi.TabIndex = 21;
            this.txtProjeAdi.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeAdi.WordWrap = false;
            // 
            // cbDetay
            // 
            this.cbDetay.AutoSize = true;
            this.cbDetay.Location = new System.Drawing.Point(812, 14);
            this.cbDetay.Name = "cbDetay";
            this.cbDetay.Size = new System.Drawing.Size(151, 17);
            this.cbDetay.TabIndex = 22;
            this.cbDetay.Text = "Gerçekleşmeyi Detaylandır";
            this.cbDetay.UseVisualStyleBackColor = true;
            this.cbDetay.CheckedChanged += new System.EventHandler(this.cbDetay_CheckedChanged);
            // 
            // FrmProjeTamamlanmaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 569);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bC_Panel1);
            this.Name = "FrmProjeTamamlanmaDetay";
            this.Text = "Proje Planlama ve Gerçekleşme detayı";
            this.Load += new System.EventHandler(this.FrmProjeTamamlanmaDetay_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCalisma)).EndInit();
            this.bC_Panel1.ResumeLayout(false);
            this.bC_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseControls.Forms.BC_Panel bC_Panel1;
        private BaseControls.BC_TextBox txtProjeNo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BaseControls.BC_DataGrid GrdPlan;
        private BaseControls.BC_DataGrid GrdCalisma;
        private BaseControls.BC_TextBox txtProjeAdi;
        private BaseControls.BC_CheckBox cbDetay;

    }
}