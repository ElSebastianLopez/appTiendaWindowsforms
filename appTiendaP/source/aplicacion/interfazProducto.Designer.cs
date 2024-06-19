namespace appTiendaP.source.aplicacion
{
    partial class interfazProducto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Listcategories = new System.Windows.Forms.ComboBox();
            this.txtCategoria_id = new System.Windows.Forms.TextBox();
            this.txtCantidad_actual = new System.Windows.Forms.TextBox();
            this.txtPrecio_venta = new System.Windows.Forms.TextBox();
            this.txtPrecio_compra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Listcategories);
            this.groupBox1.Controls.Add(this.txtCategoria_id);
            this.groupBox1.Controls.Add(this.txtCantidad_actual);
            this.groupBox1.Controls.Add(this.txtPrecio_venta);
            this.groupBox1.Controls.Add(this.txtPrecio_compra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(442, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION PRODUCTOS";
            // 
            // Listcategories
            // 
            this.Listcategories.FormattingEnabled = true;
            this.Listcategories.Location = new System.Drawing.Point(256, 211);
            this.Listcategories.Name = "Listcategories";
            this.Listcategories.Size = new System.Drawing.Size(121, 25);
            this.Listcategories.TabIndex = 12;
            // 
            // txtCategoria_id
            // 
            this.txtCategoria_id.Enabled = false;
            this.txtCategoria_id.Location = new System.Drawing.Point(265, 171);
            this.txtCategoria_id.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria_id.Name = "txtCategoria_id";
            this.txtCategoria_id.Size = new System.Drawing.Size(64, 23);
            this.txtCategoria_id.TabIndex = 11;
            // 
            // txtCantidad_actual
            // 
            this.txtCantidad_actual.Location = new System.Drawing.Point(265, 110);
            this.txtCantidad_actual.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad_actual.Name = "txtCantidad_actual";
            this.txtCantidad_actual.Size = new System.Drawing.Size(64, 23);
            this.txtCantidad_actual.TabIndex = 10;
            // 
            // txtPrecio_venta
            // 
            this.txtPrecio_venta.Location = new System.Drawing.Point(265, 54);
            this.txtPrecio_venta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio_venta.Name = "txtPrecio_venta";
            this.txtPrecio_venta.Size = new System.Drawing.Size(64, 23);
            this.txtPrecio_venta.TabIndex = 9;
            // 
            // txtPrecio_compra
            // 
            this.txtPrecio_compra.Location = new System.Drawing.Point(50, 171);
            this.txtPrecio_compra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio_compra.Name = "txtPrecio_compra";
            this.txtPrecio_compra.Size = new System.Drawing.Size(64, 23);
            this.txtPrecio_compra.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Categoria_Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad_Actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio_Venta\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio_Compra";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(50, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(64, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(50, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(56, 23);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(442, 61);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 24;
            this.dgvProducto.Size = new System.Drawing.Size(495, 193);
            this.dgvProducto.TabIndex = 6;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // interfazProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 451);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.groupBox1);
            this.Name = "interfazProducto";
            this.Text = "InterfazProducto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvProducto, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad_actual;
        private System.Windows.Forms.TextBox txtPrecio_venta;
        private System.Windows.Forms.TextBox txtPrecio_compra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txtCategoria_id;
        private System.Windows.Forms.ComboBox Listcategories;
    }
}