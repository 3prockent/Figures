
namespace Figures3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.AngleTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.Location = new System.Drawing.Point(198, 48);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.Size = new System.Drawing.Size(150, 31);
            this.SideBTextBox.TabIndex = 0;
            this.SideBTextBox.Text = "SideB";
            // 
            // SideATextBox
            // 
            this.SideATextBox.Location = new System.Drawing.Point(12, 48);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.Size = new System.Drawing.Size(150, 31);
            this.SideATextBox.TabIndex = 1;
            this.SideATextBox.Text = "SideA";
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Location = new System.Drawing.Point(382, 48);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(150, 31);
            this.AngleTextBox.TabIndex = 2;
            this.AngleTextBox.Text = "Angle";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(583, 48);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(112, 34);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 128);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AngleTextBox);
            this.Controls.Add(this.SideATextBox);
            this.Controls.Add(this.SideBTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideBTextBox;
        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.TextBox AngleTextBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}

