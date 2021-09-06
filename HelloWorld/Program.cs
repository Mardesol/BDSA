using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Navnet på metoden der skal køres
            //HelloWorld();
            //IsLeapYear();
        }

        public static void HelloWorld(){
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year){
            if (year % 4 == 0 && year % 100 != 0){
                return true;
            } else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0){
                return true;
            } else {
                return false;
            }
        }
    }
}
