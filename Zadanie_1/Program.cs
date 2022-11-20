//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
double[] GetArrayOfNumbers()
{
    Console.WriteLine("Введите 3 числа через пробел: ");
    string UserMassive = Console.ReadLine();

    double[] numbers = UserMassive.Split(' ').Select(double.Parse).ToArray();
  
    return numbers;
}

int CountPositiveNumbers(double[] array)
{
    int posNumbers = 0;
    foreach (double el in array)
    {
        if (el > 0) posNumbers++;
    }
    Console.WriteLine($"Положительных чисел {posNumbers}.");
    return posNumbers;
}

Console.WriteLine();
CountPositiveNumbers(GetArrayOfNumbers());