using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        SqlConnection connection = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = Persona; Trusted_Connection = true;");
        public void Guardar(Persona persona)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Datos VALUES(@ID, @Nombre, @Apellido)";
                command.Parameters.Add(new SqlParameter("ID", persona.Id));
                command.Parameters.Add(new SqlParameter("Nombre", persona.Nombre));
                command.Parameters.Add(new SqlParameter("Apellido", persona.Apellido));
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Persona> Leer()
        {
            SqlDataReader aux = null;
            List<Persona> personas = new List<Persona>();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Datos";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                aux = command.ExecuteReader();
                while (aux.Read())
                {
                    Persona auxPersona = new Persona((int)aux["ID"], aux["Nombre"].ToString(), aux["Apellido"].ToString());
                    personas.Add(auxPersona);
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return personas;
        }
        public Persona LeerPorID(int id)
        {
            SqlDataReader aux = null;
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM Datos WHERE ID = " + id.ToString();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                aux = command.ExecuteReader();

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return new Persona((int)aux["ID"], aux["Nombre"].ToString(), aux["Apellido"].ToString());
        }

        public void Borrar(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = $"DELETE * FROM Datos WHERE ID = " + id.ToString();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
