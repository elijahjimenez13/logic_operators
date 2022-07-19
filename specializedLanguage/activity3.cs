using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int userNum;
    
    userNum = 3;
    
    if (userNum < 0)
    {
    	Console.WriteLine("< 0");
    }
    else if (userNum < 10)
    {
    	Console.WriteLine("0-9");
    }
    else if (userNum < 20)
    {
    	Console.WriteLine("10-19");
    }
    else
    {
    	Console.WriteLine("error");
    }
    }
  }
}