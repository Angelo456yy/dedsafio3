using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
      int[,] compras = {
           {35, 25, 30, 20, 9},   //cliente 1
          {10, 20, 5, 9, 6},   //cliente 2
           {12, 65, 35, 44, 55},   //cliente 3
           {30, 40, 50, 60, 70},   //cliente 4
           {61, 38, 40, 90, 7000}   //cliente 5
        };
        Console.Write("Tienda\n================================================\n");
        AplicarDescuento(compras);
        
   
    }

    static void AplicarDescuento(int[,] compras)
    {
        for (int i = 0; i < compras.GetLength(0); i++)
        {
            int totalCompraCliente = 0;

            for (int j = 0; j < compras.GetLength(1); j++)
            {
                totalCompraCliente += compras[i, j];
            }

            double descuentos = 0;

            if (totalCompraCliente < 100)
            {
                Console.WriteLine($"Cliente {i + 1}: Total de compras = {totalCompraCliente}, Este no aplica");
            }
            else if (totalCompraCliente >= 100 && totalCompraCliente <= 1000)
            {
                descuentos = totalCompraCliente * 0.10;
                Console.WriteLine($"Cliente {i + 1}: Total de compras = {totalCompraCliente}, Descuento = 10% ");
            }
            else
            {
                descuentos = totalCompraCliente * 0.20;
                Console.WriteLine($"Cliente {i + 1}: Total de compras = {totalCompraCliente}, Descuento = 20% ");
            }
        }
    }
}