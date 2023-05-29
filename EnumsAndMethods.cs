// See https://aka.ms/new-console-template for more information

using System.Data.Common;

/*Question2
Create an application that validates user credentials, that is, username and password. The system should 
be able to track how many times a user is allowed to attempt to login without fail. The user is only required 
to attempt 3 times, if user exceeds the system should then kick out the user. Use a loop to achieve this. 
You are requested to use the following credentials as your test data:
Username: abcd
Password: 1234
 */
int availableBalance = 600;
int Total = 0;
int amount = 0;
for (int i = 3; i > 0; i--)
{
    Console.WriteLine("Enter username");
    string username =Console.ReadLine();
    Console.WriteLine("Enter password");
    string password = Console.ReadLine();
    if(username == "abcd" && password== "1234")
    {
        
        Console.WriteLine("Welcome");
        break;
        foreach (Question2 item in Enum.GetValues(typeof(Question2)))
        {
            Console.WriteLine($"{(int)item}:{item.ToString()}");
        int operation = Convert.ToInt32(Console.ReadLine());

        if (operation == 1)
        {
            for (int b = 1; b < 0; b++)
            {
                Console.WriteLine("Enter the amount you wish to send");
                amount = Convert.ToInt32(Console.ReadLine());
                if(amount>availableBalance)
                {
                    Console.WriteLine("Insufficient amount! please try again");
                }
                else
                {
                    Console.WriteLine("You amount was succesfully transfered");
                        availableBalance = availableBalance - amount;
                        break ;
                }
            }


        }
        if (operation == 2)
        {
                for (int c = 1; c < 0; c++)
                {
                    Console.WriteLine("Enter the amount you wish to send");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (amount > availableBalance)
                    {
                        Console.WriteLine("Insufficient amount! please try again");
                    }
                    else
                    {
                        Console.WriteLine("You amount was succesfully transfered");
                        availableBalance = availableBalance - amount;
                        break;
                    }
                }


            }
            if (operation == 3)
        {
                {
                    Console.WriteLine("You have R" + availableBalance + " remaining in your account.");

                }
            
        }
        if (operation == 4)
        {
           break ;
        }

     }



        }
    else
    {
        Console.WriteLine("You have " + i + " attempts left");
    }
}
/*Question1:
 * You are required to create a menu driven program using enums that gives the following setup:
 * 1)Triangle
 * 2)Rectangle
 * 3)Circle
 Use formulae given:
Triangle Area =1/2*base*height
Rectangle Area =width*height
Circle Area= 1.428*radius*radius

You are required to create a program that will ask the user for a shape (rectangle, circle or 
triangle.) Then using the relevant formula, the program will ask the user for the necessary
data in order to calculate the area of the shape. Please ensure that you make use of different mathods for
each of the shapes to calculate the area of that shape*/

foreach (Question1 item in Enum.GetValues(typeof(Question1)))
{
  
    Console.WriteLine($"To choose {item.ToString()}, press {(int)item}");
}
int UserShapes =Convert.ToInt32(Console.ReadLine());
if(UserShapes == 1)
{
    Triangle();
}
if(UserShapes == 2)
{
    Rectangle();
}
if(UserShapes == 3)
{
    Circle();
}
static void Triangle()
{
    Console.WriteLine("Enter the base");
    double Base = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the height");
    double Height =Convert.ToInt32(Console.ReadLine());
    double TriangleArea =(1/2)*Base*Height;
    Console.WriteLine(TriangleArea);
}
static void Rectangle()
{
    Console.WriteLine("Enter width");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter height");
    double height = Convert.ToDouble(Console.ReadLine());
    double RectangleArea =width*height;
    Console.WriteLine(RectangleArea);
}
static void Circle()
{
    Console.WriteLine("Enter circle radius");
    double radius = Convert.ToDouble(Console.ReadLine());      
    double CircleArea =radius*radius*3.142;
    Console.WriteLine(CircleArea);

}



Console.ReadLine();

enum Question1
{
    Triangle=1,
    Rectangle,
    Circle
}
enum Question2
{
    Send_Money=1,
    Buy_Airtime,
    Check_Balance,
    Exit
}
