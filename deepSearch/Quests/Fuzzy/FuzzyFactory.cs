namespace deepsearch.Quests.Fuzzy; 

public static class FuzzyFactory{
    static string[] nomesAtores = new string[]
    {
        "Leonardo DiCaprio",
        "Joseph Gordon-Levitt",
        "Elliot Page",
        "Marlon Brando",
        "Keanu Reeves",
        "Laurence Fishburne",
        "Christian Bale",
        "Heath Ledger",
        "Michael Caine",
        "Russell Crowe",
        "Joaquin Phoenix",
        "Robert Downey Jr.",
        "Brad Pitt",
    };
    public static List<Atores> GerarAtores()
    {
        List<Atores> atores = new List<Atores>();
        for (int i = 0; i < nomesAtores.Length; i++)
        {
            atores.Add(new Atores
            {
                id = i+1,
                nome = nomesAtores[i],
            });
        }
        return atores;
    }
    
    public static List<Filme> GerarFilmes(){
        var atores = GerarAtores();
        var filmes = new List<Filme>
        {
            new Filme
            {
                Nome = "0 - FECHAR",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Romance },
                elenco = new List<Atores> { atores.Where(a =>a.id == 1).FirstOrDefault()} // Leonardo DiCaprio

            },
            new Filme
            {
                Nome = "1 - Titanic",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Romance },
                elenco = new List<Atores> { atores.Where(a =>a.id == 1).FirstOrDefault()} // Leonardo DiCaprio
            },
            new Filme   
            {
                Nome = "2 - Inception",
                generos = new List<GeneroFilme> { GeneroFilme.FiccaoCientifica, GeneroFilme.Acao },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 0).FirstOrDefault(), // Leonardo DiCaprio
                    atores.Where(a =>a.id == 2).FirstOrDefault() // Elliot Page
                }
            },
            new Filme
            {
                Nome = "3 - The Revenant",
                generos = new List<GeneroFilme> { GeneroFilme.Aventura, GeneroFilme.Drama },
                elenco = new List<Atores> { atores.Where(a =>a.id == 2).FirstOrDefault() } // Leonardo DiCaprio
            },
            new Filme
            {
                Nome = "4 - Juno",
                generos = new List<GeneroFilme> { GeneroFilme.Comedia, GeneroFilme.Drama },
                elenco = new List<Atores> { atores.Where(a =>a.id == 2).FirstOrDefault()  } // Elliot Page
            },
            new Filme
            {
                Nome = "5 - The Godfather",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Policial },
                elenco = new List<Atores> { atores.Where(a =>a.id == 3).FirstOrDefault()  } // Marlon Brando
            },
            new Filme
            {
                Nome = "6 - The Matrix",
                generos = new List<GeneroFilme> { GeneroFilme.FiccaoCientifica, GeneroFilme.Acao },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 4).FirstOrDefault(),  // Keanu Reeves
                    atores.Where(a =>a.id == 5).FirstOrDefault()   // Laurence Fishburne
                }
            },
            new Filme
            {
                Nome = "7 - John Wick",
                generos = new List<GeneroFilme> { GeneroFilme.Acao, GeneroFilme.Suspense },
                elenco = new List<Atores> { atores.Where(a =>a.id == 4).FirstOrDefault()  } // Keanu Reeves
            },
            new Filme
            {
                Nome = "8 - Gladiator",
                generos = new List<GeneroFilme> { GeneroFilme.Acao, GeneroFilme.Drama },
                elenco = new List<Atores> { atores.Where(a =>a.id == 6).FirstOrDefault() } // Russell Crowe
            },
            new Filme
            {
                Nome = "9 - A Beautiful Mind",
                generos = new List<GeneroFilme> { GeneroFilme.Biografia, GeneroFilme.Drama },
                elenco = new List<Atores> {atores.Where(a =>a.id == 6).FirstOrDefault() } // Russell Crowe
            },
            new Filme
            {
                Nome = "10 - The Dark Knight",
                generos = new List<GeneroFilme> { GeneroFilme.Acao, GeneroFilme.Crime },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 1).FirstOrDefault() , // Leonardo DiCaprio
                    atores.Where(a =>a.id == 7).FirstOrDefault()   // Christian Bale
                }
            },
            new Filme
            {
                Nome = "11 - Joker",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Crime },
                elenco = new List<Atores> { atores.Where(a =>a.id == 8).FirstOrDefault() } // Joaquin Phoenix
            },
            new Filme
            {
                Nome = "12 - Fight Club",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Suspense },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 9).FirstOrDefault() , // Brad Pitt
                    atores.Where(a =>a.id == 10).FirstOrDefault()   // Edward Norton
                }
            },
            new Filme
            {
                Nome = "13 - The Prestige",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Suspense },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 7).FirstOrDefault() , // Christian Bale
                    atores.Where(a =>a.id == 11).FirstOrDefault() // Hugh Jackman
                }
            },
            new Filme
            {
                Nome = "14 - Her",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Romance, GeneroFilme.FiccaoCientifica },
                elenco = new List<Atores> { atores.Where(a =>a.id == 8).FirstOrDefault()  } // Joaquin Phoenix
            },
            new Filme
            {
                Nome = "15 - Once Upon a Time in Hollywood",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Comedia },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 9).FirstOrDefault() , // Brad Pitt
                    atores.Where(a =>a.id == 12).FirstOrDefault()  // Leonardo DiCaprio
                }
            },
            new Filme
            {
                Nome = "16 - 10 Things I Hate About You",
                generos = new List<GeneroFilme> { GeneroFilme.Comedia, GeneroFilme.Romance },
                elenco = new List<Atores> { atores.Where(a =>a.id == 13).FirstOrDefault() } // Heath Ledger
            },
           new Filme
            {
                Nome = "17 - 500 Days of Summer",
                generos = new List<GeneroFilme> { GeneroFilme.Comedia, GeneroFilme.Romance },
                elenco = new List<Atores> { atores.Where(a =>a.id == 2).FirstOrDefault()  } // Joseph Gordon-Levitt
            },
            new Filme
            {
                Nome = "18 - The Insider",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Biografia },
                elenco = new List<Atores> { atores.Where(a =>a.id == 6).FirstOrDefault() } // Russell Crowe
            },
            new Filme
            {
                Nome = "19 - Tropic Thunder",
                generos = new List<GeneroFilme> { GeneroFilme.Comedia, GeneroFilme.Acao },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 10).FirstOrDefault() , // Robert Downey Jr.
                    atores.Where(a =>a.id == 13).FirstOrDefault()    // Brad Pitt
                }
            },
            new Filme
            {
                Nome = "20 - The Aviator",
                generos = new List<GeneroFilme> { GeneroFilme.Biografia, GeneroFilme.Drama },
                elenco = new List<Atores> {atores.Where(a =>a.id == 1).FirstOrDefault()  } // Leonardo DiCaprio
            },
            new Filme
            {
                Nome = "21 - American Psycho",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Suspense },
                elenco = new List<Atores> { atores.Where(a =>a.id == 7).FirstOrDefault() } // Christian Bale
            },
            new Filme
            {
                Nome = "22 - Brokeback Mountain",
                generos = new List<GeneroFilme> { GeneroFilme.Drama, GeneroFilme.Romance },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 8).FirstOrDefault(),  // Heath Ledger
                    atores.Where(a =>a.id == 2).FirstOrDefault()  // Jake Gyllenhaal
                }
            },
            new Filme
            {
                Nome = "23 - Se7en",
                generos = new List<GeneroFilme> { GeneroFilme.Suspense, GeneroFilme.Crime },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 10).FirstOrDefault() , // Brad Pitt
                    atores.Where(a =>a.id == 14).FirstOrDefault()   // Morgan Freeman
                }
            },
            new Filme
            {
                Nome = "24 - The Cider House Rules",
                generos = new List<GeneroFilme> { GeneroFilme.Drama },
                elenco = new List<Atores> { atores.Where(a =>a.id == 6).FirstOrDefault() } // Michael Caine
            },
            new Filme
            {
                Nome = "25 - Alfie",
                generos = new List<GeneroFilme> { GeneroFilme.Comedia, GeneroFilme.Drama },
                elenco = new List<Atores> { atores.Where(a =>a.id == 6).FirstOrDefault() } // Michael Caine
            },
            new Filme
            {
                Nome = "26 - The Shawshank Redemption",
                generos = new List<GeneroFilme> { GeneroFilme.Drama },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 14).FirstOrDefault() , // Morgan Freeman
                    atores.Where(a =>a.id == 15).FirstOrDefault()   // Tim Robbins
                }
            },
            new Filme
            {
                Nome = "27 - Blade Runner 2049",
                generos = new List<GeneroFilme> { GeneroFilme.FiccaoCientifica, GeneroFilme.Drama },
                elenco = new List<Atores> 
                {
                    atores.Where(a =>a.id == 16).FirstOrDefault() , // Ryan Gosling
                    atores.Where(a =>a.id == 8).FirstOrDefault()   // Jared Leto
                }
            }
        };
        return filmes;
    }
}
