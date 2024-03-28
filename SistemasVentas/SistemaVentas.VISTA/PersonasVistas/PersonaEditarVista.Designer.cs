namespace SistemaVentas.VISTA.PersonasVistas
{
    partial class PersonaEditarVista
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
            button2 = new Button();
            button1 = new Button();
            txtCorreo = new TextBox();
            txtCi = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(331, 294);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 23;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(134, 294);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(148, 219);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(335, 27);
            txtCorreo.TabIndex = 21;
            // 
            // txtCi
            // 
            txtCi.Location = new Point(148, 173);
            txtCi.Name = "txtCi";
            txtCi.Size = new Size(335, 27);
            txtCi.TabIndex = 20;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(148, 127);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(335, 27);
            txtTelefono.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(148, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(335, 27);
            txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(335, 27);
            txtNombre.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 222);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 16;
            label5.Text = "CORREO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 176);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 15;
            label4.Text = "CI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 130);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 14;
            label3.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 84);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 13;
            label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 12;
            label1.Text = "NOMBRE";
            // 
            // PersonaEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 360);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCorreo);
            Controls.Add(txtCi);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PersonaEditarVista";
            Text = "PersonaEditarVista";
            Load += PersonaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox txtCorreo;
        private TextBox txtCi;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}