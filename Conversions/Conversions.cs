using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Conversions : Form
    {
        int conversion;
        double inches;
        double feet;
        double yards;            
        double miles;
        double centimetres;
        double metres;
        double kilometres;

        public Conversions()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            DisplayResults();
        }
        public void DisplayResults()
        {
            try
            {
                conversion = Convert.ToInt32(userChoice.Text);
                if (conversion == 1)
                {
                    inches = Convert.ToDouble(userValue.Text);
                    if (inches >= 0)
                    {
                        centimetres = inches * 2.54;
                        outputLabel.Text = $"{inches} inches = {centimetres} centimetres";
                    }
                    else
                    {
                        userChoice.Text = "0";
                        userValue.Text = "0";
                        outputLabel.Text = $"Please Enter a Valid Number (1-4)";
                    }
                }
                else if (conversion == 2)
                {
                    feet = Convert.ToDouble(userValue.Text);
                    if (feet >= 0)
                    {
                        centimetres = feet * 30.48;
                        outputLabel.Text = $"{feet} feet = {centimetres} centimetres";
                    }
                    else
                    {
                        userChoice.Text = "0";
                        userValue.Text = "0";
                        outputLabel.Text = $"Please Enter a Valid Number (1-4)";
                    }
                }
                else if (conversion == 3)
                {
                    yards = Convert.ToDouble(userValue.Text);
                    if (yards >= 0)
                    {
                        metres = yards * 0.91;
                        outputLabel.Text = $"{yards} yards = {metres} metres";
                    }
                    else
                    {
                        userChoice.Text = "0";
                        userValue.Text = "0";
                        outputLabel.Text = $"Please Enter a Valid Number (1-4)";
                    }
                }
                else if (conversion == 4)
                {
                    miles = Convert.ToDouble(userValue.Text);
                    if (yards >= 0)
                    {
                        kilometres = miles * 1.6;
                        outputLabel.Text = $"{miles} miles = {kilometres} kilometres";
                    }
                    else
                    {
                        userChoice.Text = "0";
                        userValue.Text = "0";
                        outputLabel.Text = $"Please Enter a Valid Number (1-4)";
                    }
                }
                else
                {
                    userChoice.Text = "0";
                    outputLabel.Text = "Please Enter a Valid Number (1-4)";
                }
            }
            catch
            {
                userChoice.Text = "0";
                userValue.Text = "0";
                outputLabel.Text = $"Please Enter a Valid Number (1-4)";
            }
        }
    }
}
