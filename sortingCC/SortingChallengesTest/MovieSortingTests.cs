using SortingChallenges;



namespace SortingChallengesTest
{
  public class MovieSortingTests
  {

    [Fact]
    public void TestSortMoviesByYear()
    {
      // Arrange
      List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "The Matrix", Year = 1999 },
            new Movie { Title = "Avatar", Year = 2009 },
            new Movie { Title = "An Inception", Year = 2010 },
            new Movie { Title = "A Fiction", Year = 1994 }
        };


      // Act
      List<Movie> sortedMovies = Program.SortMoviesByYear(movies);

      // Assert
      Assert.Equal("An Inception", sortedMovies[0].Title);
      Assert.Equal("Avatar", sortedMovies[1].Title);
      Assert.Equal("The Matrix", sortedMovies[2].Title);
      Assert.Equal("A Fiction", sortedMovies[3].Title);
    }





    [Fact]

    public void TestSortMoviesByTitle()
    {
      // Arrange
      List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "The Matrix", Year = 1999 },
            new Movie { Title = "Avatar", Year = 2009 },
            new Movie { Title = "An Inception", Year = 2010 },
            new Movie { Title = "A Fiction", Year = 1994 }
        };

      List<Movie> sortedMovies = Program.SortMoviesByTitle(movies);

      Assert.Equal("Avatar", sortedMovies[0].Title);
      Assert.Equal("An Inception", sortedMovies[2].Title);
      Assert.Equal("A Fiction", sortedMovies[1].Title);
      Assert.Equal("The Matrix", sortedMovies[3].Title);
    }


  }
}
