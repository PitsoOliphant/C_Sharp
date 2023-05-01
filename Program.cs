// See https://aka.ms/new-console-template for more information

//Question_1:Write code that attempts to add an int and a string and save the result in a int
int Num1 = 10;
string Pitso="10";
int Result = Num1 + Convert.ToInt16(Pitso);
Console.WriteLine(Result);
//Question_2:Write code that attempts to add an int and a string and save the result in a string.Using type casting
int Num2 = 5;
string str2 = "five";
string str3 = Convert.ToString(Num2) + ": "+str2;
Console.WriteLine(str3);
/*Question_3:Write program that stores an integer value.Print the integer value. 
 * Convert the value to a decimal using type casting. Print the decimal value*/
int Num3 = 54;
double D1;
Console.WriteLine(Num3);
D1 = (double)Num3;
Console.WriteLine(D1);
/*Question_4: Write program that stores a decimal value. Print the decimal value.
 * Convert the value into a integer value using type casting. Print the integer value*/
double D2 = 54.6597;
int Num4;
Num4 = (int)D2;
Console.WriteLine("This is the double value:"+D2);
Console.WriteLine("This is the converted integer value: " + Num4);
/*Question_5: Create a variable that stores a character, 'A' using implicit conversion*/
char chr = 'A';
int Num5 = chr;
long LongNum1 = chr;
float FloatNum1 = chr;  
double DoubleNum1 = chr;
Console.WriteLine("From char to int: "+Num5);
Console.WriteLine("From char to long: " + LongNum1);
Console.WriteLine("From char to float: " + FloatNum1);
Console.WriteLine("From char to doubl: " + DoubleNum1);




Console.ReadLine();