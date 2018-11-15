using System;
using System.Collections.Generic;


namespace PracticaHerencias
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre elefante = new AnimalTerrestre();
            Canguro canguro = new Canguro();

            Animal tiburon = new AnimalAcuatico();

            delfin.Nombre = "Delfin";
            elefante.Nombre = "Elefante";
            tiburon.Nombre = "Tiburon";

            List<Animal> animales = new List<Animal>();

            delfin.Comer();
            delfin.Nadar();

            elefante.Caminar();

            canguro.Comer();
            canguro.Caminar();
            canguro.Saltar();

            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(elefante);
            animales.Add(canguro);

            ((AnimalAcuatico)tiburon).Nadar();

            foreach (var animal in animales)
            {
                Console.WriteLine(animal.Nombre);
                if (animal.GetType() == typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
            }

            Console.ReadLine();
        }
    }
}
