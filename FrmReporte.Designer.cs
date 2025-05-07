namespace PryGestionTareasDamonte
{
    partial class FrmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.label2 = new System.Windows.Forms.Label();
            this.lstControl = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Reporte de tareas";
            // 
            // lstControl
            // 
            this.lstControl.FormattingEnabled = true;
            this.lstControl.ItemHeight = 20;
            this.lstControl.Location = new System.Drawing.Point(41, 77);
            this.lstControl.Name = "lstControl";
            this.lstControl.Size = new System.Drawing.Size(292, 184);
            this.lstControl.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.tareasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTareaToolStripMenuItem,
            this.completarTareaToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // crearTareaToolStripMenuItem
            // 
            this.crearTareaToolStripMenuItem.Name = "crearTareaToolStripMenuItem";
            this.crearTareaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.crearTareaToolStripMenuItem.Text = "Crear Tarea";
            // 
            // completarTareaToolStripMenuItem
            // 
            this.completarTareaToolStripMenuItem.Name = "completarTareaToolStripMenuItem";
            this.completarTareaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.completarTareaToolStripMenuItem.Text = "Completar Tarea";
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 304);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completarTareaToolStripMenuItem;
    }
}