using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestionTareasDamonte
{
    public partial class FrmCrearTarea : Form
    {
        public FrmCrearTarea()
        {
            InitializeComponent();
        }

        private void FrmCrearTarea_Load(object sender, EventArgs e)
        {
            //Crea una instancia de la clase ConexionBD, maneja la conexión a la base de datos y las operaciones de consulta.
            ConexionBD BD = new ConexionBD();

            //Llama al método LlenarcmbPrioridad, carga el control cmbCategorias con las prioridades de las tareas desde la base de datos
            BD.LlenarcmbPrioridad(CmbPrioridad);
            BD.LlenarcmbEstado(CmbEstado);
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.Show();
            this.Close();
        }

        private void completarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompletarTarea frmCompletarTarea = new FrmCompletarTarea();
            frmCompletarTarea.Show();
            this.Close();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Crea un nuevo objeto en la clase para almacenar los datos de la nueva tarea
            ClsTareas nuevaTarea = new ClsTareas();
            //Crea otra instancia de ConexionBD 
            ConexionBD conexion = new ConexionBD();

            // No asignar idProducto aquí, porque es autoincremental
            nuevaTarea.titulo = TxtTitulo.Text;
            nuevaTarea.descrip = txtDescripcion.Text;
            nuevaTarea.prioridad = CmbPrioridad.Text;
            nuevaTarea.estado = CmbEstado.Text;
            nuevaTarea.vencimiento = dateTimePicker1.Value;

            try
            {
                //Llama al método CrearTarea para insertar nuevoProducto en la base de datos
                conexion.CrearTarea(nuevaTarea);
                Limpiar();

            }//Atrapa cualquier excepción que pueda ocurrir y muestra un mensaje de error
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la tarea: " + ex.Message);
            }
        }

        public void Limpiar()
        {
            TxtTitulo.Text = "";
            txtDescripcion.Text = "";

        }

    }
}
