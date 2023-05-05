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
            this.mrcControldeAlimentos = new System.Windows.Forms.GroupBox();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.txtTipodeAlimentos1 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.txtDondeEstaAlmacenado1 = new System.Windows.Forms.TextBox();
            this.lblTiposdeAlimentos1 = new System.Windows.Forms.Label();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblDondeEstaAlmacenado1 = new System.Windows.Forms.Label();
            this.lblCantidad1 = new System.Windows.Forms.Label();
            this.mrcAlimentosAlmacenados = new System.Windows.Forms.GroupBox();
            this.txtCantidad3 = new System.Windows.Forms.TextBox();
            this.txtTipodeAlimentos2 = new System.Windows.Forms.TextBox();
            this.txtCantidad4 = new System.Windows.Forms.TextBox();
            this.txtDondeEstaAlmacenado2 = new System.Windows.Forms.TextBox();
            this.lblTiposdeAlimentos2 = new System.Windows.Forms.Label();
            this.lblCantidad4 = new System.Windows.Forms.Label();
            this.lblDondeEstaAlmacenado2 = new System.Windows.Forms.Label();
            this.lblCantidad3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.mrcControldeAlimentos.SuspendLayout();
            this.mrcAlimentosAlmacenados.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcControldeAlimentos
            // 
            this.mrcControldeAlimentos.Controls.Add(this.dateTimePicker1);
            this.mrcControldeAlimentos.Controls.Add(this.txtCantidad1);
            this.mrcControldeAlimentos.Controls.Add(this.txtTipodeAlimentos1);
            this.mrcControldeAlimentos.Controls.Add(this.txtCantidad2);
            this.mrcControldeAlimentos.Controls.Add(this.txtDondeEstaAlmacenado1);
            this.mrcControldeAlimentos.Controls.Add(this.lblTiposdeAlimentos1);
            this.mrcControldeAlimentos.Controls.Add(this.lblCantidad2);
            this.mrcControldeAlimentos.Controls.Add(this.lblDondeEstaAlmacenado1);
            this.mrcControldeAlimentos.Controls.Add(this.lblCantidad1);
            this.mrcControldeAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcControldeAlimentos.Location = new System.Drawing.Point(23, 12);
            this.mrcControldeAlimentos.Name = "mrcControldeAlimentos";
            this.mrcControldeAlimentos.Size = new System.Drawing.Size(662, 237);
            this.mrcControldeAlimentos.TabIndex = 0;
            this.mrcControldeAlimentos.TabStop = false;
            this.mrcControldeAlimentos.Text = "Control de Alimentos";
            this.mrcControldeAlimentos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(23, 181);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(194, 29);
            this.txtCantidad1.TabIndex = 1;
            // 
            // txtTipodeAlimentos1
            // 
            this.txtTipodeAlimentos1.Location = new System.Drawing.Point(23, 77);
            this.txtTipodeAlimentos1.Name = "txtTipodeAlimentos1";
            this.txtTipodeAlimentos1.Size = new System.Drawing.Size(194, 29);
            this.txtTipodeAlimentos1.TabIndex = 1;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(243, 181);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(206, 29);
            this.txtCantidad2.TabIndex = 1;
            // 
            // txtDondeEstaAlmacenado1
            // 
            this.txtDondeEstaAlmacenado1.Location = new System.Drawing.Point(243, 77);
            this.txtDondeEstaAlmacenado1.Name = "txtDondeEstaAlmacenado1";
            this.txtDondeEstaAlmacenado1.Size = new System.Drawing.Size(206, 29);
            this.txtDondeEstaAlmacenado1.TabIndex = 1;
            this.txtDondeEstaAlmacenado1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTiposdeAlimentos1
            // 
            this.lblTiposdeAlimentos1.AutoSize = true;
            this.lblTiposdeAlimentos1.Location = new System.Drawing.Point(19, 39);
            this.lblTiposdeAlimentos1.Name = "lblTiposdeAlimentos1";
            this.lblTiposdeAlimentos1.Size = new System.Drawing.Size(190, 24);
            this.lblTiposdeAlimentos1.TabIndex = 0;
            this.lblTiposdeAlimentos1.Text = "Tipos de Alimentos";
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Location = new System.Drawing.Point(239, 141);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(92, 24);
            this.lblCantidad2.TabIndex = 0;
            this.lblCantidad2.Text = "Cantidad";
            this.lblCantidad2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDondeEstaAlmacenado1
            // 
            this.lblDondeEstaAlmacenado1.AutoSize = true;
            this.lblDondeEstaAlmacenado1.Location = new System.Drawing.Point(239, 39);
            this.lblDondeEstaAlmacenado1.Name = "lblDondeEstaAlmacenado1";
            this.lblDondeEstaAlmacenado1.Size = new System.Drawing.Size(239, 24);
            this.lblDondeEstaAlmacenado1.TabIndex = 0;
            this.lblDondeEstaAlmacenado1.Text = "Donde esta Almacenado";
            this.lblDondeEstaAlmacenado1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantidad1
            // 
            this.lblCantidad1.AutoSize = true;
            this.lblCantidad1.Location = new System.Drawing.Point(19, 141);
            this.lblCantidad1.Name = "lblCantidad1";
            this.lblCantidad1.Size = new System.Drawing.Size(92, 24);
            this.lblCantidad1.TabIndex = 0;
            this.lblCantidad1.Text = "Cantidad";
            // 
            // mrcAlimentosAlmacenados
            // 
            this.mrcAlimentosAlmacenados.Controls.Add(this.dateTimePicker2);
            this.mrcAlimentosAlmacenados.Controls.Add(this.txtCantidad3);
            this.mrcAlimentosAlmacenados.Controls.Add(this.txtTipodeAlimentos2);
            this.mrcAlimentosAlmacenados.Controls.Add(this.txtCantidad4);
            this.mrcAlimentosAlmacenados.Controls.Add(this.txtDondeEstaAlmacenado2);
            this.mrcAlimentosAlmacenados.Controls.Add(this.lblTiposdeAlimentos2);
            this.mrcAlimentosAlmacenados.Controls.Add(this.lblCantidad4);
            this.mrcAlimentosAlmacenados.Controls.Add(this.lblDondeEstaAlmacenado2);
            this.mrcAlimentosAlmacenados.Controls.Add(this.lblCantidad3);
            this.mrcAlimentosAlmacenados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAlimentosAlmacenados.Location = new System.Drawing.Point(23, 265);
            this.mrcAlimentosAlmacenados.Name = "mrcAlimentosAlmacenados";
            this.mrcAlimentosAlmacenados.Size = new System.Drawing.Size(662, 219);
            this.mrcAlimentosAlmacenados.TabIndex = 0;
            this.mrcAlimentosAlmacenados.TabStop = false;
            this.mrcAlimentosAlmacenados.Text = "Alimentos Almacenados";
            this.mrcAlimentosAlmacenados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCantidad3
            // 
            this.txtCantidad3.Location = new System.Drawing.Point(23, 170);
            this.txtCantidad3.Name = "txtCantidad3";
            this.txtCantidad3.Size = new System.Drawing.Size(194, 29);
            this.txtCantidad3.TabIndex = 1;
            // 
            // txtTipodeAlimentos2
            // 
            this.txtTipodeAlimentos2.Location = new System.Drawing.Point(23, 88);
            this.txtTipodeAlimentos2.Name = "txtTipodeAlimentos2";
            this.txtTipodeAlimentos2.Size = new System.Drawing.Size(194, 29);
            this.txtTipodeAlimentos2.TabIndex = 1;
            // 
            // txtCantidad4
            // 
            this.txtCantidad4.Location = new System.Drawing.Point(243, 170);
            this.txtCantidad4.Name = "txtCantidad4";
            this.txtCantidad4.Size = new System.Drawing.Size(206, 29);
            this.txtCantidad4.TabIndex = 1;
            this.txtCantidad4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDondeEstaAlmacenado2
            // 
            this.txtDondeEstaAlmacenado2.Location = new System.Drawing.Point(243, 88);
            this.txtDondeEstaAlmacenado2.Name = "txtDondeEstaAlmacenado2";
            this.txtDondeEstaAlmacenado2.Size = new System.Drawing.Size(206, 29);
            this.txtDondeEstaAlmacenado2.TabIndex = 1;
            this.txtDondeEstaAlmacenado2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTiposdeAlimentos2
            // 
            this.lblTiposdeAlimentos2.AutoSize = true;
            this.lblTiposdeAlimentos2.Location = new System.Drawing.Point(19, 42);
            this.lblTiposdeAlimentos2.Name = "lblTiposdeAlimentos2";
            this.lblTiposdeAlimentos2.Size = new System.Drawing.Size(190, 24);
            this.lblTiposdeAlimentos2.TabIndex = 0;
            this.lblTiposdeAlimentos2.Text = "Tipos de Alimentos";
            // 
            // lblCantidad4
            // 
            this.lblCantidad4.AutoSize = true;
            this.lblCantidad4.Location = new System.Drawing.Point(239, 131);
            this.lblCantidad4.Name = "lblCantidad4";
            this.lblCantidad4.Size = new System.Drawing.Size(92, 24);
            this.lblCantidad4.TabIndex = 0;
            this.lblCantidad4.Text = "Cantidad";
            this.lblCantidad4.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDondeEstaAlmacenado2
            // 
            this.lblDondeEstaAlmacenado2.AutoSize = true;
            this.lblDondeEstaAlmacenado2.Location = new System.Drawing.Point(239, 42);
            this.lblDondeEstaAlmacenado2.Name = "lblDondeEstaAlmacenado2";
            this.lblDondeEstaAlmacenado2.Size = new System.Drawing.Size(239, 24);
            this.lblDondeEstaAlmacenado2.TabIndex = 0;
            this.lblDondeEstaAlmacenado2.Text = "Donde esta Almacenado";
            this.lblDondeEstaAlmacenado2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCantidad3
            // 
            this.lblCantidad3.AutoSize = true;
            this.lblCantidad3.Location = new System.Drawing.Point(19, 131);
            this.lblCantidad3.Name = "lblCantidad3";
            this.lblCantidad3.Size = new System.Drawing.Size(92, 24);
            this.lblCantidad3.TabIndex = 0;
            this.lblCantidad3.Text = "Cantidad";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 29);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(505, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 29);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 571);
            this.Controls.Add(this.mrcAlimentosAlmacenados);
            this.Controls.Add(this.mrcControldeAlimentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlacena";
            this.Text = "Gestor de Alimentos";
            this.mrcControldeAlimentos.ResumeLayout(false);
            this.mrcControldeAlimentos.PerformLayout();
            this.mrcAlimentosAlmacenados.ResumeLayout(false);
            this.mrcAlimentosAlmacenados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcControldeAlimentos;
        private System.Windows.Forms.Label lblDondeEstaAlmacenado1;
        private System.Windows.Forms.Label lblTiposdeAlimentos1;
        private System.Windows.Forms.GroupBox mrcAlimentosAlmacenados;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtTipodeAlimentos1;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.TextBox txtDondeEstaAlmacenado1;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.Label lblCantidad1;
        private System.Windows.Forms.TextBox txtTipodeAlimentos2;
        private System.Windows.Forms.TextBox txtCantidad3;
        private System.Windows.Forms.TextBox txtCantidad4;
        private System.Windows.Forms.TextBox txtDondeEstaAlmacenado2;
        private System.Windows.Forms.Label lblTiposdeAlimentos2;
        private System.Windows.Forms.Label lblCantidad4;
        private System.Windows.Forms.Label lblDondeEstaAlmacenado2;
        private System.Windows.Forms.Label lblCantidad3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}