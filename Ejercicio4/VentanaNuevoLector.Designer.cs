namespace Ejercicio4
{
    partial class VentanaNuevoLector
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
            label1 = new Label();
            label2 = new Label();
            tbID = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            tbApellido = new TextBox();
            textbox = new Label();
            label5 = new Label();
            cbMoroso = new CheckBox();
            btAtras = new Button();
            btGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 1;
            label1.Text = "Resgistrar Nuevo Lector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "ID de Lector";
            // 
            // tbID
            // 
            tbID.Location = new Point(100, 54);
            tbID.Name = "tbID";
            tbID.Size = new Size(131, 23);
            tbID.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(100, 83);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(131, 23);
            tbNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(100, 112);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(131, 23);
            tbApellido.TabIndex = 7;
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Location = new Point(12, 115);
            textbox.Name = "textbox";
            textbox.Size = new Size(51, 15);
            textbox.TabIndex = 6;
            textbox.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 144);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Moroso";
            // 
            // cbMoroso
            // 
            cbMoroso.AutoSize = true;
            cbMoroso.Location = new Point(100, 144);
            cbMoroso.Name = "cbMoroso";
            cbMoroso.Size = new Size(15, 14);
            cbMoroso.TabIndex = 9;
            cbMoroso.UseVisualStyleBackColor = true;
            // 
            // btAtras
            // 
            btAtras.Location = new Point(156, 198);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(75, 23);
            btAtras.TabIndex = 10;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(12, 198);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 11;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // VentanaNuevoLector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 233);
            Controls.Add(btGuardar);
            Controls.Add(btAtras);
            Controls.Add(cbMoroso);
            Controls.Add(label5);
            Controls.Add(tbApellido);
            Controls.Add(textbox);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(tbID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaNuevoLector";
            Text = "Nuevo Lector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbID;
        private TextBox tbNombre;
        private Label label3;
        private TextBox tbApellido;
        private Label textbox;
        private Label label5;
        private CheckBox cbMoroso;
        private Button btAtras;
        private Button btGuardar;
    }
}