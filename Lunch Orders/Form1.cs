using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunch_Orders
{
    public partial class Form1 : Form
    {
        const double Tax = 7.75d;
        const double Hamburger = 6.95d;
        const double pizza = 5.95d;
        const double Salad = 4.95d;

        double AddOn = 0.0d; //To hold add on sum


        double AddOnPrice = 0.0d; //To hold Add On Price
        double Order_Total = 0.0d; //To Hold Order Total

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (radioHamburger.Checked)
                Order_Total += Hamburger; // similar to Order_Total= Order_Total + Hamburger
            if (radioPizza.Checked)
                Order_Total += pizza;
            if (radioSalad.Checked)
                Order_Total += Salad;

            Order_Total += AddOn;

            txtSubtotal.Text = "$" + String.Format("{0:0.00}", Order_Total);

            double tax = (Order_Total * 7.75d) / 100;

            txtTax.Text = "$" + String.Format("{0:0.00}", tax);

            txtOrderTotal.Text = "$" + String.Format("{0:0.00}", (Order_Total + tax));

        }

        private void CheckLettuceTomatoOnionCheckedChanged(object sender, EventArgs e)
        {
            if (CheckLettuceTomatoOnion.Checked)
            {
                AddOn += AddOnPrice;
            }
            else
            {
                AddOn -= AddOnPrice;
            }
        }

        private void CheckKetchupMusterdMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckKetchupMusterdMayo.Checked)
            {
                AddOn += AddOnPrice;
            }
            else
            {
                AddOn -= AddOnPrice;
            }
        }

        private void CheckFrenchFires_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckFrenchFries.Checked)
            {
                AddOn += AddOnPrice;
            }
            else
            {
                AddOn -= AddOnPrice;
            }
        }
        private void ClearAddOns()
        {
            AddOn = 0.0d;
            CheckFrenchFries.Checked = false;
            CheckKetchupMusterdMayo.Checked = false;
            CheckLettuceTomatoOnion.Checked = false;
        }

        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            
            ClearAddOns();
            if (radioHamburger.Checked)
            {
                groupBox2.Text = "Add-on items ($.75/each)";
                CheckLettuceTomatoOnion.Text = "Lettuce, tomato and onions";
                CheckKetchupMusterdMayo.Text = "Ketchup, mustard and mayo";
                CheckFrenchFries.Text = "French Fries";
                AddOnPrice = 0.75d;
            }

        }

        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {

           
            ClearAddOns();

            if (radioPizza.Checked)
            {
                groupBox2.Text = "Add-on items ($.50/each)";

                CheckLettuceTomatoOnion.Text = "Pepperoni";
                CheckKetchupMusterdMayo.Text = "Sausage";
                CheckFrenchFries.Text = "Olives";
                AddOnPrice = 0.50d;
            }
        }

        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {

            
            ClearAddOns();

            if (radioSalad.Checked)
            {
                groupBox2.Text = "Add-on items ($.25/each)";
                CheckLettuceTomatoOnion.Text = "Croutons";
                CheckKetchupMusterdMayo.Text = "Bacon bits";
                CheckFrenchFries.Text = "Bread sticks ";
                AddOnPrice = 0.25d;
            }
        }
    }
}
