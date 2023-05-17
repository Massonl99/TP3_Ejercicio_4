namespace Ejercicio4
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btNuevoLibro = new Button();
            btSalir = new Button();
            btPrestamo = new Button();
            btDevolucion = new Button();
            btNuevoLector = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 0;
            label1.Text = "Prestamos de Libros UNCAUS";
            // 
            // btNuevoLibro
            // 
            btNuevoLibro.Location = new Point(12, 51);
            btNuevoLibro.Name = "btNuevoLibro";
            btNuevoLibro.Size = new Size(107, 46);
            btNuevoLibro.TabIndex = 1;
            btNuevoLibro.Text = "Agregar Nuevo Libro";
            btNuevoLibro.UseVisualStyleBackColor = true;
            btNuevoLibro.Click += btNuevoLibro_Click;
            // 
            // btSalir
            // 
            btSalir.Location = new Point(208, 172);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(75, 23);
            btSalir.TabIndex = 2;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btPrestamo
            // 
            btPrestamo.Location = new Point(12, 103);
            btPrestamo.Name = "btPrestamo";
            btPrestamo.Size = new Size(107, 46);
            btPrestamo.TabIndex = 3;
            btPrestamo.Text = "Registrar \r\nPrestamo";
            btPrestamo.UseVisualStyleBackColor = true;
            btPrestamo.Click += btPrestamo_Click;
            // 
            // btDevolucion
            // 
            btDevolucion.Location = new Point(176, 103);
            btDevolucion.Name = "btDevolucion";
            btDevolucion.Size = new Size(107, 46);
            btDevolucion.TabIndex = 5;
            btDevolucion.Text = "Registrar Devolucion";
            btDevolucion.UseVisualStyleBackColor = true;
            btDevolucion.Click += btDevolucion_Click;
            // 
            // btNuevoLector
            // 
            btNuevoLector.Location = new Point(176, 51);
            btNuevoLector.Name = "btNuevoLector";
            btNuevoLector.Size = new Size(107, 46);
            btNuevoLector.TabIndex = 4;
            btNuevoLector.Text = "Registrar Nuevo\r\nLector\r\n";
            btNuevoLector.UseVisualStyleBackColor = true;
            btNuevoLector.Click += btNuevoLector_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 212);
            Controls.Add(btDevolucion);
            Controls.Add(btNuevoLector);
            Controls.Add(btPrestamo);
            Controls.Add(btSalir);
            Controls.Add(btNuevoLibro);
            Controls.Add(label1);
            Name = "VentanaPrincipal";
            Text = "Biblioteca UNCAUS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btNuevoLibro;
        private Button btSalir;
        private Button btPrestamo;
        private Button btDevolucion;
        private Button btNuevoLector;
    }
}