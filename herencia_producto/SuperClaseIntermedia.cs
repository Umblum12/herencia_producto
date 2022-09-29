using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_producto
{
    internal class SuperClaseIntermedia : SuperClase
    {
        private int tempRecomendada;

        public int TempRecomendada { get => tempRecomendada; set => tempRecomendada = value; }
    }
}
