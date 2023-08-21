using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PruebaBCN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private TipoCambio tipoCambio = new TipoCambio();
        private BancoCentralService bcn= new BancoCentralService();
         
    

        private async void btnCambioMensual_Click_1(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            try
            {
                XDocument exchangeRatesDocument = await bcn.GetExchangeRatesForMonthAsync(year, month);

                dgvCambio.Rows.Clear(); // Limpia el DataGridView antes de agregar nuevos datos

                XNamespace soapNs = "http://schemas.xmlsoap.org/soap/envelope/";
                XNamespace responseNs = "http://servicios.bcn.gob.ni/";

                var responseElement = exchangeRatesDocument.Descendants(soapNs + "Body")
                    .Descendants(responseNs + "RecuperaTC_MesResponse")
                    .FirstOrDefault();

                if (responseElement != null)
                {
                    var recuperaTCMesResultElement = responseElement.Element(responseNs + "RecuperaTC_MesResult");
                    var detalleTCElement = recuperaTCMesResultElement.Element("Detalle_TC");

                    XNamespace detalleNs = detalleTCElement.GetDefaultNamespace();

                    // Lista para almacenar los días ya registrados
                    List<int> diasRegistrados = new List<int>();

                    foreach (var tcElement in detalleTCElement.Elements(detalleNs + "Tc"))
                    {
                        int day = int.Parse(tcElement.Element(detalleNs + "Dia").Value);
                        double exchangeRate = double.Parse(tcElement.Element(detalleNs + "Valor").Value);

                        dgvCambio.Rows.Add(year, month, day, exchangeRate);

                        // Verificar si ya se registró el día y evitar registros duplicados
                        if (!diasRegistrados.Contains(day) && !tipoCambio.ExistenRegistros(year, month, day))
                        {
                            // Crear una instancia de ExchangeRates con los datos y guardar en la base de datos
                            ExchangeRates exchangeRateObj = new ExchangeRates
                            {
                                Year = year,
                                Month = month,
                                Day = day,
                                ExchangeRateValue = exchangeRate
                            };

                            if (tipoCambio.Guardar(exchangeRateObj))
                            {
                                Console.WriteLine("Registrado");
                                diasRegistrados.Add(day); // Agregar el día a la lista de días registrados
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el detalle de tipos de cambio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //este evento asigna el boton el cual nos dara el resultado en label del tipo de cambio del dia actual
        private async void btnCambioDia_Click(object sender, EventArgs e)
        {
             int year = DateTime.Now.Year;//año actual
            int month = DateTime.Now.Month; //mes actual
            int day = DateTime.Now.Day; // Obtén el día actual

            try
            {
                //realiza la solicitud para la consulta del tipo de cambio para el dia correspondiente
                double exchangeRate = await bcn.GetExchangeRateForDayAsync(year, month, day);

                // Asigna el tipo de cambio del día al Label
                lblTipoCambioDia.Text = $"Tipo de Cambio del Día {year}-{month}-{day}: {exchangeRate}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el tipo de cambio del día: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblTipoCambioDia.Text = "";
        }
    }
}