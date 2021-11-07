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
    public partial class iniciosesion : Form
    {
        public iniciosesion()
        {
            InitializeComponent();
        }
        public string mensaje;

        private void aceptar_but_Click(object sender, EventArgs e)
        {
            mensaje = "1/" + usuario_tb.Text + "/" + contra_tb.Text;

        }

        public string Get_mensaje()
        {
            return mensaje;
        }
    }
}
