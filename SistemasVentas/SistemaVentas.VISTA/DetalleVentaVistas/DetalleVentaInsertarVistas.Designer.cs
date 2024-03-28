namespace SistemaVentas.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaInsertarVistas
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
            txtIdVenta = new TextBox();
            txtIdProducto = new TextBox();
            txtCantidad = new TextBox();
            txtPrecioVenta = new TextBox();
            txtSubTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "IDVENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 91);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "IDPRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 142);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 193);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "PRECIOVENTA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 244);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "SUBTOTAL";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(206, 37);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(331, 27);
            txtIdVenta.TabIndex = 5;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(206, 88);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(331, 27);
            txtIdProducto.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(206, 139);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(331, 27);
            txtCantidad.TabIndex = 7;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(206, 190);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(331, 27);
            txtPrecioVenta.TabIndex = 8;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(206, 241);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(331, 27);
            txtSubTotal.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(282, 334);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(452, 334);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // DetalleVentaInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSubTotal);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCantidad);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdVenta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetalleVentaInsertarVistas";
            Text = "DetalleVentaInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdVenta;
        private TextBox txtIdProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecioVenta;
        private TextBox txtSubTotal;
        private Button button1;
        private Button button2;
    }
}