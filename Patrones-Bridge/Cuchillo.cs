using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Bridge
{
    class Cuchillo : IArmaMelee
    {
        public string Nombre { get; private set; } = "Cuchillo";
        public bool Enfundado { get; private set; } = true;
        public void Afilar()
        {
            Console.WriteLine("Afilando cuchillo");
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
                Console.WriteLine("Desenfundado Cuchillo");
                Enfundado = false;

            }
            else
            {
                Console.WriteLine("El cuchillo ya está desenfundado");
                Enfundado = false;
            }

        }

        public void Enfundar()
        {
            if (!ComprobarEnfundado())
            {
                Console.WriteLine("Enfundado Cuchillo " );
                Enfundado = true;

            }
            else
            {
                Console.WriteLine("El Cuchillo  está Enfundado");
                Enfundado = true;
            }

        }

        public void GetAtaque()
        {
            if (ComprobarEnfundado())
            {
                Console.WriteLine("Primero debe desenfundar");

            }
            else
            {
                Console.WriteLine("+25 de ataque");
            }

        }
    }
}
