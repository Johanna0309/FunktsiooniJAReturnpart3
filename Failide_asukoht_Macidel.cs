using System;
using System.ID;

namespace DataFromFile
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/tktkbehringer/projects/foods.txt";
            string [] dataFromFile = File.ReadAllLines(filePath);

            foreach(string element in dataFromFile)
            {
                Console.WriteLine(element);
            }
        }
    }

}
