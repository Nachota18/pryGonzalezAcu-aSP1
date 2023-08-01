namespace pySP1Miprimerapp
{
    partial class frmAlacena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlacena));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreDeProducto = new System.Windows.Forms.TextBox();
            this.lblNombredelProducto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstCatProductos = new System.Windows.Forms.ComboBox();
            this.lstCantidad = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.lstAlacena = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdConfirmar);
            this.groupBox1.Controls.Add(this.cmdCancelar);
            this.groupBox1.Controls.Add(this.lstCantidad);
            this.groupBox1.Controls.Add(this.lstCatProductos);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblNombredelProducto);
            this.groupBox1.Controls.Add(this.txtNombreDeProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Productos";
            // 
            // txtNombreDeProducto
            // 
            this.txtNombreDeProducto.Location = new System.Drawing.Point(253, 50);
            this.txtNombreDeProducto.Name = "txtNombreDeProducto";
            this.txtNombreDeProducto.Size = new System.Drawing.Size(174, 31);
            this.txtNombreDeProducto.TabIndex = 0;
            this.txtNombreDeProducto.TextChanged += new System.EventHandler(this.txtNombreDeProducto_TextChanged);
            // 
            // lblNombredelProducto
            // 
            this.lblNombredelProducto.AutoSize = true;
            this.lblNombredelProducto.Location = new System.Drawing.Point(27, 50);
            this.lblNombredelProducto.Name = "lblNombredelProducto";
            this.lblNombredelProducto.Size = new System.Drawing.Size(220, 25);
            this.lblNombredelProducto.TabIndex = 1;
            this.lblNombredelProducto.Text = "Nombre del Producto:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(27, 124);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 204);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 25);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lstCatProductos
            // 
            this.lstCatProductos.FormattingEnabled = true;
            this.lstCatProductos.Items.AddRange(new object[] {
            "Pereceredos",
            "No pereceredos",
            "Bebidas",
            "Gula"});
            this.lstCatProductos.Location = new System.Drawing.Point(149, 124);
            this.lstCatProductos.Name = "lstCatProductos";
            this.lstCatProductos.Size = new System.Drawing.Size(150, 33);
            this.lstCatProductos.TabIndex = 2;
            this.lstCatProductos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstCantidad
            // 
            this.lstCantidad.FormattingEnabled = true;
            this.lstCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.lstCantidad.Location = new System.Drawing.Point(149, 196);
            this.lstCantidad.Name = "lstCantidad";
            this.lstCantidad.Size = new System.Drawing.Size(150, 33);
            this.lstCantidad.TabIndex = 2;
            this.lstCantidad.SelectedIndexChanged += new System.EventHandler(this.lstCantidad_SelectedIndexChanged);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(32, 291);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 39);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(374, 291);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(118, 39);
            this.cmdConfirmar.TabIndex = 3;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // lstAlacena
            // 
            this.lstAlacena.FormattingEnabled = true;
            this.lstAlacena.Location = new System.Drawing.Point(37, 381);
            this.lstAlacena.Name = "lstAlacena";
            this.lstAlacena.Size = new System.Drawing.Size(525, 160);
            this.lstAlacena.TabIndex = 1;
            this.lstAlacena.SelectedIndexChanged += new System.EventHandler(this.lstAlacena_SelectedIndexChanged);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 571);
            this.Controls.Add(this.lstAlacena);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "Gestor de Alimentos";
            this.Load += new System.EventHandler(this.frmAlacena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lstCantidad;
        private System.Windows.Forms.ComboBox lstCatProductos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombredelProducto;
        private System.Windows.Forms.TextBox txtNombreDeProducto;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ListBox lstAlacena;
    }
}