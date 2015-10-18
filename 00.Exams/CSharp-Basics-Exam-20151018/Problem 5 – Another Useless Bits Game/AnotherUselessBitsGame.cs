using System;


class AnotherUselessBitsGame
{
    static void Main()
    {
        string line = Console.ReadLine();
        int bitsCount = 0;
        long sum = 0;

        while (line != "end")
        {
            long n = long.Parse(line);
            int bitsOne = 0;

            for (int i = 0; i < Convert.ToString(n, 2).Length; i++)
            {
                if ((n & (1 << i)) >> i == 1)
                {
                    bitsOne++;
                }
            }

            if (bitsOne % 2 == 0)
            {
                for (int i = 0; i < bitsOne; i++)
                {
                    n = n ^ (1 << i);
                }
            }
            else
            {
                n = n << 1;
            }

            int bitsOneFinal = 0;
            for (int i = 0; i < Convert.ToString(n, 2).Length; i++)
            {
                if ((n & (1 << i)) >> i == 1)
                {
                    bitsOneFinal++;
                }
            }

            bitsCount += bitsOneFinal;
            sum += n;

            line = Console.ReadLine();
        }

        Console.WriteLine(sum);
        Console.WriteLine(bitsCount);
    }
}

