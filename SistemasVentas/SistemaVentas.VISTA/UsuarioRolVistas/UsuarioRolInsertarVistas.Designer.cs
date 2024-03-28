namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolInsertarVistas
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
            label3 = new Label();
            txtIdUsuario = new TextBox();
            txtIdRol = new TextBox();
            txtFechaAsigna = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 76);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "IDUSUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 132);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "IDROL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 188);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "FECHAASIGNA";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(212, 73);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(299, 27);
            txtIdUsuario.TabIndex = 3;
            // 
            // txtIdRol
            // 
            txtIdRol.Location = new Point(212, 129);
            txtIdRol.Name = "txtIdRol";
            txtIdRol.Size = new Size(299, 27);
            txtIdRol.TabIndex = 4;
            // 
            // txtFechaAsigna
            // 
            txtFechaAsigna.Location = new Point(212, 185);
            txtFechaAsigna.Name = "txtFechaAsigna";
            txtFechaAsigna.Size = new Size(299, 27);
            txtFechaAsigna.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(258, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(417, 276);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // UsuarioRolInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtFechaAsigna);
            Controls.Add(txtIdRol);
            Controls.Add(txtIdUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioRolInsertarVistas";
            Text = "UsuarioRolInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdUsuario;
        private TextBox txtIdRol;
        private TextBox txtFechaAsigna;
        private Button button1;
        private Button button2;
    }
}