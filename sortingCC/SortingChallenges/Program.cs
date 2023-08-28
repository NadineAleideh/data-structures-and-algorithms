namespace SortingChallenges
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] random = { 8, 4, 23, 42, 16, 15 };
      int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
      int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
      int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

      int[] random1 = InsertionSort(random);
      int[] reverseSorted1 = InsertionSort(reverseSorted);
      int[] fewUniques1 = InsertionSort(fewUniques);
      int[] nearlySorted1 = InsertionSort(nearlySorted);


      Console.WriteLine("Insertion Sort : ");

      Console.WriteLine("Example1: " + string.Join(", ", random1));
      Console.WriteLine("Example1: " + string.Join(", ", reverseSorted1));
      Console.WriteLine("Example1: " + string.Join(", ", fewUniques1));
      Console.WriteLine("Example3: " + string.Join(", ", nearlySorted1));
    }

    static public int[] InsertionSort(int[] arr)
    {
      int key, j;
      int n = arr.Length;

      for (int i = 1; i < n; i++)
      {
        key = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
          arr[j + 1] = arr[j];
          j--;
        }

        arr[j + 1] = key;
      }

      return arr;
    }


  }

}
