using System;
using deepsearch.Quests;
using deepsearch.Utilities;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph minhaClasse = new Graph();
            QueenProblem queenProblem = new QueenProblem();
            queenProblem.Resolver(int.Parse(args[0]));
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
