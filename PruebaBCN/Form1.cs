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
    public partial class Form1 : Form
    {
        public Form1()
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

                    foreach (var tcElement in detalleTCElement.Elements(detalleNs + "Tc"))
                    {
                        string fecha = tcElement.Element(detalleNs + "Fecha").Value;
                        int day = int.Parse(tcElement.Element(detalleNs + "Dia").Value);
                        double exchangeRate = double.Parse(tcElement.Element(detalleNs + "Valor").Value);

                        dgvCambio.Rows.Add(year, month, day, exchangeRate);

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
                            Console.WriteLine("Datos guardados en la base de datos correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Error al guardar los datos en la base de datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el detalle de tipos de cambio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregarTcSistema_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            if (tipoCambio.ExistenRegistros(year, month))
            {
                MessageBox.Show("Los registros para este mes ya existen en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int day = DateTime.Now.Day; // Obtén el día actual
            double exchangeRate;

            try
            {
                exchangeRate = bcn.GetExchangeRateForDayAsync(year, month, day).Result; // Espera a obtener el tipo de cambio del día
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el tipo de cambio del día: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto ExchangeRate y agregarlo a la base de datos
            ExchangeRates exchangeRateObj = new ExchangeRates
            {
                Year = year,
                Month = month,
                Day = day,
                ExchangeRateValue = exchangeRate
            };

            if (tipoCambio.Guardar(exchangeRateObj))
            {
                MessageBox.Show("Tipo de cambio del día agregado correctamente a la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar el tipo de cambio del día a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCambioDia_Click(object sender, EventArgs e)
        {
             int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day; // Obtén el día actual

            try
            {
                double exchangeRate = await bcn.GetExchangeRateForDayAsync(year, month, day);

                // Asigna el tipo de cambio del día al Label
                lblTipoCambioDia.Text = $"Tipo de Cambio del Día {year}-{month}-{day}: {exchangeRate}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el tipo de cambio del día: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}