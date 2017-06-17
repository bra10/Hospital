using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using hospital.Models;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace hospital
{
    public partial class agregaCita : hospital.templateForm
    {
        Boolean agrego = false;
        
        public agregaCita()
        {
            InitializeComponent();
        }

        
        
        private void agregaCita_Load(object sender, EventArgs e)
        {
            
            Citas c = new Citas();
            string fecha = fechaDateTimePicker.Value.ToString().Substring(0, 10);
            c.muestraCitas(dg , doctorIdTextBox.Text , fecha , idConsultorioTextBox.Text);
            idCitaTextBox.Text = c.GetID().ToString();
            

        }

        void limpiaCampos()
        {
            pacienteIdTextBox.Clear();
            ctNombre.Clear();
            ctApellidoP.Clear();
            ctApellidoM.Clear();
            ctTelefono.Clear();
            ctCorreo.Clear();
            doctorIdTextBox.Clear();
            ctNombreDoctor.Clear();
            ctApellidoPD.Clear();
            ctApellidoMD.Clear();
            idEmpleadoTextBox.Clear();
            ctNombreEmpleado.Clear();
            ctApellidoPE.Clear();
            ctApellidoME.Clear();
            idConsultorioTextBox.Clear();

       }
        
        private void buscaConsultorio_Click(object sender, EventArgs e)
        {
            buscarConsultorio formBuscar = new buscarConsultorio();
            formBuscar.ShowDialog();
             idConsultorioTextBox.Text = formBuscar.numero.ToString();
        }

        private void buscaEmpleado_Click(object sender, EventArgs e)
        {
            buscarEmpleado formBuscar = new buscarEmpleado();
            formBuscar.ShowDialog();
            idEmpleadoTextBox.Text = formBuscar.codigoEmpleado.ToString();
            ctNombreEmpleado.Text = formBuscar.nombre;
            ctApellidoPE.Text = formBuscar.apeliidoPaterno;
            ctApellidoME.Text = formBuscar.apeliidoMaterno;

        }

        private void buscaDoctor_Click(object sender, EventArgs e)
        {

            buscaDoctor formBuscar = new buscaDoctor();
            formBuscar.ShowDialog();
            doctorIdTextBox.Text = formBuscar.codigoDoctor.ToString();
            ctNombreDoctor.Text = formBuscar.nombre;
            ctApellidoPD.Text = formBuscar.apeliidoPaterno;
            ctApellidoMD.Text = formBuscar.apeliidoMaterno;
        }

        private void buscarPaciente_Click(object sender, EventArgs e)
        {
            buscaPaciente formBuscar = new buscaPaciente();
            formBuscar.ShowDialog();
            pacienteIdTextBox.Text = formBuscar.codigoPaciente.ToString();
            ctNombre.Text = formBuscar.nombre;
            ctApellidoP.Text = formBuscar.apeliidoPaterno;
            ctApellidoM.Text = formBuscar.apeliidoMaterno;
            ctTelefono.Text = formBuscar.telefono.ToString();
            ctCorreo.Text = formBuscar.correoElectronico;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            Boolean busyDoctor;
            Boolean busyConsultorio;
            Boolean busyPaciente;
            Boolean editar;

            Citas c = new Citas();
            string fecha = fechaDateTimePicker.Value.ToString().Substring(0,10);
            editar = c.validaEdicion(idCitaTextBox.Text);
            
            try
            {

                this.citasBindingSource.EndEdit();
                busyDoctor = c.validaDoctor(hora_inicioComboBox.Text, doctorIdTextBox.Text, fecha);
                busyConsultorio = c.validaConsultorio(hora_inicioComboBox.Text, idConsultorioTextBox.Text, fecha);
                busyPaciente = c.validaPaciente(hora_inicioComboBox.Text, pacienteIdTextBox.Text, fecha);
                if(!busyDoctor)
                {
                    if (!busyConsultorio)
                    {
                        

                        if (!busyPaciente)
                        {

                            if (!editar)
                            {
                                c.agregarCita( fecha, hora_inicioComboBox.Text, pacienteIdTextBox.Text,
                                    doctorIdTextBox.Text, idEmpleadoTextBox.Text, idConsultorioTextBox.Text);
                            
                                
                            }
                            else
                                c.modificarCitas(idCitaTextBox.Text, fecha, hora_inicioComboBox.Text, pacienteIdTextBox.Text,
                                    doctorIdTextBox.Text, idEmpleadoTextBox.Text, idConsultorioTextBox.Text);
                            
                            c.muestraCitas(dg, doctorIdTextBox.Text, fecha , idConsultorioTextBox.Text);
                            limpiaCampos();
                            idCitaTextBox.Text = c.GetID().ToString();
                            
                        }
                        else
                            MessageBox.Show("El paciente ya tiene una cita a las " + hora_inicioComboBox.Text);
                    
                     }
                    else
                       MessageBox.Show("El Consultorio Estara Ocupado");
                }
                else
                    MessageBox.Show("El Doctor Estara Ocupado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            
            
        }

        private void fechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Citas c = new Citas();
            string fecha = fechaDateTimePicker.Value.ToString().Substring(0, 10);
            c.muestraCitas(dg, doctorIdTextBox.Text, fecha , idConsultorioTextBox.Text);
        }

        private void doctorIdTextBox_TextChanged(object sender, EventArgs e)
        {
            Citas c = new Citas();
            string fecha = fechaDateTimePicker.Value.ToString().Substring(0, 10);
            c.muestraCitas(dg, doctorIdTextBox.Text, fecha , idConsultorioTextBox.Text);

        }
         
        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Citas c = new Citas();
            try
            {
                idCitaTextBox.Text = dg.CurrentRow.Cells[0].Value.ToString();
                hora_inicioComboBox.Text = dg.CurrentRow.Cells[2].Value.ToString();
                pacienteIdTextBox.Text = dg.CurrentRow.Cells[3].Value.ToString();
                doctorIdTextBox.Text = dg.CurrentRow.Cells[5].Value.ToString();
                idEmpleadoTextBox.Text = dg.CurrentRow.Cells[7].Value.ToString();
                idConsultorioTextBox.Text = dg.CurrentRow.Cells[9].Value.ToString();
                c.fillTextBox(idCitaTextBox.Text, ctNombre, ctApellidoP, ctApellidoM,
                         ctTelefono, ctCorreo, ctNombreDoctor, ctApellidoPD, ctApellidoMD,
                         ctNombreEmpleado, ctApellidoPE, ctApellidoME);

            }
            catch (Exception ) { 
            }
            
        
        }

        private void idConsultorioTextBox_TextChanged(object sender, EventArgs e)
        {
            Citas c = new Citas();
            string fecha = fechaDateTimePicker.Value.ToString().Substring(0, 10);
            c.muestraCitas(dg, doctorIdTextBox.Text, fecha, idConsultorioTextBox.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiaCampos();
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {

            if (txtReporte.Text.Length > 0)
            {
                PdfPTable pdfTable = new PdfPTable(dg.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in dg.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in dg.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                //Exporting to PDF
                string folderPath = "C:\\Users\\bra\\Documents\\visual studio 2010\\Projects\\hospital\\hospital\\Reports\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + txtReporte.Text + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Reporte generado  exitosamente");
            }
            else
                MessageBox.Show("Ingrese un nombre para el reporte","ERROR");
        }        
    }
}
