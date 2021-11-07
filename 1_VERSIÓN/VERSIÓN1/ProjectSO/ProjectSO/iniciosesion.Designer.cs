namespace ProjectSO
{
    partial class iniciosesion
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
            this.usuario_label = new System.Windows.Forms.Label();
            this.contra_lb = new System.Windows.Forms.Label();
            this.usuario_tb = new System.Windows.Forms.TextBox();
            this.contra_tb = new System.Windows.Forms.TextBox();
            this.aceptar_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.Location = new System.Drawing.Point(105, 106);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(200, 25);
            this.usuario_label.TabIndex = 1;
            this.usuario_label.Text = "Nombre de usuario:";
            // 
            // contra_lb
            // 
            this.contra_lb.AutoSize = true;
            this.contra_lb.Location = new System.Drawing.Point(105, 156);
            this.contra_lb.Name = "contra_lb";
            this.contra_lb.Size = new System.Drawing.Size(129, 25);
            this.contra_lb.TabIndex = 2;
            this.contra_lb.Text = "Contraseña:";
            // 
            // usuario_tb
            // 
            this.usuario_tb.Location = new System.Drawing.Point(324, 106);
            this.usuario_tb.Name = "usuario_tb";
            this.usuario_tb.Size = new System.Drawing.Size(262, 31);
            this.usuario_tb.TabIndex = 4;
            // 
            // contra_tb
            // 
            this.contra_tb.Location = new System.Drawing.Point(324, 156);
            this.contra_tb.Name = "contra_tb";
            this.contra_tb.Size = new System.Drawing.Size(262, 31);
            this.contra_tb.TabIndex = 5;
            // 
            // aceptar_but
            // 
            this.aceptar_but.Location = new System.Drawing.Point(295, 252);
            this.aceptar_but.Name = "aceptar_but";
            this.aceptar_but.Size = new System.Drawing.Size(204, 61);
            this.aceptar_but.TabIndex = 7;
            this.aceptar_but.Text = "Iniciar sesión";
            this.aceptar_but.UseVisualStyleBackColor = true;
            this.aceptar_but.Click += new System.EventHandler(this.aceptar_but_Click);
            // 
            // iniciosesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aceptar_but);
            this.Controls.Add(this.contra_tb);
            this.Controls.Add(this.usuario_tb);
            this.Controls.Add(this.contra_lb);
            this.Controls.Add(this.usuario_label);
            this.Name = "iniciosesion";
            this.Text = "Inicio Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label contra_lb;
        private System.Windows.Forms.TextBox usuario_tb;
        private System.Windows.Forms.TextBox contra_tb;
        private System.Windows.Forms.Button aceptar_but;
    }
}