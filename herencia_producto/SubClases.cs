using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_producto
{
    internal class SubClases : SuperClase
    {
        private int nitrogeno;
        private int oxigeno;
        private int dioxCarbono;
        private int vaporAgua;
        private int salinidadAgua;
        private string metodoEmpleado;
        private int tiempoExposicion;
        private int codSupervision;
        private int tempRecomendada;
        public int Nitrogeno { get => nitrogeno; set => nitrogeno = value; }
        public int Oxigeno { get => oxigeno; set => oxigeno = value; }
        public int DioxCarbono { get => dioxCarbono; set => dioxCarbono = value; }
        public int VaporAgua { get => vaporAgua; set => vaporAgua = value; }
        public int SalinidadAgua { get => salinidadAgua; set => salinidadAgua = value; }
        public string MetodoEmpleado { get => metodoEmpleado; set => metodoEmpleado = value; }
        public int TiempoExposicion { get => tiempoExposicion; set => tiempoExposicion = value; }
        public int CodSupervision { get => codSupervision; set => codSupervision = value; }
        public int TempRecomendada { get => tempRecomendada; set => tempRecomendada = value; }
    }
}
