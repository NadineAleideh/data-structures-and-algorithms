using graphs;

namespace testGraph
{
  public class UnitTest1
  {
    [Fact]
    public void Test_AddVertex()
    {
      // Arrange
      var graph = new Graph();

      // Act
      graph.AddVertex("A");
      graph.AddVertex("B");

      // Assert
      Assert.Equal(2, graph.Size());
      Assert.Contains("A", graph.GetVertices());
      Assert.Contains("B", graph.GetVertices());
    }

    [Fact]
    public void Test_AddEdge()
    {
      // Arrange
      var graph = new Graph();
      graph.AddVertex("A");
      graph.AddVertex("B");

      // Act
      graph.AddEdge("A", "B", 2);

      // Assert
      var neighborsOfA = graph.GetNeighbors("A").ToList();
      var neighborsOfB = graph.GetNeighbors("B").ToList();

      Assert.Single(neighborsOfA);
      Assert.Single(neighborsOfB);
      Assert.Equal("B", neighborsOfA[0].Item1);
      Assert.Equal("A", neighborsOfB[0].Item1);
      Assert.Equal(2, neighborsOfA[0].Item2);
      Assert.Equal(2, neighborsOfB[0].Item2);
    }

    [Fact]
    public void Test_GetVertices()
    {
      // Arrange
      var graph = new Graph();
      graph.AddVertex("A");
      graph.AddVertex("B");
      graph.AddVertex("C");

      // Act
      var vertices = graph.GetVertices();

      // Assert
      Assert.Equal(3, vertices.Count());
      Assert.Contains("A", vertices);
      Assert.Contains("B", vertices);
      Assert.Contains("C", vertices);
    }

    [Fact]
    public void Test_GetNeighbors()
    {
      // Arrange
      var graph = new Graph();
      graph.AddVertex("A");
      graph.AddVertex("B");
      graph.AddEdge("A", "B", 2);

      // Act
      var neighborsOfA = graph.GetNeighbors("A").ToList();
      var neighborsOfB = graph.GetNeighbors("B").ToList();

      // Assert
      Assert.Single(neighborsOfA);
      Assert.Single(neighborsOfB);
      Assert.Equal("B", neighborsOfA[0].Item1);
      Assert.Equal("A", neighborsOfB[0].Item1);
      Assert.Equal(2, neighborsOfA[0].Item2);
      Assert.Equal(2, neighborsOfB[0].Item2);
    }

    [Fact]
    public void Test_Size()
    {
      // Arrange
      var graph = new Graph();
      graph.AddVertex("A");
      graph.AddVertex("B");

      // Act
      var size = graph.Size();

      // Assert
      Assert.Equal(2, size);
    }
  }
}
