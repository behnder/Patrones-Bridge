using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Bridge
{
    class Personaje
    {
        public string Nombre { get; set; }
        public IArmaMelee arma;
        public void ElegirArma(IArmaMelee armaMelee)
        {
            arma = armaMelee;
        }

   
    }
}
