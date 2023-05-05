namespace pySP1Miprimerapp
{
    partial class frmAplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicaciones));
            this.cmdGestiondeEgresos = new System.Windows.Forms.Button();
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGestiondeEgresos
            // 
            this.cmdGestiondeEgresos.Location = new System.Drawing.Point(30, 194);
            this.cmdGestiondeEgresos.Name = "cmdGestiondeEgresos";
            this.cmdGestiondeEgresos.Size = new System.Drawing.Size(343, 105);
            this.cmdGestiondeEgresos.TabIndex = 0;
            this.cmdGestiondeEgresos.Text = "GESTION DE EGRESOS";
            this.cmdGestiondeEgresos.UseVisualStyleBackColor = true;
            this.cmdGestiondeEgresos.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.Location = new System.Drawing.Point(30, 36);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(343, 105);
            this.cmdAlacena.TabIndex = 1;
            this.cmdAlacena.Text = "ALACENA";
            this.cmdAlacena.UseVisualStyleBackColor = true;
            this.cmdAlacena.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAlacena);
            this.groupBox1.Controls.Add(this.cmdGestiondeEgresos);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 312);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrir";
            // 
            // frmAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 392);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAplicaciones";
            this.Text = "Aplicaciones";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmAplicaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdGestiondeEgresos;
        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}