namespace _1._3
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
            this.smetni = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.ravno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smetni
            // 
            this.smetni.Location = new System.Drawing.Point(16, 80);
            this.smetni.Name = "smetni";
            this.smetni.Size = new System.Drawing.Size(447, 23);
            this.smetni.TabIndex = 0;
            this.smetni.Text = "smetni";
            this.smetni.UseVisualStyleBackColor = true;
            this.smetni.Click += new System.EventHandler(this.smetni_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(363, 42);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 1;
            this.result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(194, 45);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 20);
            this.Y.TabIndex = 2;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(16, 45);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 20);
            this.X.TabIndex = 3;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(141, 49);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(13, 13);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.Location = new System.Drawing.Point(311, 45);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(13, 13);
            this.ravno.TabIndex = 5;
            this.ravno.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 115);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.result);
            this.Controls.Add(this.smetni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smetni;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label ravno;
    }
}

