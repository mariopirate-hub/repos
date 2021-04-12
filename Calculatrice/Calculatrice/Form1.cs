using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        int premierNombre, deuxiemeNombre;
        string symbole;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            List<string> lstSymbole = new List<string>() {  "+", "-", "*",  "/"  };

            ecran.Text += ((Button)sender).Text;
           

            if (lstSymbole.Contains(((Button)sender).Text))
            {
                symbole = ((Button)sender).Text;
                ecran.Text = string.Empty;
            }
            else if (((Button)sender).Text == "=")
            {
                if (symbole == "+")
                    ecran.Text = (premierNombre + deuxiemeNombre).ToString();
                else if (symbole == "-")
                    ecran.Text = (premierNombre - deuxiemeNombre).ToString();
                else if (symbole == "*")
                    ecran.Text = (premierNombre * deuxiemeNombre).ToString();
                else if (symbole == "/")
                    ecran.Text = (premierNombre / deuxiemeNombre).ToString();

                premierNombre = 0;
                deuxiemeNombre = 0;
                symbole = null;
            }
            else if (((Button)sender).Text == "C")
            {
                premierNombre = 0;
                deuxiemeNombre = 0;
                symbole = null;
                ecran.Text = string.Empty;
            }
            else 
            {
                if (symbole == null)
                    premierNombre = Int32.Parse(ecran.Text);
                else
                    deuxiemeNombre = Int32.Parse(ecran.Text);
            }
        }

       
    }
}
