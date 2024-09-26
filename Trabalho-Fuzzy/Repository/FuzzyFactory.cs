namespace deepsearch.Repository; 

public class FuzzyFactory{
    string[] nomesAtores = new string[]
    {
        "Leonardo DiCaprio",
        "Joseph Gordon-Levitt",
        "Elliot Page",
        "Marlon Brando",
        "Al Pacino",
        "James Caan",
        "Keanu Reeves",
        "Laurence Fishburne",
        "Carrie-Anne Moss",
        "Kate Winslet",
        "Christian Bale",
        "Heath Ledger",
        "Michael Caine",
        "Elijah Wood",
        "Ian McKellen",
        "Orlando Bloom",
        "Matthew McConaughey",
        "Anne Hathaway",
        "Jessica Chastain",
        "Russell Crowe",
        "Joaquin Phoenix",
        "Connie Nielsen",
        "Robert Downey Jr.",
        "Chris Evans",
        "Scarlett Johansson",
        "Brad Pitt",
        "Edward Norton",
        "John Travolta",
        "Samuel L. Jackson",
        "Uma Thurman",
        "Song Kang-ho",
        "Lee Sun-kyun",
        "Cho Yeo-jeong",
        "Chris Pine",
        "Alec Baldwin",
        "Tom Hardy",
        "Charlize Theron",
        "Robert De Niro",
        "Sam Neill",
        "Laura Dern",
        "Jeff Goldblum",
        "Daniel Radcliffe",
        "Emma Watson",
        "Rupert Grint"
    };
    public List<Atores> GetAtores()
    {
        List<Atores> atores = new List<Atores>();
        for (int i = 0; i < nomesAtores.Length; i++)
        {
            atores.Add(new Atores
            {
                id = i,
                nome = nomesAtores[i],
            });
        }
        return atores;
    }
    

}
