using System;
using System.Text;
using System.Collections;
// using System.Collections.Generic;

namespace SysCart
{
    public class Item
    {
        public int ItemId;
        public double Price;
        public int Qty;

        public Item(int id, double price, int qty)
        {
            ItemId = id;
            Price = price;
            Qty = qty;
        }
    }

    public class Cart
    {
        private int _totItem = 0;
        private int _totQty = 0;
        private double _totPrice = 0;
        private ArrayList _data = new ArrayList();

        public Cart addItem(int itemID, double price, int qty=1)
        {
            _data.Add(new Item(itemID, price, qty));
            return this;
        }
        
        public Cart remove(int itemID)
        {
            for(int i=0; i<_data.Count; i++)
            {
                Item item = (Item)_data[i];
                if(item.ItemId == itemID)
                {
                    _data.RemoveAt(i);
                    break;
                }
            }
            return this;
        }

        public int totalItems()
        {
            return _data.Count;
        }

        public void showItem()
        {
            foreach (var i in _data)
            {
                Item item = (Item)i;
                Console.WriteLine("{0}    {1}    {2}", item.ItemId, item.Price, item.Qty);
            }
        }
    }
}