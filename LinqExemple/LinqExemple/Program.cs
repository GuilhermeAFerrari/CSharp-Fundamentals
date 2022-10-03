// Especificar fonte de dados
int[] numbers = new int[] { 1, 4, 9, 12, 15 };

// Definir a expressão
IEnumerable<int> result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 10);

// Execução da consulta
foreach (var item in result)
{
    Console.WriteLine(item);
}

