using System.ComponentModel;

namespace Arkanoid
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(41, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(119, 31);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter your name";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(177, 41);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(129, 20);
            this.txt1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn1.Location = new System.Drawing.Point(177, 88);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 41);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Log in";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(388, 181);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;

        #endregion
    }
}