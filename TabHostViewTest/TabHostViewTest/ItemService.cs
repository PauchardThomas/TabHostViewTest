using System;
using System.Collections.Generic;
using System.Text;

namespace TabHostViewTest
{
    public static class ItemService
    {
        public static Items GetFirstList()
        {

            var items = new List<Item>
            {
                new Item("A1", "Blue"),
                new Item("B1", "Green"),
                new Item("C1", "Red"),
                new Item("D1", "Brown"),
            };

            return new Items(items, 0,"First List");
        }

        public static Items GetSecondList()
        {
            var items =  new List<Item>
            {
                new Item("A2", "Blue"),
                new Item("B2", "Green"),
                new Item("C2", "Red"),
                new Item("D2", "Brown"),
            };
            return new Items(items, 0,"Second List");
        }
    }
}
