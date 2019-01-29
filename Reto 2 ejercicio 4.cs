using System;

public class Class1
{
	public Class1()
	{
        //Ingresar Datos
        Console.WriteLine("Ingrese: w, t, c ");
        double w = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        //Convertir c a Radianes
        double cRad = c * (Math.PI / 180);

        //Encontrar y, z
        double y = t * Math.Cos(cRad);
        double z = t * Math.Sin(cRad);

        //Encontrar x
        double x = (Math.Sqrt((w * w) - (z * z))) - y;

        //Imprimir respuesta
        Console.WriteLine("x = " + x);
    }
}
