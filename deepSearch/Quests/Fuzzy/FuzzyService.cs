using System;
using System.Collections.Generic;
using System.Linq;

namespace deepsearch.Quests.Fuzzy
{
    public class FuzzyService
    {
        public static Filme recomendarFilme(Usuario usuario, List<Filme> todosOsFilmes)
        {
            var filmesRecomendados = new List<(Filme filme, double pontuacao)>();

            foreach (var filme in todosOsFilmes)
            {
                double pontuacao = calcularPontuacao(usuario.filmesAssistidos, filme);
                filmesRecomendados.Add((filme, pontuacao));
            }
            var _result = filmesRecomendados.OrderByDescending(f => f.pontuacao).FirstOrDefault().filme;
            string _elencoFilme = "";    
            
            foreach (var item in _result.elenco)
            {
                _elencoFilme += item.nome + ", ";                
            }
            string _generoFilme = "";
            foreach (var item in _result.generos)
            {
                _generoFilme += item + "/ ";
            }
            Console.WriteLine(_result.Nome + " - Elencos: " + _generoFilme +  " - Atores: " + _elencoFilme);

            return _result;
        }

        private static double calcularPontuacao(List<Filme> filmesAssistidos, Filme filme)
        {
            double pontuacao = 0;

            foreach (var assistido in filmesAssistidos)
            {
                pontuacao += CompararGeneros(assistido.generos, filme.generos);
            }

            return pontuacao;
        }

        private static double CompararGeneros(List<GeneroFilme> generosAssistidos, List<GeneroFilme> generosFilme)
        {
            return generosAssistidos.Intersect(generosFilme).Count() * 1.0; // Aumente o peso se necessário
        }



        public static Usuario InscreverUsuario()
        {
            var usuario = new Usuario();
            usuario.filmesAssistidos = new List<Filme>();
            Console.Write("Informe sua idade: ");
            usuario.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha os filmes assistidos (digite o número, 0 para parar):");
            

            return usuario;
        }
        public static Usuario SelecionarFilmes(Usuario usuario, int numeroFilmesSelecao = 3, int numeroInicial = 0)
        {
            if(numeroInicial == numeroFilmesSelecao)
            {
                return usuario;
            }
            var filmes = FuzzyFactory.GerarFilmes();
            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Nome} - ({filme.generos[0]})");
            }
            Console.Write("Informe o número do filme: ");
            int numeroFilme = int.Parse(Console.ReadLine());
            if (numeroFilme == 0)
            {
                return usuario;
            }
            usuario.filmesAssistidos.Add(filmes[numeroFilme - 1]);
            recomendarFilme(usuario, filmes);
            return SelecionarFilmes(usuario,numeroFilmesSelecao ,numeroInicial +1);
        }
        

    }
}