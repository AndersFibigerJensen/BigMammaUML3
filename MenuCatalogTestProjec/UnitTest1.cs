using BigMammaUML3;
using System.Reflection.Metadata;

namespace MenuCatalogTestProjec
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTest
        {
            Beverage beer = new Beverage(true, 1, "beer", "alcohol that taste like piss", 45, MenuType.AlcoholicDrink, true, true);
            Beverage wiskey = new Beverage(true, 2, "wiskey", "Hard alcohol", 45, MenuType.AlcoholicDrink, true, true);


            public MenuCatalog createMenu()
            {
                MenuCatalog menu = new MenuCatalog();
                return menu;
            }
               
            [TestMethod]
            public void Testaddtwobeverages()
            {
                MenuCatalog menu = createMenu();
                //act
                menu.Add(beer);
                menu.Add(wiskey);

                //assert
                Assert.AreEqual(2, menu.Count);

            }

            [TestMethod]
            public void TestUpdateALiquid()
            {
                MenuCatalog menu = createMenu();
                menu.Add(beer);
                menu.Add(wiskey);
                Beverage wine = new Beverage(true, 1, "wine", "fancy alcohol", 65, MenuType.AlcoholicDrink, false, true);

                //act
                menu.Update(1, wine);
                Assert.AreEqual(wine, menu.MenuItems[0]);
                
            }

            [TestMethod]
            public void Removealiquid()
            {
                //arrange
                MenuCatalog menu = createMenu();
                menu.Add(beer);
                menu.Add(wiskey);

                //act
                menu.Delete(1);

                //assert
                Assert.AreEqual(1, menu.Count);
            }

            [TestMethod]

            public void Searchliquid()
            {
                //arrange
                MenuCatalog menu = createMenu();
                menu.Add(beer);
                menu.Add(wiskey);

                //act
                menu.Search(1);

                //assert
                Assert.AreEqual(beer, menu.Search(1));

            }


            [TestMethod]
            //assert
            [ExpectedException(typeof(MenuItemNumberExist), "Test Exception")]
            public void TestaddbeveragesException()
            {
                //arrange
                MenuCatalog menu = createMenu();
                menu.Add(beer);
                menu.Add(wiskey);
                Beverage soda = new Beverage(true, 1, "soda", "alcohol that taste like piss", 45, MenuType.SoftDrink, true, true);

                //act
                menu.Add(soda);


            }


        }
    }
}