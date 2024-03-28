namespace SistemaVentas.VISTA.DetalleIngVistas
{
    partial class DetalleIngInsertarVistas
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
            label6 = new Label();
            label7 = new Label();
            txtIdIngreso = new TextBox();
            txtIdProducto = new TextBox();
            txtFechaVenc = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtSubTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 30);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "IDINGRESO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 68);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "IDPRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 106);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "FECHAVENC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 144);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "CANTIDAD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 182);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "PRECIOCOSTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 220);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 5;
            label6.Text = "PRECIOVENTA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 258);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 6;
            label7.Text = "SUBTOTAL";
            // 
            // txtIdIngreso
            // 
            txtIdIngreso.Location = new Point(148, 27);
            txtIdIngreso.Name = "txtIdIngreso";
            txtIdIngreso.Size = new Size(340, 27);
            txtIdIngreso.TabIndex = 7;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(148, 65);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(340, 27);
            txtIdProducto.TabIndex = 8;
            // 
            // txtFechaVenc
            // 
            txtFechaVenc.Location = new Point(148, 103);
            txtFechaVenc.Name = "txtFechaVenc";
            txtFechaVenc.Size = new Size(340, 27);
            txtFechaVenc.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(148, 141);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(340, 27);
            txtCantidad.TabIndex = 10;
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(148, 179);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(340, 27);
            txtPrecioCosto.TabIndex = 11;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(148, 217);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(340, 27);
            txtPrecioVenta.TabIndex = 12;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(148, 255);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(340, 27);
            txtSubTotal.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(232, 335);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(418, 335);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // DetalleIngInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSubTotal);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCosto);
            Controls.Add(txtCantidad);
            Controls.Add(txtFechaVenc);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdIngreso);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleIngInsertarVistas";
            Text = "DetalleIngInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtIdIngreso;
        private TextBox txtIdProducto;
        private TextBox txtFechaVenc;
        private TextBox txtCantidad;
        private TextBox txtPrecioCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtSubTotal;
        private Button button1;
        private Button button2;
    }
}