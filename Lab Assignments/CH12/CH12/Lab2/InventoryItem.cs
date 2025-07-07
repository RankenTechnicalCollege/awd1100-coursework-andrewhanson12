using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class InventoryItem
    {
        private string _itemName;
        private string _upc;
        private decimal _price;
        private decimal _costPerCase;
        private int _unitsPerCase;

        public InventoryItem(string itemName, string upc, decimal price, decimal costPerCase, int unitsPerCase)
        {
            _itemName = itemName;
            _upc = upc;
            _price = price;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
        }
        public string getItemName()
        {
            return _itemName;
        }
        public void setItemName(string itemName)
        {
            _itemName = itemName;
        }
        public string getUpc()
        {
            return _upc;
        }
        public void setUpc(string upc)
        {
            _upc = upc;
        }
        public decimal getPrice()
        {
            return _price;
        }
        public void setPrice(decimal price)
        {
            _price = price;
        }
        public decimal getCostPerCase()
        {
            return _costPerCase;
        }
        public void setCostPerCase(decimal costPerCase)
        {
            _costPerCase = costPerCase;
        }
        public int getUnitsPerCase()
        {
            return _unitsPerCase;
        }
        public void setUnitsPerCase(int unitsPerCase)
        {
            _unitsPerCase = unitsPerCase;
        }

    }
}
