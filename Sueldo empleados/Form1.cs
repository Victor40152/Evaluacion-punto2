using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sueldo_empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            double horatrabajada = double.Parse(txthoratrabajada.Text);
            double valorhora = double.Parse(txtvalorhora.Text);
            double total = valorhora * horatrabajada;
            
            

            if  (total < 700000)
            {

                total = (total * 0.10)+ total;
               
            }
            else
            {


                if (total < 1000000)
                {
                    total = (total / 0.2) + total ;
                   
                }
                else
                {
                    if (total < 1000001)
                    { total = ((total / 0.5) * 0.2)+ total;
                       
                    }

                    
                }
            }
            lbltotalsalario.Text = total.ToString();
            lbltotalsalario.Visible = true;
        }

       
    }
}
