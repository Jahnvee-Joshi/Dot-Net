namespace FontIncDec
{
    partial class Form1
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
            this.btnInc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.lblFont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInc
            // 
            this.btnInc.Location = new System.Drawing.Point(112, 130);
            this.btnInc.Name = "btnInc";
            this.btnInc.Size = new System.Drawing.Size(75, 23);
            this.btnInc.TabIndex = 1;
            this.btnInc.Text = "+";
            this.btnInc.UseVisualStyleBackColor = true;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(243, 130);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(75, 23);
            this.btnDec.TabIndex = 2;
            this.btnDec.Text = "-";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(109, 57);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(67, 17);
            this.lblFont.TabIndex = 3;
            this.lblFont.Text = "Font Size";
            this.lblFont.Click += new System.EventHandler(this.lblFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFont);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnInc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Label lblFont;
    }
}

