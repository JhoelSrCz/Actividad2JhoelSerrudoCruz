namespace SistemaVentas.VISTA.IngresoVistas
{
    partial class IngresoInsertarVistas
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
            txtIdProveedor = new TextBox();
            txtFechaIngreso = new TextBox();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "IDPROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 99);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "FECHAINGRESO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 148);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "TOTAL";
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.Location = new Point(164, 47);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(345, 27);
            txtIdProveedor.TabIndex = 3;
            // 
            // txtFechaIngreso
            // 
            txtFechaIngreso.Location = new Point(164, 96);
            txtFechaIngreso.Name = "txtFechaIngreso";
            txtFechaIngreso.Size = new Size(345, 27);
            txtFechaIngreso.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(164, 145);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(345, 27);
            txtTotal.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(270, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(415, 266);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // IngresoInsertarVistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(txtFechaIngreso);
            Controls.Add(txtIdProveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresoInsertarVistas";
            Text = "IngresoInsertarVistas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdProveedor;
        private TextBox txtFechaIngreso;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
    }
}