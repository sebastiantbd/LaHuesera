namespace EscritorioLaHuesera
{
    partial class MunuLaHuesera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDePeliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDePeliculasToolStripMenuItem,
            this.gestionDePrestamosToolStripMenuItem,
            this.gestionDeUsuariosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDePeliculasToolStripMenuItem
            // 
            this.gestionDePeliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDePeliculasToolStripMenuItem});
            this.gestionDePeliculasToolStripMenuItem.Name = "gestionDePeliculasToolStripMenuItem";
            this.gestionDePeliculasToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.gestionDePeliculasToolStripMenuItem.Text = "Gestion de Peliculas";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            this.gestionDeUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDeUsuariosToolStripMenuItem});
            this.gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            this.gestionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            // 
            // administradorDePeliculasToolStripMenuItem
            // 
            this.administradorDePeliculasToolStripMenuItem.Name = "administradorDePeliculasToolStripMenuItem";
            this.administradorDePeliculasToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.administradorDePeliculasToolStripMenuItem.Text = "Administrador de Peliculas";
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            this.administradorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(326, 34);
            this.administradorDeUsuariosToolStripMenuItem.Text = "Administrador de Usuarios";
            // 
            // gestionDePrestamosToolStripMenuItem
            // 
            this.gestionDePrestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorDePrestamosToolStripMenuItem});
            this.gestionDePrestamosToolStripMenuItem.Name = "gestionDePrestamosToolStripMenuItem";
            this.gestionDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.gestionDePrestamosToolStripMenuItem.Text = "Gestion de Prestamos";
            // 
            // administradorDePrestamosToolStripMenuItem
            // 
            this.administradorDePrestamosToolStripMenuItem.Name = "administradorDePrestamosToolStripMenuItem";
            this.administradorDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.administradorDePrestamosToolStripMenuItem.Text = "Administrador de Prestamos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelProgramaToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelProgramaToolStripMenuItem
            // 
            this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
            this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirDelProgramaToolStripMenuItem.Text = "Salir  del Programa";
            // 
            // MunuLaHuesera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MunuLaHuesera";
            this.Text = "Menu La Huesera";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDePeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDePeliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
    }
}

