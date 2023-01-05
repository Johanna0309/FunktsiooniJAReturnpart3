List<string> myShoppingList = GetItemsFromUser();
ShowItemsFromList(myShoppingList);

static List<string> GetItemsFromUser()
{
   while (true)
   {
    Console.WriteLine("Add an item (add)/ Exit (exit):");
    string userChoice = Console.ReadALine();

    if(userChoice == "add")
    {
        Console.WriteLine("Enter an item:");
        string userItem = Console.ReadLine();
        myShoppingList.Add(userItem);
    }
    else 
    {
        Console.WriteLine("Bye!");
        break;
    }
  }
  return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have added {listLength} items to your shopping list.");

    int i = 1;
    foreach (string items in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}
