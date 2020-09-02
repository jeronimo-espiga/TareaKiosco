using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce 
        {get
            { 
                return precioDulce;
            }

        set
            {
                if (value>0)
                {
                    precioDulce=value;
                }
            }
        }   
        public Double PrecioMasa 
        {
            get
            {
                return precioMasa;
            }

            set
            {
                if (value>0)
                {
                    precioMasa=value;
                }
            }
        }

        private Double precioDulce;
        private Double precioMasa;

        public Double CalculoPrecio()
        {
            return this.PrecioDulce + this.PrecioMasa;
        }
    }
}