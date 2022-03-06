namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calcula = new Calcula();
            int valor;
            decimal n1, n2;

            Console.Write("Digite o n1 >> ");
            n1 = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o n2 >> ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("1__Soma");
            Console.WriteLine("2__Subtração");
            Console.WriteLine("3__Multiplicação");
            Console.WriteLine("4__Divisão");
            Console.Write("Digite o número da operação desejada >> ");
            valor = Int32.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    {
                        Console.WriteLine(calcula.CalcSoma(n1, n2));
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine(calcula.CalcSubtracao(n1, n2));
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine(calcula.CalcMultiplicao(n1, n2));
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine(calcula.CalcDiv(n1, n2));
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Opção Inválida!!");
                        break;
                    }
            }
        }
    }
}