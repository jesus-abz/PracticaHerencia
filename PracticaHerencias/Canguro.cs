using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencias
{
    public class Canguro : AnimalTerrestre
    {
        public Canguro()
        {
            Nombre = "Canguro";
        }

        public void Saltar()
        {
            Console.WriteLine("Hola, soy un " + Nombre + " y estoy saltando");
        }
    }
}
