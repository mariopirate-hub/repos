using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tablemul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            foreach (Control b in Controls)
            {
                if (b.Name.Substring(0, 3) == "txt")
                {
                    int nb = Convert.ToInt32(b.Name.Substring(3));
                    int nb2 = Convert.ToInt32(sender.ToString().Substring(sender.ToString().Length - 2, 2));

                    b.Text = string.Format("{0} x {1} = {2}", nb, nb2, nb * nb2);
                }



            }
        }
    }
}
