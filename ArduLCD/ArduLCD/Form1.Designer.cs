namespace ArduLCD
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
            this.upperText = new System.Windows.Forms.TextBox();
            this.ReceiveData = new System.Windows.Forms.Button();
            this.SendData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lowerText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upperText
            // 
            this.upperText.Location = new System.Drawing.Point(14, 12);
            this.upperText.Name = "upperText";
            this.upperText.Size = new System.Drawing.Size(260, 20);
            this.upperText.TabIndex = 0;
            // 
            // ReceiveData
            // 
            this.ReceiveData.Location = new System.Drawing.Point(158, 64);
            this.ReceiveData.Name = "ReceiveData";
            this.ReceiveData.Size = new System.Drawing.Size(75, 23);
            this.ReceiveData.TabIndex = 3;
            this.ReceiveData.Text = "↑";
            this.ReceiveData.UseVisualStyleBackColor = true;
            this.ReceiveData.Click += new System.EventHandler(this.ReceiveData_Click);
            // 
            // SendData
            // 
            this.SendData.Location = new System.Drawing.Point(67, 64);
            this.SendData.Name = "SendData";
            this.SendData.Size = new System.Drawing.Size(75, 23);
            this.SendData.TabIndex = 2;
            this.SendData.Text = "↓";
            this.SendData.UseVisualStyleBackColor = true;
            this.SendData.Click += new System.EventHandler(this.SendData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArduLCD.Properties.Resources.Arduino_Uno;
            this.pictureBox1.Location = new System.Drawing.Point(14, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 179);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lowerText
            // 
            this.lowerText.Location = new System.Drawing.Point(14, 38);
            this.lowerText.Name = "lowerText";
            this.lowerText.Size = new System.Drawing.Size(260, 20);
            this.lowerText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 279);
            this.Controls.Add(this.lowerText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SendData);
            this.Controls.Add(this.ReceiveData);
            this.Controls.Add(this.upperText);
            this.Name = "Form1";
            this.Text = "LCDSend!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upperText;
        private System.Windows.Forms.Button ReceiveData;
        private System.Windows.Forms.Button SendData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lowerText;
    }
}

