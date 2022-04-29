

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCart //zoo
    {

        List<ShoppingCartItem> _ShoppingCartItems = new List<ShoppingCartItem>();

        public ShoppingCart()
        {


        }


        public void AddShoppingItem(ShoppingCartItem item)
        {
            _ShoppingCartItems.Add(item);
        }


        public double GetSubTotal()
        {
            double total = 0;

            foreach (ShoppingCartItem shoppingCart in _ShoppingCartItems)
            {
                total = total + shoppingCart.Price;
            }
            return total;
        }


        public double GetVat()
        {
            double vat = 0;

            vat += 1.15 * GetSubTotal();

            return vat;
        }

    }
}