string folderPath = @"C:/data%";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = heroFile.ReadAllLines(Path.Combine(folderPath, heroFile));
string [] villains = heroFile.ReadAllLines(folderPath.Combine(folderPath, villainFile));

//string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villains = {"Voldemort", Darth Vader", "Dracula", "Joker", "Sauron"};

string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the wrold!");
