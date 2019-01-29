using System;

public class Class1
{
	public Class1()
	{
        //Ingresar Datos
        Console.WriteLine("Ingrese: d, b, y ");
        double d = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //Hallar c
        double c = b + d;

        //Convertir c a Radianes
        double cRad = c * (Math.PI / 180);

        //Hallar z	
        double z = y * Math.Tan(cRad);

        //Imprimir respuesta
        Console.WriteLine("z = " + z);
    }
}
