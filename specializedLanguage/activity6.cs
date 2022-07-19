using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    float bodyTemp;
    
    bodyTemp = 99;
    
    if (Math.Abs(bodyTemp - 98.6) < 0.0001)
    {
    	Console.WriteLine("Exactly normal");
    }
    else if ((bodyTemp > 98.6))
    {
    	Console.WriteLine("Above normal");
    }
    else
    {
    	Console.WriteLine("Below normal");
    }
    }
  }
}