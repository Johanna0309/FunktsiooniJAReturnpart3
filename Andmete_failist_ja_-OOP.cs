List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(sToString line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Titel} was released in {movie.Year}");
}
static string [] GetDataFromMyFile()
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

class Movie 
{
    string titel; //fields
    string year;

    public string Titel
    {
        get{ return titel; }
    }
    public string Year
    {
        get {return year; }
    }
    public Movie(string _title, string _year)
    {
        titel = _title;
        year = _year;
    }
}
