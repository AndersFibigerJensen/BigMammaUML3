using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BigMammaUML3
{
    public abstract class MenuItem: IMenuItem
    {
        public int Number
        {
            get;
        }

        public string Name
        {
            get;
            set;
        }


        public string Description
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }

        public MenuType Type
        {
            get;
            set;
        }

        public bool isVegan
        {
            get;
            set;
        }
        public bool IsOrganic
        {
            get;
            set;
        }

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
                Number = number;
                Name = name;
                Description = description;
                Price = price;
                Type = type;
                this.isVegan = isVegan;
                IsOrganic = isOrganic;
        }

        public virtual string PrintInfo()
        {
            return $" number{Number} , {Name} , {Description} , {Price}, Menutype {Type}, {isVegan} and  isorganic {IsOrganic} ";
        }


    }
}
