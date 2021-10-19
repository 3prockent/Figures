using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures2;

namespace Figures2
{
    public partial class TriangleInit : Form
    {
        public TriangleInit()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);
                c = Double.Parse(textBox3.Text);
                var tr = new Triangle(a, b, c);
                MessageBox.Show("Perimetr: " + tr.GetPerimeter() + "\nArea: " + tr.GetArea());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
