using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest_26108178
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // Declare Variables
            string title;
            double price;

            // Input Data

            if (double.TryParse(priceTextBox.Text, out price) && price >= 0.0 && price <= 50.0)
            {
                title = titleTextBox.Text;

                // Display in listboxes
                titleListBox.Items.Add(title);
                priceListBox.Items.Add(price);
            }
            else
            {
                MessageBox.Show("Please enter price between $0.00 and $50.00");
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Declare Variables
            int count;
            int index;
            string priceString;
            double subTotal = 0;
            double totalWithTax;

            count = priceListBox.Items.Count;

            if (count > 0)
            {
                index = 0;

                do
                {

                    priceString = priceListBox.Items[index].ToString();

                    subTotal += double.Parse(priceString); // total = total + profitAmountString

                    index++;

                } while (index < count);

                totalWithTax = subTotal + (subTotal * 0.1);

                // Display subTotal and totalWithTax
                subTotalLabel.Text = subTotal.ToString("c");
                totalWithTaxLabel.Text = totalWithTax.ToString("c");
            }
            else
            {
                MessageBox.Show("Please enter data");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Clear();
            priceTextBox.Clear();
            subTotalLabel.Text = String.Empty;
            totalWithTaxLabel.Text = String.Empty;
            titleListBox.Items.Clear();
            priceListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
