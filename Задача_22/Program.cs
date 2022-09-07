// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 → 1, 4, 9, 16, 25; 2 → 1,4

while (true) // зацикливание программы
{
    Console.WriteLine();
    Console.WriteLine("Введите число 'q' для входа ");
    ConsoleKeyInfo digit = Console.ReadKey(); 
    Console.WriteLine();

    int iDigit = digit.KeyChar - '0';

    double[] arrey = new double[iDigit + 1];
    if (iDigit > 0 && iDigit < 10)
    {

        for (int step = 1; step <= iDigit; step++)
        {
            arrey[step] = Math.Pow(step, 2);
            Console.Write($"{arrey[step]} ");
        }
    
    }
    else if (digit.KeyChar == 'q') // Выход из while
    {
        Console.WriteLine("Приходите ещё!");
        break;
    }
    else
    {
        Console.WriteLine("Ошибочка!");
    }
}
