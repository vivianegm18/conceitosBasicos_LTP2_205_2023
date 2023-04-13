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
byte menorIdade, maiorIdade;
float media;
int par, impar, somador;


EntradaDeDados();
menorIdade = idades[0];
maiorIdade = idades[0];
par = idades[0];
somador = idades[0];

foreach (byte idade in idades)
{
    Console.WriteLine(idade);
}

foreach (byte idade in idades)
{
    if (idade < menorIdade)
    {
        menorIdade = idade;
    }
}
Console.WriteLine($"Menor idade:{menorIdade}");

foreach (byte idade in idades)
{
    if (idade > maiorIdade)
    {
        maiorIdade = idade;
    }
}
Console.WriteLine($"Maior idade:{maiorIdade}");

media = (idades[0] + idades[1] + idades[2] + idades[3] + idades[4]) / 5;
Console.WriteLine($"a media é {media}");

Console.WriteLine("as idades pares são:");

foreach (byte idade in idades)
{
    if (idade % 2 == 0) 
    {
        par = idade;
        Console.WriteLine(par);
    }
    
} 
Console.WriteLine("as idades impares são:");
foreach (byte idade in idades)
{
    if (idade % 2 != 0) 
    {
        impar = idade;
        Console.WriteLine(impar);
    }
    
}

void EntradaDeDados()
{
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe a {i + 1} idade:");
    idades[i] = byte.Parse(Console.ReadLine());
}
}



