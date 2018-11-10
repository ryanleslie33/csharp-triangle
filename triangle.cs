using System;

class FindTriangle
{
  static void Main()
  {
    Console.WriteLine("what is the length of your first side?");
    string sideOne = Console.ReadLine();
    int inputOne = int.Parse(sideOne);

  Console.WriteLine("what is the length of your second side?");
string sideTwo = Console.ReadLine();
  int inputTwo = int.Parse(sideTwo);
Console.WriteLine("what is the length of your third side?");
string sideThree = Console.ReadLine();
  int inputThree = int.Parse(sideThree);
if (inputOne == inputTwo && inputTwo == inputThree)
{

  Console.WriteLine("your triangle is a equilateral");
   }
   if( inputOne == inputTwo || inputTwo == inputThree)
   {
     Console.WriteLine("your triangle is a scalene");
   }
   else
    {
     Console.WriteLine("your triangle is stupid");
   }
  }
}
