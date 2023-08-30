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


      //Console.WriteLine("Insertion Sort : ");
      //Console.WriteLine();

      //Console.WriteLine("Example1: " + string.Join(", ", random1));
      //Console.WriteLine("Example2: " + string.Join(", ", reverseSorted1));
      //Console.WriteLine("Example3: " + string.Join(", ", fewUniques1));
      //Console.WriteLine("Example4: " + string.Join(", ", nearlySorted1));

      //Console.WriteLine();
      //Console.WriteLine("*********************************************");
      Console.WriteLine("Merge Sort : ");
      Console.WriteLine();


      Console.WriteLine("Example1: " + string.Join(", ", MergeSort(random)));
      Console.WriteLine("Example2: " + string.Join(", ", MergeSort(reverseSorted)));
      Console.WriteLine("Example3: " + string.Join(", ", MergeSort(fewUniques)));
      Console.WriteLine("Example4: " + string.Join(", ", MergeSort(nearlySorted)));
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



    public static int[] MergeSort(int[] arr)
    {
      int n = arr.Length;

      if (n > 1)
      {
        int mid = n / 2;
        int[] left = new int[mid];
        int[] right = new int[n - mid];

        for (int i = 0; i < n; i++)
        {
          if (i < mid)
          {
            left[i] = arr[i];
          }
          else
          {
            right[i - mid] = arr[i];
          }
        }

        MergeSort(left);
        MergeSort(right);
        Merge(left, right, arr);
      }

      return arr;
    }


    static void Merge(int[] left, int[] right, int[] arr)
    {
      int i = 0;
      int j = 0;
      int k = 0;

      while (i < left.Length && j < right.Length)
      {
        if (left[i] <= right[j])
        {
          arr[k] = left[i];
          i++;
        }
        else
        {
          arr[k] = right[j];
          j++;
        }
        k++;
      }

      if (i == left.Length)
      {
        while (j < right.Length)
        {
          arr[k] = right[j];
          j++;
          k++;
        }
      }
      else
      {
        while (i < left.Length)
        {
          arr[k] = left[i];
          i++;
          k++;
        }

      }
    }


  }

}
