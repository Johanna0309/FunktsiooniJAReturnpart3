string folderPath = @"C:/data%";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).close();
    Console.WriteLine($"File {fileName} does not exist.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();
    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if(userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Consoel.ReadlLine();
            userList.Add(userItem);
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
}
