using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int timeHour;
    int timeMinute;
    int numPersons;
    float tollAmount;
    
    timeHour = 9;
    timeMinute = 30;
    numPersons = 3;
    
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
    
    // Check for carpool (3 or more persons) and update toll
    if (numPersons >= 3)
    {
    	if ((timeHour >= 6) && (timeHour <= 10))
        {
        	tollAmount = tollAmount *0.5f;
        }  	
        else
        {
        	tollAmount = 0.0f;
        }
    }
    Console.WriteLine("Toll: " + tollAmount);
    }
  }
}