using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaHerencias
{
    public class AnimalAcuatico : Animal
    {
        public void Nadar()
        {
            Console.WriteLine("Hola, soy un " + Nombre + " y estoy nadando");
                
        }
    }
}
