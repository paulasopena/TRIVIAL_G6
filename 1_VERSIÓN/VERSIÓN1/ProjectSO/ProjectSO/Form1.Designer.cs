namespace ProjectSO
{
    partial class Form1
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
            this.Conectar_but = new System.Windows.Forms.Button();
            this.Desconectar_but = new System.Windows.Forms.Button();
            this.fecha_rb = new System.Windows.Forms.RadioButton();
            this.mail_rb = new System.Windows.Forms.RadioButton();
            this.ganadores_rb = new System.Windows.Forms.RadioButton();
            this.fecha_tb = new System.Windows.Forms.TextBox();
            this.Regis_but = new System.Windows.Forms.Button();
            this.inicio_but = new System.Windows.Forms.Button();
            this.fecha_lab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.puntos_tb = new System.Windows.Forms.TextBox();
            this.consulta_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Conectar_but
            // 
            this.Conectar_but.Location = new System.Drawing.Point(826, 73);
            this.Conectar_but.Name = "Conectar_but";
            this.Conectar_but.Size = new System.Drawing.Size(156, 67);
            this.Conectar_but.TabIndex = 0;
            this.Conectar_but.Text = "Conectar";
            this.Conectar_but.UseVisualStyleBackColor = true;
            this.Conectar_but.Click += new System.EventHandler(this.Conectar_but_Click);
            // 
            // Desconectar_but
            // 
            this.Desconectar_but.Location = new System.Drawing.Point(826, 160);
            this.Desconectar_but.Name = "Desconectar_but";
            this.Desconectar_but.Size = new System.Drawing.Size(156, 67);
            this.Desconectar_but.TabIndex = 1;
            this.Desconectar_but.Text = "Desconectar";
            this.Desconectar_but.UseVisualStyleBackColor = true;
            this.Desconectar_but.Click += new System.EventHandler(this.Desconectar_but_Click);
            // 
            // fecha_rb
            // 
            this.fecha_rb.AutoSize = true;
            this.fecha_rb.Location = new System.Drawing.Point(26, 160);
            this.fecha_rb.Name = "fecha_rb";
            this.fecha_rb.Size = new System.Drawing.Size(584, 29);
            this.fecha_rb.TabIndex = 2;
            this.fecha_rb.TabStop = true;
            this.fecha_rb.Text = "Consulta el nombre de las personas que jugaron ese día";
            this.fecha_rb.UseVisualStyleBackColor = true;
            // 
            // mail_rb
            // 
            this.mail_rb.AutoSize = true;
            this.mail_rb.Location = new System.Drawing.Point(26, 264);
            this.mail_rb.Name = "mail_rb";
            this.mail_rb.Size = new System.Drawing.Size(564, 29);
            this.mail_rb.TabIndex = 3;
            this.mail_rb.TabStop = true;
            this.mail_rb.Text = "Consulta el mail de las personas con récord de puntos";
            this.mail_rb.UseVisualStyleBackColor = true;
            // 
            // ganadores_rb
            // 
            this.ganadores_rb.AutoSize = true;
            this.ganadores_rb.Location = new System.Drawing.Point(26, 360);
            this.ganadores_rb.Name = "ganadores_rb";
            this.ganadores_rb.Size = new System.Drawing.Size(747, 29);
            this.ganadores_rb.TabIndex = 4;
            this.ganadores_rb.TabStop = true;
            this.ganadores_rb.Text = "Consulta los nombres de los ganadores que tienen más de estos puntos: ";
            this.ganadores_rb.UseVisualStyleBackColor = true;
            // 
            // fecha_tb
            // 
            this.fecha_tb.Location = new System.Drawing.Point(215, 115);
            this.fecha_tb.Name = "fecha_tb";
            this.fecha_tb.Size = new System.Drawing.Size(198, 31);
            this.fecha_tb.TabIndex = 5;
            // 
            // Regis_but
            // 
            this.Regis_but.Location = new System.Drawing.Point(826, 309);
            this.Regis_but.Name = "Regis_but";
            this.Regis_but.Size = new System.Drawing.Size(156, 67);
            this.Regis_but.TabIndex = 6;
            this.Regis_but.Text = "Registrarse";
            this.Regis_but.UseVisualStyleBackColor = true;
            this.Regis_but.Click += new System.EventHandler(this.Regis_but_Click);
            // 
            // inicio_but
            // 
            this.inicio_but.Location = new System.Drawing.Point(826, 394);
            this.inicio_but.Name = "inicio_but";
            this.inicio_but.Size = new System.Drawing.Size(156, 67);
            this.inicio_but.TabIndex = 7;
            this.inicio_but.Text = "Iniciar sesión";
            this.inicio_but.UseVisualStyleBackColor = true;
            this.inicio_but.Click += new System.EventHandler(this.inicio_but_Click);
            // 
            // fecha_lab
            // 
            this.fecha_lab.AutoSize = true;
            this.fecha_lab.Location = new System.Drawing.Point(21, 115);
            this.fecha_lab.Name = "fecha_lab";
            this.fecha_lab.Size = new System.Drawing.Size(194, 25);
            this.fecha_lab.TabIndex = 8;
            this.fecha_lab.Text = "Fecha (DDMMYY):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puntos:";
            // 
            // puntos_tb
            // 
            this.puntos_tb.Location = new System.Drawing.Point(112, 415);
            this.puntos_tb.Name = "puntos_tb";
            this.puntos_tb.Size = new System.Drawing.Size(198, 31);
            this.puntos_tb.TabIndex = 10;
            // 
            // consulta_but
            // 
            this.consulta_but.Location = new System.Drawing.Point(26, 489);
            this.consulta_but.Name = "consulta_but";
            this.consulta_but.Size = new System.Drawing.Size(156, 67);
            this.consulta_but.TabIndex = 11;
            this.consulta_but.Text = "Consultar";
            this.consulta_but.UseVisualStyleBackColor = true;
            this.consulta_but.Click += new System.EventHandler(this.consulta_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 621);
            this.Controls.Add(this.consulta_but);
            this.Controls.Add(this.puntos_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_lab);
            this.Controls.Add(this.inicio_but);
            this.Controls.Add(this.Regis_but);
            this.Controls.Add(this.fecha_tb);
            this.Controls.Add(this.ganadores_rb);
            this.Controls.Add(this.mail_rb);
            this.Controls.Add(this.fecha_rb);
            this.Controls.Add(this.Desconectar_but);
            this.Controls.Add(this.Conectar_but);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conectar_but;
        private System.Windows.Forms.Button Desconectar_but;
        private System.Windows.Forms.RadioButton fecha_rb;
        private System.Windows.Forms.RadioButton mail_rb;
        private System.Windows.Forms.RadioButton ganadores_rb;
        private System.Windows.Forms.TextBox fecha_tb;
        private System.Windows.Forms.Button Regis_but;
        private System.Windows.Forms.Button inicio_but;
        private System.Windows.Forms.Label fecha_lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox puntos_tb;
        private System.Windows.Forms.Button consulta_but;
    }
}

