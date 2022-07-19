using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int timeHour;
    int timeMinute;
    float tollAmount;
    
    timeHour = 9;
    timeMinute = 30;
    
    if (timeHour < 6)
    {
    	tollAmount = 1.50f;
    }
    else if (timeHour < 10)
    {
    	tollAmount = 4.60f;
    }
    else if (timeHour < 18)
    {
    	tollAmount = 2.30f;
    }
    else
    {
    	tollAmount = 1.50f;
    }
    
    Console.WriteLine("Toll: " + tollAmount);
    }
  }
}