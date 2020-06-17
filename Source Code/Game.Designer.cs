using System.ComponentModel;

namespace Arkanoid
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mouse = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl13 = new System.Windows.Forms.Label();
            this.lbl14 = new System.Windows.Forms.Label();
            this.lbl19 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.lbl16 = new System.Windows.Forms.Label();
            this.lbl17 = new System.Windows.Forms.Label();
            this.lbl18 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 0;
            this.label1.Tag = "block";
            // 
            // mouse
            // 
            this.mouse.BackColor = System.Drawing.Color.Cornsilk;
            this.mouse.Location = new System.Drawing.Point(245, 340);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(152, 15);
            this.mouse.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ball.Location = new System.Drawing.Point(303, 129);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(13, 13);
            this.ball.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl2.Location = new System.Drawing.Point(0, -1);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 26);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "0";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(153, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 4;
            this.label3.Tag = "block";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(245, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 5;
            this.label4.Tag = "block";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(348, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 6;
            this.label5.Tag = "block";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(444, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 23);
            this.label6.TabIndex = 7;
            this.label6.Tag = "block";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(538, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 8;
            this.label7.Tag = "block";
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Red;
            this.lbl8.Location = new System.Drawing.Point(51, 82);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(34, 23);
            this.lbl8.TabIndex = 9;
            this.lbl8.Tag = "block2";
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.Red;
            this.lbl9.Location = new System.Drawing.Point(153, 82);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(34, 23);
            this.lbl9.TabIndex = 10;
            this.lbl9.Tag = "block2";
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.Red;
            this.lbl10.Location = new System.Drawing.Point(245, 82);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(34, 23);
            this.lbl10.TabIndex = 11;
            this.lbl10.Tag = "block2";
            // 
            // lbl11
            // 
            this.lbl11.BackColor = System.Drawing.Color.Red;
            this.lbl11.Location = new System.Drawing.Point(348, 82);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(34, 23);
            this.lbl11.TabIndex = 12;
            this.lbl11.Tag = "block2";
            // 
            // lbl12
            // 
            this.lbl12.BackColor = System.Drawing.Color.Red;
            this.lbl12.Location = new System.Drawing.Point(444, 82);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(34, 23);
            this.lbl12.TabIndex = 13;
            this.lbl12.Tag = "block2";
            // 
            // lbl13
            // 
            this.lbl13.BackColor = System.Drawing.Color.Red;
            this.lbl13.Location = new System.Drawing.Point(538, 82);
            this.lbl13.Name = "lbl13";
            this.lbl13.Size = new System.Drawing.Size(34, 23);
            this.lbl13.TabIndex = 14;
            this.lbl13.Tag = "block2";
            // 
            // lbl14
            // 
            this.lbl14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl14.Location = new System.Drawing.Point(609, 0);
            this.lbl14.Name = "lbl14";
            this.lbl14.Size = new System.Drawing.Size(43, 26);
            this.lbl14.TabIndex = 15;
            this.lbl14.Text = "5";
            this.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl19
            // 
            this.lbl19.BackColor = System.Drawing.Color.Lime;
            this.lbl19.Location = new System.Drawing.Point(42, 25);
            this.lbl19.Name = "lbl19";
            this.lbl19.Size = new System.Drawing.Size(50, 31);
            this.lbl19.TabIndex = 20;
            this.lbl19.Tag = "block3";
            // 
            // lbl15
            // 
            this.lbl15.BackColor = System.Drawing.Color.Lime;
            this.lbl15.Location = new System.Drawing.Point(143, 25);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(53, 31);
            this.lbl15.TabIndex = 21;
            this.lbl15.Tag = "block3";
            // 
            // lbl16
            // 
            this.lbl16.BackColor = System.Drawing.Color.Lime;
            this.lbl16.Location = new System.Drawing.Point(238, 25);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(50, 31);
            this.lbl16.TabIndex = 22;
            this.lbl16.Tag = "block3";
            // 
            // lbl17
            // 
            this.lbl17.BackColor = System.Drawing.Color.Lime;
            this.lbl17.Location = new System.Drawing.Point(342, 25);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(49, 31);
            this.lbl17.TabIndex = 23;
            this.lbl17.Tag = "block3";
            // 
            // lbl18
            // 
            this.lbl18.BackColor = System.Drawing.Color.Lime;
            this.lbl18.Location = new System.Drawing.Point(435, 25);
            this.lbl18.Name = "lbl18";
            this.lbl18.Size = new System.Drawing.Size(52, 31);
            this.lbl18.TabIndex = 24;
            this.lbl18.Tag = "block3";
            // 
            // lbl20
            // 
            this.lbl20.BackColor = System.Drawing.Color.Lime;
            this.lbl20.Location = new System.Drawing.Point(531, 25);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(50, 31);
            this.lbl20.TabIndex = 25;
            this.lbl20.Tag = "block3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(647, 387);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl18);
            this.Controls.Add(this.lbl17);
            this.Controls.Add(this.lbl16);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.lbl19);
            this.Controls.Add(this.lbl14);
            this.Controls.Add(this.lbl13);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl13;
        private System.Windows.Forms.Label lbl14;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.Label lbl17;
        private System.Windows.Forms.Label lbl18;
        private System.Windows.Forms.Label lbl19;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label mouse;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}