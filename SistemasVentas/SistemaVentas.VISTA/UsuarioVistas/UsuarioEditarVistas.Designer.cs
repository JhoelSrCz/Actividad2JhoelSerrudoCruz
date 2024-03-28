namespace SistemaVentas.VISTA.UsuarioVistas
{
    partial class UsuarioEditarVistas
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
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtContraseña = new TextBox();
            txtNombreUser = new TextBox();
            txtIdPersona = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(246, 31);
            label5.Name = "label5";
            label5.Size = new Size(262, 37);
            label5.TabIndex = 24;
            label5.Text = "EDITAR USUARIO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(233, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(295, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // button3
            // 
            button3.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(579, 119);
            button3.Name = "button3";
            button3.Size = new Size(134, 29);
            button3.TabIndex = 22;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(401, 387);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 21;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(233, 387);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 20;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(229, 245);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(299, 27);
            txtContraseña.TabIndex = 19;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNombreUser
            // 
            txtNombreUser.Location = new Point(229, 183);
            txtNombreUser.Name = "txtNombreUser";
            txtNombreUser.Size = new Size(299, 27);
            txtNombreUser.TabIndex = 18;
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(229, 121);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(299, 27);
            txtIdPersona.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(98, 309);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 16;
            label4.Text = "FECHA REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 246);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 15;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 183);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 14;
            label2.Text = "NOMBRE USUARIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 120);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 13;
            label1.Text = "IDPERSONA";
            // 
            // UsuarioEditarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUser);
            Controls.Add(txtIdPersona);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioEditarVistas";
            Text = "UsuarioEditarVistas";
            Load += UsuarioEditarVistas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtContraseña;
        private TextBox txtNombreUser;
        private TextBox txtIdPersona;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}