double InputNuber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = double.TryParse(Console.ReadLine() ?? "0", out double number);

        if (!result)
        {
            Console.WriteLine($"Некорректные данные. {message} ещё раз!");
            Thread.Sleep(1000);

            continue;
        }

        return number;
    }
}

double[] PointCrossing(double k1, double b1, double k2, double b2)
{
        double[] coords = new double[2];
        coords[0] = (b2 - b1) / (k1 - k2);
        coords[1] = k1 * coords[0] + b1;

        return coords;
}

void CrossingLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2) Console.Write($"Прямые совпадают.");
    else if (k1 == k2 && b1 != b2) Console.Write($"Прямые параллельны и не имеют точек пересечения.");
    else PrintCoords(PointCrossing(k1, b1, k2, b2));
}

void PrintCoords(double[] array)
{
    Console.Write($"Прямые пересекаются в точке с координатами: ({Math.Round(array[0], 2)}; {Math.Round(array[1], 2)}).");
}

double k1 = InputNuber("Введите k1: ");
double b1 = InputNuber("Введите b1: ");
double k2 = InputNuber("Введите k2: ");
double b2 = InputNuber("Введите b2: ");
CrossingLines(k1, b1, k2, b2);
Console.WriteLine();