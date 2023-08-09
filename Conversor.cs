    namespace ExercicioDeFixacao_ConversorDeMoedas
{
    internal class Conversor
    {
        public static double valor;
        public static double valorCompra;
        public static double ValorPago ()
        {
            return (valor * valorCompra * 6 / 100) + (valor * valorCompra);
        }
    }
}
