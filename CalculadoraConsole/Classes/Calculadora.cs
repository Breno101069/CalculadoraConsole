using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole.Classes
{
    public class Calculadora
    {
        public double Resultado { get; set; }
        public void Soma(double valor1, double valor2)
        {
            this.Resultado = valor1 + valor2;
            Console.WriteLine($"O valor da soma é: {Resultado}");
        }

        public void Subtrair(double valor1, double valor2)
        {
            this.Resultado = valor1 - valor2;
            Console.WriteLine($"O valor da subtração é: {Resultado}");
        }

        public void Dividir(double valor1, double valor2)
        {
            this.Resultado = valor1 / valor2;
            Console.WriteLine($"O valor da divisão é: {Resultado}");
        }

        public void Multiplicacao(double valor1, double valor2)
        {
            this.Resultado = valor1 * valor2;
            Console.WriteLine($"O valor da multiplicação é: {Resultado}");
        }
    }
}
