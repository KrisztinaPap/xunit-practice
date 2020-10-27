using System;
using Xunit;
using XUnitCumulativePractice;
using System.Collections.Generic;

namespace Storage_Tests.cs
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var TestItem = new Item("TestItem");
            Storage EmptyStorage = new Storage();

            // Act
            EmptyStorage.AddItem(TestItem);

            int itemCount = EmptyStorage.Contents.Count;

            // Assert
            Assert.Equal(1, itemCount);
            Assert.Equal( TestItem, EmptyStorage.Contents[0]);
        }
        
        [Fact]
        // Huge shoutout to Aaron Barthel, Lindsey Graham, and Kenji Au for helping me understand polymorphic objects and testing!
        public void Test2()
        {
            // Arrange
            Storage newStorage = new Storage();
            newStorage.AddItem(new Item("stuff 1"));
            newStorage.AddItem(new Item("stuff 2"));
            newStorage.AddItem(new Item("stuff 3"));
            newStorage.AddItem(new Item("stuff 4"));
            newStorage.AddItem(new Item("stuff 5"));

            var lastIndex = newStorage.Contents.Count - 1;
            var lastItem = newStorage.Contents[lastIndex];
            // Act
            newStorage.RemoveItem();

            // Assert
            Assert.Equal(4, newStorage.Contents.Count);
            Assert.DoesNotContain(lastItem, newStorage.Contents);
        }
    }
}