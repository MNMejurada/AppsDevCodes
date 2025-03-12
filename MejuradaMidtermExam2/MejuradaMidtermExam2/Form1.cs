using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MejuradaMidtermExam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckTriangle_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSide1.Text, out double side1) || !double.TryParse(txtSide2.Text, out double side2) || !double.TryParse(txtSide3.Text, out double side3))
            {
                lblResult.Text = ("Invalid input. Please enter a valid number.");
                return;
            }

            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                lblResult.Text = "Invalid Triangle";
            }

            if (side1 == side2 && side2 == side3)
            {
                lblResult.Text = "Equilateral Triangle";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                lblResult.Text = "Isosceles Triangle";
            }
            else
            {
                lblResult.Text = "Scalene Triangle";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
