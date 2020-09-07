using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string Nombre{get;set;}
        public string Telefono{get;set;}
        public string Edad{get; set;}
        public string Id{get; set;}
        public Paciente (string nombre, string telefono, string edad, string id)
        {
              if (!string.IsNullOrEmpty(nombre))
            {
                this.Nombre=nombre;
            }

            if (!string.IsNullOrEmpty(telefono))
            {
                this.Telefono=telefono;
            }

            if (!string.IsNullOrEmpty(edad))
            {
                this.Edad=edad;
            }

            if (!string.IsNullOrEmpty(id))
            {
                this.Id=id;
            }

        }
        public bool Validar_Paciente(Paciente paciente)
        {
            if (string.IsNullOrEmpty(this.Nombre) || string.IsNullOrEmpty(this.Telefono) || string.IsNullOrEmpty(this.Edad) || string.IsNullOrEmpty(this.Id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}