string[] data = GetDataFromFile();
ReadDataFromArray(data);

static string [] GetDataFrommyFile()
{
    string filePath = @"C:\data\movies.txt";
    return filePath.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}
