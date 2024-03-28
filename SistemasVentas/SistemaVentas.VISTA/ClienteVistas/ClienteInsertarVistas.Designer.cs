namespace SistemaVentas.VISTA.ClienteVistas
{
    partial class ClienteInsertarVistas
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
            txtIdPersona = new TextBox();
            label4 = new Label();
            txtTipoCliente = new TextBox();
            txtCodigoCliente = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 47);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "IDPERSONA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 95);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "TIPOCLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 143);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "CODIGOCLIENTE";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(259, 44);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(305, 27);
            txtIdPersona.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 215);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(259, 92);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.Size = new Size(305, 27);
            txtTipoCliente.TabIndex = 5;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(259, 140);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(305, 27);
            txtCodigoCliente.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(305, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(470, 252);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // ClienteInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCodigoCliente);
            Controls.Add(txtTipoCliente);
            Controls.Add(label4);
            Controls.Add(txtIdPersona);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteInsertarVistas";
            Text = "ClienteInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdPersona;
        private Label label4;
        private TextBox txtTipoCliente;
        private TextBox txtCodigoCliente;
        private Button button1;
        private Button button2;
    }
}