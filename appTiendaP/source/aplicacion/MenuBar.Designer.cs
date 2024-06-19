namespace appTiendaP.source.aplicacion
{
    partial class MenuBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnmNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnmGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnmEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnmConsultar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmNuevo,
            this.btnmGuardar,
            this.btnCancelar,
            this.btnmEliminar,
            this.btnmConsultar,
            this.btnModificar,
            this.btnCerrar,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 348);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 102);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnmNuevo
            // 
            this.btnmNuevo.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnmNuevo.Image")));
            this.btnmNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmNuevo.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnmNuevo.Name = "btnmNuevo";
            this.btnmNuevo.Padding = new System.Windows.Forms.Padding(20);
            this.btnmNuevo.Size = new System.Drawing.Size(102, 85);
            this.btnmNuevo.Text = "Nuevo";
            this.btnmNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmNuevo.Click += new System.EventHandler(this.btnmNuevo_Click);
            // 
            // btnmGuardar
            // 
            this.btnmGuardar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnmGuardar.Image")));
            this.btnmGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmGuardar.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnmGuardar.Name = "btnmGuardar";
            this.btnmGuardar.Size = new System.Drawing.Size(75, 85);
            this.btnmGuardar.Text = "Guardar";
            this.btnmGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmGuardar.Click += new System.EventHandler(this.btnmGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 85);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnmEliminar
            // 
            this.btnmEliminar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnmEliminar.Image")));
            this.btnmEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmEliminar.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnmEliminar.Name = "btnmEliminar";
            this.btnmEliminar.Size = new System.Drawing.Size(77, 85);
            this.btnmEliminar.Text = "Eliminar";
            this.btnmEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmEliminar.Click += new System.EventHandler(this.btnmEliminar_Click);
            // 
            // btnmConsultar
            // 
            this.btnmConsultar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnmConsultar.Image")));
            this.btnmConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmConsultar.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnmConsultar.Name = "btnmConsultar";
            this.btnmConsultar.Size = new System.Drawing.Size(83, 85);
            this.btnmConsultar.Text = "Consultar";
            this.btnmConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmConsultar.Click += new System.EventHandler(this.btnmConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 85);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(12, 15, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 85);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 102);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // MenuBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MenuBar";
            this.Text = "MenuBar";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.ToolStripButton btnmGuardar;
        private System.Windows.Forms.ToolStripButton btnmEliminar;
        private System.Windows.Forms.ToolStripButton btnmConsultar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        public System.Windows.Forms.ToolStripButton btnmNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}