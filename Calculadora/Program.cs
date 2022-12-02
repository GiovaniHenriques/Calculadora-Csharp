namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1,Subtracao,Multiplicacao,Divisao,Potencia,Raiz,Sair}
        static void Main(string[] args)
        {
            bool verificacao = false;

            while (!verificacao)
            {
                Console.WriteLine("Seja Bem Vindo ao Calculex, Por favor escolha uma das opções a baixo");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Potenciação\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine(opcao);

                Console.Clear();

                switch (opcao)
                {
                    case Menu.Soma:
                         Soma();
                         break;

                    case Menu.Subtracao:
                         Subtracao();
                         break;

                    case Menu.Multiplicacao:
                         Multiplicacao();
                         break;

                    case Menu.Divisao:
                         Divisao();
                         break;

                    case Menu.Potencia:
                         Potencia();
                         break;

                    case Menu.Raiz:
                         Raiz();
                         break; 

                    case Menu.Sair:
                         verificacao = true;
                         break;
                }

            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 + n2;
            Console.WriteLine($"Esse é o resultado do seu Calculo: {resultado}");
            Console.WriteLine("Precione a tecla Enter para efetuar outro calculo");
            Console.ReadLine();
            Console.Clear();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 - n2;
            Console.WriteLine($"Esse é o resultado do seu Calculo: {resultado}");
            Console.WriteLine("Precione a tecla Enter para efetuar outro calculo");
            Console.ReadLine();
            Console.Clear();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 * n2;
            Console.WriteLine($"Esse é o resultado do seu Calculo: {resultado}");
            Console.WriteLine("Precione a tecla Enter para efetuar outro calculo");
            Console.ReadLine();
            Console.Clear();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());
            float resultado = (float)n1 / (float)n2;
            Console.WriteLine($"Esse é o resultado do seu Calculo: {resultado}");
            Console.WriteLine("Precione a tecla Enter para efetuar outro calculo");
            Console.ReadLine();
            Console.Clear();
        }

        static void Potencia()
        {
            Console.WriteLine("Potencia de um número: ");
            Console.WriteLine("Digite a base: ");
            int baseNumerica = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNumerica,expoente);
            Console.WriteLine($"Esse é o resultado do seu Calculo: {resultado}");
            Console.WriteLine("Precione a tecla Enter para efetuar outro calculo");
            Console.ReadLine();
            Console.Clear();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um número: ");
            Console.WriteLine("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(numero);
            Console.WriteLine($"Esse é o resultado do seu Calculo: {resultado}");
            Console.WriteLine("Precione a tecla Enter para efetuar outro calculo");
            Console.ReadLine();
            Console.Clear();
        }
    }
}