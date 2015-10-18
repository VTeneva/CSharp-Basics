using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VoteForMe
{
    static void Main()
    {
        int candidates = int.Parse(Console.ReadLine());
        int population = int.Parse(Console.ReadLine());

        string[] candidatesNames = new string[candidates];
        int[] votesForCandidates = new int[candidates];
        int votes = 0;

        for (int i = 0; i < candidates; i++)
        {
            candidatesNames[i] = Console.ReadLine();
            votesForCandidates[i] = int.Parse(Console.ReadLine());
            votes += votesForCandidates[i];
        }        

        // Output
        for (int i = 0; i < candidates; i++)
        {
            Console.WriteLine("{0} has {1:F2}%.", candidatesNames[i], (double) votesForCandidates[i] / population * 100);
        }

        int winner = Array.IndexOf(votesForCandidates, votesForCandidates.Max());
        Console.WriteLine("The new mayor is {0} - {1:F2}%.", candidatesNames[winner], (double) votesForCandidates[winner] / population * 100);

        Console.WriteLine("{0:F2}% of the population didn't vote.", (double) (population - votes) / population * 100);
    }
}

