using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        private long _id;
        private string _name;
        private float _price;
        private bool _active;
        private DateTime _dateofLaunch;
        private string _category;
        private bool _freeDelivery;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
        public DateTime DateOfLaunch
        {
            get { return _dateofLaunch; }
            set { _dateofLaunch = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public bool FreeDelivery
        {
            get { return _freeDelivery; }
            set { _freeDelivery = value; }
        }
        /*public MenuItem(long id,string name,float price,bool active,DateTime dateoflaunch,string category,bool freedelivery)
        {
            Id = id;
            Name = name;
            Price = price;
            Active = active;
            DateOfLaunch = dateoflaunch;
            Category = category;
            FreeDelivery = freedelivery;


        }*/




    }
    }
