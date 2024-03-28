namespace SistemaVentas.VISTA.ProductoVistas
{
    partial class ProductoInsertarVistas
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
            txtIdTipoProd = new TextBox();
            txtIdMarca = new TextBox();
            txtNombre = new TextBox();
            txtCodigoBarra = new TextBox();
            txtUnidad = new TextBox();
            txtDescripcion = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 34);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "IDTIPOPROD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 71);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "IDMARCA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 108);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 145);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "CODIGOBARRA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 182);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "UNIDAD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 219);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "DESCRIPCION";
            // 
            // txtIdTipoProd
            // 
            txtIdTipoProd.Location = new Point(194, 31);
            txtIdTipoProd.Name = "txtIdTipoProd";
            txtIdTipoProd.Size = new Size(317, 27);
            txtIdTipoProd.TabIndex = 6;
            // 
            // txtIdMarca
            // 
            txtIdMarca.Location = new Point(194, 68);
            txtIdMarca.Name = "txtIdMarca";
            txtIdMarca.Size = new Size(317, 27);
            txtIdMarca.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(194, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(194, 142);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.Size = new Size(317, 27);
            txtCodigoBarra.TabIndex = 9;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(194, 179);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(317, 27);
            txtUnidad.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(194, 216);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(317, 27);
            txtDescripcion.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(275, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(441, 307);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProductoInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtUnidad);
            Controls.Add(txtCodigoBarra);
            Controls.Add(txtNombre);
            Controls.Add(txtIdMarca);
            Controls.Add(txtIdTipoProd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoInsertarVistas";
            Text = "ProductoInsertarVistas";
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
        private TextBox txtIdTipoProd;
        private TextBox txtIdMarca;
        private TextBox txtNombre;
        private TextBox txtCodigoBarra;
        private TextBox txtUnidad;
        private TextBox txtDescripcion;
        private Button button1;
        private Button button2;
    }
}