using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class buscarEmpleado : hospital.templateForm
    {
        public int codigoEmpleado;
        public string nombre;
        public string apeliidoPaterno;
        public string apeliidoMaterno;
        
        public buscarEmpleado()
        {
            InitializeComponent();
        }

        

        private void btAceptar_Click(object sender, EventArgs e)
        {
            codigoEmpleado = hospitalDataSet.Empleado[empleadoBindingSource.Position].idEmpleado;
            nombre = hospitalDataSet.Empleado[empleadoBindingSource.Position].nombre;
            apeliidoPaterno = hospitalDataSet.Empleado[empleadoBindingSource.Position].apeliido_paterno;
            apeliidoMaterno = hospitalDataSet.Empleado[empleadoBindingSource.Position].apellido_materno;
            Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            empleadoTableAdapter.FillByNombresApellido(hospitalDataSet.Empleado, "%" + ctNombreApellido.Text + "%");
        }

        private void buscarEmpleado_Load(object sender, EventArgs e)
        {
            empleadoTableAdapter.Fill(hospitalDataSet.Empleado);
        }
    } 
}
