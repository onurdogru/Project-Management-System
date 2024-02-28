namespace ALPARGE.AppForms.Genel
{
    partial class FrmSistemAyar
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
            this.txtStatus = new BaseControls.BC_TextBox();
            this.ssclose = new BaseControls.BC_Button(this.components);
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtStatus.BorderColor = System.Drawing.Color.DarkGray;
            this.txtStatus.BorderFocusColor = System.Drawing.Color.Maroon;
            this.txtStatus.BorderSelectColor = System.Drawing.Color.Gray;
            this.txtStatus.ButtonType = BaseControls.TextBoxButtonType.ButtonType.None;
            this.txtStatus.Label = null;
            this.txtStatus.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStatus.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStatus.LabelText = null;
            this.txtStatus.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.txtStatus.LabelTop = 3;
            this.txtStatus.LabelVisible = true;
            this.txtStatus.LabelWith = 100;
            this.txtStatus.Location = new System.Drawing.Point(13, 13);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.NumericBox = false;
            this.txtStatus.NumericDecimal = 0;
            this.txtStatus.ReferansTip = 0;
            this.txtStatus.Required = false;
            this.txtStatus.RequiredPass = true;
            this.txtStatus.Size = new System.Drawing.Size(480, 170);
            this.txtStatus.TabIndex = 0;
            this.txtStatus.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.txtStatus.WordWrap = false;
            // 
            // ssclose
            // 
            this.ssclose.Location = new System.Drawing.Point(13, 189);
            this.ssclose.Name = "ssclose";
            this.ssclose.Size = new System.Drawing.Size(132, 23);
            this.ssclose.TabIndex = 2;
            this.ssclose.Text = "Smart Screen i Kapat";
            this.ssclose.UseVisualStyleBackColor = true;
            this.ssclose.Click += new System.EventHandler(this.ssclose_Click);
            // 
            // FrmSistemAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 220);
            this.Controls.Add(this.ssclose);
            this.Controls.Add(this.txtStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSistemAyar";
            this.Text = "Sistem Ayarları";
            this.Load += new System.EventHandler(this.FrmSistemAyar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox txtStatus;
        private BaseControls.BC_Button ssclose;
    }
}