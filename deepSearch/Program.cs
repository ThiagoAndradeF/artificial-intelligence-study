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
            
            // minhaClasse.Test();
            // minhaClasse.TestDFS();
            queenProblem.Resolver();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();



        }
    }
}
