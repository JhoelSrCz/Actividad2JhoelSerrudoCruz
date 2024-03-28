namespace SistemaVentas.VISTA.VentaVistas
{
    partial class VentaInsertarVistas
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
            label4 = new Label();
            txtIdCliente = new TextBox();
            txtIdVendedor = new TextBox();
            txtFecha = new TextBox();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 45);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "IDCLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 90);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "IDVENDEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 135);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "FECHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 180);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "TOTAL";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(181, 42);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(295, 27);
            txtIdCliente.TabIndex = 4;
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(181, 87);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(295, 27);
            txtIdVendedor.TabIndex = 5;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(181, 132);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(295, 27);
            txtFecha.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(181, 177);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(295, 27);
            txtTotal.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(305, 277);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(448, 277);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // VentaInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(txtFecha);
            Controls.Add(txtIdVendedor);
            Controls.Add(txtIdCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentaInsertarVistas";
            Text = "VentaInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdCliente;
        private TextBox txtIdVendedor;
        private TextBox txtFecha;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
    }
}