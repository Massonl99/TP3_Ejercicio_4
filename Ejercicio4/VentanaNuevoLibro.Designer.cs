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
            btGuardar.Location = new Point(12, 284);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(100, 25);
            btGuardar.TabIndex = 22;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btAtras
            // 
            btAtras.Location = new Point(352, 284);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(100, 25);
            btAtras.TabIndex = 21;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 19;
            label5.Text = "Editorial";
            // 
            // tbAutor
            // 
            tbAutor.Location = new Point(203, 146);
            tbAutor.Name = "tbAutor";
            tbAutor.Size = new Size(217, 22);
            tbAutor.TabIndex = 18;
            // 
            // tbApellido
            // 
            tbApellido.AutoSize = true;
            tbApellido.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbApellido.Location = new Point(12, 149);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(59, 19);
            tbApellido.TabIndex = 17;
            tbApellido.Text = "Autor";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(203, 99);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.Size = new Size(217, 22);
            tbTitulo.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 15;
            label3.Text = "Titulo";
            // 
            // tbID
            // 
            tbID.Location = new Point(203, 54);
            tbID.Name = "tbID";
            tbID.Size = new Size(217, 22);
            tbID.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 13;
            label2.Text = "ID del Libro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 17.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(320, 28);
            label1.TabIndex = 12;
            label1.Text = "Resgistrar Nuevo Libro";
            // 
            // tbEditorial
            // 
            tbEditorial.Location = new Point(203, 194);
            tbEditorial.Name = "tbEditorial";
            tbEditorial.Size = new Size(217, 22);
            tbEditorial.TabIndex = 23;
            // 
            // VentanaNuevoLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(464, 321);
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
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "VentanaNuevoLibro";
            StartPosition = FormStartPosition.Manual;
            Text = "REGISTRAR LIBRO";
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