using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int dado = 0, total = 0, contador = 0;
        string continuar = "s", win = "no";

        while (continuar == "s" && win == "no")
        {
            contador += 1;
            dado = aleatorio.Next(1, 13);
            Console.WriteLine("Dado = " + dado);
            while (dado == 12)
            {
                total += dado;
                Console.WriteLine("Total = " + total);
                if (total >= 100)
                {
                    win = "Si";
                    Console.WriteLine("Ganaste");
                    Console.WriteLine("Total = " + total);
                }
                else
                {
                    Console.WriteLine("¿Desea Continuar? (s/n)");
                    continuar = Console.ReadLine();
                }
                if (continuar == "s")
                {
                    contador += 1;
                    dado = aleatorio.Next(1, 13);
                    Console.WriteLine("Dado = " + dado);
                    if (dado == 10)
                    {
                        win = "Si";
                        Console.WriteLine("Ganaste");
                        dado = 0;
                    }
                }
            }
            if (contador <= 3)
            {
                total += dado;
                Console.WriteLine("Total = " + total);
                Console.WriteLine("¿Desea Continuar? (s/n)");
                continuar = Console.ReadLine();
            }
            else if (contador > 3)
            {
                if (dado == 2 || dado == 4 || dado == 6 || dado == 8 || dado == 10)
                {
                    total += dado;
                    Console.WriteLine("Total = " + total);
                    if (total >= 100)
                    {
                        win = "Si";
                        Console.WriteLine("Ganaste");
                        Console.WriteLine("Total = " + total);
                    }
                    else
                    {
                        Console.WriteLine("¿Desea Continuar? (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
                else
                {
                    total = 0;
                    Console.WriteLine("Perdiste");
                    Console.WriteLine("Total = " + total);
                    continuar = "n";
                }
            }
        }
        Console.WriteLine("Fin Del juego");
    }
}