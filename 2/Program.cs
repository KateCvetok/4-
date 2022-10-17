//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
 int[] array = new int [12];

 int sum = 0;
 int sum1 = 0;
 for ( int i = 0;i<12; i++)
{
 array[i] = new Random().Next(0,9);

}
Console.WriteLine ("Ваш массив: ");
 for ( int i = 0;i<12; i++)

    Console.Write ($"{array[i]} ");

 for ( int i = 0;i<12; i++)
{
    if (array[i]>=0)
     sum = sum + array[i];
else
sum1 = sum1 + array[i];
}

Console.WriteLine ($"Сумма положительных чисел равна {sum}, а отрицательных {sum1}");