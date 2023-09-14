using System;
using Xunit;
using hashtable;
namespace hashtableTest
{
  public class UnitTest1

  {
    [Fact]
    public void SettingKeyAndValue_AddsValueToDataStructure()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);

      // Act
      hashTable.Set("name", "Nadine");

      // Assert
      Assert.Equal("Nadine", hashTable.Get("name").Value);
    }

    [Fact]
    public void RetrievingValueByKey_ReturnsStoredValue()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);
      hashTable.Set("age", "23");

      // Act
      var result = hashTable.Get("age");

      // Assert
      Assert.Equal("23", result.Value);
    }

    [Fact]
    public void RetrievingNonExistentKey_ReturnsNull()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);

      // Act
      var result = hashTable.Get("nonexistent");

      // Assert
      Assert.Null(result);
    }

    [Fact]
    public void ReturningListOfUniqueKeys_ReturnsUniqueKeys()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);
      hashTable.Set("key1", "value1");
      hashTable.Set("key2", "value2");
      hashTable.Set("key3", "value3");

      // Act
      var keys = hashTable.Keys();

      // Assert
      Assert.Contains("key1", keys);
      Assert.Contains("key2", keys);
      Assert.Contains("key3", keys);
      Assert.Equal(3, keys.Count);
    }

    [Fact]
    public void HandlingCollision_SuccessfullyRetrievesValue()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);
      hashTable.Set("abc", "value1");
      hashTable.Set("cba", "value2");

      // Act
      var value1 = hashTable.Get("abc");
      var value2 = hashTable.Get("cba");

      // Assert
      Assert.Equal("value1", value1.Value);
      Assert.Equal("value2", value2.Value);
    }

    [Fact]
    public void RetrievingValueFromBucketWithCollision_Successful()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);
      hashTable.Set("abc", "value1");
      hashTable.Set("cba", "value2");

      // Act
      var value1 = hashTable.Get("abc");
      var value2 = hashTable.Get("cba");

      // Assert
      Assert.Equal("value1", value1.Value);
      Assert.Equal("value2", value2.Value);
    }

    [Fact]
    public void HashingKeyToInRangeValue_Successful()
    {
      // Arrange
      HashTable hashTable = new HashTable(1024);
      var key = "testkey";

      // Act
      var index = hashTable.Hash(key);

      // Assert
      Assert.InRange(index, 0, 1023);
    }
  }
}
