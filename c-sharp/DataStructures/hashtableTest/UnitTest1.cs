using System;
using Xunit;
using hashtable;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = hashtable.Program;

namespace hashtableTest
{
  public class UnitTest1

  {
    //[Fact]
    //public void SettingKeyAndValue_AddsValueToDataStructure()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);

    //  // Act
    //  hashTable.Set("name", "Nadine");

    //  // Assert
    //  Assert.Equal("Nadine", hashTable.Get("name").Value);
    //}

    //[Fact]
    //public void RetrievingValueByKey_ReturnsStoredValue()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);
    //  hashTable.Set("age", "23");

    //  // Act
    //  var result = hashTable.Get("age");

    //  // Assert
    //  Assert.Equal("23", result.Value);
    //}

    //[Fact]
    //public void RetrievingNonExistentKey_ReturnsNull()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);

    //  // Act
    //  var result = hashTable.Get("nonexistent");

    //  // Assert
    //  Assert.Null(result);
    //}

    //[Fact]
    //public void ReturningListOfUniqueKeys_ReturnsUniqueKeys()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);
    //  hashTable.Set("key1", "value1");
    //  hashTable.Set("key2", "value2");
    //  hashTable.Set("key3", "value3");

    //  // Act
    //  var keys = hashTable.Keys();

    //  // Assert
    //  Assert.Contains("key1", keys);
    //  Assert.Contains("key2", keys);
    //  Assert.Contains("key3", keys);
    //  Assert.Equal(3, keys.Count);
    //}

    //[Fact]
    //public void HandlingCollision_SuccessfullyRetrievesValue()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);
    //  hashTable.Set("abc", "value1");
    //  hashTable.Set("cba", "value2");

    //  // Act
    //  var value1 = hashTable.Get("abc");
    //  var value2 = hashTable.Get("cba");

    //  // Assert
    //  Assert.Equal("value1", value1.Value);
    //  Assert.Equal("value2", value2.Value);
    //}

    //[Fact]
    //public void RetrievingValueFromBucketWithCollision_Successful()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);
    //  hashTable.Set("abc", "value1");
    //  hashTable.Set("cba", "value2");

    //  // Act
    //  var value1 = hashTable.Get("abc");
    //  var value2 = hashTable.Get("cba");

    //  // Assert
    //  Assert.Equal("value1", value1.Value);
    //  Assert.Equal("value2", value2.Value);
    //}

    //[Fact]
    //public void HashingKeyToInRangeValue_Successful()
    //{
    //  // Arrange
    //  HashTable hashTable = new HashTable(1024);
    //  var key = "testkey";

    //  // Act
    //  var index = hashTable.Hash(key);

    //  // Assert
    //  Assert.InRange(index, 0, 1023);
    //}


    //CC31
    //[Fact]
    //public void RepeatedWord_FindsFirstRepeatedWord()
    //{
    //  // Arrange
    //  string input1 = "Once upon a time, there was a brave princess who...";
    //  string input2 =
    //      "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
    //  string input3 =
    //      "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";


    //  // Act and Assert
    //  Assert.Equal("a", Program.RepeatedWord(input1));
    //  Assert.Equal("it", Program.RepeatedWord(input2));
    //  Assert.Equal("summer", Program.RepeatedWord(input3));
    //}

    //[Fact]
    //public void RepeatedWord_NoRepeatedWord_ReturnsEmptyString()
    //{
    //  // Arrange
    //  string input = "This is a test sentence without repeated words.";

    //  // Act and Assert
    //  Assert.Equal("", Program.RepeatedWord(input));
    //}

    //[Fact]
    //public void RepeatedWord_EmptyString_ReturnsEmptyString()
    //{
    //  // Arrange
    //  string input = "";

    //  // Act and Assert
    //  Assert.Equal("", Program.RepeatedWord(input));
    //}


    //CC32

    //[Fact]
    //public void FindCommonValues_ReturnsCommonValues()
    //{
    //  // Create the first binary tree
    //  BinaryTree tree1 = new BinaryTree
    //  {
    //    Root = new TreeNode(1)
    //    {
    //      Left = new TreeNode(2),
    //      Right = new TreeNode(3)
    //    }
    //  };

    //  // Create the second binary tree
    //  BinaryTree tree2 = new BinaryTree
    //  {
    //    Root = new TreeNode(2)
    //    {
    //      Left = new TreeNode(3),
    //      Right = new TreeNode(4)
    //    }
    //  };

    //  // Call the FindCommonValues method
    //  HashSet<int> commonValues = TreeIntersection.FindCommonValues(tree1, tree2);

    //  // Assert that the common values are as expected
    //  Assert.Contains(2, commonValues);
    //  Assert.Contains(3, commonValues);
    //  Assert.DoesNotContain(1, commonValues);
    //  Assert.DoesNotContain(4, commonValues);
    //}

    //[Fact]
    //public void FindCommonValues_NoCommonValues_ReturnsEmptySet()
    //{
    //  // Create two binary trees with no common values
    //  BinaryTree tree1 = new BinaryTree
    //  {
    //    Root = new TreeNode(1)
    //    {
    //      Left = new TreeNode(2)
    //    }
    //  };

    //  BinaryTree tree2 = new BinaryTree
    //  {
    //    Root = new TreeNode(3)
    //    {
    //      Left = new TreeNode(4)
    //    }
    //  };

    //  // Call the FindCommonValues method
    //  HashSet<int> commonValues = TreeIntersection.FindCommonValues(tree1, tree2);

    //  // Assert that the common values set is empty
    //  Assert.Empty(commonValues);
    // }

    //CC33
    [Fact]
    public void LeftJoin_WithMatchingValues_ReturnsJoinedData()
    {
      // Arrange
      Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

      Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

      // Act
      List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

      // Assert
      Assert.Collection(result,
          row => Assert.Equal(new List<string> { "diligent", "employed", "idle" }, row),
          row => Assert.Equal(new List<string> { "fond", "enamored", "averse" }, row),
          row => Assert.Equal(new List<string> { "guide", "usher", "follow" }, row),
          row => Assert.Equal(new List<string> { "outfit", "garb", null }, row),
          row => Assert.Equal(new List<string> { "wrath", "anger", "delight" }, row)
      );
    }

    [Fact]
    public void LeftJoin_WithNoMatchingValues_ReturnsJoinedDataWithNullAntonyms()
    {
      // Arrange
      Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "apple", "fruit" },
            { "banana", "fruit" },
            { "carrot", "vegetable" }
        };

      Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "dog", "cat" },
            { "elephant", "giraffe" },
            { "lion", "tiger" }
        };

      // Act
      List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

      // Assert
      Assert.Collection(result,
          row => Assert.Equal(new List<string> { "apple", "fruit", null }, row),
          row => Assert.Equal(new List<string> { "banana", "fruit", null }, row),
          row => Assert.Equal(new List<string> { "carrot", "vegetable", null }, row)
      );
    }

    [Fact]
    public void LeftJoin_WithEmptyInput_ReturnsEmptyResult()
    {
      // Arrange
      Dictionary<string, string> synonyms = new Dictionary<string, string>();
      Dictionary<string, string> antonyms = new Dictionary<string, string>();

      // Act
      List<List<string>> result = Program.LeftJoin(synonyms, antonyms);

      // Assert
      Assert.Empty(result);
    }
  }
}
