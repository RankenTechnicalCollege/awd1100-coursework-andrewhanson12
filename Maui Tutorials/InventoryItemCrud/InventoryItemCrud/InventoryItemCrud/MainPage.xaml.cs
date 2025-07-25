﻿using System.Collections.ObjectModel;
using InventoryItemCrud.Models;
namespace InventoryItemCrud
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<InventoryItem> InventoryItems { get; set; } = [];

        public MainPage()
        {
            InitializeComponent();
            InventoryItems.Add(new InventoryItem(1000, "Laptop", 999.99m));
            InventoryItems.Add(new InventoryItem(2000, "Mouse", 19.99m));
            BindingContext = this;
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(ItemNoEntry.Text, out int itemNo)&& 
                !string.IsNullOrWhiteSpace(DescriptionEntry.Text) &&
                decimal.TryParse(PriceEntry.Text, out decimal price))
            {
                InventoryItems.Add(new InventoryItem(itemNo, DescriptionEntry.Text, price));
                ClearEntries();
            }
            else
            {
                DisplayAlert("Error", "Please enter valid values for all fields", "OK");
            }
        }

        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            if(InventoryListView.SelectedItem is InventoryItem selectedItem)
            {
                if (int.TryParse(ItemNoEntry.Text, out int itemNo) &&
                !string.IsNullOrWhiteSpace(DescriptionEntry.Text) &&
                decimal.TryParse(PriceEntry.Text, out decimal price))
                {
                    selectedItem.ItemNo = itemNo;
                    selectedItem.Description = DescriptionEntry.Text;
                    selectedItem.Price = price;
                    //InventoryItems[InventoryItems.IndexOf(selectedItem)] = selectedItem;
                    //ClearEntries();
                }
            }
        }

        private void btnDelete_Clicked(object sender, EventArgs e)
        {
            if (InventoryListView.SelectedItem is InventoryItem selectedItem)
            {
                InventoryItems.Remove(selectedItem);
            }
        }

        private void InventoryListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem is InventoryItem selectedItem)
            {
                ItemNoEntry.Text = selectedItem.ItemNo.ToString();
                DescriptionEntry.Text = selectedItem.Description;
                PriceEntry.Text = selectedItem.Price.ToString("F2");
            }
            else
            {
                ClearEntries();
            }
        }
        private void ClearEntries()
        {
            ItemNoEntry.Text = string.Empty;
            DescriptionEntry.Text = string.Empty;   
            PriceEntry.Text = string.Empty;
        }
    }
}
