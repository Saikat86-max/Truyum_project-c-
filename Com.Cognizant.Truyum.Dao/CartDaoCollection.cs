using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
    class CartDaoCollection : ICartDao
    {
        private static Dictionary<long, Cart> _userCarts;
        public CartDaoCollection()
        {
            if(_userCarts==null)
            {
                _userCarts = new Dictionary<long, Cart>();
            }
        }
        public void AddCartItem(long userId, long menuItemId)
        {
            MenuItemDaoCollection menuItemDaoCollection = new MenuItemDaoCollection();
            MenuItem menuitem = menuItemDaoCollection.GetMenuItem(menuItemId);
            if(_userCarts.ContainsKey(userId))
            {
                _userCarts[userId].MenuItemList.Add(menuitem);
            }
            else
            {
                List<MenuItem> menuItemList = new List<MenuItem>();
                menuItemList.Add(menuitem);
                Cart cart = new Cart();
                cart.MenuItemList = menuItemList;
                _userCarts.Add(userId, cart);

            }

        }
        public Cart GetAllCartItems(long userId)
        {
            Cart cart = null;
            foreach(var item in _userCarts)
            {
                if(item.Key==userId)
                {
                    if(item.Value.MenuItemList==null)
                    {
                        throw new CartEmptyException("cc");
                    }
                    else
                    {
                        foreach(var item1 in item.Value.MenuItemList )
                        {
                            item.Value.Total += item1.Price;
                        }
                        cart = item.Value;
                    }
                }
               
            }
            return cart;
        }
      /*  public void RemoveCartItem(long userId, long productId)
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            Cart cart = cartDao.GetAllCartItems(userId);
            List<MenuItem> menuItems = cart.MenuItemList;
            foreach (var item in menuItems.ToList())
            {
                if (item.Id == productId)
                {
                    menuItems.Remove(item);
                }
            }
            if (menuItems.Count == 0)
            {
                _userCarts.Remove(1);
            }
        }*/
        public void RemoveCartItem(long userId, long productId)
        {
            CartDaoCollection cartDao = new CartDaoCollection();
            Cart cart = cartDao.GetAllCartItems(userId);
            List<MenuItem> menuItems = cart.MenuItemList;
            foreach (var item in menuItems)
            {
                if (item.Id == productId)
                {
                    menuItems.Remove(item);
                }
            }
        }
    }
}
