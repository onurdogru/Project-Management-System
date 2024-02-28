namespace ALPARGE.AppForms.Talepler
{
    partial class FrmSorumluAtama
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
            this.btnSorumluAta = new BaseControls.BC_Button(this.components);
            this.txtProjeSorumlusu = new BaseControls.BC_TextBox();
            this.txtSecilenProje = new BaseControls.BC_TextBox();
            this.btnYenile = new BaseControls.BC_Button(this.components);
            this.GrdListe = new BaseControls.BC_DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSorumluAta
            // 
            this.btnSorumluAta.Location = new System.Drawing.Point(677, 12);
            this.btnSorumluAta.Name = "btnSorumluAta";
            this.btnSorumluAta.Size = new System.Drawing.Size(169, 23);
            this.btnSorumluAta.TabIndex = 6;
            this.btnSorumluAta.Text = "Proje Sorumlusunu Değiştir";
            this.btnSorumluAta.UseVisualStyleBackColor = true;
            this.btnSorumluAta.Click += new System.EventHandler(this.btnSorumluAta_Click);
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
            this.txtProjeSorumlusu.LabelText = "Proje Sorumlusu";
            this.txtProjeSorumlusu.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtProjeSorumlusu.LabelTop = 3;
            this.txtProjeSorumlusu.LabelVisible = true;
            this.txtProjeSorumlusu.LabelWith = 100;
            this.txtProjeSorumlusu.Location = new System.Drawing.Point(549, 15);
            this.txtProjeSorumlusu.Name = "txtProjeSorumlusu";
            this.txtProjeSorumlusu.NumericBox = false;
            this.txtProjeSorumlusu.NumericDecimal = 0;
            this.txtProjeSorumlusu.ReadOnly = true;
            this.txtProjeSorumlusu.ReferansTip = 0;
            this.txtProjeSorumlusu.Required = false;
            this.txtProjeSorumlusu.RequiredPass = true;
            this.txtProjeSorumlusu.Size = new System.Drawing.Size(100, 20);
            this.txtProjeSorumlusu.TabIndex = 4;
            this.txtProjeSorumlusu.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtProjeSorumlusu.WordWrap = false;
            this.txtProjeSorumlusu.ButtonClick += new System.EventHandler(this.txtProjeSorumlusu_ButtonClick);
            // 
            // txtSecilenProje
            // 
            this.txtSecilenProje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSecilenProje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSecilenProje.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSecilenProje.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtSecilenProje.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtSecilenProje.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtSecilenProje.Label = null;
            this.txtSecilenProje.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSecilenProje.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSecilenProje.LabelText = "Proje No";
            this.txtSecilenProje.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtSecilenProje.LabelTop = 3;
            this.txtSecilenProje.LabelVisible = true;
            this.txtSecilenProje.LabelWith = 100;
            this.txtSecilenProje.Location = new System.Drawing.Point(334, 15);
            this.txtSecilenProje.Name = "txtSecilenProje";
            this.txtSecilenProje.NumericBox = false;
            this.txtSecilenProje.NumericDecimal = 0;
            this.txtSecilenProje.ReadOnly = true;
            this.txtSecilenProje.ReferansTip = 0;
            this.txtSecilenProje.Required = false;
            this.txtSecilenProje.RequiredPass = true;
            this.txtSecilenProje.Size = new System.Drawing.Size(100, 20);
            this.txtSecilenProje.TabIndex = 2;
            this.txtSecilenProje.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtSecilenProje.WordWrap = false;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(13, 13);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(93, 23);
            this.btnYenile.TabIndex = 1;
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
            this.GrdListe.Location = new System.Drawing.Point(12, 46);
            this.GrdListe.MenuDeleteVisible = true;
            this.GrdListe.Name = "GrdListe";
            this.GrdListe.RowHeadersWidth = 25;
            this.GrdListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdListe.Size = new System.Drawing.Size(834, 513);
            this.GrdListe.TabIndex = 0;
            this.GrdListe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdListe_RowEnter);
            // 
            // FrmSorumluAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 571);
            this.Controls.Add(this.btnSorumluAta);
            this.Controls.Add(this.txtProjeSorumlusu);
            this.Controls.Add(this.txtSecilenProje);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.GrdListe);
            this.FormCode = "ProjeSorumluAtama";
            this.FormName = "Proje Sorumlusu Atama";
            this.Name = "FrmSorumluAtama";
            this.Text = "Proje Sorumlusu Atama";
            this.Load += new System.EventHandler(this.FrmSorumluAtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_DataGrid GrdListe;
        private BaseControls.BC_Button btnYenile;
        private BaseControls.BC_TextBox txtSecilenProje;
        private BaseControls.BC_TextBox txtProjeSorumlusu;
        private BaseControls.BC_Button btnSorumluAta;
    }
}