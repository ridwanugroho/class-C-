using System;
using SysCart;


namespace CartProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            cart.addItem(1, 30000, 2).addItem(2, 10000).addItem(3, 50000, 4);

            cart.showItem();
            Console.WriteLine("/////////////////REMOVE ITEM 2 ////////////////");
            cart.remove(2);
            cart.showItem();
        }
    }
}
