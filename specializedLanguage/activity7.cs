using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    int hotelRate;
    int userAge;
    
    hotelRate = 155;
    userAge = 22;
    
    if (userAge > 65)
    {
    	hotelRate = hotelRate - 20;
    }
    
    Console.WriteLine("Your rate: " + hotelRate);
    }
  }
}