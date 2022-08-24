using CalculadoraConsole.Classes;
using Newtonsoft.Json;

namespace CalculadoraConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Soma(10, 10.3);
        }
    }
}