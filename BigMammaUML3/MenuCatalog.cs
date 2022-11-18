using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BigMammaUML3.MenuType;

namespace BigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        private List<IMenuItem> _menuItems;

        public List<IMenuItem> Menuitems
        {
            get { return _menuItems; }  
        }

        public List<IMenuItem> MenuItems
        {
            get { return _menuItems; }
        }

        public int Count { get { return _menuItems.Count; } }

        public MenuCatalog()
        {
            _menuItems = new List<IMenuItem>();
        }

        public void Add(IMenuItem aMenuItem)
        {

            if (aMenuItem.Number != null)
                throw new MenuItemNumberExist("nummeret eksistere allerede i systemet");
            _menuItems.Add(aMenuItem);


        }

        public IMenuItem Search(int number)
        {

            for (int i = 0; i < MenuItems.Count; i++)
                if (MenuItems[i].Number == number)
                    return _menuItems[i];
            return null;

        }

        public void Delete(int number)
        {
            for (int i = 0; i < _menuItems.Count; i++)
                if (_menuItems[i].Number == number)
                    _menuItems.Remove(_menuItems[i]);
        }

        public void PrintPizzasMenu()
        {
            foreach (MenuItem menuitem in _menuItems)
            {
                if (menuitem.Type == MenuType.Pizza)
                {
                    Console.WriteLine(menuitem.PrintInfo());
                }
            }
        }

        public void PrintBeveragesMenu()
        {
            foreach (MenuItem menuitem in _menuItems)
            {
                if (menuitem.Type == MenuType.AlcoholicDrink || menuitem.Type == MenuType.SoftDrink)
                {
                    Console.WriteLine(menuitem.PrintInfo());
                }
            }

        }

        public void PrintToppingsMenu()
        {
            foreach (MenuItem menuitem in _menuItems)
            {
                if (menuitem.Type == MenuType.Topping)
                {
                    Console.WriteLine(menuitem.PrintInfo());
                }
            }

        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            try
            {
                for (int i = 0; i < _menuItems.Count; i++)
                    if (_menuItems[i].Number == number)
                        _menuItems[i] = theMenuItem;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("det tal du søger efter er ikke i systemet");
            }

        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem menuitem in _menuItems)
            {
                if (menuitem.isVegan == true && menuitem.Type==type)
                    list.Add(menuitem);
            }
            return list;
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem menuitem in _menuItems)
            {
                if (menuitem.IsOrganic == true && menuitem.Type==type)
                    list.Add(menuitem);
            }
            return list;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            IMenuItem MostExpensiveItem = _menuItems[0];
            foreach (IMenuItem menuitem in _menuItems)
            {
                if (menuitem.Price > MostExpensiveItem.Price)
                {
                    MostExpensiveItem = menuitem;
                }

            }
            return MostExpensiveItem;
        }

    }
}
