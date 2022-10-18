// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[7];
int n = 0; // количество элементов, стоящих на нечетной позиции
int sum =0 ;
int i = 0;
for ( i = 0;i<7; i++)
    array[i] = new Random().Next(0, 100);
Console.WriteLine ("Ваш массив ");

for ( i = 0;i<7; i++)
    Console.WriteLine ($"{array[i]} ");
    Console.WriteLine();

for ( i = 0;i<7; i++)
{
    if (i % 2 ==0)
    {
        n++;
    }
    else if (i % 2 !=0)
    sum = array[i]+sum;
}

Console.WriteLine ($"Количество элементов, стоящих на нечетной позиции {n} ");
Console.WriteLine ($"Сумма элементов, стоящих на нечетной позиции {sum} ");