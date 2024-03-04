using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    internal interface ISelector
    {
        //Interficie per als diferents menus de seleccio entre opció 1 o 2//
        public int Selector(int selection);
    }
}
