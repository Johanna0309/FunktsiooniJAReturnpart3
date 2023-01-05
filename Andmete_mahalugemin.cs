using System.Data.SQLite;

ReadData(CreateConnection());

static SQLiteConnection CreateConnection()
{
   SQLiteConnection connection = new SQLiteConnection("Data Source=mydb.db; Version = 3; New = True; Compress = True;");

   try
  {
    connection.Open();
    Console.WriteLine("DB found.");
  }
   catch
  {
    Console.WrtieLine("DB not found.");
  }
  return connection;
}

static void ReadData(SQLiteConnection myConnection)
{
    Console.Clear();
    SQLiteDataReader reader;
    SQLiteCommand command;

    command = myConnection.CreateCommand();
    command.CommandText = "SELECT customer.firstName, customer.lastName, status.statustype" +
    "FROM customerStatus " +
    "JOIN customer on customer.rowid = customerStatus.statusId " +
    "JOIN status on status.rowid = customerStatus.statusId " +
    "ORDER BY ";

    reared = command.ExecuteReader();

    while (reader.Read())
    {
        string readerStringFirstName = reader.GetString(0);
        string readerStringLasttName = reader.GetString(1);
        string readerStringStatus = reader.GetString(2);

        Console.WriteLine($"Full name: {readerStringFirstName} {readerStringFirstName}; Status:  {readerStringStatus}");
    }
    myConnection.Close();
}
