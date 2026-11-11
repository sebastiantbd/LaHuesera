namespace EscritorioLaHuesera
{
    partial class GestionPelicula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txDescripcion = new System.Windows.Forms.TextBox();
            this.txDuracion = new System.Windows.Forms.TextBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.btAgregarPelicula = new System.Windows.Forms.Button();
            this.btEditarPelicula = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Peliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de la Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripcion de la Pelicula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Codigo";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(373, 132);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(236, 26);
            this.txNombre.TabIndex = 1;
            // 
            // txDescripcion
            // 
            this.txDescripcion.Location = new System.Drawing.Point(373, 196);
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.Size = new System.Drawing.Size(236, 26);
            this.txDescripcion.TabIndex = 1;
            // 
            // txDuracion
            // 
            this.txDuracion.Location = new System.Drawing.Point(373, 255);
            this.txDuracion.Name = "txDuracion";
            this.txDuracion.Size = new System.Drawing.Size(236, 26);
            this.txDuracion.TabIndex = 1;
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(373, 317);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(236, 26);
            this.txCodigo.TabIndex = 1;
            // 
            // btAgregarPelicula
            // 
            this.btAgregarPelicula.Location = new System.Drawing.Point(715, 89);
            this.btAgregarPelicula.Name = "btAgregarPelicula";
            this.btAgregarPelicula.Size = new System.Drawing.Size(200, 38);
            this.btAgregarPelicula.TabIndex = 2;
            this.btAgregarPelicula.Text = "Guardar Registro";
            this.btAgregarPelicula.UseVisualStyleBackColor = true;
            this.btAgregarPelicula.Click += new System.EventHandler(this.btAgregarPelicula_Click);
            // 
            // btEditarPelicula
            // 
            this.btEditarPelicula.Location = new System.Drawing.Point(715, 151);
            this.btEditarPelicula.Name = "btEditarPelicula";
            this.btEditarPelicula.Size = new System.Drawing.Size(200, 38);
            this.btEditarPelicula.TabIndex = 2;
            this.btEditarPelicula.Text = "Editar Pelicula";
            this.btEditarPelicula.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(715, 270);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(200, 38);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar Pelicula";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(715, 337);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(200, 38);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // txSalida
            // 
            this.txSalida.Location = new System.Drawing.Point(55, 450);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txSalida.Size = new System.Drawing.Size(860, 310);
            this.txSalida.TabIndex = 3;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(50, 387);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(342, 29);
            this.lblSalida.TabIndex = 0;
            this.lblSalida.Text = "Salida de Peliculas Agregadas";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(715, 210);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 38);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar Peliculas Agregadas";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // GestionPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 837);
            this.Controls.Add(this.txSalida);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditarPelicula);
            this.Controls.Add(this.btAgregarPelicula);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.txDuracion);
            this.Controls.Add(this.txDescripcion);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionPelicula";
            this.Text = "GestionPelicula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txDescripcion;
        private System.Windows.Forms.TextBox txDuracion;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Button btAgregarPelicula;
        private System.Windows.Forms.Button btEditarPelicula;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button btnConsultar;
    }
}