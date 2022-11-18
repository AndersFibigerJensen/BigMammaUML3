using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaUML3
{
    
    public interface IMenuItem
    {
            int Number
            { get; }

            string Name
            { get; set; }


            string Description { get; set; }

            double Price { get; set; }

            MenuType Type { get; set; }

            bool isVegan { get; set; }
            bool IsOrganic { get; set; }

            string PrintInfo();


    }
}
