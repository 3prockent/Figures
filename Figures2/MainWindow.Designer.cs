
namespace Figures2
{
    partial class MainWindow
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
            this.Triangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Rhombus = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(46, 45);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(192, 55);
            this.Triangle.TabIndex = 0;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(46, 200);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(192, 53);
            this.Circle.TabIndex = 1;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(46, 283);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(192, 55);
            this.Square.TabIndex = 2;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Rhombus
            // 
            this.Rhombus.Location = new System.Drawing.Point(46, 365);
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.Size = new System.Drawing.Size(192, 51);
            this.Rhombus.TabIndex = 3;
            this.Rhombus.Text = "Rhombus";
            this.Rhombus.UseVisualStyleBackColor = true;
            this.Rhombus.Click += new System.EventHandler(this.Rhombus_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(46, 122);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(192, 53);
            this.RectangleButton.TabIndex = 4;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 428);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.Rhombus);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Triangle);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Rhombus;
        private System.Windows.Forms.Button RectangleButton;
    }
}

