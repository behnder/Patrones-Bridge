using System;

namespace Patrones_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje();
            personaje.Nombre = "Alan";
            personaje.ElegirArma(new Cuchillo());
            personaje.arma = personaje.arma as Cuchillo;
            Console.WriteLine($"el personaje {personaje.Nombre}, tiene un Cuchillo");


            Console.WriteLine("\nLlamando a afilar");
            personaje.arma.Afilar();
           
            Console.WriteLine("\nLlamando a Atacar");
            personaje.arma.GetAtaque();
            Console.WriteLine("\nLlamando a Desenfundar");
            personaje.arma.Desenfundar(); 
            Console.WriteLine("\nLlamando a Desenfundar de nuevo");
            personaje.arma.Desenfundar();
            Console.WriteLine("\nLlamando a ataque de nuevo");
            personaje.arma.GetAtaque();
            Console.WriteLine("\nllamando a enfundar");
            personaje.arma.Enfundar();
            Console.WriteLine("\nllamando a enfundar de nuevo");
            personaje.arma.Enfundar();

        }
    }
}
