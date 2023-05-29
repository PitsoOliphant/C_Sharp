// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/*Create a program that will ask the user for 10 numbers and store them in a list. Then show a menu for MAX,MIN, AVERAGE and SUM and use a method
* for each of those menu options. You will need to pass your list as a parameter to the methods. Max will show the biggest number,
* Min will show the smallest number, Average will show the average and Sum will show the sum.*/
{
  
    List<int> LisOfNumbers=new List<int>();
    int ListItems;
   
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("Please enter number");
         ListItems = Convert.ToInt32(Console.ReadLine());
      
        LisOfNumbers.Add(ListItems);
     
    }
    Console.WriteLine("Please select operation: max, min,average,sum");
    string operation = Convert.ToString(Console.ReadLine());
    if (operation == "max") 
    {
        Max(LisOfNumbers);
        
       
    }
    if(operation == "min")
    {
        Min(LisOfNumbers);
    }
    if(operation== "average")
    {
        Average(LisOfNumbers);
    }
    if(operation=="sum")
    {
        Sum(LisOfNumbers);
    }
    static void Max(List<int> MaxList)
    {
        int max = MaxList[0];
        for (int i = 1; i < MaxList.Count; i++)
        {
            if (MaxList[i] > max)
            {
                max = MaxList[i];
                
            }
        }
        Console.WriteLine(max + " is the largets number in the list");
    }
    static void Min(List<int>Minimum)
    {
        int min = Minimum[0];
        for (int i = 1; i < Minimum.Count; i++)
        {
            if(Minimum[i] < min)
            {
                min = Minimum[i];
            }
        }
        Console.WriteLine(min + " is the smallest value in the list");
    }
    static void Average(List<int>Mean)
    {
        int total = 0;
        for (int i = 0; i < Mean.Count; i++)
        {
             total = total + Mean[i];
        }
        int average = total / Mean.Count;
        Console.WriteLine(average + " is the average of values from the list");
    }
    static void Sum(List<int>Result)
    {
        int total = 0;
        for (int i = 0; i < Result.Count; i++)
        {
             total = total+Result[i];
        }
        Console.WriteLine(total+" is the sum of all list items ");
    }
}
/*Create a program that will ask the user for one number. Then create 3 different methods. None of the methods will have 
* a return type. Pass the number as a parameter to the method. The first method is called EvenOdd. In this method check if the numbers
* are even or odd and show a message. The next method is called IsPrime. This will check if the numbers is a prime number or not.
* The third method is called Factors. This will show all the factors of this numbe*/
{
    Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
static void EvenOdd(int userInput)
    {
        if (userInput % 2 == 0)
        {
            Console.WriteLine("You have entered a even number");
        }
        else
        {
            Console.WriteLine("You have entered a odd number");
        }
    }


    static void isPrime(int userInput)
    {
        int factor = 1;
        for (int i = 2; i <= userInput; i++)
        {
            if(userInput % i == 0)
            {
                factor++;   
            }
        }
        if(factor == 2)
        {
            Console.WriteLine("You have entered a Prime number");
        }
        else
        {
            Console.WriteLine("You have not entered a Prime Number");
        }
    }
    static void Factors( int UserInput)
    {
        int factors = 0;
        for (int i = 1; i < UserInput; i++)
        {
            if(UserInput % i == 0)
            {

                Console.WriteLine(i + ": is the factor of " + UserInput);
            }
            else
            {
                Console.WriteLine(i + ": is not a factor of " + UserInput);
            }
        }
    }

    EvenOdd(number);isPrime(number); Factors(number);
}
/*Create a program that will ask the user for their age. Create a method called in10Years that will add 10 to their age and return
 * this new age. Your method will need one parameter, the age. Back in the Main program you save this new age to a new int.
 * Then display it and say "In 10 years you will be 32 years old"*/
{
    Console.WriteLine("Please enter your current age?");
    int UserAge = Convert.ToInt32(Console.ReadLine());
    static int in10Year( int CurrentAge)
    {
        int ten = 10;
        return CurrentAge + ten;
    }
    int AgeIn10Years = in10Year(UserAge);
    Console.WriteLine("You age will be: " + AgeIn10Years + " in the next 10 years");
}

/*Create a program the will ask the user for their age. Create a method called CanVote that will check if the person is older than 18
 *  and tell them they can vote*/
Console.WriteLine("Please enter your age");
int Age = Convert.ToInt32(Console.ReadLine());
static void CanVote(int UserAge)
{
    if(UserAge > 18)
    {
        Console.WriteLine("You can vote!");
    }
    else
    {
        Console.WriteLine("Sorry bra,give it couple of years");
    }
}
CanVote(Age);  
/*Create a program that will ask the user for their cellphone numbers. Then make a method called
 * CheckNumber. THis must check if the cellphone numbers is 10 characters. THen show a message if the 
 * number is correct or not. You do not need to return anything*/
Console.WriteLine("Please enter your cellphone numbers");
string UserNumbers =(Console.ReadLine());
static void CheckNumber(string phoneNumbers)

{
    if (phoneNumbers.Length == 10)
    {
        Console.WriteLine("You have entered correct numbers");
    }
    else
    {
        Console.WriteLine("Please enter 10 numbers");
    }
}    
CheckNumber(UserNumbers);

Console.WriteLine("Enter name and surname please");
string Name =Console.ReadLine(); 
string Surname=Console.ReadLine();

static string FullName(string firstName,string lastName)
{
     return firstName +" "+ lastName;
}
string UserDetails =FullName(Name,Surname);
Console.WriteLine(UserDetails);

/*Create a program that will ask the user for 2 numbers. Then make four different methods. Send 
 * the numbers to each method. Use methods to add, subtract, multiply and divide the numbers. Inside 
 * the divided method, check if the second number is zero. For each method you can show the answer*/
Console.WriteLine("Please give two nunbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = 0;
static void Add(int userInput,int userInput2)
{
    int result = userInput + userInput2;
  Console.WriteLine(userInput+"+"+userInput2 +"= "+result);
    
}

static void Minus(int userInput, int userInput2)
{
    int result = userInput - userInput2;
    Console.WriteLine(userInput + "-" + userInput2 + "= " + result);

}

static void multiply(int userInput, int userInput2)
{
    int result = userInput * userInput2;
    Console.WriteLine(userInput + "*" + userInput2 + "= " + result);

}

static void Divide(int userInput, int userInput2)
{
    if(userInput2==0)
    {
        return;
    }
    else
    {
        int result = userInput / userInput2;
        Console.WriteLine(userInput + "/" + userInput2 + "= " + result);

    }
}
Minus(num1, num2);
Add(num1,num2);
multiply(num1, num2);
Divide(num1, num2);
/*Create a program with a method that will ask the user for their name and then,
 * say "Hello name".*/
static void UserName()
{
    Console.WriteLine("Give name");
    string Name =Console.ReadLine();    
    if(Name!=null)
    {
        Console.WriteLine("Hello " + Name);
    }
}

UserName();
Console.ReadLine();
