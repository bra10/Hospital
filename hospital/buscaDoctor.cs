using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class buscaDoctor : hospital.templateForm
    {
        public int codigoDoctor;
        public string nombre;
        public string apeliidoPaterno;
        public string apeliidoMaterno;
        
        public buscaDoctor()
        {
            InitializeComponent();
        }

      

        private void buscaDoctor_Load(object sender, EventArgs e)
        {

            doctoresTableAdapter.Fill(hospitalDataSet.doctores);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            doctoresTableAdapter.FillByNombresApellido(hospitalDataSet.doctores, "%" + ctBuscar.Text + "%");

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            codigoDoctor = hospitalDataSet.doctores[doctoresBindingSource.Position].idDoctor;
            nombre = hospitalDataSet.doctores[doctoresBindingSource.Position].nombre;
            apeliidoPaterno = hospitalDataSet.doctores[doctoresBindingSource.Position].apellidoPaterno;
            apeliidoMaterno = hospitalDataSet.doctores[doctoresBindingSource.Position].apellidoMaterno;
            Close();
        }
    }
}
