

class Tabuada
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para ver a tabuada: ");
        int numero = int.Parse(Console.ReadLine()!);

        ExibirTabuada(numero);
    }

    static void ExibirTabuada(int numero)
    {
        Console.WriteLine($"Tabuada do {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
