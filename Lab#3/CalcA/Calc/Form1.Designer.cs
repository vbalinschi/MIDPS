namespace Calc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screen = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outToolStripMenuItem});
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.archiveToolStripMenuItem.Text = "Archive";
            // 
            // outToolStripMenuItem
            // 
            this.outToolStripMenuItem.Name = "outToolStripMenuItem";
            this.outToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.outToolStripMenuItem.Text = "Exit";
            this.outToolStripMenuItem.Click += new System.EventHandler(this.outToolStripMenuItem_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.screen.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.ForeColor = System.Drawing.SystemColors.MenuText;
            this.screen.Location = new System.Drawing.Point(12, 38);
            this.screen.Multiline = true;
            this.screen.Name = "screen";
            this.screen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.screen.Size = new System.Drawing.Size(269, 38);
            this.screen.TabIndex = 1;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.back.Location = new System.Drawing.Point(12, 93);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 38);
            this.back.TabIndex = 2;
            this.back.Text = "Backspace";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num7.Location = new System.Drawing.Point(12, 137);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(49, 38);
            this.num7.TabIndex = 3;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num4.Location = new System.Drawing.Point(12, 181);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(49, 38);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num1.Location = new System.Drawing.Point(12, 225);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(49, 38);
            this.num1.TabIndex = 5;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num2.Location = new System.Drawing.Point(67, 225);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(49, 38);
            this.num2.TabIndex = 9;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num5.Location = new System.Drawing.Point(67, 181);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(49, 38);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num8.Location = new System.Drawing.Point(67, 137);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(49, 38);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num3.Location = new System.Drawing.Point(122, 225);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(49, 38);
            this.num3.TabIndex = 13;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num6.Location = new System.Drawing.Point(122, 181);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(49, 38);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num9.Location = new System.Drawing.Point(122, 137);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(49, 38);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // erase
            // 
            this.erase.BackColor = System.Drawing.SystemColors.ControlLight;
            this.erase.Location = new System.Drawing.Point(122, 93);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(49, 38);
            this.erase.TabIndex = 10;
            this.erase.Text = "C";
            this.erase.UseVisualStyleBackColor = false;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.Location = new System.Drawing.Point(177, 269);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(49, 38);
            this.plus.TabIndex = 17;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.Location = new System.Drawing.Point(177, 181);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(49, 38);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ControlLight;
            this.div.Location = new System.Drawing.Point(177, 137);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(49, 38);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mul.Location = new System.Drawing.Point(177, 225);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(49, 38);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equal.Location = new System.Drawing.Point(232, 181);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(49, 126);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrt.Location = new System.Drawing.Point(232, 137);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(49, 38);
            this.sqrt.TabIndex = 19;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // pow
            // 
            this.pow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pow.Location = new System.Drawing.Point(232, 93);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(49, 38);
            this.pow.TabIndex = 18;
            this.pow.Text = "x^2";
            this.pow.UseVisualStyleBackColor = false;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlLight;
            this.point.Location = new System.Drawing.Point(122, 269);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(49, 38);
            this.point.TabIndex = 22;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num0.Location = new System.Drawing.Point(12, 269);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(104, 38);
            this.num0.TabIndex = 21;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sign.Location = new System.Drawing.Point(177, 93);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(49, 38);
            this.sign.TabIndex = 23;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.point);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.back);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outToolStripMenuItem;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button sign;
    }
}

