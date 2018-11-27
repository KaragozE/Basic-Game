using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Start:
            Random numGen = new Random ();
            int num1 = numGen.Next(1,101);
            int flag = 0;
            int numMax = 100;
            int numMin = 0;

            while (flag == 0)
            {

                for (int i = 1; ; i++)
                {

                    Console.Write("Predict Number between "+numMin+" to "+numMax + " :");
                     int num2;
          
    
                    try
                    {

                        num2 = Convert.ToInt32(Console.ReadLine());
                       
                            if (num2 == num1)
                            {
                                Console.WriteLine("Correct Number " + i + " times trying");
                                flag = 1;
                                Console.WriteLine("press any button to play again");
                                Console.ReadKey();
                                goto Start;
                            }
                            else if (num2 < num1) 
                            {
                               if (num2>numMin)
                               {
                                numMin = num2;
                                Console.WriteLine("more than" + num2);
                               }
                               else
                               {
                                Console.WriteLine("more than" + num2);
                               }
                             
                            }
                            else if (num2 > num1)
                            {
                                if (num2 < numMax)
                                {
                                numMax = num2;
                                Console.WriteLine("less than" + num2);
                                }
                                else
                                {
                                Console.WriteLine("less than" + num2);
                                }
                            
                            }

                            else if (num2 < 0 && num2 > 100)
                            {
                                Console.WriteLine("Correct number is between 0 to 100 try again");
                            }
                        
                    }
                    catch
                    {
                        Console.WriteLine("wrong character try again");
                    }
                }

            }
        
        }
       
    }
    
}
