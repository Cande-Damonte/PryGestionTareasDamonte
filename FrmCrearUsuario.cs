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
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void crearTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearTarea frmCrearTarea = new FrmCrearTarea();
            frmCrearTarea.Show();
            this.Hide();
        }

        private void completarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompletarTarea frmCompletarUsuario = new FrmCompletarTarea();
            frmCompletarUsuario.Show();
            this.Hide();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            frmReporte.Show();
            this.Hide();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            ClsUsuarios nuevoUsuario = new ClsUsuarios();
            ConexionBD conexion = new ConexionBD();

            nuevoUsuario.dni = int.Parse(TxtDNI.Text);
            nuevoUsuario.nombre = TxtUsuario.Text;

            try
            {
                conexion.crearUsuario(nuevoUsuario);
                Limpiar();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al crear el usuario " + ex.Message);
            }
        }

        public void Limpiar()
        {
            TxtDNI.Text = "";
            TxtUsuario.Text = "";
        }
    }
}
