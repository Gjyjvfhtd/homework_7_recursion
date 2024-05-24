// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] numbers = { -4, -3, -2, -1,0, 1, 2, 3, 4 };
int LenArray = numbers.Length - 1;

void ExpandTheArray(int[] array, int iter)
{
    if (iter < 0)
    {
        return;
    }
    Console.Write(array[iter] + "\t");
    iter --;
    ExpandTheArray(array, iter);
}

ExpandTheArray(numbers, LenArray);