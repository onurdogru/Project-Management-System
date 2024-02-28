namespace ALPARGE.AppForms.Sistem
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOk = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.GRDListe = new BaseControls.BC_DataGrid();
            this.bC_Panel1 = new BaseControls.Forms.BC_Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRDListe)).BeginInit();
            this.bC_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOk,
            this.btnCancel,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 29);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOk
            // 
            this.btnOk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Padding = new System.Windows.Forms.Padding(1, 1, 10, 1);
            this.btnOk.Size = new System.Drawing.Size(35, 26);
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCancel.Size = new System.Drawing.Size(34, 26);
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.ToolTipText = "Vazgeç";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 26);
            this.toolStripLabel1.Text = "  Kayıt Arama";
            // 
            // GRDListe
            // 
            this.GRDListe.AllowUserToAddRows = false;
            this.GRDListe.AllowUserToDeleteRows = false;
            this.GRDListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GRDListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRDListe.Location = new System.Drawing.Point(5, 5);
            this.GRDListe.MenuDeleteVisible = true;
            this.GRDListe.Name = "GRDListe";
            this.GRDListe.ReadOnly = true;
            this.GRDListe.RowHeadersWidth = 25;
            this.GRDListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRDListe.Size = new System.Drawing.Size(697, 318);
            this.GRDListe.TabIndex = 2;
            this.GRDListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRDListe_CellDoubleClick);
            // 
            // bC_Panel1
            // 
            this.bC_Panel1.Controls.Add(this.GRDListe);
            this.bC_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bC_Panel1.Location = new System.Drawing.Point(0, 29);
            this.bC_Panel1.Name = "bC_Panel1";
            this.bC_Panel1.Padding = new System.Windows.Forms.Padding(5);
            this.bC_Panel1.Size = new System.Drawing.Size(707, 328);
            this.bC_Panel1.TabIndex = 3;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 357);
            this.Controls.Add(this.bC_Panel1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "SearchForm";
            this.Text = "Kayıt Arama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XSearchForm_FormClosing);
            this.Load += new System.EventHandler(this.XSearchForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DG_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRDListe)).EndInit();
            this.bC_Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private BaseControls.BC_DataGrid GRDListe;
        private System.Windows.Forms.ToolStripButton btnOk;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private BaseControls.Forms.BC_Panel bC_Panel1;
    }
}