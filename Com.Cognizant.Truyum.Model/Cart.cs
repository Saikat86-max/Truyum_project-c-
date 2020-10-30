using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        private List<MenuItem> _menuItemList;
        private double _total;

        public List<MenuItem> MenuItemList
        {
            get { return _menuItemList; }
            set { _menuItemList = value; }
        }
        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}

