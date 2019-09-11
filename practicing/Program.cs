using System;

namespace practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            //I was using this as a template to learn loops and bools and how to break
            Console.WriteLine("Guess a number between 1 and 10. If you guess the right number, you win. If you guess the wrong number, Try again.");

            Console.WriteLine("guess a number");
            while (true)
            {
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                bool guess = true;

                if (guessedNumber == 10 == true)
                {
                    Console.WriteLine("Lucky guess");

                    break;
                }
                else if (guessedNumber > 10 == false)
                {
                    Console.WriteLine("Guess again...");
                }
                
            }
            
           




          
             

     
            
             
            
               
          
            
         
            


            
            
            

       

            

           
            

            
            
             

            
            

            


            
            
            
        }
              
        }
    }