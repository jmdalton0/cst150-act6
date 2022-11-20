using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act2
{
    // form to convert inches to centimeters
    public partial class InToCm : Form
    {
        public InToCm()
        {
            InitializeComponent();
        }

        // on click, convert user entered number from inches to centimeters
        private void Convert_Click(object sender, EventArgs e)
        {
            try // handle invalid input
            {
                double inches = double.Parse(inchesTextBox.Text);
                double centimeters = inches * 2.54; // conversion rate
                centimetersTextBox.Text = String.Format("{0:F3}", centimeters); // output precision of 3 decimal places
            }
            catch (FormatException ex)
            {
                MessageBox.Show("ERROR: Please enter a number in inches.");
            }
        }
    }
}
