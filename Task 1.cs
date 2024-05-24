// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNumbersFromTwoValues (int first, int second)
{
    if (first == second)
    {
        Console.Write(second + "\t");
    }
    if (first > second)
    {
        Console.Write(first + "\t");
        first --;
        PrintNaturalNumbersFromTwoValues (first, second);
    }
    if (first < second)
    {
        Console.Write(first + "\t");
        first ++;
        PrintNaturalNumbersFromTwoValues (first, second);
    }
}

PrintNaturalNumbersFromTwoValues (M, N);