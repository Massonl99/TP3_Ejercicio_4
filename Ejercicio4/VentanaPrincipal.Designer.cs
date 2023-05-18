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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            label1 = new Label();
            btNuevoLibro = new Button();
            btSalir = new Button();
            btPrestamo = new Button();
            btDevolucion = new Button();
            btNuevoLector = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 17.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(376, 28);
            label1.TabIndex = 0;
            label1.Text = "Prestamos de Libros UNCAUS";
            // 
            // btNuevoLibro
            // 
            btNuevoLibro.Location = new Point(12, 75);
            btNuevoLibro.Name = "btNuevoLibro";
            btNuevoLibro.Size = new Size(100, 50);
            btNuevoLibro.TabIndex = 1;
            btNuevoLibro.Text = "Agregar Nuevo Libro";
            btNuevoLibro.UseVisualStyleBackColor = true;
            btNuevoLibro.Click += btNuevoLibro_Click;
            // 
            // btSalir
            // 
            btSalir.Location = new Point(352, 259);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(100, 50);
            btSalir.TabIndex = 2;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // btPrestamo
            // 
            btPrestamo.Location = new Point(12, 143);
            btPrestamo.Name = "btPrestamo";
            btPrestamo.Size = new Size(100, 50);
            btPrestamo.TabIndex = 3;
            btPrestamo.Text = "Registrar \r\nPrestamo";
            btPrestamo.UseVisualStyleBackColor = true;
            btPrestamo.Click += btPrestamo_Click;
            // 
            // btDevolucion
            // 
            btDevolucion.Location = new Point(118, 143);
            btDevolucion.Name = "btDevolucion";
            btDevolucion.Size = new Size(100, 50);
            btDevolucion.TabIndex = 5;
            btDevolucion.Text = "Registrar Devolucion";
            btDevolucion.UseVisualStyleBackColor = true;
            btDevolucion.Click += btDevolucion_Click;
            // 
            // btNuevoLector
            // 
            btNuevoLector.Location = new Point(118, 75);
            btNuevoLector.Name = "btNuevoLector";
            btNuevoLector.Size = new Size(100, 50);
            btNuevoLector.TabIndex = 4;
            btNuevoLector.Text = "Registrar Nuevo\r\nLector\r\n";
            btNuevoLector.UseVisualStyleBackColor = true;
            btNuevoLector.Click += btNuevoLector_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(266, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(464, 321);
            Controls.Add(pictureBox1);
            Controls.Add(btDevolucion);
            Controls.Add(btNuevoLector);
            Controls.Add(btPrestamo);
            Controls.Add(btSalir);
            Controls.Add(btNuevoLibro);
            Controls.Add(label1);
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIBLIOTECA UNCAUS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}