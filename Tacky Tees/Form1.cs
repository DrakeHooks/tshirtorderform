using System.Windows.Forms;

// Purpose: A form that calculates the price of a T-shirt order. The user selects the size of the shirt, the color,
// and the number of shirts. The program displays the price of the order, the sales tax, and the total price.
// The user can also select a discount for preferred customers. Custom Lettering is also available for an additional charge.

// Author: John "Drake" Hooks
// Date: 8/2/2023




namespace Tacky_Tees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // This is the main method that calculates the price of the T-shirt order.
            decimal subTotal, taxes, discount, afterTaxTotal;

            decimal sizePrice = SizePrice();

            decimal quantity = GetValidQuantity();



            decimal colorPrice = ColorPrice();

            decimal letterPrice = LetterPrice();


            subTotal = (sizePrice + colorPrice + letterPrice) * quantity;


            // Check if the discountChkBox is not checked. If it is not checked, calculate the tax and total without the discount.
            if (!discountChkBox.Checked)
            {
                taxes = CalculateTax(subTotal);
                afterTaxTotal = subTotal + taxes;
            }
            else
            // If the discountChkBox is checked, calculate the discount, tax, and total with the discount.
            {
                discount = CalculateDiscount(subTotal);
                subTotal -= discount;

                taxes = CalculateTax(subTotal);
                afterTaxTotal = subTotal + taxes;
            }

            outputListBox.Items.Clear();


            outputListBox.Items.Add("Subtotal: " + subTotal.ToString("C2"));
            outputListBox.Items.Add("Taxes: " + taxes.ToString("C2"));
            outputListBox.Items.Add("Total: " + afterTaxTotal.ToString("C2"));
        }


        private void customColorRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            customColorTxtBox.Visible = customColorRadBtn.Checked;

        }
        private decimal SizePrice()
        {
            // This method checks to see which radio button is checked and returns the price of the size.
            if (smRadButton.Checked)
                return 4m;

            else if (medRadButton.Checked)
                return 5m;

            else if (lgRadButton.Checked)
                return 6m;

            else
                return 7m;
        }

        private decimal ColorPrice()
        {
            // If statement using or operator to check if any of the radio buttons are checked. 
            if (redRadBtn.Checked || greenRadBtn.Checked || yellowRadBtn.Checked
                || orangeRadBtn.Checked || blueRadBtn.Checked || purpleRadBtn.Checked)
            {
                return 1m;
            }
            else if (customColorRadBtn.Checked)
            {
                ColorName();
                return 2m;
            }
            else
            {
                return 0m;
            }
        }

        private decimal GetValidQuantity()
        // This method checks to see if the quantity is valid. If the quantity is greater than 30, it will set the quantity to 30.
        // The numericupdown control will not allow the user to enter a quantity greater than 30, but this is a backup.
        {
            decimal max = 30;
            decimal quantity = numericUpDown1.Value;

            if (quantity > max)
            {
                MessageBox.Show("Max quantity has been reached.\nQuantity has been updated to " + max.ToString());
                numericUpDown1.Value = max;
                return max;
            }
            else if (quantity < 1)
            {
                MessageBox.Show("Invalid quantity entered. Quantity has been updated to 1.");
                numericUpDown1.Value = 1;
                return 1;
            }

            return quantity;
        }




        private void ColorName()
        {
            // .trim() removes any whitespace from the beginning or end of the string.
            string customColor = customColorTxtBox.Text.Trim();

            // Check if the custom color text box is empty or contains invalid characters
            if (customColor == "" && customColorRadBtn.Checked)
            {
                MessageBox.Show("Please enter a custom Color!");
                return;
            }

            // Check if the custom color contains any digits, special characters, or is entirely whitespace
            foreach (char character in customColor)
            {

                if (!char.IsLetter(character))
                {
                    MessageBox.Show("Invalid custom color entered. Please enter only letters.");
                    return;
                }
            }

        }


        private decimal LetterPrice()
        {
            // This method calculates the price of the lettering.
            // It counts the number of characters in the message and multiplies it by .10 with a minimum charge of $1.00.
            string message = letteringTxtBox.Text;
            decimal lettering = 0m;


            for (int index = 0; index < message.Length; index++)
            {
                // Check if the character is a whitespace character and if it is, add 0 to the lettering variable.
                if (char.IsWhiteSpace(message, index))
                    lettering += 0m;
                else
                    lettering += 1m;
            }

            return lettering * .10m;
        }

        // Calculate the tax and discount
        private decimal CalculateTax(decimal subTotal)
        {
            decimal taxRate = 0.05m;

            return subTotal * taxRate;
        }

        private decimal CalculateDiscount(decimal subTotal)
        {
            decimal discount = 0.10m;

            return subTotal * discount;
        }





        // Unecessary code to load the form that I cannot get rid of without breaking the program.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {

            customColorTxtBox.Clear();
            letteringTxtBox.Clear();
            discountChkBox.Checked = false;
            numericUpDown1.Value = 1;
            outputListBox.Items.Clear();
           

        }

    }
}