
namespace Figures2
{
    partial class TriangleInit
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
            this.sideA = new System.Windows.Forms.Label();
            this.sideB = new System.Windows.Forms.Label();
            this.sideC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sideA
            // 
            this.sideA.AutoSize = true;
            this.sideA.Location = new System.Drawing.Point(58, 9);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(56, 25);
            this.sideA.TabIndex = 0;
            this.sideA.Text = "sideA";
            // 
            // sideB
            // 
            this.sideB.AutoSize = true;
            this.sideB.Location = new System.Drawing.Point(210, 9);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(54, 25);
            this.sideB.TabIndex = 1;
            this.sideB.Text = "sideB";
            // 
            // sideC
            // 
            this.sideC.AutoSize = true;
            this.sideC.Location = new System.Drawing.Point(376, 9);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(55, 25);
            this.sideC.TabIndex = 2;
            this.sideC.Text = "sideC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(325, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(184, 97);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(112, 34);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TriangleInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 152);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sideC);
            this.Controls.Add(this.sideB);
            this.Controls.Add(this.sideA);
            this.Name = "TriangleInit";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sideA;
        private System.Windows.Forms.Label sideB;
        private System.Windows.Forms.Label sideC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CalculateButton;
    }
}