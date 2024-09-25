namespace deepsearch.Quests;

public class QueenProblem{
    private static int N = 8; // Tamanho do tabuleiro (8x8)

    // Função para imprimir o tabuleiro
    static void ImprimirTabuleiro(int[,] tabuleiro)
    {
        // Emojis para representar as casas e as rainhas
        string rainha = "👑";
        string quadradoBranco = "⬜";
        string quadradoPreto = "⬛";

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (tabuleiro[i, j] == 1)
                {
                    Console.Write(rainha + "");
                }
                else
                {
                    // Alterna entre branco e preto dependendo da posição
                    if ((i + j) % 2 == 0)
                        Console.Write(quadradoBranco + "");
                    else
                        Console.Write(quadradoPreto + "");
                }
            }
            Console.WriteLine();
        }
    }

    // Função para verificar se uma dama pode ser colocada na posição (linha, coluna)
    static bool VerificarSeguranca(int[,] tabuleiro, int linha, int coluna)
    {
        // Verifica a linha à esquerda
        for (int i = 0; i < coluna; i++)
        {
            if (tabuleiro[linha, i] == 1)
                return false;
        }

        // Verifica a diagonal superior à esquerda
        for (int i = linha, j = coluna; i >= 0 && j >= 0; i--, j--)
        {
            if (tabuleiro[i, j] == 1)
                return false;
        }

        // Verifica a diagonal inferior à esquerda
        for (int i = linha, j = coluna; i < N && j >= 0; i++, j--)
        {
            if (tabuleiro[i, j] == 1)
                return false;
        }
        return true;
    }

    // Função recursiva para resolver o problema das 8 damas
    // Função recursiva para resolver o problema das 8 damas
    static bool ResolverDamas(int[,] tabuleiro, int coluna, int primeiraLinha = 0)
    {
        // Caso base: se todas as damas foram colocadas, retorna verdadeiro
        if (coluna >= N)
            return true;
        // Tenta colocar uma dama em cada linha da coluna atual
        for (int i = primeiraLinha; i < N; i++)
        {
            // Verifica se a posição é segura
            if (VerificarSeguranca(tabuleiro, i, coluna))
            {
                // Coloca a dama
                tabuleiro[i, coluna] = 1;
                // Recursivamente tenta colocar as damas nas colunas restantes
                if (ResolverDamas(tabuleiro, coluna + 1))
                    return true;
                // Se não for possível, remove a dama (backtrack)
                tabuleiro[i, coluna] = 0;
            }
        }
        // Se não for possível colocar uma dama em nenhuma 
        // linha desta coluna, retorna falso
        return false;
    }

    public void Resolver(int n)
    {
        N=n;
        // Inicia o algoritmo
        for(int i = 0; i < N; i++)
        {
            var tabuleiro = new int[N, N];
            if (ResolverDamas(tabuleiro, 0, i))
            {
                Console.Clear();
                Console.WriteLine($"Solução para a dama na linha {i + 1}:");
                ImprimirTabuleiro(tabuleiro);
            }
            else
            {
                Console.WriteLine("Não existe solução.");
            }

            Task.Delay(1000).Wait();
            
        }
    }


}