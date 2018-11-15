using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencias
{
    public class AnimalTerrestre : Animal
    {
        public void Caminar()
        {
            Console.WriteLine("Hola, soy un " + Nombre + " y estoy caminando");

        }
    }
}
