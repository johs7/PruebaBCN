using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBCN
{
    public class TipoCambio
    {
        TipoCambioEntities db = new TipoCambioEntities();
        public double Value { get; set; }
        public bool Guardar(ExchangeRates exchangeRate)
        {
            try
            {
                db.ExchangeRates.Add(exchangeRate);
                return db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo:
                Console.WriteLine("Error al guardar en la base de datos: " + ex.Message);
                return false;
            }
        }
        public bool ExistenRegistros(int year, int month)
        {
            try
            {
                // Verificar si existen registros para el año y mes dados
                return db.ExchangeRates.Any(r => r.Year == year && r.Month == month);
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo:
                Console.WriteLine("Error al verificar existencia de registros: " + ex.Message);
                return false;
            }
        }

        public void Guardar()
        {
            throw new NotImplementedException();
        }

        public bool Guardar(object exchangeRates)
        {
            throw new NotImplementedException();
        }
    }
}
