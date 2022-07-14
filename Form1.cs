using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        int cve_prodP, stock_prod;
        string nom_prod, prodP;
        double prec_prodP, tot_venP, dineroP;

        String SQL = "";
        MySqlCommand Query;// crea una instancia sql que se ejecutara en la bd

        MySqlDataReader registros; //permite ejecutar la sentencia sql

        Conexion con = new Conexion(); //instanciar clase conexion
        Producto prod = new Producto();

        public void SinStock()
        {
            if (con.abrirBD() == true)
            {
                MessageBox.Show("BD conectada");
                try
                {

                    SQL = "select id_pro, stock from producto";
                    Query = new MySqlCommand(SQL, con.connection);
                    registros = Query.ExecuteReader();
                    while (registros.Read())
                    {
                        cve_prodP = registros.GetInt32(0);
                        stock_prod = registros.GetInt32(1);
                        if (stock_prod == 0)
                        {
                            switch (cve_prodP)
                            {
                                case 1:
                                    pct1.Visible = false;
                                    break;
                                case 2:
                                    pct2.Visible = false;
                                    break;
                                case 3:
                                    pct3.Visible = false;
                                    break;
                                case 4:
                                    pct4.Visible = false;
                                    break;
                                case 5:
                                    pct5.Visible = false;
                                    break;
                                case 6:
                                    pct6.Visible = false;
                                    break;
                            }
                        }
                    }
                    con.cerrarBD();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("error de bd" + e);
                }
            }
            else
            {
                MessageBox.Show("BD no conectada");
            }
        }

        public void ComprarProducto()
        {
            if (con.abrirBD() == true)
            {
                MessageBox.Show("BD conectada");
                try
                {

                    SQL = "select * from producto where id_pro=" + prod.Clave1;
                    Query = new MySqlCommand(SQL, con.connection);
                    registros = Query.ExecuteReader();
                    while (registros.Read())
                    {
                        cve_prodP = registros.GetInt32(0);
                        nom_prod = registros.GetString(1);
                        prec_prodP = registros.GetDouble(2);
                        stock_prod = registros.GetInt32(3);
                        tot_venP = registros.GetDouble(4);
                        registros.Close();
                        if (stock_prod > 1)//si hay producto en la maquina para vender 
                        {
                            if (dineroP >= prec_prodP) //el dinero ingresado >= al precio
                            {
                                try
                                {
                                    SQL = "update producto set stock = stock-1 where id_pro=" + prod.Clave1;
                                    Query = new MySqlCommand(SQL, con.connection);
                                    int modStock = Query.ExecuteNonQuery();
                                    if (modStock == 1)
                                    {
                                        try
                                        {
                                            SQL = "update producto set tot = tot+precio where id_pro=" + prod.Clave1;
                                            Query = new MySqlCommand(SQL, con.connection);
                                            int modTot = Query.ExecuteNonQuery();
                                            if (modTot == 1)
                                            {
                                                double cambio = dineroP - prec_prodP;
                                                txtCambio.Text = "$" + cambio;
                                            }

                                        }
                                        catch
                                        {

                                        }
                                    }
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

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
