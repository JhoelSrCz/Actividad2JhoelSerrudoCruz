namespace SistemaVentas.VISTA.ProveeVistas
{
    partial class ProveeInsertarVistas
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
            label5 = new Label();
            txtIdProducto = new TextBox();
            txtProveedor = new TextBox();
            txtFecha = new TextBox();
            txtPrecio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "IDPRODUCTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 70);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "IDPROVEEDOR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 166);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 102);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "FECHA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 134);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "PRECIO";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(146, 35);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(316, 27);
            txtIdProducto.TabIndex = 5;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(146, 67);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(316, 27);
            txtProveedor.TabIndex = 6;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(146, 98);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(316, 27);
            txtFecha.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(146, 131);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(316, 27);
            txtPrecio.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(214, 224);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 224);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProveeInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(txtFecha);
            Controls.Add(txtProveedor);
            Controls.Add(txtIdProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProveeInsertarVistas";
            Text = "ProveeInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdProducto;
        private TextBox txtProveedor;
        private TextBox txtFecha;
        private TextBox txtPrecio;
        private Button button1;
        private Button button2;
    }
}