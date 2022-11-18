using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Topping:MenuItem
    {
        public Topping(int number, string name, string Description, double Price, MenuType Type, bool isVegan, bool IsOrganic) : base(number, name, Description, Price, Type, isVegan, IsOrganic)
        {

        }

        public override string PrintInfo()
        {
            return $" number {Number} , {Name} , {Description} , {Price}, Menutype {Type}, {isVegan} and  isorganic {IsOrganic}";
        }
    }
}
