using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BigMammaUML3.MenuType;

namespace BigMammaUML3
{
    public class Beverage:MenuItem
    {
        private bool _alcohol;

        public bool Alcohol
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }

        public Beverage(bool Alcohol,int number, string name, string Description, double Price, MenuType type, bool isVegan, bool IsOrganic):base(number, name, Description, Price, type, isVegan, IsOrganic)
        {
            _alcohol = Alcohol;
        }

        public override string PrintInfo()
        {
            return $"{base.PrintInfo()} Alcohol {Alcohol} ";
        }


    }
}
