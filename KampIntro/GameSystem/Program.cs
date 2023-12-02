using GameSystem;

GamerManager gamerManager = new GamerManager();

foreach (var gamer in gamerManager.GetAll())
{
    Console.WriteLine(gamer.Username);
}

Console.WriteLine("------------------------------");

Gamer gamer1 = new Gamer(3,"John","Smith","jhsmth","usa45");
gamerManager.Add(gamer1);


foreach (var gamer in gamerManager.GetAll())
{
    Console.WriteLine(gamer.Username);
}

Console.WriteLine("------------------------------");

GameManager gameManager = new GameManager();

Game game1 = new Game(2, "Battlefield V", 49.50);
gameManager.Add(game1);



foreach (var game in gameManager.GetAll())
{
    Console.WriteLine(game.Name);
}

Console.WriteLine("------------------------------");

ShopManager shopManager = new ShopManager();

shopManager.Sell(game1, gamer1);