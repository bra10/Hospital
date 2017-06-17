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
    public partial class newPatient : Form
    {
        public newPatient()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void templateForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.hospitalDataSet.pacientes);
            this.pacientesBindingSource.AddNew();

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.pacientesBindingSource.EndEdit();
                    this.pacientesTableAdapter.Update(this.hospitalDataSet.pacientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
                MessageBox.Show(this, "Errores de validación.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
