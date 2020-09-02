using System;

namespace Expert_SRP
{
    public class Kiosco //No se aplica el SRP debido a que hay dos razones de cambio, ya que si apareciera un nuevo tipo de moneda o se cambiara a otro producto que no fueran alfajores se tendria que cambiar el codigo
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) //solo permite vender alfajores, si el dueño quiere vender otra mercaderia tendria que modificar el codigo
        {
            Double pesos = ConversorMoneda.ConvertirAPesos(dinero, moneda);
            return pesos >= a.CalculoPrecio();
        }
    }
}