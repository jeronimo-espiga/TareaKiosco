using System;

namespace Expert_SRP
{
    public class Kiosco //No se aplica el SRP debido a que hay dos razones de cambio, ya que si apareciera un nuevo tipo de moneda o se cambiara a otro producto que no fueran alfajores se tendria que cambiar el codigo
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) //solo permite vender alfajores, si el dueño quiere vender otra mercaderia tendria que modificar el codigo
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)//si el cliente viene con una moneda que no sea dolares o pesos, como euros o yenes, nos encontramos en una razon de cambio
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}