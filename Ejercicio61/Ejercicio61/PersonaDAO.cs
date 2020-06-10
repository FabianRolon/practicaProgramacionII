using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

            }
            catch (FormatException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public SqlDataReader Leer(Persona persona)
        {
            SqlDataReader aux = null;
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
            }
            catch (ArgumentNullException ex)
            {

            }
            catch (FormatException ex)
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return aux;
        }
    }
}
