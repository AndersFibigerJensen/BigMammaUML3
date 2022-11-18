using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    public class Pasta:MenuItem
    {
        private bool _gluten;
        private string _filling;

        public  bool Gluten
        {
            get { return _gluten; }
            set { _gluten = value; }
        }

        public string Filling
        {
            get { return _filling; }
            set { _filling = value; }
        }

        public Pasta(bool gluten,string filling, int number, string name, string Description, double Price, MenuType Type, bool isVegan, bool IsOrganic) : base(number, name, Description, Price, Type, isVegan, IsOrganic)
        {
            _gluten = gluten;
            _filling = filling;

        }

        public override string PrintInfo()
        {
            return $" number {Number} , {Name} , {Description}, {Filling} , {Price}, Menutype {Type}, {isVegan} and  isorganic {IsOrganic}, Gluten{_gluten} ";
        }

    }
}
