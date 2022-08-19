// Ввести массив вещественных чисел, найти разницу между максимальным и минимальным элементами массива
double [] arrayrandom = new double [10];
double max=arrayrandom[1];
double min=arrayrandom[1];
for (int i = 0; i < arrayrandom.Length; i++)
{
    arrayrandom[i] = new Random().Next(-100,100);
        if (arrayrandom[i] > max)
    {
        max = arrayrandom[i];
    }
   if (arrayrandom[i] < min)
   {
    min = arrayrandom[i];
   }
    
}
Console.WriteLine($"массив вещественных чисел: [{String.Join("; ", arrayrandom)}]");
Console.WriteLine($"Разница между максимальным  минимальным элементами: {(max-min)}");
