namespace pySP1Miprimerapp
{
    partial class frmMiPrimerApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiPrimerApp));
            this.lblDeposito = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtAlqiuler = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.mrcIngresos = new System.Windows.Forms.GroupBox();
            this.mrcOtrosGastos = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.mrcIngresos.SuspendLayout();
            this.mrcOtrosGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.ForeColor = System.Drawing.Color.Black;
            this.lblDeposito.Location = new System.Drawing.Point(6, 61);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(101, 24);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            this.lblDeposito.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlquiler);
            this.groupBox1.Controls.Add(this.lblComida);
            this.groupBox1.Controls.Add(this.lblImpuestos);
            this.groupBox1.Controls.Add(this.txtAlqiuler);
            this.groupBox1.Controls.Add(this.txtComida);
            this.groupBox1.Controls.Add(this.txtImpuestos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos Fijos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(76, 171);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(90, 24);
            this.lblAlquiler.TabIndex = 5;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(76, 103);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(89, 24);
            this.lblComida.TabIndex = 4;
            this.lblComida.Text = "Comida";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(76, 40);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(116, 24);
            this.lblImpuestos.TabIndex = 3;
            this.lblImpuestos.Text = "Impuestos";
            this.lblImpuestos.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAlqiuler
            // 
            this.txtAlqiuler.Location = new System.Drawing.Point(248, 168);
            this.txtAlqiuler.Name = "txtAlqiuler";
            this.txtAlqiuler.Size = new System.Drawing.Size(169, 37);
            this.txtAlqiuler.TabIndex = 2;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(248, 100);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(169, 37);
            this.txtComida.TabIndex = 1;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(248, 37);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(169, 37);
            this.txtImpuestos.TabIndex = 0;
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(173, 48);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(157, 37);
            this.txtDeposito.TabIndex = 2;
            // 
            // mrcIngresos
            // 
            this.mrcIngresos.Controls.Add(this.txtDeposito);
            this.mrcIngresos.Controls.Add(this.lblDeposito);
            this.mrcIngresos.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngresos.Location = new System.Drawing.Point(28, 45);
            this.mrcIngresos.Name = "mrcIngresos";
            this.mrcIngresos.Size = new System.Drawing.Size(368, 116);
            this.mrcIngresos.TabIndex = 3;
            this.mrcIngresos.TabStop = false;
            this.mrcIngresos.Text = "Ingresos";
            // 
            // mrcOtrosGastos
            // 
            this.mrcOtrosGastos.Controls.Add(this.txtMonto);
            this.mrcOtrosGastos.Controls.Add(this.lblMonto);
            this.mrcOtrosGastos.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOtrosGastos.Location = new System.Drawing.Point(446, 45);
            this.mrcOtrosGastos.Name = "mrcOtrosGastos";
            this.mrcOtrosGastos.Size = new System.Drawing.Size(368, 116);
            this.mrcOtrosGastos.TabIndex = 4;
            this.mrcOtrosGastos.TabStop = false;
            this.mrcOtrosGastos.Text = "Otros Gastos";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(180, 48);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(144, 37);
            this.txtMonto.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(13, 61);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(73, 24);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(28, 493);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(147, 64);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(667, 493);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(147, 64);
            this.cmdCalcular.TabIndex = 6;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMiPrimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 678);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.mrcOtrosGastos);
            this.Controls.Add(this.mrcIngresos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMiPrimerApp";
            this.Text = "Administrador de Gastos Menusales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mrcIngresos.ResumeLayout(false);
            this.mrcIngresos.PerformLayout();
            this.mrcOtrosGastos.ResumeLayout(false);
            this.mrcOtrosGastos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtAlqiuler;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.GroupBox mrcIngresos;
        private System.Windows.Forms.GroupBox mrcOtrosGastos;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCalcular;
    }
}

