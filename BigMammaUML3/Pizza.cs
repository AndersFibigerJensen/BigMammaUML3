using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pizza:MenuItem
    {
        private bool _deeppan;

        public bool Deeppan
        {
            get { return _deeppan; }
            set { _deeppan = value; }
        }
        
        public Pizza(bool Deeppan,int number,string name,string Description, double Price,MenuType Type, bool isVegan, bool IsOrganic) :base(number,name,Description,Price,Type,isVegan,IsOrganic)
        {
            if (Type !=MenuType.Pizza)
                throw new ArgumentException("Type skal være en pizza");
            _deeppan = Deeppan;

        }

        public override string PrintInfo()
        {
            return $" number {Number} , {Name} , {Description} , {Price}, Menutype {Type}, {isVegan} and  isorganic {IsOrganic} Deeppan {_deeppan} ";
        }




    }
}
