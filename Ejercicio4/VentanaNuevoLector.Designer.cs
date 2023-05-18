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
            label1.Font = new Font("Unispace", 17.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(334, 28);
            label1.TabIndex = 1;
            label1.Text = "Resgistrar Nuevo Lector";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 2;
            label2.Text = "ID de Lector";
            // 
            // tbID
            // 
            tbID.Location = new Point(200, 62);
            tbID.Name = "tbID";
            tbID.Size = new Size(203, 22);
            tbID.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(200, 107);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(203, 22);
            tbNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(200, 135);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(203, 22);
            tbApellido.TabIndex = 7;
            // 
            // textbox
            // 
            textbox.AutoSize = true;
            textbox.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textbox.Location = new Point(12, 138);
            textbox.Name = "textbox";
            textbox.Size = new Size(89, 19);
            textbox.TabIndex = 6;
            textbox.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 8;
            label5.Text = "Moroso";
            // 
            // cbMoroso
            // 
            cbMoroso.AutoSize = true;
            cbMoroso.Location = new Point(200, 192);
            cbMoroso.Name = "cbMoroso";
            cbMoroso.Size = new Size(15, 14);
            cbMoroso.TabIndex = 9;
            cbMoroso.UseVisualStyleBackColor = true;
            // 
            // btAtras
            // 
            btAtras.Location = new Point(352, 284);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(100, 25);
            btAtras.TabIndex = 10;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(12, 284);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(100, 25);
            btGuardar.TabIndex = 11;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // VentanaNuevoLector
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(464, 321);
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
            Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "VentanaNuevoLector";
            StartPosition = FormStartPosition.Manual;
            Text = "REGISTRAR LECTOR";
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