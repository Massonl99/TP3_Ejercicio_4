namespace Ejercicio4
{
    partial class VentanaNuevoLibro
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
            label5 = new Label();
            tbAutor = new TextBox();
            tbApellido = new Label();
            tbTitulo = new TextBox();
            label3 = new Label();
            tbID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tbEditorial = new TextBox();
            SuspendLayout();
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(12, 198);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 22;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btAtras
            // 
            btAtras.Location = new Point(218, 198);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(75, 23);
            btAtras.TabIndex = 21;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 19;
            label5.Text = "Editorial";
            // 
            // tbAutor
            // 
            tbAutor.Location = new Point(100, 112);
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(193, 23);
            tbAutor.TabIndex = 18;
            // 
            // tbApellido
            // 
            tbApellido.AutoSize = true;
            tbApellido.Location = new Point(12, 115);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(37, 15);
            tbApellido.TabIndex = 17;
            tbApellido.Text = "Autor";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(100, 83);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(193, 23);
            tbTitulo.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 15;
            label3.Text = "Titulo";
            // 
            // tbID
            // 
            tbID.Location = new Point(100, 54);
            tbID.Name = "tbID";
            tbID.Size = new Size(193, 23);
            tbID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 13;
            label2.Text = "ID del Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 12;
            label1.Text = "Resgistrar Nuevo Libro";
            // 
            // tbEditorial
            // 
            tbEditorial.Location = new Point(100, 144);
            tbEditorial.Name = "tbEditorial";
            tbEditorial.Size = new Size(193, 23);
            tbEditorial.TabIndex = 23;
            // 
            // VentanaNuevoLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 231);
            Controls.Add(tbEditorial);
            Controls.Add(btGuardar);
            Controls.Add(btAtras);
            Controls.Add(label5);
            Controls.Add(tbAutor);
            Controls.Add(tbApellido);
            Controls.Add(tbTitulo);
            Controls.Add(label3);
            Controls.Add(tbID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaNuevoLibro";
            Text = "Nuevo Libro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGuardar;
        private Button btAtras;
        private Label label5;
        private TextBox tbAutor;
        private Label tbApellido;
        private TextBox tbTitulo;
        private Label label3;
        private TextBox tbID;
        private Label label2;
        private Label label1;
        private TextBox tbEditorial;
    }
}