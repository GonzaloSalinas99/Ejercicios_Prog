using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        static string connectionStrings;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionStrings = "Server=DESKTOP-2HKT4SF\\SQLEXPRESS;Database=PersonaPrueba;Trusted_Connection=True;MultipleActiveResultSets=true;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionStrings);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        
        
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Personas";
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    personas.Add(new Persona(sqlDataReader["NOMBRE"].ToString(), sqlDataReader["APELLIDO"].ToString()));
                }
                return personas;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                //command.CommandText = $"DELETE FROM EMPLEADOS WHERE ID_EMPLEADO = {id}";

                //Esta es una forma segura de pasarle los parametros y sin que nos puedan
                //pasar una instruccion que no debe. Se usaria una mascara para que se use
                //Como una variable y la ejecuta
                command.CommandText = $"INSERT INTO Personas (NOMBRE,APELLIDO) VALUES (@Nombre,@Apellido)";
                command.Parameters.AddWithValue("@Nombre", persona.nombre);
                command.Parameters.AddWithValue("@Apellido", persona.apellido);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(string nombre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                //command.CommandText = $"DELETE FROM EMPLEADOS WHERE ID_EMPLEADO = {id}";
                
                //Esta es una forma segura de pasarle los parametros y sin que nos puedan
                //pasar una instruccion que no debe. Se usaria una mascara para que se use
                //Como una variable y la ejecuta
                command.CommandText = $"DELETE FROM Personas WHERE Nombre = @Nombre";
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
