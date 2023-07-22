using System;
using System.Collections.Generic;


namespace DataStructures
{
  public class AnimalShelter
  {
    public Queue<Animal> dogs;
    public Queue<Animal> cats;

    public AnimalShelter()
    {
      dogs = new Queue<Animal>();
      cats = new Queue<Animal>();
    }

    public void Enqueue(Animal animal)
    {
      if (animal.Species == "dog")
      {
        dogs.Enqueue(animal);
      }
      else if (animal.Species == "cat")
      {
        cats.Enqueue(animal);
      }
      else
      {
        throw new ArgumentException("Invalid species. Only 'dog' or 'cat' is allowed.");
      }
    }

    public Animal Dequeue(string pref)
    {
      if (pref == "dog")
      {
        return dogs.Count > 0 ? dogs.Dequeue() : null;
      }
      else if (pref == "cat")
      {
        return cats.Count > 0 ? cats.Dequeue() : null;
      }
      else
      {
        return null; // If pref is neither "dog" nor "cat", return null.
      }
    }

    public Animal DequeueAny()
    {
      if (dogs.Count == 0 && cats.Count == 0)
      {
        return null;
      }
      else if (dogs.Count == 0)
      {
        return cats.Dequeue();
      }
      else if (cats.Count == 0)
      {
        return dogs.Dequeue();
      }
      else
      {
        // If both queues have animals, return the one that has been waiting longer (based on timestamp).
        return dogs.Peek().TimeStamp <= cats.Peek().TimeStamp ? dogs.Dequeue() : cats.Dequeue();
      }
    }
  }

}
