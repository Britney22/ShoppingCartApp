
using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();


            ShoppingCartItem shoppingCartItem = new ShoppingCartItem("xBox",3950.99);

            cart.AddShoppingItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("PS5",15999.49);
            cart.AddShoppingItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("NOKIA ",5000);
            cart.AddShoppingItem(shoppingCartItem);

            shoppingCartItem = new ShoppingCartItem("Huawei ",5500);
            cart.AddShoppingItem(shoppingCartItem);


            List<ShoppingCartItem> items = cart.ShoppingCartItems();
            foreach (ShoppingCartItem item in items)
            {
                Console.Write(item.Name + "\t\t");
                Console.WriteLine(item.Price);
            }


            Console.WriteLine("Sub Total: \t" + cart.GetSubTotal());
            Console.WriteLine("With VAT: \t" + cart.GetVat());

        }

    }
}
