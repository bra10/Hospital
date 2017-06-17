using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hospital.Clases
{
    class LogicaNegocio
    {
        public static void RealizarPedido(DateTime fecha , TimeSpan hora ,int idPaciente, int idDoctor, int idEmpleado , int idConsultorio )
        {
            // Agregar un pedido
            hospitalDataSetTableAdapters.citasTableAdapter adaptador = new hospitalDataSetTableAdapters.citasTableAdapter();
            hospitalDataSet datos = new hospitalDataSet();
            adaptador.Fill(datos.citas);
            
            //datos.citas.AddcitasRow(fecha , hora , idPaciente , idDoctor , idEmpleado , idConsultorio);
            // Actualizar la base de datos desde "datos"
            adaptador.Update(datos);
        }
    }
}
