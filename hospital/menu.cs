using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menuPatient_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "formNuevoCliente")
                {
                    f.Activate();
                    return;
                }
            }
             newPatient formHijo = new newPatient();
            
            formHijo.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuApoinment_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "formRealizarPedido")
                {
                    f.Activate();
                    return;
                }
            }
            agregaCita formHijo = new agregaCita();
           
            formHijo.Show();

        }
    }
}
