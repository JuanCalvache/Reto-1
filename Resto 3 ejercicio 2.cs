using System;

public class Program
{
    public static void Main()
    {
        //INGRESAR SALARIO
        Console.WriteLine("Ingrese su Salario");
        int x = int.Parse(Console.ReadLine());

        //IMPRIMIR TARIFA
        if (x < (2 * 828116))
        {
            Console.WriteLine("Tarifa A");
        }
        else if ((2 * 828116) <= x && x < (5 * 828116))
        {
            Console.WriteLine("Tarifa B");
        }
        else
        {
            Console.WriteLine("Tarifa c");
        }
        //IMPRIMIR CUOTA MODERADORA
        if (x <= (1656231))
        {
            Console.WriteLine("Cuota Moderadora de $ 3.200");
        }
        else if ((1656231) < x && x <= (4140580))
        {
            Console.WriteLine("Cuota Moderadora de $ 12.700");
        }
        else
        {
            Console.WriteLine("Cuota Moderadora de $ 33.500");
        }
    }
}
