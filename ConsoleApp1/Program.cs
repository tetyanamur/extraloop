using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {


            bool IsMonth;
          
            {


                do 
                {
                    ;
                    Console.WriteLine("Independence month?");

                   string sample = Console.ReadLine();


            
                  



                
                    if  (sample == "july")
                    {
                     Console.WriteLine("Correct");
                    }
                    
                    else
                    {
                        Console.WriteLine("Wrong");
                    }
                    // Do Something
                   
                    IsMonth = Boolean.TryParse(sample, out IsMonth);

                } while (IsMonth == false) ;
                }
                }
        }
    }





                    

                    
