using System;
using deepsearch.Utilities;

namespace ConsoleAppExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe 'MinhaClasse'
            Graph minhaClasse = new Graph();
            
            // Chamando o método 'DizerOla' da classe 'MinhaClasse'
            minhaClasse.Test();
            
            // Mantém a janela do console aberta até pressionar uma tecla
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
