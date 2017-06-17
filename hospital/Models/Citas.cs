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

namespace hospital.Models
{
    class Citas
    {

        public void modificarCitas(string idCita , string fecha, string hora ,
                                   string idPaciente , string idDoctor ,
                                   string idEmpleado , string idConsultorio)
        {

            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("editarCita", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCita", Int32.Parse( idCita));
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@horaInicio", hora);
            cmd.Parameters.AddWithValue("@pacienteId", Int32.Parse(idPaciente));
            cmd.Parameters.AddWithValue("@doctorId", Int32.Parse(idDoctor));
            cmd.Parameters.AddWithValue("@idEmpleado", Int32.Parse(idEmpleado));
            cmd.Parameters.AddWithValue("@idConsultorio", Int32.Parse(idConsultorio));
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Dispose();
                cmd.Dispose();
            }
        }


        public void agregarCita(string fecha, string hora,
                                   string idPaciente, string idDoctor,
                                   string idEmpleado, string idConsultorio)
        {

            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("agregarCita", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@horaInicio", hora);
            cmd.Parameters.AddWithValue("@pacienteId", Int32.Parse(idPaciente));
            cmd.Parameters.AddWithValue("@doctorId", Int32.Parse(idDoctor));
            cmd.Parameters.AddWithValue("@idEmpleado", Int32.Parse(idEmpleado));
            cmd.Parameters.AddWithValue("@idConsultorio", Int32.Parse(idConsultorio));
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Dispose();
                cmd.Dispose();
            }
        }
        


        
        public void  muestraCitas(DataGridView dg , string idDoctor , string fecha , string consultorio)
        {
           
            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            
            SqlCommand cmd = new SqlCommand("mostrarCitas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha", fecha);
            
            if(idDoctor.Length==0)
                cmd.Parameters.AddWithValue("@idDoctor",DBNull.Value );
            else
                cmd.Parameters.AddWithValue("@idDoctor", Int32.Parse( idDoctor));
            if (consultorio.Length == 0)
                cmd.Parameters.AddWithValue("@idConsultorio", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@idConsultorio", Int32.Parse(consultorio));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            sda.Fill(dt);
            dg.DataSource = dt;
            
        }

        public void fillTextBox(string idCita , TextBox nombrePaciente
            ,TextBox apellidoPP , TextBox apellidoMP , TextBox telefono, TextBox correo
             , TextBox nombreDoctor, TextBox apellidoPD, TextBox apellidoMD , 
             TextBox nombreEmpleado, TextBox apellidoPE, TextBox apellidoME)
        {

            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("getCita", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCita", idCita);

            cn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            
            nombrePaciente.Text = sdr[ "nombrePaciente" ].ToString();
            apellidoPP.Text = sdr["apellidoPP"].ToString();
            apellidoMP.Text = sdr["apellidoMP"].ToString();
            telefono.Text = sdr["telefono"].ToString();
            correo.Text = sdr["correo"].ToString();
            nombreDoctor.Text = sdr["nombreDoctor"].ToString();
            apellidoPD.Text = sdr["apellidoPD"].ToString();
            apellidoMD.Text = sdr["apellidoMD"].ToString();
            nombreEmpleado.Text = sdr["nombreEmpleado"].ToString();
            apellidoPE.Text = sdr["apellidoPE"].ToString();
            apellidoME.Text = sdr["apellidoME"].ToString();
            
            cn.Close();
        
        }

            
            
        
        public int GetID()
        {
            SqlConnection conn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");
            string sqlstr1 = "select max(idCita) from citas";
            SqlCommand comm = new SqlCommand(sqlstr1, conn);
            conn.Open();
            int lastId = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return lastId + 1;
        }
        
        
        
        public Boolean validaPaciente(string hora, string id, string fecha)
        {

            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");

            
            SqlCommand cmd = new SqlCommand("SELECT c.pacienteId " +
                                             "FROM citas c " +
                                             "WHERE c.pacienteId=" + id + " AND c.hora_inicio='" + hora + "' " +
                                                    "AND c.fecha='" + fecha + "'", cn);

            cn.Open();
            object val = cmd.ExecuteScalar();
            cn.Close();
            if (val == null)
                return false;

            return true;

        }

        public Boolean validaEdicion(string idCita)
        {

            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("SELECT c.pacienteId " +
                                             "FROM citas c " +
                                             "WHERE c.idCita=" + idCita , cn);

            cn.Open();
            object val = cmd.ExecuteScalar();
            cn.Close();
            if (val == null)
                return false;

            return true;

        }
        
        public Boolean validaDoctor(string hora , string idDoctor ,string fecha)
        {
            
            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("SELECT c.doctorId "+
                                             "FROM citas c " +
                                             "WHERE c.doctorId="+idDoctor+" AND c.hora_inicio='"+hora+"' "+
                                                    "AND c.fecha='"+fecha+"'", cn);

            cn.Open();
            object val = cmd.ExecuteScalar();
            cn.Close();
            if (val == null)
                 return false;
            
            return true;
           
        }

        public Boolean validaConsultorio(string hora, string id, string fecha)
        {

            SqlConnection cn = new SqlConnection("Data Source=BRA-PC\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True");


            SqlCommand cmd = new SqlCommand("SELECT c.idConsultorio " +
                                             "FROM citas c " +
                                             "WHERE c.idConsultorio=" + id + " AND c.hora_inicio='" + hora + "' " +
                                                    "AND c.fecha='" + fecha + "'", cn);

            cn.Open();
            object val = cmd.ExecuteScalar();
            cn.Close();
            if (val == null)
                return false;

            return true;

        }
    
    
    }


}
