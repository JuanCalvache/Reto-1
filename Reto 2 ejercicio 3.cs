using System;

public class Class1
{
	public Class1()
	{
        //Ingresar Datos
        Console.WriteLine("Ingrese: w, d, x ");
        double w = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        //Convertir d a Radianes
        double dRad = d * (Math.PI / 180);

        //Hallar y	
        double y = (w * Math.Cos(dRad)) - x;

        //Imprimir respuesta
        Console.WriteLine("y = " + y);
    }
}
