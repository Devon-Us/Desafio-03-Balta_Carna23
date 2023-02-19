internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Olá, esse aplicativo vai calcular entre alcool ou gasolina, qual vale mais a pena!");
        Console.WriteLine("Digite o valor do Alcool na sua cidade:");
        var alcool = double.Parse(Console.ReadLine());
        Console.WriteLine("Agora digite o valor da Gasolina na sua cidade:");
        var gasolina = double.Parse(Console.ReadLine());
        var resultado = alcool / gasolina;
        if (resultado >= 0.65 && resultado < 0.72)
            Console.WriteLine("Vale mais a pena abastecer com Alcool!");
        if (resultado >= 0.72)
            Console.WriteLine("Vale mais a pena abastecer com Alcool e você irá economizar com a troca");
        if (resultado < 0.65)
            Console.WriteLine("Vale a pena abastecer com Gasolina");
    }
}