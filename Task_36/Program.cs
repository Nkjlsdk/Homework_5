// Ввести одномерный массив случайных чисел, найти сумму элементов стоящих на нечетных позициях
int [] arrayrandom = new int [4];
int sum = 0;
for (int i = 0; i < arrayrandom.Length; i++)
{
    arrayrandom[i] = new Random().Next(-100,100);
    
    if (i%2 != 0) sum += arrayrandom[i];
    
}
Console.WriteLine($"случайный массив: [{String.Join("; ", arrayrandom)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
