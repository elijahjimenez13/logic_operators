using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int userAge;
    
    userAge = 55;
    
    if (userAge > 15)
    {
    	Console.WriteLine("Can drive\n");
    }
    if (userAge > 17)
    {
    	Console.WriteLine("Can vote\n");
    }
    if (userAge > 24)
    {
    	Console.WriteLine("Can rent car\n");
    }
    
    Console.WriteLine("Bye");
    }
  }
}