using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Bridge
{
    class Espada : IArmaMelee
    {
        public bool Enfundado { get; private set; } = true;
        public string Nombre { get; private set; } = "Espada";
        public void Afilar()
        {
            Console.WriteLine("Afilando espada");
        }

        public bool ComprobarEnfundado()
        {
            if (Enfundado)
            {
                return true;
            }
            return false;

        }


        public void Desenfundar()
        {
            if (ComprobarEnfundado())
            {
                Console.WriteLine("Desenfundado Espada");
                Enfundado = false;

            }
            else
            {
                Console.WriteLine("La espada ya está desenfundada");
                Enfundado = false;
            }

        }

        public void Enfundar()
        {
            if (!ComprobarEnfundado())
            {
                Console.WriteLine("Enfundado Espada");
                Enfundado = true;
            }
            else
            {
                Console.WriteLine("La espada ya está Enfundada");
                Enfundado = true;
            }

        }

        public void GetAtaque()
        {
            if (ComprobarEnfundado())
            {
                Console.WriteLine("+25 de ataque");

            }
            else
            {
                Console.WriteLine("Primero debe desenfundar");
            }

        }
    }
}
