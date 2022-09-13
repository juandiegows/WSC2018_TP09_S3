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
    public partial class Busquedad : Form
    {
        public Busquedad()
        {
            InitializeComponent();
        }
        ErrorProvider errorProvider = new ErrorProvider();
        private void Busquedad_Load(object sender, EventArgs e)
        {
            FillComboCabina();
            FillComboOrigen();
            FilllComboDestino();

            FillTableSalida();
            Console.WriteLine(Environment.CurrentDirectory);
        }

        private void FillTableSalida()
        {
            int.TryParse(cmbOrigen.SelectedValue.ToString(), out int IDO);
            int.TryParse(cmbDestino.SelectedValue.ToString().ToString().ToString(), out int IDD);
            int.TryParse(cmbCabina.SelectedValue.ToString().ToString().ToString(), out int IDC);
            using (session3Entities model = new session3Entities())
            {
                List<VueloView> lista = null;
                if (cb3diasSalida.Checked)
                {
                    lista = model.Schedules.ToList().Where(x =>
                             x.Routes.ArrivalAirportID == IDO
                             && x.Routes.DepartureAirportID == IDD
                             && x.Date.Date > dtSalida.Value.AddDays(-3).Date
                             && x.Date.Date < dtSalida.Value.AddDays(3).Date
                             ).ToList().Select(x => new VueloView()
                             {
                                 ID = x.ID,
                                 Destino = x.Routes.Airports1.IATACode,
                                 Origen = x.Routes.Airports.IATACode,
                                 Fecha = x.Date,
                                 EconomyPrice = ObtenerPrecio(IDC, (double)x.EconomyPrice),
                                 NumeroVuelo = x.FlightNumber


                             }).ToList();
                }
                else
                {
                    lista = model.Schedules.ToList().Where(x =>
                          x.Routes.ArrivalAirportID == IDO
                          && x.Routes.DepartureAirportID == IDD
                          && x.Date.Date == dtSalida.Value.Date).ToList().Select(x => new VueloView()
                          {
                              ID = x.ID,
                              Destino = x.Routes.Airports1.IATACode,
                              Origen = x.Routes.Airports.IATACode,
                              Fecha = x.Date,
                              EconomyPrice = ObtenerPrecio(IDC, (double)x.EconomyPrice),
                              NumeroVuelo = x.FlightNumber



                          }).ToList();

                }

                dgvSalida.DataSource = lista;
            }
        }

        private void FillTableRetorno()
        {
            int.TryParse(cmbDestino.SelectedValue.ToString(), out int IDO);
            int.TryParse(cmbOrigen.SelectedValue.ToString().ToString().ToString(), out int IDD);
            int.TryParse(cmbCabina.SelectedValue.ToString().ToString().ToString(), out int IDC);
            using (session3Entities model = new session3Entities())
            {
                List<VueloView> lista = null;
                if (cbRegreso.Checked)
                {
                    lista = model.Schedules.ToList().Where(x =>
                             x.Routes.ArrivalAirportID == IDO
                             && x.Routes.DepartureAirportID == IDD
                             && x.Date.Date > dtRegreso.Value.AddDays(-3).Date
                             && x.Date.Date < dtRegreso.Value.AddDays(3).Date
                             ).ToList().Select(x => new VueloView()
                             {
                                 ID = x.ID,
                                 Destino = x.Routes.Airports1.IATACode,
                                 Origen = x.Routes.Airports.IATACode,
                                 Fecha = x.Date,
                                 EconomyPrice = ObtenerPrecio(IDC, (double)x.EconomyPrice),
                                 NumeroVuelo = x.FlightNumber


                             }).ToList();
                }
                else
                {
                    lista = model.Schedules.ToList().Where(x =>
                          x.Routes.ArrivalAirportID == IDO
                          && x.Routes.DepartureAirportID == IDD
                          && x.Date.Date == dtRegreso.Value.Date).ToList().Select(x => new VueloView()
                          {
                              ID = x.ID,
                              Destino = x.Routes.Airports1.IATACode,
                              Origen = x.Routes.Airports.IATACode,
                              Fecha = x.Date,
                              EconomyPrice = ObtenerPrecio(IDC, (double)x.EconomyPrice),
                              NumeroVuelo = x.FlightNumber



                          }).ToList();

                }

                dgvRegreso.DataSource = lista;
            }
        }
        private double ObtenerPrecio(int cabina, double precio)
        {

            if(cabina == 2 || cabina == 3)
            {
                precio += precio * 0.30;
            }
            if (cabina == 3)
            {
                precio += precio * 0.35;
            }
            return precio;
        }
        private void FilllComboDestino()
        {
            using (session3Entities model = new session3Entities())
            {
                cmbDestino.DataSource = model.Airports.ToList();
                cmbDestino.DisplayMember = "IATACode";
                cmbDestino.ValueMember = "ID";
            }
        }

        private void FillComboOrigen()
        {
            using (session3Entities model = new session3Entities())
            {
                cmbOrigen.DataSource = model.Airports.ToList();
                cmbOrigen.DisplayMember = "IATACode";
                cmbOrigen.ValueMember = "ID";
            }

        }

        private void FillComboCabina()
        {
            using (session3Entities model = new session3Entities())
            {
                cmbCabina.DataSource = model.CabinTypes.ToList();
                cmbCabina.DisplayMember = "Name";
                cmbCabina.ValueMember = "ID";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRetorno.Checked)
            {
                lblRegreso.Visible = true;
                dtRegreso.Visible = true;
                PRegreso.Visible = true;
            }
            else
            {
                lblRegreso.Visible = false;
                dtRegreso.Visible = false;
                PRegreso.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿desea salir de programa?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbDestino, "");
            errorProvider.SetError(dtRegreso, "");
            if (cmbDestino.SelectedValue.ToString() == cmbOrigen.SelectedValue.ToString())
            {
                errorProvider.SetError(cmbDestino, "Debe ser diferente al origen");
                
                return;
            }
            if (dtSalida.Value.Date > dtRegreso.Value.Date)
            {
                errorProvider.SetError(dtRegreso, "Debe ser mayor la fecha de regreso");

                return;
            }
            FillTableSalida();
            FillTableRetorno();
        }

        private void cb3diasSalida_CheckedChanged(object sender, EventArgs e)
        {
            FillTableSalida();
        }

        private void cbRegreso_CheckedChanged(object sender, EventArgs e)
        {
            FillTableRetorno();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (nudPasaje.Value == 0)
            {
                errorProvider.SetError(nudPasaje, "no debe ser cero");
                return;
            }
            int IDVS = 0, IDV = 0;
            try
            {
                if(dgvSalida.CurrentRow != null)
                int.TryParse(dgvSalida.CurrentRow.Cells[0].Value.ToString(), out  IDVS);
                else
                {
                    MessageBox.Show("debe selecionar un vuelo");
                    errorProvider.SetError(dgvSalida, "no seleccionar un vuelo");
                    return;
                }
            }
            catch (Exception)
            {

                errorProvider.SetError(dgvSalida, "no seleccionar un vuelo");
                return;
            }
        
            if(rbRetorno.Checked)
            try
                {
                    if (dgvRegreso.CurrentRow != null)
                        int.TryParse(dgvRegreso.CurrentRow.Cells[0].Value.ToString(), out IDV);
                    else
                    {
                        errorProvider.SetError(dgvRegreso, "no seleccionar un vuelo");
                        MessageBox.Show("debe selecionar un vuelo");
                        return;
                    }
            }
            catch (Exception)
            {
                errorProvider.SetError(dgvRegreso, "no seleccionar un vuelo");
                return;
            }

            using (session3Entities model = new session3Entities())
            {
                VueloView vueloSalida = null;
                VueloView vueloRetorno = null;
     

                int.TryParse(cmbCabina.SelectedValue.ToString().ToString().ToString(), out int IDC);
                CabinTypes cabin = model.CabinTypes.Find(IDC);
                vueloSalida = model.Schedules.ToList().Where(x =>
                    x.ID == IDVS
                             ).ToList().Select(x => new VueloView()
                             {
                                 ID = x.ID,
                                 Destino = x.Routes.Airports1.IATACode,
                                 Origen = x.Routes.Airports.IATACode,
                                 Fecha = x.Date,
                                 EconomyPrice = ObtenerPrecio(IDC, (double)x.EconomyPrice),
                                 NumeroVuelo = x.FlightNumber


                             }).FirstOrDefault(); 
                vueloRetorno = model.Schedules.ToList().Where(x =>
                    x.ID == IDV
                             ).ToList().Select(x => new VueloView()
                             {
                                 ID = x.ID,
                                 Destino = x.Routes.Airports1.IATACode,
                                 Origen = x.Routes.Airports.IATACode,
                                 Fecha = x.Date,
                                 EconomyPrice = ObtenerPrecio(IDC, (double)x.EconomyPrice),
                                 NumeroVuelo = x.FlightNumber


                             }).FirstOrDefault();

                this.Hide();
                new ConfirmaReserva(vueloSalida, vueloRetorno, cabin, (int)nudPasaje.Value).ShowDialog();
                this.Show();
          
            }

        }
    }
}
