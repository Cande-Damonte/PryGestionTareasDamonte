﻿using System;
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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario frmCrearUsuario = new FrmCrearUsuario();
            frmCrearUsuario.Show();
            this.Hide();
        }
    }
}
