using System.Data.SQLite;

ReadData(CreateConnection());
//InsertCustomer(CreateConnection());
//RemoveCustomer(CreateConnection());
FindCustomer();
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
    command.CommandText = "SELECT * FROM customer";
    
    reader = command.ExecuteReader();

    while (reader.Read())
    {
        string readerRowId = reader["rowid"].ToString(0);
        string readerStringFirstName = reader.GetString(1);
        string readerStringLastName= reader.GetString(2);
        string readerStringDoB = reader.GetString(3);

        Console.WriteLine($"{readerRowId}. Full name: {readerStringFirstName} {readerStringStatus}; DoB: {readerStringDoB}");
    
    }

    myConnection.Close();

    static void InsertCustomer(SQLiteConnection myConnection)
    {
        SQLiteCommand command;
        string fName, lName, dob;

        Console.WriteLine("En ter first name:");
        fName = Console.ReadLine();
        Console.WriteLine("Enter last name:");
        lName = Console.ReadLine();
        Console.WriteLine("Enter dat of birth(mm-dd-yyyy):");
        dob = Console.ReadLine();

        command = myConnection.CreateCommand();
        command.CommandText = $"INSERT INTO customer(firstName, lastName, dateOfBirth) " + 
          $"VALUES('{fName}'. '{lName}', '{dob}')";

        int rowInserted = command.ExecuteReader();
        Console.WriteLine($"Row inserted: {rowInserted}");

        ReadDate(myConnection);
    }
}

static void RemoveCustomer(SQLiteConnection myConnection)
{
    SQLiteCommand command;

    string idToDelete;
    Console.WriteLine("Enter an id to delete a customer:");
    idToDelete = Console.ReadLine();

    command = myConnection.CreateCommand();
    command.CommandText = $"DELETE FROM customer WHERE rowid = {idToDelete}";
    int rowRemoved = command.ExecuteNonQuery();
    Console.WriteLine($"{rowRemoved} was removed from the table customer.");

    ReadData(myConnection);
}

static void FindCustomer()
{
    
}
