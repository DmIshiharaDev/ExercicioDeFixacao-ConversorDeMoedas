using ExercicioDeFixacao_ConversorDeMoedas;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--- Conversor de Moeda (Dólar) ---");
        
        
        Console.WriteLine();
        Console.Write("Qual é a cotação do dólar? $");
        Conversor.valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? $");
        Conversor.valorCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Valor a ser pago = R$" + Conversor.ValorPago().ToString("f2", CultureInfo.InvariantCulture));

    }
}