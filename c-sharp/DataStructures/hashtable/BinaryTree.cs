using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable
{
  public class BinaryTree
  {
    public TreeNode Root { get; set; }

    public HashSet<int> GetValues()
    {
      HashSet<int> values = new HashSet<int>();
      GetValues(Root, values);
      return values;
    }

    private void GetValues(TreeNode node, HashSet<int> values)
    {
      if (node == null)
      {
        return;
      }

      values.Add(node.Value);
      GetValues(node.Left, values);
      GetValues(node.Right, values);
    }
  }
}
