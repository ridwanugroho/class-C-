using System;
using System.Text;
using System.Collections;
using System.IO;

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
        private ArrayList _data = new ArrayList();
        private double _disc;

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

        public Cart discount(string discount)
        {
            _disc = (double)Decimal.Parse(discount.Remove(discount.Length-1))/100;
            return this;
        }

        public int totalItems()
        {
            return _data.Count;
        }

        public int totalQuantity()
        {
            int ret = 0;

            foreach (var i in _data)
            {
                Item item = (Item)i;
                ret += item.Qty;
            }

            return ret;
        }

        public double totalPrice()
        {
            double ret = 0;

            foreach (var i in _data)
            {
                Item item = (Item)i;
                ret += item.Price * item.Qty;
            }

            return ret - ret*_disc;
        }

        public void showItem()
        {
            foreach (var i in _data)
            {
                Item item = (Item)i;
                Console.WriteLine("{0}    {1}    {2}", item.ItemId, item.Price, item.Qty);
            }
        }

        public void checkout(string path)
        {
            TextWriter tw = new StreamWriter(path+"checkout.txt");
            tw.WriteLine("ID    Price   Qty");
            foreach (var i in _data)
            {
                Item item = (Item)i;
                tw.WriteLine("{0}    {1}    {2}", item.ItemId, item.Price, item.Qty);
            }
            
            tw.WriteLine("total item : {0}", totalItems());
            tw.WriteLine("total price : {0}", totalPrice());
            tw.WriteLine("total Qty : {0}", totalQuantity());

            tw.Close();
        }

    }
}