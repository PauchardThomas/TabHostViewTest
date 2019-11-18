using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Xamarin.Forms;

namespace TabHostViewTest
{
    public class MainPageViewModel : BindableBase
    {
        private Items _Items;
        private Items _FirstList;
        private Items _SecondList;
        private bool _GetFirstList;
        public MainPageViewModel()
        {
            ChangeItemsCommand = new DelegateCommand(ChangeItemsCommandExecute);
            _FirstList = ItemService.GetFirstList();
            _SecondList = ItemService.GetSecondList();
            _Items = _FirstList;
        }

        private void ChangeItemsCommandExecute()
        {
            if (_GetFirstList)
            {
                Items = _FirstList;
                _GetFirstList = false;
            }
            else
            {
                Items = _SecondList;
                _GetFirstList = true;
            }
        }

        public DelegateCommand ChangeItemsCommand { get; set; }
        public Items Items
        {
            get => _Items;
            set => SetProperty(ref _Items , value);
        }
    }
}
