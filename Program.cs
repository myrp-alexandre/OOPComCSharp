 using System;

namespace WorkshopCSharp160319
{
    public class Program
    {
        static void Main(string[] args)
        {
            var automovel = new Automovel();
            automovel.Abastecer(100);
            automovel.Ligar();

            for (int i = 0; i < 50; i++)
            {
                automovel.Acelerar();
            }

            for (int i = 0; i < 50; i++)
            {
                automovel.Frear();
            }

            automovel.Desligar();

            Console.ReadKey();
        }
    }
}
