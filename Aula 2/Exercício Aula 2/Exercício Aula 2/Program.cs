using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zeros de uma equação do se2gundo grau. É necessário saber o valor de a, b e c.

            //Definir as variáveis.
            int a;
            int b;
            int c;
            double x1;
            double x2;

            //Atribuir valores às variáveis.

            a = 0; b = 4; c = 3;

            //Calcular os Zeros (valores de x1 e x2).

            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a); //Fórmula de Bhaskara: -b ± √(b² - 4ac) / 2a
            //Math.Pow(Number1, Number2) - Potências no C# são definidas assim. Number1 é a base e Number2 é o expoente.
            //Math.sqrt(Number) - Raiz quadrada no C# é definida assim. Number é o número que você quer a raiz quadrada.

            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            //Mostrar os resultados no console.

            if (a == 0) {                
                Console.WriteLine("O valor de 'a' não pode ser 0.");
            }

            else
            {
                Console.WriteLine("Zeros da equação: " + x1 + " e " + x2);
            }
            
            Console.WriteLine(" "); //Espaço em branco no console.

            //Conversão de temperatura de Fahrenheit para Celsius.

            //Definir as variáveis.

            float fahrenheit;
            float celsius;

            //Atribuir valores às variáveis.

            fahrenheit = 77;

            //Calcular a conversão.

            celsius = (fahrenheit - 32) * 5 / 9;

            //Mostrar o resultado no console.

            Console.WriteLine("Temperatura em Celsius: " + celsius + "ºC");
            Console.ReadKey();
        }
    }
}
