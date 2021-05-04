using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double initialPrice = 7.00;
        double toppings = 1.25;
        double numberOfToppings;
        double totalPrice;

        private void PizzaParlour_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfToppings = Convert.ToInt32(TextInput.Text);
                
                totalPrice = toppings * numberOfToppings + initialPrice;
               
                TextOutput.Text = $"The price of a pizza with {numberOfToppings} toppings is {totalPrice} dollars ";
               
                TextOutput.Text = totalPrice.ToString("0.00");
            }

            catch
            {
                TextOutput.Text = "Please use a number";
            }
            
            }
    }
}
