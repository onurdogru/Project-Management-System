namespace ALPARGE.AppForms
{
    partial class TestForm
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
            this.bC_TextBox1 = new BaseControls.BC_TextBox();
            this.bC_GroupBox1 = new BaseControls.BC_GroupBox();
            this.SuspendLayout();
            // 
            // bC_TextBox1
            // 
            this.bC_TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bC_TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.bC_TextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.bC_TextBox1.BorderFocusColor = System.Drawing.Color.Maroon;
            this.bC_TextBox1.BorderSelectColor = System.Drawing.Color.Gray;
            this.bC_TextBox1.ButtonType = BaseControls.TextBoxButtonType.ButtonType.Simple;
            this.bC_TextBox1.Label = null;
            this.bC_TextBox1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bC_TextBox1.LabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bC_TextBox1.LabelText = "kODU";
            this.bC_TextBox1.LabelTextAllign = System.Drawing.ContentAlignment.BottomLeft;
            this.bC_TextBox1.LabelTop = 3;
            this.bC_TextBox1.LabelVisible = true;
            this.bC_TextBox1.LabelWith = 100;
            this.bC_TextBox1.Location = new System.Drawing.Point(131, 24);
            this.bC_TextBox1.Name = "bC_TextBox1";
            this.bC_TextBox1.NumericBox = false;
            this.bC_TextBox1.NumericDecimal = 0;
            this.bC_TextBox1.ReferansTip = 0;
            this.bC_TextBox1.Required = false;
            this.bC_TextBox1.RequiredPass = true;
            this.bC_TextBox1.Size = new System.Drawing.Size(100, 20);
            this.bC_TextBox1.TabIndex = 0;
            this.bC_TextBox1.UserSecurity = BaseControls.Functions.SecurityLevel.ReadWrite;
            this.bC_TextBox1.WordWrap = false;
            this.bC_TextBox1.ButtonClick += new System.EventHandler(this.bC_TextBox1_ButtonClick);
            // 
            // bC_GroupBox1
            // 
            this.bC_GroupBox1.Location = new System.Drawing.Point(244, 114);
            this.bC_GroupBox1.Name = "bC_GroupBox1";
            this.bC_GroupBox1.Size = new System.Drawing.Size(200, 100);
            this.bC_GroupBox1.TabIndex = 2;
            this.bC_GroupBox1.TabStop = false;
            this.bC_GroupBox1.Text = "bC_GroupBox1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 378);
            this.Controls.Add(this.bC_GroupBox1);
            this.Controls.Add(this.bC_TextBox1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BaseControls.BC_TextBox bC_TextBox1;
        private BaseControls.BC_GroupBox bC_GroupBox1;
    }
}