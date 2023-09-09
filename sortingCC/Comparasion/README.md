# Movie Sorting Challenge

## Introduction

Welcome to the Movie Sorting Challenge! In this coding challenge, you will be tasked with sorting a list of movie objects based on different criteria such as release year and title. You'll also write tests to ensure your sorting functions work correctly.

## Challenge Description

You are provided with a list of movie objects, where each movie has the following attributes:

- `Title`: A string representing the title of the movie.
- `Year`: An integer representing the release year of the movie.
- `Genres`: A list of strings representing the genres of the movie.

You need to implement two sorting functions:

1. `SortMoviesByYear`: This function should sort the movies in descending order of release year, i.e., from the most recent year to the oldest.

2. `SortMoviesByTitle`: This function should sort the movies alphabetically by title. However, it should ignore leading articles such as "A," "An," or "The" when comparing titles so I used a Helper Function to do this.


After sorting by year descending, the movies should be ordered from the most recent year to the oldest year. After sorting by title, the movies should be ordered alphabetically, with leading articles ignored.

## Code

In the repository, you will find the code [here](../SortingChallenges/Program.cs).


## Testing

In the repository, you will find a test file [here](../SortingChallengesTest/MovieSortingTests.cs). where you can write your test cases.

