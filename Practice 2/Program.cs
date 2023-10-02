using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Приветствую!");
        Console.WriteLine("Выберите номер программы, которую вы хотите запустить");
        Console.WriteLine("1. Игра - Угадай число");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Выход");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 1)
        {
            first();
        }
        else if (input == 2)
        {
            second();
        }
        else if (input == 3)
        {
            third();
        }
        else if (input == 4)
        {
            Console.WriteLine("До встречи!");
            close();
        }
    }
    static void first()
    {
      
        Console.WriteLine("Вы выбрали <<Игра - Угадай число>>");
        Random random = new Random();
        int a = random.Next(100);
        Console.WriteLine("Теперь попробуйте отгадать число в диапазоне от 0 до 100");
        int value = Convert.ToInt32(Console.ReadLine());
        while (value != a)
        {
            Console.WriteLine("Увы, но вы не угадали :)");
            value = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Ничоси, а как так-то? ПОЗДРАВЛЯЮ!");
        Console.WriteLine("Вот число, которое было рандомно сгенерировано:");
        Console.WriteLine(a);
        continueprogram();
    }

    static void second()
    {
        Console.WriteLine("Вы выбрали <<Таблица умножения>>");
        for (int y = 0; y <= 9; y++)
        {
            Console.Write(y + "\t");
            for (int x = 1; x <= 9; x++)
            {
                if (y > 0) Console.Write(y * x + "\t");
                else Console.Write(x + "\t");
            }
            Console.Write("\n");
        }
        Main();
    }

    static void third()
    {
        Console.WriteLine("Введите число для нахождения его делителей:");
        int i = Convert.ToInt32(Console.ReadLine());
        for (int a = 1; a <= i; a++)
        {
            if (i % a == 0) Console.Write("{0} ", a);
        }
        Console.WriteLine(" ");
        Main();
    }

    static void continueprogram()
    {
        {
            Console.WriteLine("Вы хотите продолжить? Да или Нет?");
            string a = Console.ReadLine();
            while (a == "Да")
            {
                Console.WriteLine("Продолжаем!");
                first();
            }
            while (a == "Нет")
            {
                Main();
            }
            
        }
    }

    static void close()
    {
        Environment.Exit(0);
    }


}