using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double angle, a, b;
                a = double.Parse(SideATextBox.Text);
                b = double.Parse(SideBTextBox.Text);
                angle = double.Parse(AngleTextBox.Text);
                var it = new RightTriangle(a, b, angle);
                if (angle == 90)
                {
                    MessageBox.Show("It is Right Triangle\nPerimetr: " + it.GetPerimeter() + "\nArea: " + it.GetArea());
                }
                else
                {
                    MessageBox.Show("It is issoseles Triangle\nPerimetr: " + it.GetPerimeter() + "\nArea: " + it.GetArea());
                }
            }

            catch (Exception)
            {


            }
        }
    }
}
