using System;

namespace DataStructures
{
  public class Animal
  {
    public string Name { get; set; }
    public string Species { get; set; }
    public DateTime TimeStamp { get; set; } // Adding timestamp property
    public Animal(string species, string name)
    {
      Species = species;
      Name = name;
      TimeStamp = DateTime.Now; // Setting the timestamp to the current time during creation
    }
  }
}
