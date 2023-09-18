using static System.Math;
int x, y, num;

do
{
    Console.WriteLine("1) Сложение");
    Console.WriteLine("2) Вычетание");
    Console.WriteLine("3) Умножение");
    Console.WriteLine("4) Деление");
    Console.WriteLine("5) Возведение в степень");
    Console.WriteLine("6) Корень числа");
    Console.WriteLine("7) 1 процент от числа");
    Console.WriteLine("8) Факториал числа");
    Console.WriteLine("9) Выйти из программы");
    Console.WriteLine("Выберите операцию:");

    num = Convert.ToInt32(Console.ReadLine());
    if (num == 1)
    {
        Console.WriteLine("Введите 1 число:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x + y);
    }
    else if (num == 2)
    {
        Console.WriteLine("Введите 1 число:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x - y);
    }
    else if (num == 3)
    {
        Console.WriteLine("Введите 1 число:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x * y);
    }
    else if (num == 4)
    {
        double c, d;
        Console.WriteLine("Введите 1 число:");
        c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите 2 число:");
        d = Convert.ToDouble(Console.ReadLine());
        while (d == 0)
        {
            Console.WriteLine("Извините, но деление на ноль неосуществимо, попробуйте снова.");
            break;
        }
        Console.WriteLine(c / d);
    }
    else if (num == 5)
    {
        Console.WriteLine("Введите 1 число:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите 2 число:");
        y = Convert.ToInt32(Console.ReadLine());
        Math.Pow(x, y);
        Console.WriteLine(Math.Pow(x, y));
    }
    else if (num == 6)
    {
        Console.WriteLine("Введите число:");
        double d = Convert.ToInt32(Console.ReadLine());
        d = Sqrt(d);
        Console.WriteLine(d);
    }
    else if (num == 7)
    {
        Console.WriteLine("Введите число:");
        float n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n / 100);
    }
    else if (num == 8)
    {
        Console.WriteLine("Введите число:");
        num = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }

} while (num != 9);