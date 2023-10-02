using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
  public class Graph
  {
    private Dictionary<string, List<(string, int)>> adjacencyList;

    public Graph()
    {
      adjacencyList = new Dictionary<string, List<(string, int)>>();
    }


    public void AddVertex(string value)
    {
      if (!adjacencyList.ContainsKey(value))
      {
        adjacencyList[value] = new List<(string, int)>();
      }
    }


    public void AddEdge(string source, string destination, int weight = 0)
    {
      if (!adjacencyList.ContainsKey(source) || !adjacencyList.ContainsKey(destination))
      {
        throw new InvalidOperationException("Both vertices should already be in the graph.");
      }

      adjacencyList[source].Add((destination, weight));
      adjacencyList[destination].Add((source, weight));
    }


    public IEnumerable<string> GetVertices()
    {
      return adjacencyList.Keys;
    }


    public IEnumerable<(string, int)> GetNeighbors(string vertex)
    {
      if (!adjacencyList.ContainsKey(vertex))
      {
        return new List<(string, int)>();
      }

      return adjacencyList[vertex];
    }


    public int Size()
    {
      return adjacencyList.Count;
    }



    //CC36

    public IEnumerable<string> BreadthFirstTraversal(string startNode)
    {
      if (!adjacencyList.ContainsKey(startNode))
      {
        throw new ArgumentException("Start node is not in the graph.");
      }

      var visited = new HashSet<string>();
      var result = new List<string>();
      var queue = new Queue<string>();

      visited.Add(startNode);
      queue.Enqueue(startNode);

      while (queue.Count > 0)
      {
        var currentNode = queue.Dequeue();
        result.Add(currentNode);

        foreach (var neighbor in adjacencyList[currentNode])
        {
          if (!visited.Contains(neighbor.Item1))
          {
            visited.Add(neighbor.Item1);
            queue.Enqueue(neighbor.Item1);
          }
        }
      }

      return result;
    }
  }
}
