using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
  public static class TreeIntersection
  {
    public static HashSet<int> FindCommonValues(BinaryTree tree1, BinaryTree tree2)
    {
      HashSet<int> values1 = tree1.GetValues();
      HashSet<int> values2 = tree2.GetValues();
      HashSet<int> commonValues = new HashSet<int>();

      foreach (int value in values1)
      {
        if (values2.Contains(value))
        {
          commonValues.Add(value);
        }
      }

      return commonValues;
    }
  }
}
