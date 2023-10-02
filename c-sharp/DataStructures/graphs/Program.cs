namespace graphs
{
  public class Program
  {
    static void Main(string[] args)
    {

      //var graph = new Graph();


      //graph.AddVertex("A");
      //graph.AddVertex("B");
      //graph.AddVertex("C");


      //graph.AddEdge("A", "B", 2);
      //graph.AddEdge("B", "C", 3);

      //var vertices = graph.GetVertices();
      //Console.WriteLine("All Vertices:");
      //foreach (var vertex in vertices)
      //{
      //  Console.WriteLine(vertex);
      //}


      //var neighborsOfA = graph.GetNeighbors("A");
      //Console.WriteLine("\nNeighbors of A:");
      //foreach (var neighbor in neighborsOfA)
      //{
      //  Console.WriteLine($"{neighbor.Item1} (Weight: {neighbor.Item2})");
      //}


      //var neighborsOfB = graph.GetNeighbors("B");
      //Console.WriteLine("\nNeighbors of B:");
      //foreach (var neighbor in neighborsOfB)
      //{
      //  Console.WriteLine($"{neighbor.Item1} (Weight: {neighbor.Item2})");
      //}


      //var graphSize = graph.Size();
      //Console.WriteLine($"\nGraph Size: {graphSize}");


      //var singleVertexGraph = new Graph();
      //singleVertexGraph.AddVertex("X");
      //singleVertexGraph.AddEdge("X", "X", 1);

      //Console.WriteLine("\nSingle Vertex Graph:");
      //Console.WriteLine($"Vertices: {singleVertexGraph.Size()}");
      //var neighborsOfX = singleVertexGraph.GetNeighbors("X");
      //Console.WriteLine("Neighbors of X:");
      //foreach (var neighbor in neighborsOfX)
      //{
      //  Console.WriteLine($"{neighbor.Item1} (Weight: {neighbor.Item2})");
      //}


      //cc36
      //var graph = new Graph();

      //// Add vertices and edges to the graph
      //graph.AddVertex("A");
      //graph.AddVertex("B");
      //graph.AddVertex("C");
      //graph.AddVertex("D");
      //graph.AddEdge("A", "B");
      //graph.AddEdge("A", "C");
      //graph.AddEdge("B", "D");

      //string startNode = "A"; // Specify the starting node for traversal

      //// Perform breadth-first traversal and display the result
      //var traversalResult = graph.BreadthFirstTraversal(startNode);

      //Console.WriteLine("Breadth-First Traversal:");
      //foreach (var node in traversalResult)
      //{
      //  Console.Write(node + " ");
      //}
      //Console.WriteLine();


      //C37


      var routeMap = new RouteMap();
      // Add routes to the route map
      routeMap.AddRoute("Metroville", "Pandora", 82);
      routeMap.AddRoute("Arendelle", "New Monstropolis", 115);
      routeMap.AddRoute("New Monstropolis", "Naboo", 150);

      // Test cases
      string[] itinerary1 = { "Metroville", "Pandora" };
      string[] itinerary2 = { "Arendelle", "New Monstropolis", "Naboo" };
      string[] itinerary3 = { "Naboo", "Pandora" };
      string[] itinerary4 = { "Narnia", "Arendelle", "Naboo" };

      Console.WriteLine("Input: [" + string.Join(", ", itinerary1) + "]");
      int? result1 = BusinessTrip(routeMap, itinerary1);
      Console.WriteLine("Output: " + (result1.HasValue ? "$" + result1 : "null"));
      Console.WriteLine();

      Console.WriteLine("Input: [" + string.Join(", ", itinerary2) + "]");
      int? result2 = BusinessTrip(routeMap, itinerary2);
      Console.WriteLine("Output: " + (result2.HasValue ? "$" + result2 : "null"));
      Console.WriteLine();

      Console.WriteLine("Input: [" + string.Join(", ", itinerary3) + "]");
      int? result3 = BusinessTrip(routeMap, itinerary3);
      Console.WriteLine("Output: " + (result3.HasValue ? "$" + result3 : "null"));
      Console.WriteLine();

      Console.WriteLine("Input: [" + string.Join(", ", itinerary4) + "]");
      int? result4 = BusinessTrip(routeMap, itinerary4);
      Console.WriteLine("Output: " + (result4.HasValue ? "$" + result4 : "null"));
    }



    //CC37
    public static int? BusinessTrip(RouteMap routeMap, string[] itinerary)
    {
      int totalCost = 0;

      for (int i = 0; i < itinerary.Length - 1; i++)
      {
        string source = itinerary[i];
        string destination = itinerary[i + 1];

        int cost = routeMap.GetCost(source, destination);

        if (cost == -1)
        {
          return null; // Direct flight not available, return null
        }

        totalCost += cost;
      }

      return totalCost;
    }


  }

}
