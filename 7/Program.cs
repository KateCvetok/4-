// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int[] array = new int[6];
for ( int i = 0;i<6; i++)
    array[i] = new Random().Next(0, 100);
Console.WriteLine ("Ваш массив ");

for ( int i = 0;i<6; i++)
    Console.WriteLine ($"{array[i]} ");
    Console.WriteLine();

    int a = 0;
    double min = array [a];
    double max = array [a];
for ( int i = 0;i<6; i++)
    if (max < array[i])
        {
            max = array[i];
        }
    else if  (min>array[i])
    {
        min=array[i];
    }
Console.WriteLine ($"Минимальное значение {min}, максимальное {max}");
Console.WriteLine ($"Разница между {max} и {min} = {max-min}");