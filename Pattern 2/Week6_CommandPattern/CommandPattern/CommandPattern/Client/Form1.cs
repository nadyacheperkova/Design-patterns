using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class Form1 : Form
    {
        private  IProduct product;
        private PurchaseController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new PurchaseController();
        }

        private void ProductCheck()
        {
            if (rbPants.Checked)
            {
                product = new Pants();
            }
            else if (rbTshirt.Checked)
            {
                product = new Tshirt();
            }
            else if (rbShoes.Checked)
            {
                product = new Shoes();
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            ProductCheck();
            ICommand order = new OrderCommand(product);
            controller.InsertCommand(order);
            lbOrder.Text = "You ordered: " + order.Execute();
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            ProductCheck();
            ICommand buy = new BuyCommand(product);
            controller.InsertCommand(buy);
            lbBuy.Text = "You just bought it for " + buy.Execute();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbTshirt_CheckedChanged(object sender, EventArgs e)
        {
            ClearLabel();
        }

        private void rbPants_CheckedChanged(object sender, EventArgs e)
        {
            ClearLabel();
        }

        private void rbShoes_CheckedChanged(object sender, EventArgs e)
        {
            ClearLabel();
        }

        private void ClearLabel()
        {
            lbBuy.Text = "";
            lbOrder.Text = "";
        }
        
    }
}
