namespace QuanLyBenhVienBacSi
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
            this.textma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richdiachi = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma so benh nhan";
            // 
            // textma
            // 
            this.textma.Location = new System.Drawing.Point(216, 92);
            this.textma.Name = "textma";
            this.textma.Size = new System.Drawing.Size(370, 22);
            this.textma.TabIndex = 1;
            this.textma.TextChanged += new System.EventHandler(this.textma_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia chi";
            // 
            // textten
            // 
            this.textten.Location = new System.Drawing.Point(216, 196);
            this.textten.Name = "textten";
            this.textten.Size = new System.Drawing.Size(370, 22);
            this.textten.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ho ten";
            // 
            // textcmnd
            // 
            this.textcmnd.Location = new System.Drawing.Point(216, 145);
            this.textcmnd.Name = "textcmnd";
            this.textcmnd.Size = new System.Drawing.Size(370, 22);
            this.textcmnd.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "So CMND";
            // 
            // richdiachi
            // 
            this.richdiachi.Location = new System.Drawing.Point(216, 257);
            this.richdiachi.Name = "richdiachi";
            this.richdiachi.Size = new System.Drawing.Size(370, 114);
            this.richdiachi.TabIndex = 8;
            this.richdiachi.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mang Hinh Nhan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richdiachi);
            this.Controls.Add(this.textcmnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textma);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richdiachi;
        private System.Windows.Forms.Label label5;
    }
}

