int[] numeros = new int[10];

int somaPares = 0;

 // Preenchendo o vetor com valores do usuário
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Informe o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        // Calculando a soma dos números pares
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
        }

        Console.WriteLine($"\nA soma dos números pares é: {somaPares}");
    
 

