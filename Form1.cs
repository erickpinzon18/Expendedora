using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expendedora
{
    public partial class frmExpendedora : Form
    {
        public frmExpendedora()
        {
            InitializeComponent();

            txtCambio.Enabled = false;
            txtClave.Enabled = false;
            txtDinero.Enabled = false;
            inhabilitarBotones();
            pctProducto.Visible = false;
        }

        int cve_prodP, stock_prodP;
        string nom_prodP, prodP;
        double prec_prodP, tot_venP, dineroP;

        public void inhabilitarBotones()
        {
            btn1.Enabled = false; 
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }

        public void habilitarBotones()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

 

        private void rdb1_Click(object sender, EventArgs e)
        {
            dineroP = dineroP + 1;
            txtDinero.Clear();
            //txtDinero.Text =Convert.ToString(dineroP);
            txtDinero.Text = dineroP + "";
            habilitarBotones();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "7");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "6");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "4");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtClave.Text = Convert.ToString(prodP = prodP + "1");
        }


        private void rbd2_Click(object sender, EventArgs e)
        {
            dineroP = dineroP + 2;
            txtDinero.Clear();
            //txtDinero.Text =Convert.ToString(dineroP);
            txtDinero.Text = dineroP + "";
            habilitarBotones();
        }

        private void rdb5_Click(object sender, EventArgs e)
        {
            dineroP = dineroP + 5;
            txtDinero.Clear();
            //txtDinero.Text =Convert.ToString(dineroP);
            txtDinero.Text = dineroP + "";
            habilitarBotones();
        }

        private void rdb10_Click(object sender, EventArgs e)
        {
            dineroP = dineroP + 10;
            txtDinero.Clear();
            //txtDinero.Text =Convert.ToString(dineroP);
            txtDinero.Text = dineroP + "";
            habilitarBotones();
        }

    }
}
