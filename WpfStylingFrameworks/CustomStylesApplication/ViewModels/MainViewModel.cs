using CustomStylesApplication.Helpers;
using CustomStylesApplication.Models;
using CustomStylesApplication.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStylesApplication.ViewModels
{
    public class MainViewModel : Observable
    {
        private SampleOrder _selectedItem;

        public SampleOrder SelectedItem
        {
            get { return _selectedItem; }
            set { Set(ref _selectedItem, value); }
        }

        public ObservableCollection<SampleOrder> Items { get; } = new ObservableCollection<SampleOrder>();

        public MainViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Items.Clear();
            var data = await SampleDataService.GetOrdersAsync();
            foreach (var item in data)
            {
                Items.Add(item);
            }

            SelectedItem = Items.First();
        }
    }
}
