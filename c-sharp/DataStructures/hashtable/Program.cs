using System.Collections;
using System.Text.RegularExpressions;

namespace hashtable
{
  public class Program
  {
    static void Main(string[] args)
    {
      //HashTable hashTable = new HashTable(1024);


      //hashTable.Set("name", "Nadine");
      //hashTable.Set("age", "23");
      //hashTable.Set("city", "Irbid");
      //hashTable.Set("major", "developer");


      //Node nameNode = hashTable.Get("name");
      //Node ageNode = hashTable.Get("age");
      //Node cityNode = hashTable.Get("city");
      //Node majorNode = hashTable.Get("major");


      //bool containsName = hashTable.Contains("name");
      //bool containsCountry = hashTable.Contains("country");


      //Console.WriteLine("Value for 'name': " + nameNode?.Value);
      //Console.WriteLine("\nValue for 'age': " + ageNode?.Value);
      //Console.WriteLine("\nValue for 'city': " + cityNode?.Value);
      //Console.WriteLine("\nValue for 'major': " + majorNode?.Value);
      //Console.WriteLine("\nContains 'name': " + containsName);
      //Console.WriteLine("\nContains 'country': " + containsCountry);


      //List<string> keys = hashTable.Keys();
      //Console.WriteLine("\nAll Unique Keys:");
      //foreach (var key in keys)
      //{
      //  Console.WriteLine(key);
      //}


      string input1 = "Once upon a time, there was a brave princess who...";
      string input2 =
          "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
      string input3 =
          "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";

      Console.WriteLine(RepeatedWord(input1)); // Output: "a"
      Console.WriteLine(RepeatedWord(input2)); // Output: "it"
      Console.WriteLine(RepeatedWord(input3)); // Output: "summer"

    }


    public static string RepeatedWord(string input)
    {
      // Split the input string into words using regular expressions
      string[] words = Regex.Split(input.ToLower(), @"\W+");

      HashSet<string> wordSet = new HashSet<string>();

      foreach (string word in words)
      {
        // If the word is already in the HashSet, it's a repeated word, return it
        if (wordSet.Contains(word))
        {
          return word;
        }

        // Otherwise, add the word to the HashSet
        wordSet.Add(word);
      }

      // If no repeated words are found, return an empty string
      return "";
    }
  }
}
