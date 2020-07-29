using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        IPizza pizza;

        public Form1()
        {
            InitializeComponent();
        }

        private void PbCheesyDough_Click(object sender, EventArgs e)
        {
            pizza = new ClassicDough();
            lbPizzaName.Text = pizza.getName();
            lbPizzaPrice.Text = Convert.ToString(pizza.GetPrice());
        }

        private void PbPanDough_Click(object sender, EventArgs e)
        {
            pizza = new FreshPanDough();
            lbPizzaName.Text = pizza.getName();
            lbPizzaPrice.Text = Convert.ToString(pizza.GetPrice());
        }

        private void PbClassicDough_Click(object sender, EventArgs e)
        {
            pizza = new CheesyCrustDough();
            lbPizzaName.Text = pizza.getName();
            lbPizzaPrice.Text = Convert.ToString(pizza.GetPrice());
        }

        private void PbHam_Click(object sender, EventArgs e)
        {
            pizza = new Ham(pizza);
            lbPizzaName.Text = pizza.getName();
            lbPizzaPrice.Text = Convert.ToString(pizza.GetPrice());
        }

        private void PBCheese_Click(object sender, EventArgs e)
        {
            pizza = new Cheese(pizza);
            lbPizzaName.Text = pizza.getName();
            lbPizzaPrice.Text = Convert.ToString(pizza.GetPrice());
        }

        private void PbMushrooms_Click(object sender, EventArgs e)
        {
            pizza = new Mushrooms(pizza);
            lbPizzaName.Text = pizza.getName();
            lbPizzaPrice.Text = Convert.ToString(pizza.GetPrice());
        }
    }
}
