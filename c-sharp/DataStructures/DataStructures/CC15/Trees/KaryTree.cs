using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
  public class KaryTree<T>
  {
    public TreeNode<T> Root { get; set; }

    public KaryTree()
    {
      Root = null;
    }
  }

}
