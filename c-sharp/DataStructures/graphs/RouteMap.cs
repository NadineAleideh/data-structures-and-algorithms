using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs
{
  public class RouteMap
  {
    public Dictionary<string, Dictionary<string, int>> graph;


    public RouteMap()
    {
      graph = new Dictionary<string, Dictionary<string, int>>();
    }

    public void AddRoute(string source, string destination, int cost)
    {
      if (!graph.ContainsKey(source))
      {
        graph[source] = new Dictionary<string, int>();
      }
      graph[source][destination] = cost;
    }

    public int GetCost(string source, string destination)
    {
      if (graph.ContainsKey(source) && graph[source].ContainsKey(destination))
      {
        return graph[source][destination];
      }
      return -1; // Return -1 if the route is not found
    }
  }
}
