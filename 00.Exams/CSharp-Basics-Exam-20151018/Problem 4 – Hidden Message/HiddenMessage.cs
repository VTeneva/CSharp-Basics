using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HiddenMessage
{
    static void Main()
    {
        string input = Console.ReadLine();

        int inputSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            inputSum += (int)input[i];
        }

        int key = SumDigits(inputSum);
        int step = 0;

        switch ((int) Math.Ceiling((decimal) key / 3)) 
        {
            case 1: step = 2; break;
            case 2: step = 3; break;
            case 3: step = 4; break;
            default:
                break;
        }

        List<char> output = new List<char>();

        for (int i = 0; i < input.Length; i += step)
        {
            output.Add(input[i]);
        }
      
        Console.WriteLine(string.Join("", output));
    }

    static int SumDigits(int number)
    {
        int digitSum = 0;

        for (int i = 0; i < number.ToString().Length; i++)
        {
            digitSum += int.Parse(number.ToString()[i].ToString());
        }

        if (digitSum.ToString().Length > 1)
        {
            return SumDigits(digitSum);
        }
        else
        {
            return digitSum;
        }       
    }
}

