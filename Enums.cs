// See https://aka.ms/new-console-template for more information

foreach (calculator operation in Enum.GetValues(typeof(calculator)))
{
    Console.WriteLine($"To choose {operation.ToString()}, press {(int)operation}");
}
int UserChoice = Convert.ToInt32(Console.ReadLine());
Add(UserChoice);
Subtract(UserChoice);
Multiply(UserChoice);
Divide(UserChoice);


int userInput =Convert.ToInt32(Console.ReadLine());
static void Add(int operation)
{
    if(operation == 1)
    {
        Console.WriteLine("Enter the first number you would like to add");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number you would like us to add");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        int result = Num1 + Num2;
        Console.WriteLine(result);
    }
}

static void Subtract(int operation)
{
    if( operation == 2)
    {
        Console.WriteLine("Enter the first number you would like to subtract");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number you would like us to subtract");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        int result = Num1 -Num2;
        Console.WriteLine(result);
    }
}

static void Multiply(int operation)
{
    if (operation == 3)
    {
        Console.WriteLine("Enter the first number you would like to multiply");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number you would like us to multiply");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        int result = Num1 * Num2;
        Console.WriteLine(result);
    }
}

static void Divide(int operation)
{
    if (operation == 4)
    {
        Console.WriteLine("Enter the first number you would like to divide");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number you would like us to divide");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        int result = Num1 / Num2;
        Console.WriteLine(result);
    }
}
Console.ReadLine();




enum calculator
{
    Add =1,
    Subtract,
    Multiply,
    Divide
}