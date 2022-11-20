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
    public partial class InToCm : Form
    {
        public InToCm()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            double inches = double.Parse(inchesTextBox.Text);
            double centimeters = inches * 2.54;
            centimetersTextBox.Text = centimeters.ToString("0.##");
        }
    }
}
