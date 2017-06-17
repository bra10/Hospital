using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    
    public partial class buscaPaciente : hospital.templateForm
    {
        public int codigoPaciente;
        public string nombre;
        public string apeliidoPaterno;
        public string apeliidoMaterno;
        public int telefono;
        public string correoElectronico;
        public buscaPaciente()
        {
            InitializeComponent();
        }

        

        private void buscaPaciente_Load(object sender, EventArgs e)
        {
            pacientesTableAdapter.Fill(hospitalDataSet.pacientes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            pacientesTableAdapter.FillByNombresApellido(hospitalDataSet.pacientes, "%" + ctBuscar.Text + "%");
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            codigoPaciente = hospitalDataSet.pacientes[pacientesBindingSource.Position].idPaciente;
            nombre = hospitalDataSet.pacientes[pacientesBindingSource.Position].nombre;
            apeliidoPaterno = hospitalDataSet.pacientes[pacientesBindingSource.Position].apellidoPaterno;
            apeliidoMaterno = hospitalDataSet.pacientes[pacientesBindingSource.Position].apellidoMaterno;
            telefono = hospitalDataSet.pacientes[pacientesBindingSource.Position].telefono;
            correoElectronico = hospitalDataSet.pacientes[pacientesBindingSource.Position].correo_electronico;
            Close();


        }
    }
}
