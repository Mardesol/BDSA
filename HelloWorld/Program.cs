using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Metoden der skal køres
            IsLeapYearUI();
        }

        public static void HelloWorld(){
            Console.WriteLine("Hello World!");
        }

        public static void IsLeapYearUI(){
            // Breaks tests since I can't figure out how to make the writer skip to next line.
            //Console.WriteLine("Type in year to check if it is a leap year:");
            
            try {
                var input = Console.ReadLine();
                int year = Convert.ToInt32(input);
                
                if (IsLeapYear(year)){
                    Console.WriteLine("Yay");
                } else {
                    Console.WriteLine("Nay");
                }
            }

            catch (FormatException){
                Console.WriteLine("You can only input numbers, pal");
            }

            catch (ArgumentOutOfRangeException){
                Console.WriteLine("Too old");
            }

            // Fanger alle exceptions som ikke er fanget endnu
            catch (Exception e){
                System.Console.WriteLine(e.Message);
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year < 1583) {
                throw new ArgumentOutOfRangeException();
            }
        
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
