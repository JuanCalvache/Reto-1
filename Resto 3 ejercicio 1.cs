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
        else if ((2 * 828116) <= x && x < (4 * 828116))
        {
            Console.WriteLine("Tarifa B");
        }
        else
        {
            Console.WriteLine("Tarifa c");
        }
    }
}