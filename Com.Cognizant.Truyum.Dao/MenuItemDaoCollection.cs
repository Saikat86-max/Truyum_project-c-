using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;
using Com.Cognizant.Truyum.Utility;

namespace Com.Cognizant.Truyum.Dao
{
    class MenuItemDaoCollection : IMenuItemDao
    {
        private static List<MenuItem> _menuItemList;
        public MenuItemDaoCollection()
        {
            if (_menuItemList == null)
            {
                _menuItemList = new List<MenuItem>();
                _menuItemList.Add(new MenuItem() { Id = 1, Name = "Sandwich", Price = 99.00F, Active = true, DateOfLaunch =DateUtility.ConvertToDate( "15-03-2017"), Category = "Main Course", FreeDelivery = true });
                _menuItemList.Add(new MenuItem() { Id = 2, Name = "Burger", Price = 129.00F, Active = true, DateOfLaunch = DateUtility.ConvertToDate( "23-12-2017"), Category = "Main Course", FreeDelivery = false });
                _menuItemList.Add(new MenuItem() { Id = 3, Name = "Pizza", Price = 149.00F, Active = true, DateOfLaunch = DateUtility.ConvertToDate("21-08-2018"), Category = "Main Course", FreeDelivery = false });
                _menuItemList.Add(new MenuItem() { Id = 4, Name = "French Fries", Price = 57.00F, Active = false, DateOfLaunch = DateUtility.ConvertToDate( "02-07-2017"), Category = "Starters", FreeDelivery = true });
                _menuItemList.Add(new MenuItem() { Id = 5, Name = "Chocolate Brownie", Price = 32.00F, Active = true, DateOfLaunch = DateUtility.ConvertToDate( "02-11-2022"), Category = "Deserts", FreeDelivery = true });




            }
        }
        public List<MenuItem> GetMenuItemListAdmin()
        {
            return _menuItemList;
        }
        public List<MenuItem> GetMenuItemListCustomer()
        {
            List<MenuItem> myList = new List<MenuItem>();

            foreach (var i in _menuItemList)
            {
                if (i.DateOfLaunch > DateTime.Now && i.Active == true)
                {
                    myList.Add(i);
                }
            }
            return myList;
        }
        public void ModifyMenuItem(MenuItem menuItem)
        {
            foreach (var item in _menuItemList)
            {
                if (item.Id == menuItem.Id)
                {
                    item.Name = menuItem.Name;
                    item.Price = menuItem.Price;
                    item.Active = menuItem.Active;
                    item.DateOfLaunch = menuItem.DateOfLaunch;
                    item.Category = menuItem.Category;
                    item.FreeDelivery = menuItem.FreeDelivery;
                }
            }

        }
        MenuItem x;
        public MenuItem GetMenuItem(long menuItemId)
        {
            foreach(var item in _menuItemList)
            {
                if(item.Id==menuItemId)
                {
                    x=item;
                }
            }
            return x;
        }



    }
}
