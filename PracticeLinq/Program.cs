var myFavoriteGames = new List<string>() {
        "Return Of The Obra Dinn",
        "The Outer Wilds",
        "The Witcher 3: Wild Hunt",
        "Super Mario Odyssey",
        "Fallout New Vegas",
        "What Remains Of Edith Finch",
        "Red Dead Redemption 2",
        "Spider-Man",
        "Prince Of Persia: The Sands Of Time" };


Console.WriteLine("1st try: using a foreach loop:");
Console.WriteLine("");

var LengthOfGameName = myFavoriteGames.OrderByDescending(x => x.Length).ToList();

foreach (var game in LengthOfGameName)
{
    Console.WriteLine(game);
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("2nd try: using just LINQ:");
Console.WriteLine("");

myFavoriteGames.OrderByDescending(game => game.Length)
               .ToList()
               .ForEach(game => Console.WriteLine(game));