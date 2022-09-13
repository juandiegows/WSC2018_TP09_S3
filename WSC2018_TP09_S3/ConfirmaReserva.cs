using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2018_TP09_S3.Model;
using WSC2018_TP09_S3.ViewClass;

namespace WSC2018_TP09_S3
{
    public partial class ConfirmaReserva : Form
    {
        List<UsuarioView> usuarios = new List<UsuarioView>();
        int Cantidad = 1;
        public ConfirmaReserva(VueloView vueloSalida, VueloView vueloRegreso, CabinTypes cabin, int cant= 1)
        {
            InitializeComponent();
            Cantidad = cant;
            this.Text = $"Confirmar reserva ({Cantidad} pasajeros restantes)";
            if (!(vueloSalida is null))
            {
                lblCabinaD.Text = cabin.Name;
                lblDestinoD.Text = vueloSalida.Destino;
                lblFechaD.Text = vueloSalida.Fecha.ToString("yyyy/MM/dd");
                lblOrigenD.Text = vueloSalida.Origen;
                lblVueloD.Text = vueloSalida.NumeroVuelo;
            }
            if (!(vueloRegreso is null))
            {
                lblCabinaS.Text = cabin.Name;
                lblDestinoS.Text = vueloRegreso.Destino;
                lblFechaS.Text = vueloRegreso.Fecha.ToString("yyyy/MM/dd");
                lblOrigenS.Text = vueloRegreso.Origen;
                lblVueloS.Text = vueloRegreso.NumeroVuelo;
            }
            else
            {
                GBRegreso.Visible = false;
            }
        }

        private void ConfirmaReserva_Load(object sender, EventArgs e)
        {
            using (session3Entities model = new session3Entities())
            {
                cmbPais.DataSource = model.Countries.ToList();
                cmbPais.DisplayMember = "Name";
                cmbPais.ValueMember = "ID";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿desea regresar al buscar vuelos", "pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (OpenFileJD.ShowDialog() == DialogResult.OK)
            {
                PBImagen.Image = Image.FromFile(OpenFileJD.FileName);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro que desea agregar el usuario?", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usuarios.Add(new UsuarioView
                {
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellido.Text,
                    Fecha = dtFecha.Value,
                    Numero = txtPassport.Text,
                    Pais = cmbPais.SelectedText,
                    Photo = PBImagen.Image,
                    Telefono = txtTelefono.Text

                });
                DTUser.DataSource = usuarios;
                DTUser.Columns[6].Visible = false;
                DTUser.Columns.Add(new DataGridViewButtonColumn()
                {
                   
                    HeaderText = "Ver Foto",
                    UseColumnTextForButtonValue = true
                });
            
            }
        }

        private void DTUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DTUser.Columns.Count - 1)
            {
                String ID = DTUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                new VerFoto(usuarios.First(x=> x.Nombres == ID)).ShowDialog();
            }
        }
    }
}
