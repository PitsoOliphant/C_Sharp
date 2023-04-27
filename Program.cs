using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG161_Test1PitsoOliphant_578437
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AvailableBalance = 600;
            string UserName = "Pitso";
            int Pin = 12345;
            int Transaction = 0;
            int iterator1 = 1;
            int Amount = 0;
            string[] Rate = new string[] { "bad", "good", "Excellent" };
   
           
          
            
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Please enter user name");
                string UserNameInput=Console.ReadLine();
                Console.WriteLine("Please enter your pin");
                int UserPinInut = Convert.ToInt16(Console.ReadLine());
                if (UserNameInput != UserName && UserPinInut != Pin)
                {
                    Console.WriteLine("Incorrect pin or user name");
                    if(i==3)
                    {
                        Console.WriteLine("You have exhausted your attempts.");

                    }
                }
                else
                {
                    i = 3;
                    while (iterator1 > 0)
                    {
                        Console.WriteLine("Please select the following transaction: \r\n 1) Send Money\r\n 2) Buy Airtime\r\n 3) View Balance\r\n 4) Exit");
                        Transaction = Convert.ToInt16(Console.ReadLine());
                        if (Transaction == 1)
                        {


                            Console.WriteLine("Enter the amount you would like to send");
                            Amount = Convert.ToInt16(Console.ReadLine());
                           
                            if (Amount > AvailableBalance)
                            {
                                Console.WriteLine("Insufficient amount! Please try again");
                            }
                            else
                            {

                                AvailableBalance = AvailableBalance - Amount;
                                Console.WriteLine("You have successfully sent: R" + Amount);
                             

                            }




                        }

                        if (Transaction == 2)
                        {
                            for (int b = 1; b > 0; b++)
                            {
                                Console.WriteLine("Enter the amount of airtime you would like to purchase");
                                Amount = Convert.ToInt16(Console.ReadLine());
                                if (Amount > AvailableBalance)
                                {
                                    Console.WriteLine("Insufficient amount! Please try again");
                                }
                                else
                                {
                                    AvailableBalance = AvailableBalance - Amount;
                                    Console.WriteLine("Transaction was successfull");
                                    break;

                                }
                            }

                         }

                        if (Transaction == 3)
                         {
                        Console.WriteLine("You have R" + AvailableBalance + " remaining in your account");
                         }

                        if (Transaction == 4)
                         {

                            for (int c = 0; i < 4; c++)
                            {

                                Console.WriteLine("Please rate our service. 1 to 3 \n1 being poor and 3 being excellent");
                                int service = Convert.ToInt16(Console.ReadLine());
                                if (service == 1)
                                {
                                    Console.WriteLine(Rate[0]);
                                    Console.WriteLine("===============================================================");
                                    Console.WriteLine("Thank you!");
                                    Console.WriteLine("===============================================================");
                                    break;
                                }
                                else if (service == 2)
                                {
                                    Console.WriteLine(Rate[1]);
                                    Console.WriteLine("===============================================================");
                                    Console.WriteLine("Thank you!");
                                    Console.WriteLine("===============================================================");
                                    break;
                                }
                                else if (service == 3)
                                {
                                    Console.WriteLine(Rate[2]);
                                    Console.WriteLine("===============================================================");
                                    Console.WriteLine("Thank you!");
                                    Console.WriteLine("===============================================================");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid selection. Please try again");
                                    c--;
                                }
                            }


                            break;
                         }
                        iterator1++;
                    }





                }

            }





             Console.WriteLine("Press any key to teminate");
            
            
              Console.ReadKey();
        }
    }
}
