using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSC2018_TP09_S3.Helper;
using WSC2018_TP09_S3.Model;
using WSC2018_TP09_S3.ViewClass;

namespace WSC2018_TP09_S3
{
    public partial class ConfirmaReserva : Form
    {
        List<UsuarioView> usuarios = new List<UsuarioView>();
        CabinTypes Cabin;
        int Cantidad = 1;
        VueloView vueloSalida, vueloRegreso;
        public ConfirmaReserva(VueloView vueloSalida_, VueloView vueloRegreso_, CabinTypes cabin, int cant = 1)
        {
            vueloRegreso = vueloRegreso_;
            vueloSalida = vueloSalida_;
            InitializeComponent();
            Validation();
            Cantidad = cant;
            Cabin = cabin;
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
        public void Validation()
        {
            txtNombre.Requerido();
            txtApellido.Requerido();
            txtPassport.Requerido();
            txtTelefono.Requerido();
            txtTelefono.SoloNumero();
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
            if (Cantidad - usuarios.Count <= 0)
            {
                MessageBox.Show("Ya al alcanzado el limite");
                return;
            }

            if (this.ValidateChildren())
                if (MessageBox.Show("¿esta seguro que desea agregar el usuario?", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (usuarios.FirstOrDefault(x => x.Numero.ToLower() == txtPassport.Text.ToLower()) != null)
                    {
                        MessageBox.Show($"Ya se agregar un usuario con este pasaporte {txtPassport.Text}");
                        return;
                    }
                    DTUser.DataSource = null;
                    DTUser.Columns.Clear();
                    int.TryParse(cmbPais.SelectedValue.ToString(), out int IDC);
                    Countries countries = new session3Entities().Countries.Find(IDC);
                    
                    usuarios.Add(new UsuarioView
                    {
                        Nombres = txtNombre.Text,
                        Apellidos = txtApellido.Text,
                        Fecha = dtFecha.Value,
                        Numero = txtPassport.Text,
                        Pais = countries.Name,
                        Photo = PBImagen.Image,
                        Telefono = txtTelefono.Text,
                        PaisID = countries.ID

                    });
                    DTUser.DataSource = usuarios;
                    DTUser.Columns[7].Visible = false;

                    DTUser.Columns[4].Visible = false;
                    DTUser.Columns.Add(new DataGridViewButtonColumn()
                    {

                        HeaderText = "Ver Foto",
                        Text = "Ver Foto",
                        UseColumnTextForButtonValue = true,
                        DefaultCellStyle = new DataGridViewCellStyle()
                        {
                            SelectionForeColor = Color.Red
                        }
                    });
                    this.Text = $"Confirmar reserva ({Cantidad - usuarios.Count} pasajeros restantes)";

                }
        }

        private void DTUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DTUser.Columns.Count - 1)
            {
                String ID = DTUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                new VerFoto(usuarios.First(x => x.Nombres == ID)).ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿esta seguro que desea eliminar el usuario?", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                string ID = DTUser.CurrentRow.Cells[2].Value.ToString();
                usuarios.Remove(usuarios.First(x => x.Numero == ID));

                DTUser.DataSource = null;
                DTUser.Columns.Clear();

                DTUser.DataSource = usuarios;
                DTUser.Columns[7].Visible = false;
                DTUser.Columns[4].Visible = false;
                DTUser.Columns.Add(new DataGridViewButtonColumn()
                {

                    HeaderText = "Ver Foto",
                    Text = "Ver Foto",
                    UseColumnTextForButtonValue = true,
                    DefaultCellStyle = new DataGridViewCellStyle()
                    {
                        SelectionForeColor = Color.Red
                    }
                });
                this.Text = $"Confirmar reserva ({Cantidad - usuarios.Count} pasajeros restantes)";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cantidad - usuarios.Count != 0)
            {
                MessageBox.Show($"Faltan pasajeros por agregar");
                return;
            }
            if(MessageBox.Show("¿desea generar el booking", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show($"operaciones cancelada");
                return;
            }
            if (!File.Exists($"{Environment.CurrentDirectory}/img/passport"))
            {
                Directory.CreateDirectory($"{Environment.CurrentDirectory}/img/passport");
            }
            var md5 = MD5CryptoServiceProvider.Create();
            String numero = new Random().Next(0, 10000).ToString();
            var encry = System.Text.Encoding.ASCII.GetBytes(numero);
            var booking = Convert.ToBase64String(md5.ComputeHash(encry));
            int cantSave = 0;
            foreach (var item in usuarios)
            {
             
                Image img = PBImagen.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    //using (FileStream fs = new FileStream($"{Environment.CurrentDirectory}/img/passport/{item.Numero}.jpg", FileMode.OpenOrCreate))
                    //{
                    //    fs.Write(ms.ToArray(), 0, ms.ToArray().Length);
                    //    fs.Close();
                    //}
                    using (FileStream fs = File.Create($"{Environment.CurrentDirectory}/img/passport/{item.Numero}.jpg"))
                    {
                        fs.Write(ms.ToArray(), 0, ms.ToArray().Length);
                        fs.Close();
                    }
                    ms.Close();
                }
                using (session3Entities model = new session3Entities())
                {

                    model.Tickets.Add(new Tickets
                    {

                        PassportPhoto = $"/img/passport/{item.Numero}.jpg",
                        BookingReference = booking.Substring(0, 6).ToUpper(),
                        CabinTypeID = Cabin.ID,
                        Confirmed = true,
                        Email = null,
                        Firstname = item.Nombres,
                        Lastname = item.Apellidos,
                        PassportNumber = item.Numero,
                        Phone = item.Telefono,
                        UserID = 1,
                        PassportCountryID = item.PaisID,
                        ScheduleID = vueloSalida.ID

                    });
                    if (vueloRegreso != null)
                        model.Tickets.Add(new Tickets
                        {

                            PassportPhoto = $"/img/passport/{item.Numero}.jpg",
                            BookingReference = booking.Substring(0, 6).ToUpper(),
                            CabinTypeID = Cabin.ID,
                            Confirmed = true,
                            Email = null,
                            Firstname = item.Nombres,
                            Lastname = item.Apellidos,
                            PassportNumber = item.Numero,
                            Phone = item.Telefono,
                            UserID = 1,
                            PassportCountryID = item.PaisID,
                            ScheduleID = vueloRegreso.ID

                        });
                    cantSave += model.SaveChanges();
                }
            }
            this.ClearAll();
            MessageBox.Show($"se ha generado {cantSave} de tiquetes");
            
        }
    }
}
