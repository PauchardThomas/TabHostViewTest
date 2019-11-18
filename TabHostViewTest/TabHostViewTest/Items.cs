using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace TabHostViewTest
{
    public class Items : BindableBase
    {
        private int _CurrentIndex;
        private List<Item> _ListItems;
        private string _Name;

        public Items(List<Item> items, int currentIndex, string name)
        {
            _CurrentIndex = currentIndex;
            _Name = name;
            _ListItems = items;
        }

        public List<Item> ListItems
        {
            get => _ListItems;
            set => _ListItems = value;
        }

        public int CurrentIndex
        {
            get => _CurrentIndex;
            set => SetProperty(ref _CurrentIndex , value);
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
    }
}
