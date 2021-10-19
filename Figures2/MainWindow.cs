using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            var trCalc = new TriangleInit();
            trCalc.Show();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            var cr = new Circle(4);
            MessageBox.Show("Perimetr: " + cr.GetPerimeter() + "\nArea: " + cr.GetArea());
        }

        private void Square_Click(object sender, EventArgs e)
        {
            var sq = new Square(5);
            MessageBox.Show("Perimetr: " + sq.GetPerimeter() + "\nArea: " + sq.GetArea());
        }

        private void Rhombus_Click(object sender, EventArgs e)
        {
            var rh = new Rhombus(2, 3);
            MessageBox.Show("Perimetr: " + rh.GetPerimeter() + "\nArea: " + rh.GetArea());
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            var rc = new Rectangle(2,5);
            MessageBox.Show("Perimetr: " + rc.GetPerimeter() + "\nArea: " + rc.GetArea());
        }
    }
}
