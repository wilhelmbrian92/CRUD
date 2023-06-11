﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CRUD
{
    class Datos
    {
        #region parametros_alta
        string Nombre, Tipo;
        string getNombre() { return Nombre; }
        string getTipo() { return Tipo; }
        //establecer valor
        void setNombre(string nombre) { Nombre = nombre; }
        void setTipo(string tipo) { Tipo = tipo; }
        #endregion

        static string s = "workstation id=wilsql92.mssql.somee.com;packet size=4096;user id=wilhelmbrian92_SQLLogin_1;pwd=91omw2ur8i;data source=wilsql92.mssql.somee.com;persist security info=False;initial catalog=wilsql92";


        public void altaProducto(string nombre,string tipo) {

            setNombre(nombre);
            setTipo(tipo);
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Producto(Nombre,Tipo) values('" +
                              Nombre + "','" + Tipo + "')", conexion);
            comando.ExecuteNonQuery();
            
            conexion.Close();
        }

        public string [] ObtenerNombresProductos()
        {
            //en este método se obtiene los nombres de todos los productos para mostrarlos en el combobox
            string query = "SELECT Nombre FROM Producto";

            using (SqlConnection connection = new SqlConnection(s))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    // Crear una lista para almacenar los nombres de los productos
                    List<string> nombresProductos = new List<string>();

                    while (reader.Read())
                    {
                        string nombreProducto = reader.GetString(0);
                        nombresProductos.Add(nombreProducto);
                    }

                    reader.Close();

                    return nombresProductos.ToArray();
                }
            }
        }

        public int ObtenerIDProducto(string nombreProducto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    string query = "SELECT ID FROM Producto WHERE Nombre = @Nombre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombreProducto);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo en la consulta
                Console.WriteLine("Ha ocurrido un error al obtener el ID del producto: " + ex.Message);
            }

            return 0; // Valor predeterminado si no se encuentra el producto o hay un error
        }

        public bool InsertarLote(int idProducto, int cantidad, DateTime fechaVencimiento)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    // Preparar la consulta SQL para la inserción
                    string query = "INSERT INTO Lote (ProductoID, Cantidad, FechaVencimiento) VALUES (@ProductoID, @Cantidad, @FechaVencimiento)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asignar los parámetros de la consulta
                        command.Parameters.AddWithValue("@ProductoID", idProducto);
                        command.Parameters.AddWithValue("@Cantidad", cantidad);
                        command.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de fallo en la inserción
                Console.WriteLine("Ha ocurrido un error al insertar los registros en la tabla Lote: " + ex.Message);
                return false;
            }
        }
    }

}