using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingListOperations
{
    public class ListManager
    {
        /*
        3. Testing List Operations
Problem:
Create a ListManager class that has the following methods:
● AddElement(List<int> list, int element): Adds an element to a list.
● RemoveElement(List<int> list, int element): Removes an element from a
list.
● GetSize(List<int> list): Returns the size of the list.
Write NUnit or MSTest tests to verify that:
✅ Elements are correctly added.
✅ Elements are correctly removed.
✅ The size of the list is updated correctly.
        */

        // method to add element in list
        public void AddElement(List<int> list, int element)
        {
            list.Add(element);
        }
        // method to remove element from list
        public void RemoveElement(List<int> list, int element)
        {
            list.Remove(element);
        }
        // method to get size of list
        public int GetSize(List<int> list)
        {
            return list.Count;
        }
    }
}