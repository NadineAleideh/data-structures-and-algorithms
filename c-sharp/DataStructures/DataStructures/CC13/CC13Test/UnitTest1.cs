using Xunit;
using CC13;
using System.ComponentModel.DataAnnotations;

namespace CC13Test
{
  public class UnitTest1
  {
    BracketsValidation bv = new BracketsValidation();
    [Fact]
    public void TestBalancedBrackets_ReturnsTrue()
    {
      string str1 = "{}(){}";
      string str2 = "()[[Extra Characters]]";
      string str3 = "[({})]";
      string str4 = "({[{}]}[])";

      Assert.True(bv.ValidateBrackets(str1));
      Assert.True(bv.ValidateBrackets(str2));
      Assert.True(bv.ValidateBrackets(str3));
      Assert.True(bv.ValidateBrackets(str4));
    }

    [Fact]
    public void TestUnbalancedBrackets_ReturnsFalse()
    {
      string str1 = "(](";
      string str2 = "}";
      string str3 = "[}";
      string str4 = "[({}]";

      Assert.False(bv.ValidateBrackets(str1));
      Assert.False(bv.ValidateBrackets(str2));
      Assert.False(bv.ValidateBrackets(str3));
      Assert.False(bv.ValidateBrackets(str4));
    }

    [Fact]
    public void TestArePairs_Succefully()
    {
      string example1 = "{a}(b)c";
      string example2 = "[abc]def";
      string example3 = "{[}(ac)";

      Assert.True(bv.ValidateBrackets(example1));
      Assert.True(bv.ValidateBrackets(example2));
      Assert.False(bv.ValidateBrackets(example3));
    }
  }
}
