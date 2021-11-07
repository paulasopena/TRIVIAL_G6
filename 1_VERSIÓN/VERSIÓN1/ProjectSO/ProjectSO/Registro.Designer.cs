namespace ProjectSO
{
    partial class Registro
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
            this.Mail_lb = new System.Windows.Forms.Label();
            this.usuario_tb = new System.Windows.Forms.TextBox();
            this.contra_tb = new System.Windows.Forms.TextBox();
            this.mail_tb = new System.Windows.Forms.TextBox();
            this.aceptar_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.Location = new System.Drawing.Point(97, 84);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(200, 25);
            this.usuario_label.TabIndex = 0;
            this.usuario_label.Text = "Nombre de usuario:";
            // 
            // contra_lb
            // 
            this.contra_lb.AutoSize = true;
            this.contra_lb.Location = new System.Drawing.Point(97, 139);
            this.contra_lb.Name = "contra_lb";
            this.contra_lb.Size = new System.Drawing.Size(129, 25);
            this.contra_lb.TabIndex = 1;
            this.contra_lb.Text = "Contraseña:";
            // 
            // Mail_lb
            // 
            this.Mail_lb.AutoSize = true;
            this.Mail_lb.Location = new System.Drawing.Point(97, 193);
            this.Mail_lb.Name = "Mail_lb";
            this.Mail_lb.Size = new System.Drawing.Size(58, 25);
            this.Mail_lb.TabIndex = 2;
            this.Mail_lb.Text = "Mail:";
            // 
            // usuario_tb
            // 
            this.usuario_tb.Location = new System.Drawing.Point(317, 84);
            this.usuario_tb.Name = "usuario_tb";
            this.usuario_tb.Size = new System.Drawing.Size(262, 31);
            this.usuario_tb.TabIndex = 3;
            // 
            // contra_tb
            // 
            this.contra_tb.Location = new System.Drawing.Point(317, 139);
            this.contra_tb.Name = "contra_tb";
            this.contra_tb.Size = new System.Drawing.Size(262, 31);
            this.contra_tb.TabIndex = 4;
            // 
            // mail_tb
            // 
            this.mail_tb.Location = new System.Drawing.Point(317, 193);
            this.mail_tb.Name = "mail_tb";
            this.mail_tb.Size = new System.Drawing.Size(262, 31);
            this.mail_tb.TabIndex = 5;
            // 
            // aceptar_but
            // 
            this.aceptar_but.Location = new System.Drawing.Point(307, 300);
            this.aceptar_but.Name = "aceptar_but";
            this.aceptar_but.Size = new System.Drawing.Size(145, 53);
            this.aceptar_but.TabIndex = 6;
            this.aceptar_but.Text = "Registrarse";
            this.aceptar_but.UseVisualStyleBackColor = true;
            this.aceptar_but.Click += new System.EventHandler(this.aceptar_but_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aceptar_but);
            this.Controls.Add(this.mail_tb);
            this.Controls.Add(this.contra_tb);
            this.Controls.Add(this.usuario_tb);
            this.Controls.Add(this.Mail_lb);
            this.Controls.Add(this.contra_lb);
            this.Controls.Add(this.usuario_label);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label contra_lb;
        private System.Windows.Forms.Label Mail_lb;
        private System.Windows.Forms.TextBox usuario_tb;
        private System.Windows.Forms.TextBox contra_tb;
        private System.Windows.Forms.TextBox mail_tb;
        private System.Windows.Forms.Button aceptar_but;
    }
}