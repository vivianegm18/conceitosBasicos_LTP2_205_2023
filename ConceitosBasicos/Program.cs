//EXERCICIOS COM VETORES

/*
 * crie um vetor para armazenar as idades de 5 pessoas e ao final imprima:
 * 1) a pessoa mais nova
 * 2) a pessoa mais velha
 * 3)a média das idades
 * 4) todas as idades impares
 * 5) todas as idades pares 
 */
byte[] idades = new byte[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe a {i + 1} idade:");
    idades[i] = byte.Parse(Console.ReadLine());
}

foreach (byte idade in idades)
{
    Console.WriteLine(idade);
}
