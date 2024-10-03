using System;
using deepsearch.Quests;
using deepsearch.Utilities;

using deepsearch.Quests.Fuzzy;
namespace ConsoleAppExample
{
    class Program
    {
        // PROBLEMA DAS N RAINHAS
        // static void Main(string[] args)
        // {
        //     Graph minhaClasse = new Graph();
        //     QueenProblem queenProblem = new QueenProblem();
        //     queenProblem.Resolver(int.Parse(args[0]));
        //     Console.WriteLine("Pressione qualquer tecla para sair...");
        //     Console.ReadKey();
        // }


        // FUZZY
        
        static void Main(string[] args)
        {
            // var _service = new FuzzyService();
            var _usuario = FuzzyService.InscreverUsuario();
            // var _filmes = FuzzyFactory.GerarFilmes();   
            FuzzyService.SelecionarFilmes(_usuario, 5);
            // FuzzyService.recomendarFilme(_usuario, _filmes);
            
            

        }
    }
}
