using System;


class Concerts
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        int local = int.Parse(Console.ReadLine());
        int intern = int.Parse(Console.ReadLine());
        decimal priceLocal = decimal.Parse(Console.ReadLine());
        decimal priceIntern = decimal.Parse(Console.ReadLine());

        decimal savings = n * m * 0.10M;
        decimal localsMoneySpent = local * priceLocal;
        decimal internMoneySpent = intern * priceIntern;

        decimal beerMoney = savings - (localsMoneySpent + internMoneySpent);
        bool canGo = beerMoney >= 0;

        if (canGo)
        {
            Console.WriteLine("You'll have enough money. And you'll have {0:F2} for beers.", beerMoney);
        }
        else { Console.WriteLine("You should work {0} extra day(s). You need {1:F2}.", Math.Ceiling(-beerMoney/m), -beerMoney);  }
    }
}
