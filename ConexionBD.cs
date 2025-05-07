using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace PryGestionTareasDamonte
{
    public class ConexionBD
    {

        //Se declaran las variables conexion, comando y adaptador para manejar la conexión a la base de datos,
        //los comandos SQL y el adaptador de datos
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;

        //cadena almacena la cadena de conexión para acceder a la base de datos de Access
        string cadena;

        //Constructor de la clase ConexionBD que inicializa cadena con la ruta de la base de datos Productos-Lab3.accdb.
        public ConexionBD()
        {
            cadena = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Tareas-Lab3.accdb";

        }
        public void listarTareas(DataGridView dgvTareas)
        {
            try
            {
                // Intenta conectar y traer los productos
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Tareas";// Selecciona todos las tareas.  

                DataTable tablaTareas = new DataTable(); // Crea un DataTable(estructura de datos que representa una tabla)para almacenar los datos.

                adaptador = new OleDbDataAdapter(comando);// Adaptador para llenar el DataTable
                adaptador.Fill(tablaTareas); // Llenar el DataTable con datos de la base de datos

                dgvTareas.DataSource = tablaTareas; // Asignar el DataTable al DataGridView para mostrar las tareas
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void LlenarcmbPrioridad(ComboBox CmbPrioridad)
        {
            //Se utiliza un bloque try-catch para manejar posibles excepciones
            //Se crea una nueva conexión conexion usando la cadena de conexión cadena, que contiene la ruta a la base de datos
            //Se crea un OleDbCommand llamado comando para ejecutar consultas en la base de datos
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                //establece la conexión de la base de datos que se usará para ejecutar el comando
                comando.Connection = conexion;
                //define que el tipo de comando es texto
                comando.CommandType = CommandType.Text;
                //establece la consulta SQL para seleccionar prioridades distintas de la tabla tareas
                comando.CommandText = "SELECT DISTINCT Prioridad FROM Tareas";

                //La conexión a la base de datos se abre para permitir la ejecución de la consulta
                conexion.Open();

                //El método limpia el ComboBox de categorías para eliminar cualquier dato que estuviera cargado previamente
                CmbPrioridad.Items.Clear();

                //Un OleDbDataReader llamado reader ejecuta el comando y obtiene los resultados de la consulta.
                //Un bucle while (reader.Read()) recorre cada fila devuelta.
                //reader.GetString(0) obtiene el valor de la categoría y lo agrega a cmbCategorias usando cmbCategorias.Items.Add()
                using (OleDbDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CmbPrioridad.Items.Add(reader.GetString(0));
                    }
                }

                //El bloque catch captura cualquier excepción que ocurra y muestra un mensaje de error con MessageBox.Show.
                // El bloque finally se usa para operaciones de limpieza, aunque aquí el cierre de conexión está comentado
                // (debería estar abierto al inicio del método y cerrado al final).
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conexion.Close();
            }
        }

        public void LlenarcmbEstado(ComboBox CmbEstado)
        {
            
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT DISTINCT Estado FROM Tareas";

                conexion.Open();

                CmbEstado.Items.Clear();
 
                using (OleDbDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CmbEstado.Items.Add(reader.GetString(0));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conexion.Close();
            }
        }

        public void LlenarcmbTareas(ComboBox CmbTareas)
        {

            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT DISTINCT Titulo FROM Tareas";

                conexion.Open();

                CmbTareas.Items.Clear();

                using (OleDbDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CmbTareas.Items.Add(reader.GetString(0));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conexion.Close();
            }
        }

        public void CrearTarea(ClsTareas Tareas)
        {
            //Se usa un bloque using para inicializar una instancia de OleDbConnection llamada conexion con la cadena de conexión cadena.
            //Este bloque garantiza que la conexión se cierre automáticamente al final.
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                //OleDbCommand llamado comando se utiliza para definir la instrucción SQL.
                using (OleDbCommand comando = new OleDbCommand())
                {
                    //establece la conexión que usará el comando.
                    comando.Connection = conexion;
                    //indica que el tipo de comando es una consulta SQL de texto.
                    comando.CommandType = CommandType.Text;
                    //contiene la instrucción SQL para insertar un nuevo registro en la tabla tareas, utilizando parámetros para cada columna
                    comando.CommandText = @"INSERT INTO Tareas (Titulo, Descripcion, Prioridad, Estado, Fecha de vencimiento, Usuarios, Categorias)
                                    VALUES (@titulo,@descrip, @prioridad, @estado, @vencimiento, @usuario, @categorias)";

                    // Agregar los parámetros
                    comando.Parameters.AddWithValue("@titulo", Tareas.titulo);
                    comando.Parameters.AddWithValue("@descrip", Tareas.descrip);
                    comando.Parameters.AddWithValue("@prioridad", Tareas.prioridad);
                    comando.Parameters.AddWithValue("@estado", Tareas.estado);
                    comando.Parameters.AddWithValue("@vencimiento", Tareas.vencimiento);
                    comando.Parameters.AddWithValue("@usuario", Tareas.usuario);
                    comando.Parameters.AddWithValue("@categorias", Tareas.categorias);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al crear la tarea: " + ex.Message);
                    }
                }
            }
        }

        public void crearUsuario(ClsUsuarios usuario)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                using (OleDbCommand comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = @"INSERT INTO Usuarios (Usuarios, DNI)
                                    VALUES (@nombre,@dni)";

                    // Agregar los parámetros
                    comando.Parameters.AddWithValue("@dni", usuario.dni);
                    comando.Parameters.AddWithValue("@nombre", usuario.nombre);
                   
                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al crear el usuario " + ex.Message);
                    }
                }
            }
        }

        public void ModificarTareas(ClsTareas Tareas)
        {

            using (OleDbConnection conexion = new OleDbConnection(cadena))
            {
                using (OleDbCommand comando = new OleDbCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText
                         = @"UPDATE Tareas
                                 SET Titulo = @nuevoTitulo,
                                     estado = @nuevoEstado
                                 WHERE Titulo = @titulo";

                    // Agregar los parámetros
                    comando.Parameters.AddWithValue("@titulo", Tareas.titulo);
                    comando.Parameters.AddWithValue("@nuevoEstado", Tareas.estado);


                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("estado de tarea modificado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se realizo ningun cambio");
                        }

                        //Si ocurre un error al agregar la tarea,
                        //se lanza una excepción con un mensaje que indica que ocurrió un error, junto con el mensaje detallado del error original (ex.Message).
                        //Al final del bloque using, se cierran automáticamente la conexión y el comando, liberando los recursos usados
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el estado de la tarea " + ex.Message);
                    }
                }
            }
        }

    }
}
