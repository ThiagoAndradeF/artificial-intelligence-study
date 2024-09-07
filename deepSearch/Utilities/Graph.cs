using System;
using System.Collections.Generic;
namespace deepsearch.Utilities;
class Graph
{
    // Dicionário que representa a lista de adjacência
    private Dictionary<int, List<int>> adjList;

    // Construtor para inicializar o grafo
    public Graph()
    {
        adjList = new Dictionary<int, List<int>>();
    }

    // Método para adicionar um vértice
    public void AddVertex(int vertex)
    {
        if (!adjList.ContainsKey(vertex))
        {
            adjList[vertex] = new List<int>();
            Console.WriteLine($"Vértice {vertex} adicionado ao grafo.");
        }
        else
        {
            Console.WriteLine($"O vértice {vertex} já existe.");
        }
    }

    // Método para adicionar uma aresta (não direcionada)
    public void AddEdge(int source, int destination)
    {
        if (!adjList.ContainsKey(source))
        {
            AddVertex(source);
        }

        if (!adjList.ContainsKey(destination))
        {
            AddVertex(destination);
        }

        adjList[source].Add(destination);
        adjList[destination].Add(source); // Grafo não direcionado
        Console.WriteLine($"Aresta entre {source} e {destination} adicionada.");
    }

    // Método para imprimir o grafo
    public void PrintGraph()
    {
        foreach (var vertex in adjList)
        {
            Console.Write($"Vértice {vertex.Key}: ");
            foreach (var neighbor in vertex.Value)
            {
                Console.Write(neighbor + " ");
            }
            Console.WriteLine();
        }
    }

    // Método para verificar se há uma aresta entre dois vértices
    public bool HasEdge(int source, int destination)
    {
        if (adjList.ContainsKey(source) && adjList[source].Contains(destination))
        {
            return true;
        }
        return false;
    }

    // Método para remover uma aresta
    public void RemoveEdge(int source, int destination)
    {
        if (adjList.ContainsKey(source) && adjList[source].Contains(destination))
        {
            adjList[source].Remove(destination);
            adjList[destination].Remove(source); // Remover dos dois lados
            Console.WriteLine($"Aresta entre {source} e {destination} removida.");
        }
        else
        {
            Console.WriteLine($"Aresta entre {source} e {destination} não existe.");
        }
    }

    // Método para remover um vértice
    public void RemoveVertex(int vertex)
    {
        if (adjList.ContainsKey(vertex))
        {
            // Remover todas as arestas associadas ao vértice
            foreach (var neighbor in adjList[vertex])
            {
                adjList[neighbor].Remove(vertex);
            }
            adjList.Remove(vertex);
            Console.WriteLine($"Vértice {vertex} removido.");
        }
        else
        {
            Console.WriteLine($"Vértice {vertex} não existe.");
        }
    }

    // Método principal para testar o grafo
   public void Test()
    {
        Graph graph = new Graph();

        // Adicionando vértices e arestas
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(3, 4);

        // Imprimindo o grafo
        Console.WriteLine("Grafo:");
        graph.PrintGraph();

        // Verificar se há aresta
        Console.WriteLine($"\nHá aresta entre 0 e 1? {graph.HasEdge(0, 1)}");

        // Remover uma aresta
        graph.RemoveEdge(1, 2);
        Console.WriteLine("\nGrafo após remover a aresta entre 1 e 2:");
        graph.PrintGraph();

        // Remover um vértice
        graph.RemoveVertex(3);
        Console.WriteLine("\nGrafo após remover o vértice 3:");
        graph.PrintGraph();
    }
}
