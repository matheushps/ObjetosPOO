using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosPOO
{
    public class Program
    {
        static void Main(string[] args)
        
        {
            int numero;
            Console.WriteLine("Informe uma operação:");
            Console.WriteLine("1 Quadrado / 2 Triangulo / 3 Circulo / 4 Trapezio / 5 Retangulo / 6 Losangulo / 7 Paralelogramo");
            numero = int.Parse(Console.ReadLine());
            Console.Clear();

            if (numero == 1)
            {
                Quadrado quadrado = new Quadrado();

                Console.Write("Informe o tamanho do primeiro lado do quadrado:");
                quadrado.LadoA = double.Parse(Console.ReadLine());
                Console.Write("Informe o tamanho do segundo lado do quadrado:");
                quadrado.LadoB = double.Parse(Console.ReadLine());
                Console.WriteLine("A área do quadrado é {0}", quadrado.CalcularQuadrado());
                Console.ReadKey();
            }
            else if (numero == 2)
            {
                Triangulo triangulo = new Triangulo();

                Console.Write("Informe o tamanho da base do triangulo:");
                triangulo.LadoA = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura do triangulo:");
                triangulo.Altura = double.Parse(Console.ReadLine());
                Console.WriteLine("A área do triangulo é {0}", triangulo.CalcularTriangulo());
                Console.ReadKey();

            }
            else if (numero == 3)
            {
                Circulo circulo = new Circulo();

                Console.Write("Informe o raio do Círculo :");
                circulo.RaioCirculo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A área do círculo de raio é {0}", circulo.CalcularAreaCirculo());
            }
            else if (numero == 4)
            {
                Trapezio trapezio = new Trapezio();

                Console.Write("Informe a altura do trapezio: ");
                trapezio.Altura = double.Parse(Console.ReadLine());
                Console.Write("Informe a o valor da base maior do Trapezio: ");
                trapezio.LadoA = double.Parse(Console.ReadLine());
                Console.Write("Informe a o valor da base menor do Trapezio: ");
                trapezio.LadoB = double.Parse(Console.ReadLine());
                Console.WriteLine("A área do trapezio é {0}", trapezio.CalcularTrapezio());
                Console.ReadKey();

            }
            else if (numero == 5)
            {
                Retangulo retangulo = new Retangulo();

                Console.Write("Informe o tamanho da base do Retangulo:");
                retangulo.LadoA = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura do Retangulo:");
                retangulo.Altura = double.Parse(Console.ReadLine());
                Console.WriteLine("A área do retangulo é {0} ", retangulo.CalcularRetangulo());
                Console.ReadKey();

            }

            else if (numero == 6)
            {
                Losangulo losangulo = new Losangulo();

                Console.Write("Informe a diagonal maior do losangulo:");
                losangulo.LadoA = double.Parse(Console.ReadLine());
                Console.Write("Informe a diagonal menor do losangulo:");
                losangulo.LadoB = double.Parse(Console.ReadLine());
                Console.WriteLine("A área do losangulo é {0}", losangulo.CalcularAreaLosangulo());
                Console.ReadKey();

            }
            else if (numero == 7)
            {
                Paralelogramo paralelogramo = new Paralelogramo();

                Console.Write("Informe o tamanho da base do paralelogramo:");
                paralelogramo.LadoA = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura do paralelogramo:");
                paralelogramo.Altura = double.Parse(Console.ReadLine());
                Console.WriteLine("A área do paralelogramo é {0}", paralelogramo.CalcularParalelogramo());
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("erro - O numero informado não corresponde a nenhuma operação!");
                Console.ReadKey();
            }
        }
    }
}

