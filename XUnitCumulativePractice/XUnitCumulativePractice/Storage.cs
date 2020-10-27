using System.Collections.Generic;
using System.Dynamic;
using System.Net.Mime;

namespace XUnitCumulativePractice
{
    public class Storage
    {
        public List<Item> Contents { get; private set; }

        public void AddItem(Item newItem)
        {
            Contents.Add(newItem);
        }

        public void RemoveItem()
        {
            int lastIndex = Contents.Count - 1;
            Contents.RemoveRange( lastIndex, 1);
        }

        public Storage()
        {
            Contents = new List<Item>();
            /*new Item("stuff 1"),
            new Item("stuff 2"),
            new Item("stuff 3")*/
        }
    }
}