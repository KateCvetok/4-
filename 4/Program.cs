//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int i=0;


for (i = 0;i<123; i++)
{
    array[i] = new Random().Next(0, 123);
    Console.WriteLine (array[i]);
}
Console.WriteLine();
int A = 10;
int B = 99;
int k = 1; // количество элементов
for ( i = 0;i<123; i++)
{
    if ((array[i] >=A) && (array[i]<=B))
    k++;
}
Console.WriteLine ($"Количество элементов из отрезка [10,99] {k}");
