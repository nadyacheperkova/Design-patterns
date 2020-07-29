using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryPattern
{
    public partial class Form1 : Form
    {
       private IClothingFactory factory;
        public Form1()
        {
            InitializeComponent();
        }

        public void GetFactoryAttributes()
        {
            lbType.Text = factory.GetFactoryType().ToString();

            var tshirt = factory.CreateTshirt();
            var pants = factory.CreatePants();
            var jacket = factory.CreateJacket();

            lbTshirt.Text = tshirt.GetProduct().ToString();
            lbPants.Text = pants.GetProduct().ToString();
            lbJacket.Text = jacket.GetProduct().ToString();
            lbPriceTshirt.Text = tshirt.GetPrice().ToString();
            lbPricePants.Text = pants.GetPrice().ToString();
            lbPriceJacket.Text = jacket.GetPrice().ToString();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PbBershka_Click(object sender, EventArgs e)
        {
            //code for the UI
            lineBershka.Visible = true;
            lineStradi.Visible = false;
            lineZara.Visible = false;
            panleClothes.Visible = true;

            factory = new BershkaFactory();
            GetFactoryAttributes();
        }

        private void PbZara_Click(object sender, EventArgs e)
        {
            //code for the UI
            lineBershka.Visible = false;
            lineStradi.Visible = false;
            lineZara.Visible = true;
            panleClothes.Visible = true;

            factory = new ZaraFactory();
            GetFactoryAttributes();
        }

        private void PbStadi_Click(object sender, EventArgs e)
        {
            //code for the UI
            lineBershka.Visible = false;
            lineStradi.Visible = true;
            lineZara.Visible = false;
            panleClothes.Visible = true;

            factory = new StradivariusFactory();
            GetFactoryAttributes();
        }

    }
}
