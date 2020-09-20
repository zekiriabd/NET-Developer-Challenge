namespace ConsumerApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnGetFibonacciData = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnConvertXmlToJson = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BtnGetFibonacciData
            // 
            this.BtnGetFibonacciData.Location = new System.Drawing.Point(222, 81);
            this.BtnGetFibonacciData.Name = "BtnGetFibonacciData";
            this.BtnGetFibonacciData.Size = new System.Drawing.Size(186, 23);
            this.BtnGetFibonacciData.TabIndex = 1;
            this.BtnGetFibonacciData.Text = "GetFibonacciData";
            this.BtnGetFibonacciData.UseVisualStyleBackColor = true;
            this.BtnGetFibonacciData.Click += new System.EventHandler(this.BtnGetFibonacciData_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 134);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 286);
            this.textBox2.TabIndex = 2;
            // 
            // BtnConvertXmlToJson
            // 
            this.BtnConvertXmlToJson.Location = new System.Drawing.Point(439, 248);
            this.BtnConvertXmlToJson.Name = "BtnConvertXmlToJson";
            this.BtnConvertXmlToJson.Size = new System.Drawing.Size(176, 23);
            this.BtnConvertXmlToJson.TabIndex = 3;
            this.BtnConvertXmlToJson.Text = "XML Convert to JSON";
            this.BtnConvertXmlToJson.UseVisualStyleBackColor = true;
            this.BtnConvertXmlToJson.Click += new System.EventHandler(this.BtnConvertXmlToJson_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(639, 134);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(396, 286);
            this.textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 435);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BtnConvertXmlToJson);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnGetFibonacciData);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnGetFibonacciData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnConvertXmlToJson;
        private System.Windows.Forms.TextBox textBox3;
    }
}

