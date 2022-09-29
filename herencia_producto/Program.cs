namespace herencia_producto
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SuperClase producto = new SuperClase();
            producto.FechaCaducidad = "13 de abril 2023";
            producto.NumeroLote = 23456;
            producto.FechaEnvasado = "13 de abril del 2021";
            producto.PaisDeOrigen = "México";
            Console.WriteLine("Producto: \nFecha de Caducidad: " + producto.FechaCaducidad + "\nNumero de Lote: " + producto.NumeroLote + "\nFecha de Envasado: " + producto.FechaEnvasado + "\nPais de Origen: " + producto.PaisDeOrigen);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SuperClaseIntermedia Producto_Frio = new SuperClaseIntermedia();
            Producto_Frio.FechaCaducidad = "09 de julio del 2023";
            Producto_Frio.NumeroLote = 23093;
            Producto_Frio.FechaEnvasado = "09 de julio del 2020";
            Producto_Frio.PaisDeOrigen = "Mexico";
            Producto_Frio.TempRecomendada = 5;
            Console.WriteLine("Producto Frio:\nFecha de Caducidad: " + Producto_Frio.FechaCaducidad + "\nNumero de Lote: " + Producto_Frio.NumeroLote + "\nFecha de Envasado: " + Producto_Frio.FechaEnvasado + "\nPais de Origen: " + Producto_Frio.PaisDeOrigen + "\n tempRecomendada: " + Producto_Frio.TempRecomendada);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SubClases CongeladoAire = new SubClases();
            CongeladoAire.FechaCaducidad = "25 de dicimebre del 2026";
            CongeladoAire.NumeroLote = 435;
            CongeladoAire.FechaEnvasado = "25 de septiembre del 2020";
            CongeladoAire.PaisDeOrigen = "Mexico";
            CongeladoAire.TempRecomendada = 5;
            CongeladoAire.Nitrogeno = 7;
            CongeladoAire.Oxigeno = 8;
            CongeladoAire.DioxCarbono = 23;
            CongeladoAire.VaporAgua = 40;
            Console.WriteLine("Congelado Aire: \nFecha de Caducidad: " + CongeladoAire.FechaCaducidad + "\nNumero de Lote: " + CongeladoAire.NumeroLote + "\nFecha de Envasado: " + CongeladoAire.FechaEnvasado + "\nPais de Origen: " + CongeladoAire.PaisDeOrigen + "\nTemperatura Recomendada: " + CongeladoAire.TempRecomendada + "\nNitrogeno: " + CongeladoAire.Nitrogeno + "\nOxigeno: " + CongeladoAire.Oxigeno + "\nDioxido de Carbono: " + CongeladoAire.DioxCarbono + "\nVapor Agua: " + CongeladoAire.VaporAgua);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SubClases CongeladoAgua = new SubClases();
            CongeladoAgua.FechaCaducidad = "12 de octubre del 2023";
            CongeladoAgua.NumeroLote = 256;
            CongeladoAgua.FechaEnvasado = "12 de octubre del 2022";
            CongeladoAgua.PaisDeOrigen = "México";
            CongeladoAgua.TempRecomendada = 6;
            CongeladoAgua.SalinidadAgua = 15;
            Console.WriteLine("Congelado Agua: \nFecha de Caducidad: " + CongeladoAgua.FechaCaducidad + "\nNumero de Lote: " + CongeladoAgua.NumeroLote + "\nFecha de Envasado: " + CongeladoAgua.FechaEnvasado + "\nPais de Origen: " + CongeladoAgua.PaisDeOrigen + "\nTemperatura Recomendada: " + CongeladoAgua.TempRecomendada + "\nSalinidad en el Agua: " + CongeladoAgua.SalinidadAgua);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SubClases CongeladoNitrogeno = new SubClases();
            CongeladoNitrogeno.FechaCaducidad = "13 de marzo del 2024";
            CongeladoNitrogeno.NumeroLote = 532;
            CongeladoNitrogeno.FechaEnvasado = "13 de marzo del 2021";
            CongeladoNitrogeno.PaisDeOrigen = "México";
            CongeladoNitrogeno.TempRecomendada = 3;
            CongeladoNitrogeno.MetodoEmpleado = "Congelado";
            CongeladoNitrogeno.TiempoExposicion = 25;
            Console.WriteLine("Congelado Nitrogeno: \nFecha de Caducidad: " + CongeladoNitrogeno.FechaCaducidad + "\nNumero de Lote: " + CongeladoNitrogeno.NumeroLote + "\nFecha de Envasado: " + CongeladoNitrogeno.FechaEnvasado + "\nPais de Origen: " + CongeladoNitrogeno.PaisDeOrigen + "\nTemperatura Recomendada: " + CongeladoNitrogeno.TempRecomendada + "\nMetodo Empleado: " + CongeladoNitrogeno.MetodoEmpleado + "\nTiempo de Exposicion: " + CongeladoNitrogeno.TiempoExposicion);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SubClases ProductoRefrigerado = new SubClases();
            ProductoRefrigerado.FechaCaducidad = "08 de diciembre del 2025";
            ProductoRefrigerado.NumeroLote = 532;
            ProductoRefrigerado.FechaEnvasado = "08 de diciembre del 2024";
            ProductoRefrigerado.PaisDeOrigen = "México";
            ProductoRefrigerado.TempRecomendada = 4;
            ProductoRefrigerado.CodSupervision = 9685412;
            Console.WriteLine("Producto Refrigerado: \nFecha de Caducidad: " + ProductoRefrigerado.FechaCaducidad + "\nNumero de Lote: " + ProductoRefrigerado.NumeroLote + "\nFecha de Envasado: " + ProductoRefrigerado.FechaEnvasado + "\nPais de Origen: " + ProductoRefrigerado.PaisDeOrigen + "\nTemperatura Recomendada: " + ProductoRefrigerado.TempRecomendada + "\nCodigo de Supervision: " + ProductoRefrigerado);
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
            SubClases ProductoFresco = new SubClases();
            ProductoFresco.FechaCaducidad = "30 de mayo del 2023";
            ProductoFresco.NumeroLote = 453;
            ProductoFresco.FechaEnvasado = "30 de mayo del 2022";
            ProductoFresco.PaisDeOrigen = "México";
            Console.WriteLine("Producto Fresco: \nFecha de Caducidad: " + ProductoFresco.FechaCaducidad + "\nNumero de Lote: " + ProductoFresco.NumeroLote + "\nFecha de Envasado: " + ProductoFresco.FechaEnvasado + "\nPais de Origen: " + ProductoFresco.PaisDeOrigen);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}