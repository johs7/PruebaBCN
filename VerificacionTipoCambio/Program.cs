using System;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;
using PruebaBCN;

namespace VerificacionTipoCambio
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                TipoCambio tipoCambio = new TipoCambio();
                BancoCentralService bcn = new BancoCentralService();

                // Obtén el año y mes del próximo mes
                DateTime nextMonth = DateTime.Now.AddMonths(1);
                int year = nextMonth.Year;
                int month = nextMonth.Month;
                int day = nextMonth.Day;

                // Verifica si ya existen registros para el próximo mes en la base de datos
                if (tipoCambio.ExistenRegistros(year, month,day))
                {
                    Console.WriteLine("Los registros para este mes ya existen en la base de datos.");
                    return;
                }

                // Obtén el último día del próximo mes
                int lastDayOfMonth = DateTime.DaysInMonth(year, month);

                Console.WriteLine($"Obteniendo tipo de cambio para el próximo mes (Año: {year}, Mes: {month})...");

                // Inicializa una variable para el tipo de cambio
                double exchangeRate;

                // Intenta obtener el tipo de cambio para cada día del próximo mes
                for ( day = 1; day <= lastDayOfMonth; day++)
                {
                    try
                    {
                        // Espera a obtener el tipo de cambio del día
                        exchangeRate = await bcn.GetExchangeRateForDayAsync(year, month, day);
                        Console.WriteLine($"Tipo de cambio para el día {day}: {exchangeRate}");

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
                            Console.WriteLine($"Tipo de cambio del día {day} agregado correctamente a la base de datos.");
                        }
                        else
                        {
                            Console.WriteLine($"Error al agregar el tipo de cambio del día {day} a la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al obtener el tipo de cambio para el día {day}: {ex.Message}");
                    }
                }

                // Envía un correo electrónico de notificación
                EnviarCorreoNotificacion($" (Año: {year}, Mes: {month}).");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }

        static void EnviarCorreoNotificacion(string exchangeRatesXml)
        {
            string toEmail = "info@casavision.com";
            string subject = "Notificación de Existencia de Datos";
            string body = "Se han encontrado registros para el próximo mes, se ha realizado el registro en la base de datos\n\n" + exchangeRatesXml;

            if (EnviarCorreo(toEmail, subject, body))
            {
                Console.WriteLine("Correo de notificación enviado correctamente.");
            }
            else
            {
                Console.WriteLine("Error al enviar el correo de notificación.");
            }
        }

        public static bool EnviarCorreo(string correo, string asunto, string mensaje)
        {
            bool resultado = false;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("Roquejohanssen@gmail.com"); 
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;
                var smtp = new SmtpClient()
                {
                    Credentials = new NetworkCredential("Roquejohanssen@gmail.com", "oyaitgdgwtfsciwr"), 
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };
                smtp.Send(mail);
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

       
        
    }
}
