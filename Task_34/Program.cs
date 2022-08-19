// Ввести массив случайных положительных трехзначных чисел, показать количестов четных чисел
int [] arrayrandom = new int [4];
int sum = 0;

for (int i = 0; i <arrayrandom.Length; i++)
{
    arrayrandom[i] = new Random().Next(100,1000);
       if (arrayrandom[i]%2 == 0) sum++;
}

Console.WriteLine($"случайный массив: [{String.Join("; ", arrayrandom)}]");
Console.WriteLine($"Количество четных элементов: {sum}");
  