using System;
using System.Windows.Forms;

namespace burgers
{
    public partial class BurgerMenu : Form
    {
        private const double CHEESE = 1.50;
        private const double BACON = 2.33;
        private const double PICKLES = 0.50;
        private const double MUSTARD = 0.50;
        private const double KETCHUP = 0.50;
        private const double ONIONRING = 1.99;
        private const double SMALL = 9.99;
        private const double MEDIUM = 11.99;
        private const double LARGE = 13.99;
        private double burgerPrice = 0.00;
        private double condimentPrice = 0.00;
        private double price = 0.00;
        public BurgerMenu()
        {
            InitializeComponent();
        }
        private void BurgerMenu_Load(object sender, EventArgs e)
        {

        }

        private void MediumBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumBurger.Checked)
                price += MEDIUM;
            else
                price -= MEDIUM;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void SmallBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (smallBurger.Checked)
                price += SMALL;
            else
                price -= SMALL;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void LargeBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (largeBurger.Checked)
                price += LARGE;
            else
                price -= LARGE;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void Condiment_Enter(object sender, EventArgs e)
        {
            

        }

        private void BurgerSize_Enter(object sender, EventArgs e)
        {
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void cheeseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseBox.Checked)
                price += CHEESE;
            else
                price -= CHEESE;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void baconBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baconBox.Checked)
                price += BACON;
            else
                price -= BACON;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void pickleBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pickleBox.Checked)
                price += PICKLES;
            else
                price -= PICKLES;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void ketchupBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ketchupBox.Checked)
                price += KETCHUP;
            else
                price -= KETCHUP;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void mustardBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mustardBox.Checked)
                price += MUSTARD;
            else
                price -= MUSTARD;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }

        private void onionRingBox_CheckedChanged(object sender, EventArgs e)
        {
            if (onionRingBox.Checked)
                price += ONIONRING;
            else
                price -= ONIONRING;
            PriceLabel.Text = "Price: " + price.ToString("C");
        }
    }
}
