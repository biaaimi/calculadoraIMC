using System;

namespace calculadoraIMC
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            double massa, altura, imc;
            string diagnostico;

            Console.WriteLine("-- Calculadora de IMC --\n");

            Console.Write("Digite seu peso em kg...: ");
            massa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em m..: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = massa / Math.Pow(altura, 2);

            Console.WriteLine($"\nSeu IMC é {imc:N2} kg/m².");

            if (imc < 17)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Diagnostico: Obsidade");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Diagnostico: Obesidade II severa");
            }
            else
            {
                Console.WriteLine("Diagnostico:Obesidade III mórbida");
            }
        }
    }
    }


    
        

