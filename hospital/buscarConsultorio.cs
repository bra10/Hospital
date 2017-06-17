using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class buscarConsultorio : hospital.templateForm
    {
       public int numero;
        
        
        public buscarConsultorio()
        {
            InitializeComponent();
        }

        

        private void buscarConsultorio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.consultorio' Puede moverla o quitarla según sea necesario.
            this.consultorioTableAdapter.Fill(this.hospitalDataSet.consultorio);

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            numero = hospitalDataSet.consultorio[consultorioBindingSource.Position].numero;
            Close();
        }

        

        
    }
}
