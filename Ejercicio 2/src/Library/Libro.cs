using System;

namespace SRP
{
    public class Libro
    {//la clase tiene dos responsabilidades y estan acordes a la informacion que tiene la clase por lo que el Principio Expert se cumple

        public string Titulo { get ; }
        public string Autor { get ; }// se cumple el SRP debido a que no econtramos más de una razon de cambio para el programa 
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
