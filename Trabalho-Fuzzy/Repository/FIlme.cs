public class Filme{
    public int faixaEtareaMinima{get;set;}
    public List<Genero> generos{get;set;}
    public List<Atores> elenco{get;set;}

    public int tempoAssistidoEmMinutos{get;set;}
    public int tempoLancamento{get;set;}
}
public class Genero{
    public string nome{get;set;}
    public int faixaEtarea{get;set;}
}
public class Atores{
    public int id{get;set}
    public int idade{get;set;}
}