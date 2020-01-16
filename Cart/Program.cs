using System;
using SysCart;


namespace CartProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            cart.addItem(1, 30000, 2)
                .addItem(2, 10000)
                .addItem(3, 50000, 4)
                .remove(2)
                .addItem(4, 15000, 5).discount("50%");
            
            Console.WriteLine("total item : {0}", cart.totalItems());
            Console.WriteLine("total Qty : {0}", cart.totalQuantity());
            Console.WriteLine("total Price : {0}", cart.totalPrice());
            cart.showItem();
        }
    }
}
