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
    public partial class FrmCompletarTarea : Form
    {
        public FrmCompletarTarea()
        {
            InitializeComponent();
        }

        private void FrmCompletarTarea_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();

            conexion.listarTareas(dgvTareas);
            conexion.LlenarcmbTareas(CmbTareas);
            conexion.LlenarcmbEstado(CmbEstado);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ClsTareas tareaModificada = new ClsTareas();
            ConexionBD conexion = new ConexionBD();



            // Verifica que se haya seleccionado un título y un nuevo estado
            if (CmbTareas.SelectedIndex != -1  && CmbEstado.SelectedIndex != -1)
            {
                tareaModificada.titulo = CmbTareas.Text;
                tareaModificada.estado = CmbEstado.Text;

                MessageBox.Show("Tarea modificada");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea para ser modificada");
            }


            try
            {

                conexion.ModificarTareas(tareaModificada);
                //Actualiza el dgvProductos con la lista actualizada de productos después de la modificación
                conexion.listarTareas(dgvTareas);

            }//Captura cualquier excepción que se produzca en el bloque try y
             //muestra un mensaje de error al usuario con el contenido de la excepción
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el estado de la tarea: " + ex.Message);
            }

        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.Show();
            this.Hide();
        }

        private void crearTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearTarea frmCrearTarea = new FrmCrearTarea();
            frmCrearTarea.Show();
            this.Hide();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            FrmReporte.Show();
            this.Hide();
        }
    }
}
