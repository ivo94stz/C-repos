namespace _1._4
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
            this.chislo1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.chislo2 = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.TextBox();
            this.ravno = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chislo1
            // 
            this.chislo1.Location = new System.Drawing.Point(0, 89);
            this.chislo1.Name = "chislo1";
            this.chislo1.Size = new System.Drawing.Size(100, 20);
            this.chislo1.TabIndex = 0;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(120, 92);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(13, 13);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            // 
            // chislo2
            // 
            this.chislo2.Location = new System.Drawing.Point(179, 89);
            this.chislo2.Name = "chislo2";
            this.chislo2.Size = new System.Drawing.Size(100, 20);
            this.chislo2.TabIndex = 2;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(348, 89);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(99, 20);
            this.suma.TabIndex = 3;
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.Location = new System.Drawing.Point(305, 92);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(13, 13);
            this.ravno.TabIndex = 4;
            this.ravno.Text = "=";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(159, 196);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "smqtai";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.chislo2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.chislo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chislo1;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.TextBox chislo2;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.Label ravno;
        private System.Windows.Forms.Button calculate;
    }
}

