

class Texto
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um texto:");
        string texto = Console.ReadLine()!.ToLower();

        // Dicionário para armazenar a contagem das letras
        Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

        // Inicializa o dicionário com as letras do alfabeto
        for (char letra = 'a'; letra <= 'z'; letra++)
        {
            contagemLetras[letra] = 0;
        }

        // Conta as letras no texto
        foreach (char caractere in texto)
        {
            if (contagemLetras.ContainsKey(caractere))
            {
                contagemLetras[caractere]++;
            }
        }

        // Exibe a contagem de cada letra
        Console.WriteLine("\nContagem de letras:");
        foreach (var item in contagemLetras)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
