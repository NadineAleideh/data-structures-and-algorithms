using graphs;

namespace testGraph
{
  public class UnitTest1
  {
    //[Fact]
    //public void Test_AddVertex()
    //{
    //  // Arrange
    //  var graph = new Graph();

    //  // Act
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");

    //  // Assert
    //  Assert.Equal(2, graph.Size());
    //  Assert.Contains("A", graph.GetVertices());
    //  Assert.Contains("B", graph.GetVertices());
    //}

    //[Fact]
    //public void Test_AddEdge()
    //{
    //  // Arrange
    //  var graph = new Graph();
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");

    //  // Act
    //  graph.AddEdge("A", "B", 2);

    //  // Assert
    //  var neighborsOfA = graph.GetNeighbors("A").ToList();
    //  var neighborsOfB = graph.GetNeighbors("B").ToList();

    //  Assert.Single(neighborsOfA);
    //  Assert.Single(neighborsOfB);
    //  Assert.Equal("B", neighborsOfA[0].Item1);
    //  Assert.Equal("A", neighborsOfB[0].Item1);
    //  Assert.Equal(2, neighborsOfA[0].Item2);
    //  Assert.Equal(2, neighborsOfB[0].Item2);
    //}

    //[Fact]
    //public void Test_GetVertices()
    //{
    //  // Arrange
    //  var graph = new Graph();
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");
    //  graph.AddVertex("C");

    //  // Act
    //  var vertices = graph.GetVertices();

    //  // Assert
    //  Assert.Equal(3, vertices.Count());
    //  Assert.Contains("A", vertices);
    //  Assert.Contains("B", vertices);
    //  Assert.Contains("C", vertices);
    //}

    //[Fact]
    //public void Test_GetNeighbors()
    //{
    //  // Arrange
    //  var graph = new Graph();
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");
    //  graph.AddEdge("A", "B", 2);

    //  // Act
    //  var neighborsOfA = graph.GetNeighbors("A").ToList();
    //  var neighborsOfB = graph.GetNeighbors("B").ToList();

    //  // Assert
    //  Assert.Single(neighborsOfA);
    //  Assert.Single(neighborsOfB);
    //  Assert.Equal("B", neighborsOfA[0].Item1);
    //  Assert.Equal("A", neighborsOfB[0].Item1);
    //  Assert.Equal(2, neighborsOfA[0].Item2);
    //  Assert.Equal(2, neighborsOfB[0].Item2);
    //}

    //[Fact]
    //public void Test_Size()
    //{
    //  // Arrange
    //  var graph = new Graph();
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");

    //  // Act
    //  var size = graph.Size();

    //  // Assert
    //  Assert.Equal(2, size);
    //}


    //cc36
    //[Fact]
    //public void Test_BreadthFirstTraversal()
    //{
    //  // Arrange
    //  var graph = new Graph();
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");
    //  graph.AddVertex("C");
    //  graph.AddVertex("D");
    //  graph.AddEdge("A", "B");
    //  graph.AddEdge("A", "C");
    //  graph.AddEdge("B", "D");

    //  // Act
    //  var traversalResult = graph.BreadthFirstTraversal("A").ToList();

    //  // Assert
    //  Assert.Equal(4, traversalResult.Count);
    //  Assert.Equal("A", traversalResult[0]);
    //  Assert.Equal("B", traversalResult[1]);
    //  Assert.Equal("C", traversalResult[2]);
    //  Assert.Equal("D", traversalResult[3]);
    //}

    //[Fact]
    //public void Test_BreadthFirstTraversal_InvalidStartNode()
    //{
    //  // Arrange
    //  var graph = new Graph();
    //  graph.AddVertex("A");
    //  graph.AddVertex("B");

    //  // Act & Assert
    //  Assert.Throws<ArgumentException>(() => graph.BreadthFirstTraversal("C"));
    //}


    //cc37

    [Fact]
    public void Test_BusinessTrip_Valid()
    {
      var routeMap = new RouteMap();
      // Add routes to the route map
      routeMap.AddRoute("Metroville", "Pandora", 82);
      routeMap.AddRoute("Arendelle", "New Monstropolis", 115);
      routeMap.AddRoute("New Monstropolis", "Naboo", 150);

      string[] itinerary = { "Metroville", "Pandora" };
      int? result = Program.BusinessTrip(routeMap, itinerary);

      // Assert
      Assert.NotNull(result);
      Assert.Equal(82, result);
    }

    [Fact]
    public void Test_BusinessTrip_Invalid()
    {
      var routeMap = new RouteMap();
      // Add routes to the route map
      routeMap.AddRoute("Metroville", "Pandora", 82);
      routeMap.AddRoute("Arendelle", "New Monstropolis", 115);

      string[] itinerary = { "Metroville", "Naboo" };
      int? result = Program.BusinessTrip(routeMap, itinerary);

      // Assert
      Assert.Null(result);
    }

    [Fact]
    public void Test_BusinessTrip_EmptyItinerary()
    {
      var routeMap = new RouteMap();
      // Add routes to the route map
      routeMap.AddRoute("Metroville", "Pandora", 82);

      string[] itinerary = new string[0];
      int? result = Program.BusinessTrip(routeMap, itinerary);

      // Assert
      Assert.NotNull(result);
      Assert.Equal(0, result);
    }
  }
}
