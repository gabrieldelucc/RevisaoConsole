int quantidadeNomes = 5; 

string [] nomes = new string[quantidadeNomes];


for (int i = 0; i < quantidadeNomes; i++) {

Console.WriteLine($"Bem vindo ao sistema, informe os nomes:"); 
nomes[i] = Console.ReadLine()!; 

}

  BubbleSort(nomes);

        Console.WriteLine("\nNomes ordenados em ordem alfabética:");
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
    

static void BubbleSort(string[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (String.Compare(array[j], array[j + 1]) > 0)
                {
                    string temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
