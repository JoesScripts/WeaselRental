using System;
using System.Windows.Forms;

namespace WeaselRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OutPut.Text = "";
        }

        private void PriceEm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Quantity.Text))
            {
                double total = Convert.ToDouble(Quantity.Text) * 24.5 * 0.075;
                OutPut.Text = "Your total cost comes to $" + total.ToString("N2");
                OutPut.Visible = true;
            }

            else
            {
                OutPut.Visible = false;
            }

       

        }
    }
}
