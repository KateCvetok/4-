// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int size = 8;
int [] array = new int [size];
int S = 1;
int j = array.Length -1;
int i = 0;
for (i=0; i<array.Length; i++)

    array [i] = new Random().Next(1,10);
    Console.WriteLine ("Ваш массив: ");

for (i=0; i<array.Length; i++)
    Console.Write ($"{array[i]}");

for (i=0; i<=j; i++)
{
    S = array [i] * array [j];
    Console.WriteLine();
    Console.WriteLine($"{array[i]} * {array[j]} = {S}");
    j--;
}
