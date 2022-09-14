using System;

namespace calculadora 
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CalculadorA:");
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("6 - Resto da Divisão");
            Console.WriteLine("7 - Potenciação");
            Console.WriteLine("0- Sair");

            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Somar();
                    break;
                case "2":
                    Subtrair();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                case "5":
                    RaizQuadrada();
                    break;
                case "6":
                    RestoDivisao();
                    break;
                case "7":
                    CalcularPotenciacao();
                    break;
                case "0":
                    Console.WriteLine("Obrigado por usar nossa calculadora!");
                    break;
                default:
                    Menu();
                    break;

                
            }
        }
        public static void Somar()
        {
            double valor1,valor2, total;
            Console.WriteLine("Informe o primeiro valor");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            valor2 = double.Parse(Console.ReadLine());

            total = valor1 + valor2;

            Console.WriteLine($"{valor1} + {valor2} = {total}");
            Console.ReadLine();
            Menu();
        }

        public static void Subtrair()
        {
            double valor1,valor2, total;
            Console.WriteLine("Informe o primeiro valor");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            valor2 = double.Parse(Console.ReadLine());

            total = valor1 - valor2;

            Console.WriteLine($"{valor1} - {valor2} = {total}");
            Console.ReadLine();
            Menu();
        }

        public static void Multiplicar()
        {
            double valor1,valor2, total;
            Console.WriteLine("Informe o primeiro valor");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            valor2 = double.Parse(Console.ReadLine());

            total = valor1 * valor2;

            Console.WriteLine($"{valor1} X {valor2} = {total}");
            Console.ReadLine();
            Menu();
        }

        public static void Dividir()
        {
            double dividendo,divisor, total;
            Console.WriteLine("Informe o primeiro valor");
            dividendo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor");
            divisor = double.Parse(Console.ReadLine());

            if(divisor != 0)
            {
                total = dividendo / divisor;

                Console.WriteLine($"{dividendo} / {divisor} = {total}");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }

            
            Console.ReadLine();
            Menu();
        }

        public static void RaizQuadrada()
        {
            double numero;
            double raiz;
            Console.WriteLine("Informe o numero que deseja saber a raiz quadrada:");
            numero = double.Parse(Console.ReadLine());
            raiz = Math.Sqrt(numero);
            Console.WriteLine($"A raiz quadrada de {numero} é {raiz}");
            Console.ReadLine();
            Menu();
        }

        public static void RestoDivisao()
        {
            double dividendo, divisor;
            System.Console.WriteLine("Informe o dividendo:");
            dividendo = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe o divisor:");
            divisor = double.Parse(Console.ReadLine());

            if(divisor != 0)
            {
                System.Console.WriteLine($"O resto entre {dividendo} e {divisor} = {dividendo % divisor}");
            } else
            {
                System.Console.WriteLine("Não é possível realizar divisão por 0");
            }


            Console.ReadLine();
            Menu();
        }

        public static void CalcularPotenciacao()
        {
            double basePotencia, expoente;
            System.Console.WriteLine("Informe a base:");
            basePotencia = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o expoente:");
            expoente = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"{basePotencia} elevado a {expoente} é = {Math.Pow(basePotencia, expoente)}");
            Console.ReadLine();
            Menu();
    }
    }
}