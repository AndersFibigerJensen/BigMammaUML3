// See https://aka.ms/new-console-template for more information

using BigMammaUML3;

Beverage beer = new Beverage(true, 1, "beer", "alcohol that taste like piss", 45,MenuType.AlcoholicDrink , true, true);
Beverage wiskey = new Beverage(true, 2, "wiskey", "alcohol that is very refined", 65, MenuType.AlcoholicDrink, true, true);
Beverage wine = new Beverage(true, 1, "wiskey", "alcohol that taste very bitter", 65, MenuType.AlcoholicDrink, true, true);
//Console.WriteLine(beer.PrintInfo());

Pizza Margaritta = new Pizza(true, 3, "Margaritta", "Pizza with cheese and tomato", 60,MenuType.Pizza, true, true);
//Console.WriteLine(Margaritta.PrintInfo());
MenuCatalog Menu=new MenuCatalog();
Menu.Add(beer);
Menu.Add(wiskey);
try
{

    Menu.Add(wine);
}
catch (MenuItemNumberExist eox)
{
    Console.WriteLine(eox.Message);
}
Console.WriteLine();

//nyt felt
Menu.PrintBeveragesMenu();
Menu.Delete(1);
Console.WriteLine("beer er slettet fra systemet");
Menu.PrintBeveragesMenu();

//nyt felt
Console.WriteLine();
Console.WriteLine(Menu.Search(2).PrintInfo());

//nyt felt
Console.WriteLine();
Menu.Add(Margaritta);   
List<IMenuItem> veganMenu=Menu.FindAllVegan(MenuType.Pizza);
foreach (IMenuItem veganItem in veganMenu)
    Console.WriteLine(veganItem.PrintInfo());

//nyt felt
Console.WriteLine();
MenuItem pasta = new Pasta(true, "ham and cheese",4, "pasta ", "Pasta with ham and cheese", 45, MenuType.Pasta,false,false);








