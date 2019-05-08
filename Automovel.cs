using System;

namespace WorkshopCSharp160319
{
    public class Automovel
    {
        public int Velocidade { get; set; }
        public int QuantidadeCombustivel { get; set; }
        public bool Ligado { get; set; }

        public virtual void Acelerar()
        {
            switch (Ligado)
            {
                case true:
                    if (QuantidadeCombustivel > 0)
                    {
                        Velocidade += 2;
                        QuantidadeCombustivel -= 2;
                        Console.WriteLine("Velocidade: {0} KM", Velocidade);
                    }
                    else
                    {
                        Console.WriteLine("Acabou o combustível! Abasteça!");
                        Desligar();
                    }
                    break;
                case false:
                    Console.WriteLine("Automóvel desligado");
                    break;
            }
        }

        public virtual void Frear()
        {
            if (Velocidade >= 0 && Ligado)
            {
                Velocidade -= 2;
                Console.WriteLine("Velocidade: {0} KM", Velocidade);
            }
            else
                Console.WriteLine("Automóvel esta parado ou desligado");

        }

        public virtual void Abastecer(int quantidadeCombustivel)
        {
            QuantidadeCombustivel += quantidadeCombustivel;
        }

        public virtual void Ligar()
        {
            if (QuantidadeCombustivel > 0)
            {
                Ligado = true;
                Console.WriteLine("Carro ligado");
            }
            else
                Console.WriteLine("Necessário abastecer o carro");
        }

        public virtual void Desligar()
        {
            Ligado = false;
            Console.WriteLine("Automóvel desligado");
        }
    }
}
