using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Nombre{get; set;}
        public string Especialidad{get; set;}
        public Doctor (string nombre, string especialidad)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.Nombre=nombre;
            }
            if (!string.IsNullOrEmpty(especialidad))
            {
                this.Especialidad=especialidad;
            }

        }
        public bool Validar_Doctor(Doctor doctor)
        {
            if (string.IsNullOrEmpty(this.Nombre) || string.IsNullOrEmpty(this.Especialidad))
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