// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

int CalculationAckermansFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else
    {
        if (secondNumber == 0)
        {
            return CalculationAckermansFunction(firstNumber - 1, 1);
        }
        else
        {
            return CalculationAckermansFunction(firstNumber - 1, CalculationAckermansFunction(firstNumber, secondNumber - 1));
        }
    }
}

Console.WriteLine(CalculationAckermansFunction(N, M));