using System.Collections;

namespace hashtable
{
  internal class Program
  {
    static void Main(string[] args)
    {
      HashTable hashTable = new HashTable(1024);


      hashTable.Set("name", "Nadine");
      hashTable.Set("age", "23");
      hashTable.Set("city", "Irbid");
      hashTable.Set("major", "developer");


      Node nameNode = hashTable.Get("name");
      Node ageNode = hashTable.Get("age");
      Node cityNode = hashTable.Get("city");
      Node majorNode = hashTable.Get("major");


      bool containsName = hashTable.Contains("name");
      bool containsCountry = hashTable.Contains("country");


      Console.WriteLine("Value for 'name': " + nameNode?.Value);
      Console.WriteLine("\nValue for 'age': " + ageNode?.Value);
      Console.WriteLine("\nValue for 'city': " + cityNode?.Value);
      Console.WriteLine("\nValue for 'major': " + majorNode?.Value);
      Console.WriteLine("\nContains 'name': " + containsName);
      Console.WriteLine("\nContains 'country': " + containsCountry);


      List<string> keys = hashTable.Keys();
      Console.WriteLine("\nAll Unique Keys:");
      foreach (var key in keys)
      {
        Console.WriteLine(key);
      }


    }
  }
}
