// See https://aka.ms/new-console-template for more information
   

/*Create a program to check if a number is a prime number*/

using System.Globalization;
/*Use a for loop and ask the user for a number and an exponent. Then show the answer*/
{
   Console.WriteLine("Enter number");
    int num = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter exponent");
    int exponent = Convert.ToInt16(Console.ReadLine());
    int total = 1;
    for (int i = 1; i <= exponent; i++)
    {
        total = total * num;
    }
    Console.WriteLine(total);
}
/*Create a program that will ask the user for 10 numbers. Each time show the number multiplied by 8.
 * Ask the number only once, but use it inside the for-loop. The for loop will do it 10 times*/
{
    Console.WriteLine("Please give 10 numbers");
    int input = Convert.ToInt16(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(input * 8);
    }
}

{
    Console.WriteLine("Please give number");
    int input = Convert.ToInt16(Console.ReadLine());

    int divisor = 0;
    for (int i = 1; i <=input; i++)
    {
      
        
            if(input%i==0)
            { divisor++;
               
           

            }
           

        
    }
            if(divisor==2)
            {
            Console.WriteLine("It is a prime number");
            }
    else
    {
        Console.WriteLine(input + ": is not a prime number");
    }
       
    
}
        
    /*Create a program that can show all the factors of a number*/
    {
        Console.WriteLine("Enter number please");
        int num = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i <= num)
        {
            i++;
            if (num % i == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
    /*Create a program that will ask users for a word. Then use a for-loop with the 
     * word length. Show each letter on a line and check if a letter is "a"*/
    {
        Console.WriteLine("Please give word");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a')
            {
                Console.WriteLine(str[i] + ": this is a");
            }
            else
            {
                Console.WriteLine(str[i] + ": this is not a");
            }
        }
    }
    /*Create that will ask the user for a word, use a for-loop with the word length
     * Show each letter on a line and then show that letter in uppercase*/
    {
        Console.WriteLine("Please give word");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str.ToUpper()[i]);
        }


    }
    /*Create a program that will ask the user for a word. 
     * Then use the length of the word to show the word that number of times.*/
    {
        Console.WriteLine("Please give word");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine(str[i]);
        }
    }
    /*Create a program that will ask the user for a word. Then the length of the word
     * to show the word that number of times*/
    {
        int i = 0;
        Console.WriteLine("Please give word");
        string UserInput = Console.ReadLine();
        while (i < UserInput.Length)
        {
            Console.WriteLine(UserInput);
            i++;
        }
    }
    /*Create a program that will show the multiples of 5 up to 200*/
    {
        int i = 0;
        while (i <= 200)
        {
            Console.WriteLine(i);
            i += 5;
        }
    }
    /*Create a program that will show 1 to 100*/
    {
        int i = 1;
        while (i <= 100)
        {
            Console.WriteLine(i);
            i++;
        }
    }


    /*Create a program that will show the word,"hello" 10 times*/
    {
        int i = 0;
        while (i < 10)
        {
            i++;
            Console.WriteLine(i + ")hello");
        }
    }
    /*Ask the user for a number and show that number 10 times*/
    {
        int i = 0;
        Console.WriteLine("Please enter number");
        int UserInput = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < UserInput; i++)
        {
            Console.WriteLine(i + ")hello");
        }
    }
Console.ReadLine();
   