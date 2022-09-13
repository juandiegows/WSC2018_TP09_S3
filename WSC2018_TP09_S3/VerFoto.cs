using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2018_TP09_S3.ViewClass;

namespace WSC2018_TP09_S3
{
    public partial class VerFoto : Form
    {
        public VerFoto(UsuarioView user)
        {
            InitializeComponent();
            pictureBox1.Image = user.Photo;
            lblNombre.Text = $"{user.Nombres} {user.Apellidos}";
        }

        private void VerFoto_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿está seguro que desea cerrar?", "ALerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
