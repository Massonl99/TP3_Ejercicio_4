namespace Ejercicio4
{
    partial class VentanaDevolucion
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
            FechaPrestamo = new DateTimePicker();
            label4 = new Label();
            boxLibros = new ComboBox();
            btGuardar = new Button();
            btAtras = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FechaDevolucion = new DateTimePicker();
            label5 = new Label();
            tbLector = new TextBox();
            SuspendLayout();
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.Location = new Point(112, 141);
            FechaPrestamo.Name = "FechaPrestamo";
            FechaPrestamo.Size = new Size(302, 22);
            FechaPrestamo.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 34;
            label4.Text = "Fecha De\r\nPrestamo";
            // 
            // boxLibros
            // 
            boxLibros.FormattingEnabled = true;
            boxLibros.Location = new Point(112, 48);
            boxLibros.Name = "boxLibros";
            boxLibros.Size = new Size(302, 22);
            boxLibros.TabIndex = 33;
            boxLibros.SelectedIndexChanged += boxLibros_SelectedIndexChanged;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(12, 284);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(100, 25);
            btGuardar.TabIndex = 31;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btAtras
            // 
            btAtras.Location = new Point(352, 284);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(100, 25);
            btAtras.TabIndex = 30;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(42, 14);
            label3.TabIndex = 29;
            label3.Text = "Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(49, 14);
            label2.TabIndex = 28;
            label2.Text = "Lector";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 17.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(306, 28);
            label1.TabIndex = 27;
            label1.Text = "Resgistrar Devolucion";
            // 
            // FechaDevolucion
            // 
            FechaDevolucion.Location = new Point(112, 192);
            FechaDevolucion.Name = "FechaDevolucion";
            FechaDevolucion.Size = new Size(302, 22);
            FechaDevolucion.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 36;
            label5.Text = "Fecha De\r\nDevolucion";
            // 
            // tbLector
            // 
            tbLector.Location = new Point(112, 90);
            tbLector.Name = "tbLector";
            tbLector.Size = new Size(302, 22);
            tbLector.TabIndex = 38;
            // 
            // VentanaDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(464, 321);
            Controls.Add(tbLector);
            Controls.Add(FechaDevolucion);
            Controls.Add(label5);
            Controls.Add(FechaPrestamo);
            Controls.Add(label4);
            Controls.Add(boxLibros);
            Controls.Add(btGuardar);
            Controls.Add(btAtras);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "VentanaDevolucion";
            StartPosition = FormStartPosition.Manual;
            Text = "REGISTRAR DEVOLUCION";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker FechaPrestamo;
        private Label label4;
        private ComboBox boxLibros;
        private Button btGuardar;
        private Button btAtras;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker FechaDevolucion;
        private Label label5;
        private TextBox tbLector;
    }
}