using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MikeSummers
{
    public partial class AddQuote : Form
    {

        //const int minWidth = 24;
        //const int maxWidth = 96;
        //const int minDepth = 12;
        //const int maxDepth = 48;


        public AddQuote()
        {
            InitializeComponent();
        }

        private void CancelAddQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validatingWidth(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(widthInput.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                widthInput.Select(0, widthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.widthErrorProvider.SetError(widthInput, errorMsg);
            }
        }


        public bool ValidWidth(string myWidth, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (myWidth.Length == 0)
            {
                errorMessage = "A width is required.";
                return false;
            }

            // 
            if ((Convert.ToDecimal(myWidth) >= 24) && (Convert.ToDecimal(myWidth) <= 96))
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "Please enter a width between 24 and 96";
            return false;
        }



        private void validatedWidth(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            widthErrorProvider.SetError(widthInput, "");
        }

        private void validateDepth(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if ((char.IsControl(e.KeyChar)) || (!char.IsDigit(e.KeyChar)))
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
    }
}
