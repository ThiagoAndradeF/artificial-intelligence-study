namespace deepsearch.Repository;
public class Filme{
    public int faixaEtareaMinima{get;set;}
    public List<GeneroFilme> generos{get;set;}
    public List<Atores> elenco{get;set;}

    public int tempoAssistidoEmMinutos{get;set;}
    public int tempoLancamento{get;set;}
}
public class Usuario{ 
    public List<Filme> filmesAssistidos{get;set;}
    public int idade {get;set;}
    public GeneroPessoa idade {get;set;}

}
public class Atores{
    public int id{get;set}
    public int idade{get;set;}
}

public enum GeneroFilme
{
    Acao = 1,
    Aventura = 2,
    Comedia = 3,
    Drama = 4,
    Fantasia = 5,
    FiccaoCientifica = 6,
    Suspense = 7,
    Terror = 8,
    Romance = 9,
    Animacao = 10,
    Musical = 11,
    Documentario = 12,
    Policial = 13,
    Biografia = 14,
    Guerra = 15,
    Faroeste = 16,
    Esporte = 17
}
public enum GeneroPessoa
{
    Masculino = 1,
    Feminino = 2,
}
