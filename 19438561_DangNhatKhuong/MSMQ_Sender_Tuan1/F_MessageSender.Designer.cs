namespace MSMQ_Sender
{
    partial class F_MessageSender
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.btnSendObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(45, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 97);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(45, 156);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(98, 23);
            this.btnSendText.TabIndex = 1;
            this.btnSendText.Text = "Send Text";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // btnSendObject
            // 
            this.btnSendObject.Location = new System.Drawing.Point(166, 156);
            this.btnSendObject.Name = "btnSendObject";
            this.btnSendObject.Size = new System.Drawing.Size(75, 23);
            this.btnSendObject.TabIndex = 2;
            this.btnSendObject.Text = "Send Object";
            this.btnSendObject.UseVisualStyleBackColor = true;
            this.btnSendObject.Click += new System.EventHandler(this.btnSendObject_Click);
            // 
            // F_MessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnSendObject);
            this.Controls.Add(this.btnSendText);
            this.Controls.Add(this.richTextBox1);
            this.Name = "F_MessageSender";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.Button btnSendObject;
    }
}

