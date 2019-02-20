using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Enter the number of the month: ");
            string userValue = Console.ReadLine();
            string monthName = "";
           {
            if(userValue == "1");
                monthName = January; 
                                        
            if(userValue == "2");
                monthName = February; 
                                        
            else if (userValue == "3")
                monthName = March; 
                                        
            else if (userValue == "4");
                monthName = April; 
                                        
            else if (userValue == "5");
                monthName = May; 
                                        
            else if (userValue == "6");
                monthName = June; 
           
            else if (userValue == "7");
                monthName = July; 
           
            else if (userValue == "8");
                monthName = August; 
           
            else if (userValue == "9");
                monthName = September; 
           
            else if (userValue == "10");
                monthName = October; 
                                             
            else if (userValue == "11");
                monthName = November; 
                                          
           
            else if (userValue == "12");
                monthName = December; 
           }                               
            string monthName = string.Empty;


            Console.WriteLine($"The name of the month you entered is : (monthName)");

            Console.ReadLine();
        }   
    }
}
