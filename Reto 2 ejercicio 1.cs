using System;

public class Class1
{
	public Class1()
	{
        //Ingresar Datos
        Console.WriteLine("Ingrese: b, z, y ");
        double b = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //Calcular angulo a
        double a = Math.Atan(y / z);

        //Convertir b en radianes
        double bRad = b * (Math.PI / 180);

        //Calcular x
        double x = (z * Math.Tan(a + bRad)) - y;

        //Imprimir respuesta
        Console.WriteLine("x = " + x);
    }
}
