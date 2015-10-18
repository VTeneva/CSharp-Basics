using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DrawMeACat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < Math.Ceiling((double)n / 2); i++)
        {
            Console.Write(new string('.', n - i));
            Console.Write(new string('*', 1 + i * 2));
            Console.Write(new string('.', Math.Max(0, n - 2 * i) ));
            Console.Write(new string('*', 1 + i * 2));
            Console.WriteLine(new string('.', n - i));
        }

        // 2 rows before nose
        for (int i = (int) Math.Ceiling((double)n / 2) - 1; i > 0; i--)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('*', (3 * n + 2) - (2 * i) ));
            Console.WriteLine(new string('.', i));
        }

        // Nose line
        Console.Write(new string ('*', (3 * n + 2) / 2));
        Console.Write('O');
        Console.WriteLine(new string('*', (3 * n + 2) / 2));

        for (int i = 1; i <= n; i += 2)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('*', (3 * n + 2) - 2 * i ));
            Console.WriteLine(new string('.', i));
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string('.', n + 1));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', n + 1));
        }
    }
}

