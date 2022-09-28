namespace QuanLyBenVienLeTan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textma = new System.Windows.Forms.TextBox();
            this.textcmnd = new System.Windows.Forms.TextBox();
            this.textten = new System.Windows.Forms.TextBox();
            this.richdiachi = new System.Windows.Forms.RichTextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benh Nhan";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thong tin benh nhan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ho ten";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "So CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ma so benh nhan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dia chi";
            // 
            // textma
            // 
            this.textma.Location = new System.Drawing.Point(240, 107);
            this.textma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textma.Name = "textma";
            this.textma.Size = new System.Drawing.Size(279, 22);
            this.textma.TabIndex = 6;
            this.textma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textcmnd
            // 
            this.textcmnd.Location = new System.Drawing.Point(240, 149);
            this.textcmnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textcmnd.Name = "textcmnd";
            this.textcmnd.Size = new System.Drawing.Size(279, 22);
            this.textcmnd.TabIndex = 7;
            this.textcmnd.TextChanged += new System.EventHandler(this.textcmnd_TextChanged);
            // 
            // textten
            // 
            this.textten.Location = new System.Drawing.Point(240, 190);
            this.textten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textten.Name = "textten";
            this.textten.Size = new System.Drawing.Size(279, 22);
            this.textten.TabIndex = 8;
            this.textten.TextChanged += new System.EventHandler(this.textten_TextChanged);
            // 
            // richdiachi
            // 
            this.richdiachi.Location = new System.Drawing.Point(240, 238);
            this.richdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richdiachi.Name = "richdiachi";
            this.richdiachi.Size = new System.Drawing.Size(279, 61);
            this.richdiachi.TabIndex = 9;
            this.richdiachi.Text = "";
            this.richdiachi.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(240, 315);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(280, 28);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Luu thong tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 358);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.richdiachi);
            this.Controls.Add(this.textten);
            this.Controls.Add(this.textcmnd);
            this.Controls.Add(this.textma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textma;
        private System.Windows.Forms.TextBox textcmnd;
        private System.Windows.Forms.TextBox textten;
        private System.Windows.Forms.RichTextBox richdiachi;
        private System.Windows.Forms.Button btnLuu;
    }
}

