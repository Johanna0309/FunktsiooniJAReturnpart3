string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo"};
string[] villains = {"voldemort", "Darth Vader", "Dracula","Joker", "Sauron"};
string[] weapon = {"magic wand", "plastic fork", "banana", "wooden sword", "Lego brick"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GeRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} ({villainHP}) HP)with {villainWeapon}tries to take over the world!");

while(heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - Hit(villain, villainHP);
    villainHP = villainHP - Hit(hero, heroHP);
}

Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villain {villain} HP: {villainHP}");

if(heroHP > 0)
{
    Console.WriteLine($"{hero} saves the day!");
}
else if (villainHP > 0)
{
    Console.WriteLine($"Dark side wins");
}

static string GetRandomValueFromArray(string[] someArray)
{
   Random rnd = new Random();
   int randomIndex = rnd.Next(0, someArray.Length);
   string randomStringFromArray = someArray[randomIndex];
   return randomStringFromArray;
}
