using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Positive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int inputNumber;
        double remainder;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                inputNumber = Int32.Parse(inputNumberBox.Text);
                if (inputNumber > 0)
                {
                    positiveLabel.Text = $"{inputNumber} is a positive number";
                }
                else
                {
                    positiveLabel.Text = $"{inputNumber} is not a positive number";
                }
                remainder = inputNumber % 7;
                if (remainder == 0)
                {
                    divisibleLabel.Text = $"{inputNumber} is divisible by 7";
                }
                else
                {
                    divisibleLabel.Text = $"{inputNumber} is not divisible by 7";
                }
            }
            catch { 
                integerLabel.Text = "I said an integer";
                positiveLabel.Text = "___ is a ________ number";
                  }
        }
    }
}
