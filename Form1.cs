using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmissionsRegressionApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Regression regression = new Regression();

        private void button1_Click(object sender, EventArgs e)
        {
            //get the value from the text box

            int value = Convert.ToInt32(textBox1.Text);

            //calculate the regression

            double result = regression.calculateRegression(value);

            //show regression to forms

            label6.Text = result.ToString();

        }
    }
}
