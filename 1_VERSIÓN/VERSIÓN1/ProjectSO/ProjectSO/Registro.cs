using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSO
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        public string mensaje;
        private void aceptar_but_Click(object sender, EventArgs e)
        {
            string usuario = usuario_tb.Text;
            string contra = contra_tb.Text;
            string mail = mail_tb.Text;
            mensaje = "2/" + usuario + "/" + contra + "/" + mail;


        }
        public string Get_mensaje()
        {
            return mensaje;
        }
    }
}
