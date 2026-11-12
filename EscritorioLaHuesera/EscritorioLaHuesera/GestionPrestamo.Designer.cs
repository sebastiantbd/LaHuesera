namespace EscritorioLaHuesera
{
    partial class GestionPrestamo
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
            this.components = new System.ComponentModel.Container();
            this.cbPelicula = new System.Windows.Forms.ComboBox();
            this.laHueseraDataSetPelis = new EscritorioLaHuesera.LaHueseraDataSetPelis();
            this.peliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peliculasTableAdapter = new EscritorioLaHuesera.LaHueseraDataSetPelisTableAdapters.peliculasTableAdapter();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.laHueseraDataSetUsu = new EscritorioLaHuesera.LaHueseraDataSetUsu();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new EscritorioLaHuesera.LaHueseraDataSetUsuTableAdapters.usuariosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerDevolucion = new System.Windows.Forms.DateTimePicker();
            this.btAgregarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.laHueseraDataSetPelis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laHueseraDataSetUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPelicula
            // 
            this.cbPelicula.DataSource = this.peliculasBindingSource;
            this.cbPelicula.DisplayMember = "nombre";
            this.cbPelicula.FormattingEnabled = true;
            this.cbPelicula.Location = new System.Drawing.Point(392, 177);
            this.cbPelicula.Name = "cbPelicula";
            this.cbPelicula.Size = new System.Drawing.Size(237, 28);
            this.cbPelicula.TabIndex = 0;
            this.cbPelicula.ValueMember = "id";
            // 
            // laHueseraDataSetPelis
            // 
            this.laHueseraDataSetPelis.DataSetName = "LaHueseraDataSetPelis";
            this.laHueseraDataSetPelis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peliculasBindingSource
            // 
            this.peliculasBindingSource.DataMember = "peliculas";
            this.peliculasBindingSource.DataSource = this.laHueseraDataSetPelis;
            // 
            // peliculasTableAdapter
            // 
            this.peliculasTableAdapter.ClearBeforeFill = true;
            // 
            // cbUsuario
            // 
            this.cbUsuario.DataSource = this.usuariosBindingSource;
            this.cbUsuario.DisplayMember = "nombre";
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(392, 257);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(237, 28);
            this.cbUsuario.TabIndex = 1;
            this.cbUsuario.ValueMember = "id";
            // 
            // laHueseraDataSetUsu
            // 
            this.laHueseraDataSetUsu.DataSetName = "LaHueseraDataSetUsu";
            this.laHueseraDataSetUsu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.laHueseraDataSetUsu;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione la Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione el Usuario";
            // 
            // dateTimePickerPrestamo
            // 
            this.dateTimePickerPrestamo.Location = new System.Drawing.Point(463, 335);
            this.dateTimePickerPrestamo.Name = "dateTimePickerPrestamo";
            this.dateTimePickerPrestamo.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerPrestamo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Seleccione Fecha de Prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Seleccione Fecha de Devolucion";
            // 
            // dateTimePickerDevolucion
            // 
            this.dateTimePickerDevolucion.Location = new System.Drawing.Point(463, 400);
            this.dateTimePickerDevolucion.Name = "dateTimePickerDevolucion";
            this.dateTimePickerDevolucion.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerDevolucion.TabIndex = 3;
            // 
            // btAgregarPrestamo
            // 
            this.btAgregarPrestamo.Location = new System.Drawing.Point(338, 490);
            this.btAgregarPrestamo.Name = "btAgregarPrestamo";
            this.btAgregarPrestamo.Size = new System.Drawing.Size(154, 43);
            this.btAgregarPrestamo.TabIndex = 4;
            this.btAgregarPrestamo.Text = "Agregar Prestamo";
            this.btAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btAgregarPrestamo.Click += new System.EventHandler(this.btAgregarPrestamo_Click);
            // 
            // GestionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 609);
            this.Controls.Add(this.btAgregarPrestamo);
            this.Controls.Add(this.dateTimePickerDevolucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbPelicula);
            this.Name = "GestionPrestamo";
            this.Text = "GestionPrestamo";
            this.Load += new System.EventHandler(this.GestionPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laHueseraDataSetPelis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laHueseraDataSetUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPelicula;
        private LaHueseraDataSetPelis laHueseraDataSetPelis;
        private System.Windows.Forms.BindingSource peliculasBindingSource;
        private LaHueseraDataSetPelisTableAdapters.peliculasTableAdapter peliculasTableAdapter;
        private System.Windows.Forms.ComboBox cbUsuario;
        private LaHueseraDataSetUsu laHueseraDataSetUsu;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private LaHueseraDataSetUsuTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerDevolucion;
        private System.Windows.Forms.Button btAgregarPrestamo;
    }
}