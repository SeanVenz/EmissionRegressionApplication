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
        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();
        public Form1()
        {
            InitializeComponent();
            xValues.Add(72430);
            yValues.Add(25.66);

            xValues.Add(73190);
            yValues.Add(25.79);

            xValues.Add(71670);
            yValues.Add(25.85);

            xValues.Add(72940);
            yValues.Add(25.73);

            xValues.Add(74770);
            yValues.Add(25.61);

            xValues.Add(76320);
            yValues.Add(25.70);

            xValues.Add(78100);
            yValues.Add(25.80);

            xValues.Add(70810);
            yValues.Add(25.86);

            xValues.Add(74560);
            yValues.Add(25.85);

            xValues.Add(76730);
            yValues.Add(25.52);

            xValues.Add(77520);
            yValues.Add(25.56);

            xValues.Add(83570);
            yValues.Add(25.83);

            xValues.Add(84470);
            yValues.Add(25.63);

            xValues.Add(88060);
            yValues.Add(25.93);

            xValues.Add(97800);
            yValues.Add(25.94);

            xValues.Add(104410);
            yValues.Add(25.78);

            xValues.Add(113670);
            yValues.Add(26.02);

            xValues.Add(124920);
            yValues.Add(26.36);

            xValues.Add(136590);
            yValues.Add(25.91);

            xValues.Add(142240);
            yValues.Add(26.11);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
        }
    }
}
