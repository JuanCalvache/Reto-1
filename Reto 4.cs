using System;

public class Program
{
    public static void Main()
    {

        //INGRESAR DATOS
        Console.WriteLine("Ingrese número de votos por el partido 1");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese número de votos por el partido 2");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese número de votos en Blanco");
        int blancos = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese número de votos Anulados");
        int anulados = int.Parse(Console.ReadLine());
        Console.WriteLine("número total de la población de todas las edades");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("el porcentaje (de 0 a 100%) de la población que es mayor de edad");
        double p = double.Parse(Console.ReadLine());

        //CONDICIONES
        bool c1 = (a + b + blancos + anulados) > n;
        bool c2 = (Math.Abs(a - b)) < (a + b + blancos + anulados) * (0.1);
        bool c3 = (int)(n * (p / 100)) < (n * (0.3));
        bool c4 = a < b;
        bool c5 = a > b;
        bool c6 = a == b;

        //IMPRIMIR RESULTADOS
        if ((c1 || c2) && c3) Console.WriteLine("Las elecciones deben repetirse");
        else if (c4) Console.WriteLine("El ganador de las elecciones es el partido 2");
        else if (c5) Console.WriteLine("El ganador de las elecciones es el partido 1");
        else if (c6) Console.WriteLine("Hubo un empate");
    }
}
