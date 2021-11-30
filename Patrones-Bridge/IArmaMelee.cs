using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Bridge
{
    interface IArmaMelee
    {
        void GetAtaque();
        void Afilar();
        void Enfundar();
        void Desenfundar();
        bool  ComprobarEnfundado();
     

    }
}
