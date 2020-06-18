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
    public static class PersonaDAO
    {
        public static void Guardar(Persona persona)
        {
            SqlConnection connection = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = Persona; Trusted_Connection = true;");

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Datos VALUES(@Nombre, @Apellido)";
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
        public static List<Persona> Leer()
        {
            SqlConnection connection = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = Persona; Trusted_Connection = true;");

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
        public static Persona LeerPorID(int id)
        {
            SqlConnection connection = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = Persona; Trusted_Connection = true;");

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

        public static void Borrar(int id)
        {
            SqlConnection connection = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = Persona; Trusted_Connection = true;");

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
