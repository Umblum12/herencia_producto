using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_producto
{
    internal class SuperClase
    {
        private string fechaCaducidad;
        private int numeroLote;
        private string fechaEnvasado;
        private string paisDeOrigen;

        public string FechaCaducidad { get => fechaCaducidad; set => fechaCaducidad = value; }
        public int NumeroLote { get => numeroLote; set => numeroLote = value; }
        public string FechaEnvasado { get => fechaEnvasado; set => fechaEnvasado = value; }
        public string PaisDeOrigen { get => paisDeOrigen; set => paisDeOrigen = value; }
    }
}
