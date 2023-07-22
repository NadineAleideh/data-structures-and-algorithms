namespace CC13
{
  public class Program
  {
    static void Main(string[] args)
    {
      BracketsValidation bracketsValidation = new BracketsValidation();

      string example1 = "{}(){}";
      string example2 = "()[[Extra Characters]]";
      string example3 = "[({}]";

      Console.WriteLine("Example 1: {}(){} Returns: " + bracketsValidation.ValidateBrackets(example1)); // Output: True
      Console.WriteLine("Example 2: ()[[Extra Characters]] Returns: " + bracketsValidation.ValidateBrackets(example2)); // Output: True
      Console.WriteLine("Example 3: [({}] Returns: " + bracketsValidation.ValidateBrackets(example3)); // Output: False
    }
  }



  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
      Value = value;
      Next = null;
    }
  }

  public class Stack<T>
  {
    public Node<T>? Top { get; set; }

    public Stack()
    {
      Top = null;
    }

    public bool IsStackEmpty()
    {
      return Top == null;
    }

    public void Push(T value)
    {
      Node<T> newNode = new Node<T>(value);

      if (Top == null)
      {
        Top = newNode;
      }
      else
      {
        newNode.Next = Top;
        Top = newNode;
      }
    }

    public T Pop()
    {
      if (IsStackEmpty())
      {
        throw new InvalidOperationException("Stack is empty!");
      }

      T value = Top.Value;
      Top = Top.Next;

      return value;
    }

    public T Peek()
    {
      if (IsStackEmpty())
      {
        throw new InvalidOperationException("Stack is empty!");
      }
      return Top.Value;
    }
  }


  public class BracketsValidation
  {
    public Stack<char> stack = new Stack<char>();

    public BracketsValidation()
    {
      stack = new Stack<char>();
    }
    public bool ValidateBrackets(string str)
    {
      Stack<char>? chars = new Stack<char>();
      foreach (char c in str)
      {
        if (c == '(' || c == '{' || c == '[')
        {
          chars.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
          if (chars.IsStackEmpty() || !ArePair(chars.Top.Value, c))
          {
            return false;
          }
          else
          {
            chars.Pop();
          }
        }
      }
      return chars.IsStackEmpty() ? true : false;
    }
    public bool ArePair(char open, char close)
    {
      if (open == '(' && close == ')') { return true; }
      else if (open == '{' && close == '}') { return true; }
      else if (open == '[' && close == ']') { return true; }
      return false;
    }
  }

}


