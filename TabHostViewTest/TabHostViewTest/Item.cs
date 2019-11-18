using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace TabHostViewTest
{
    public class Item
    {
        private string _Name;
        private string _Color;

        public Item(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Color
        {
            get => _Color;
            set => _Color = value;
        }
    }
}
