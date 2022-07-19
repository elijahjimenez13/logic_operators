using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int userChannel;
    
    userChannel = 1300;
    
    if ((userChannel >= 2) && (userChannel <= 499))
    {
    	Console.WriteLine("Standard");
    }
    else if ((userChannel >= 1002) && (userChannel <= 1499))
    {
    	Console.WriteLine("High del");
    }
    else
    {
    	Console.WriteLine("Error");
    }
    }
  }
}