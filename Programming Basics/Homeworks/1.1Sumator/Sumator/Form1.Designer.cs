namespace Sumator
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label1textBox1 = new System.Windows.Forms.Label();
            this.label2textBox2 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label3textBoxSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(370, 75);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(135, 26);
            this.textBoxSum.TabIndex = 2;
            // 
            // label1textBox1
            // 
            this.label1textBox1.AutoSize = true;
            this.label1textBox1.Location = new System.Drawing.Point(181, 75);
            this.label1textBox1.Name = "label1textBox1";
            this.label1textBox1.Size = new System.Drawing.Size(18, 20);
            this.label1textBox1.TabIndex = 3;
            this.label1textBox1.Text = "+";
            // 
            // label2textBox2
            // 
            this.label2textBox2.AutoSize = true;
            this.label2textBox2.Location = new System.Drawing.Point(346, 75);
            this.label2textBox2.Name = "label2textBox2";
            this.label2textBox2.Size = new System.Drawing.Size(18, 20);
            this.label2textBox2.TabIndex = 4;
            this.label2textBox2.Text = "=";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(40, 135);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(465, 56);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label3textBoxSum
            // 
            this.label3textBoxSum.AutoSize = true;
            this.label3textBoxSum.Location = new System.Drawing.Point(238, 26);
            this.label3textBoxSum.Name = "label3textBoxSum";
            this.label3textBoxSum.Size = new System.Drawing.Size(70, 20);
            this.label3textBoxSum.TabIndex = 6;
            this.label3textBoxSum.Text = "Sumator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 276);
            this.Controls.Add(this.label3textBoxSum);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label2textBox2);
            this.Controls.Add(this.label1textBox1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label1textBox1;
        private System.Windows.Forms.Label label2textBox2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label3textBoxSum;
    }
}

