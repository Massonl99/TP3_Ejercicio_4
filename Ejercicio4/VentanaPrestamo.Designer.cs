namespace Ejercicio4
{
    partial class VentanaPrestamo
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
            btGuardar = new Button();
            btAtras = new Button();
            cbMoroso = new CheckBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            boxLectores = new ComboBox();
            boxLibros = new ComboBox();
            label4 = new Label();
            FechaPrestamo = new DateTimePicker();
            cbPrestado = new CheckBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(11, 222);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 22;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btAtras
            // 
            btAtras.Location = new Point(248, 222);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(75, 23);
            btAtras.TabIndex = 21;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // cbMoroso
            // 
            cbMoroso.AutoSize = true;
            cbMoroso.Location = new Point(88, 161);
            cbMoroso.Name = "cbMoroso";
            cbMoroso.Size = new Size(15, 14);
            cbMoroso.TabIndex = 20;
            cbMoroso.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 19;
            label5.Text = "Moroso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 13;
            label2.Text = "Lector";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 28);
            label1.TabIndex = 12;
            label1.Text = "Resgistrar Nuevo Prestamo\r\n";
            // 
            // boxLectores
            // 
            boxLectores.FormattingEnabled = true;
            boxLectores.Location = new Point(88, 54);
            boxLectores.Name = "boxLectores";
            boxLectores.Size = new Size(235, 23);
            boxLectores.TabIndex = 23;
            boxLectores.SelectedIndexChanged += boxLectores_SelectedIndexChanged;
            // 
            // boxLibros
            // 
            boxLibros.FormattingEnabled = true;
            boxLibros.Location = new Point(88, 83);
            boxLibros.Name = "boxLibros";
            boxLibros.Size = new Size(235, 23);
            boxLibros.TabIndex = 24;
            boxLibros.SelectedIndexChanged += boxLibros_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 115);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 25;
            label4.Text = "Fecha De\r\nPrestamo";
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.Location = new Point(88, 115);
            FechaPrestamo.Name = "FechaPrestamo";
            FechaPrestamo.Size = new Size(235, 23);
            FechaPrestamo.TabIndex = 26;
            // 
            // cbPrestado
            // 
            cbPrestado.AutoSize = true;
            cbPrestado.Location = new Point(88, 193);
            cbPrestado.Name = "cbPrestado";
            cbPrestado.Size = new Size(15, 14);
            cbPrestado.TabIndex = 28;
            cbPrestado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 193);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 27;
            label6.Text = "Prestado";
            // 
            // VentanaPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 260);
            Controls.Add(cbPrestado);
            Controls.Add(label6);
            Controls.Add(FechaPrestamo);
            Controls.Add(label4);
            Controls.Add(boxLibros);
            Controls.Add(boxLectores);
            Controls.Add(btGuardar);
            Controls.Add(btAtras);
            Controls.Add(cbMoroso);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaPrestamo";
            Text = "Nuevo Prestamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGuardar;
        private Button btAtras;
        private CheckBox cbMoroso;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox boxLectores;
        private ComboBox boxLibros;
        private Label label4;
        private DateTimePicker FechaPrestamo;
        private CheckBox cbPrestado;
        private Label label6;
    }
}