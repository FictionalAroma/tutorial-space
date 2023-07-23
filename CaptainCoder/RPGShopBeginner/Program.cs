
namespace RPGShopBeginner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To RPG Shop Simulator!!!");
			Console.WriteLine("Please enter your shop name");
			string shopName = Console.ReadLine();


			List<Item> shopItems = new List<Item>()
								   {
									   new Item(){ItemName = "Init", ItemPrice = 10},
									   new Item(){ItemName = "Shield", ItemPrice = 10}
								   };
			Item createdItem = new Item();

			shopItems.Add(createdItem);
			shopItems.Add(new Item(){ItemName = "Making Item On the Fly"});

			Shop myShop = new Shop(50)
						  {
							  ShopName = shopName,
						  };
			
			Console.WriteLine($"Your shop name is called {myShop.ShopName}");
			Console.WriteLine($"{myShop.ShopName} has {myShop.Gold} gold! You Are Rich!");

			myShop.Sell(20);
			Console.WriteLine($"I now has {myShop.Gold} gold! You Are Richer!");
		}
    }


	public class Shop
	{
		public Shop(int startingGold)
		{
			Gold = startingGold;
		}


		public string ShopName { get; set; }
		public int Gold { get; private set; }

		public List<Item> Inventory { get; set; }

		public void Buy(int cost)
		{
			this.Gold -= cost;
		}

		public void Sell(int cost)
		{
			this.Gold += cost;
		}

	}

	public class Item
	{
		public string ItemName { get; set; }
		public int ItemPrice { get; set; }
	}





}