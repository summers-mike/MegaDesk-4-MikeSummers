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
    }
}
