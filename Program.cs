using System;

class Program
{
    int[][] Notes = new int[][]
    {
        new int[] {262, 294, 330, 349, 392, 440, 494, 523, 587, 659},
        new int[] {523, 587, 659, 698, 784, 880, 988, 1046, 1175, 1319},
        new int[] {1046, 1175, 1319, 1397, 1568, 1760, 1976, 2093, 2349, 2637}
    };

    int[][] Sharp = new int[][]

    {
        new int[] {277, 311, 370, 415, 466},
        new int[] {554, 622, 740, 831, 932},
        new int[] {1109, 1245, 1480, 1661, 1865}
    };

    int Octave = 0;

    static void Main()
    {
        var program = new Program();
        program.Menu();
    }

    void Menu()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("Привет! Это пианино написанное на C#");
            Console.WriteLine("1. Играть");
            Console.WriteLine("2. Выйти");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    start();
                    break;
                case "2":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Такого действия нету, введите либо 1, либо 2.");
                    break;
            }
        }
    }

    void start()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key >= ConsoleKey.F1 && keyInfo.Key <= ConsoleKey.F3)
            {
                OctaveChange(keyInfo.Key - ConsoleKey.F1);
            }
            else if (keyInfo.Key >= ConsoleKey.A && keyInfo.Key <= ConsoleKey.L)
            {
                int frequency = Notes[Octave][keyInfo.Key - ConsoleKey.A];
                Sound(frequency, 300);
            }
            else if (keyInfo.Key >= ConsoleKey.Q && keyInfo.Key <= ConsoleKey.T)
            {
                int frequency = Sharp[Octave][keyInfo.Key - ConsoleKey.Q];
                Sound(frequency, 300);
            }
        }
    }
    void Sound(int frequency, int duration)
    {
        Console.Beep(frequency, duration);
    }
    void OctaveChange(int octave)
    {
        if (octave >= 0 && octave < Notes.Length)
        {
            Octave = octave;
            Console.WriteLine($"Октава: {Octave + 4}");
        }
    }

}