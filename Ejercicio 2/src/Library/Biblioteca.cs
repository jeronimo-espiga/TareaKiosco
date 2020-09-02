using System;

namespace SRP
{
    public class Biblioteca
    {
        public static void AlmacenarLibro(Libro libro_cualquiera, String sector, String estante)
        {
            libro_cualquiera.SectorBiblioteca = sector;
            libro_cualquiera.EstanteBiblioteca = estante;
        }
    }
}
