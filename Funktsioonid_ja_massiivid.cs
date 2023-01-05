string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo"};
string[] villains = {"voldemort", "Darth Vader", "Dracula","Joker", "Sauron"};
string[] weapon = {"magic wand", "plastic fork", "banana", "wooden sword", "Lego brick"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GeRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon}tries to take over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
   Random rnd = new Random();
   int randomIndex = rnd.Next(0, someArray.Length);
   string randomStringFromArray = someArray[randomIndex];
   return randomStringFromArray;
}
