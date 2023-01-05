using System.Data.SQLite;

CreateConnection();
static SQLiteConnection CreateConnection()
{
   SQLiteConnection connection = new SQLiteConnection("Data Source=mydb.db; Version = 3; New = True; Compress = True;");

   try
  {
    connection.Open();
    Console.WriteLine("DB found.");
  }
   catch (System.Exception)
  {
    Console.WrtieLine("DB not found.");
  }
}
