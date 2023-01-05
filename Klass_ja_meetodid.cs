Console.WriteLine("Name your dog: ");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {myDog._name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog._name}.");

myDog.Rename("Bad Boy");


while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    public string _name; //field
    public int _levelOfHappiness;
    //constructor
    public Dog(string name) //name -lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter 
    public string Name
    {
       get { return _name; }
    }
    public int LevelOfHappiness
    {
        get{ return _levelOfHappiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }
    public void WagTail()
    (
        Console.WriteLine("Wiggle-wiggle!");
    )
}
