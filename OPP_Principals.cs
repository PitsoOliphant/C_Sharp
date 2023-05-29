using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        //An abstract class is created, indicating that the derived classes will do all the processing of the given class members
        //"Public" is used in this instance to ensure accessibility of the fields to the derived classes
        //The getter and setter properties are used to ensure that the system is flexible enough that the use,
        //is able it retrieve and assign values to the fields

        abstract class Register
        {
            public string Name { get; set; }
            public string LasName { get; set; }
            public  Random StudentID { get; set; }
            public string StudentGender { get; set; }
            public string EmailAddress { get; set; }
            public DateTime DOB { get; set; }
            public string PhoneNumber { get;set; }

            //Abstract method is used to enable method overriding, the derived class will implement is configured process
            public abstract int Age();
            public abstract string promotion();
          
           

        }
        //A derived class is created with its own respective fields
        class Qualification:Register
        {
            protected internal string course { get; set; }
            internal double DegreeFees = 85000.00;
            internal double DiplomaFees = 45000.00;

            //Constructor is used to initialise the fields from the parent and the current child class
            public Qualification(string c,string n,string ln,Random SId,string Sg,string ea,DateTime date,string pn)
            {
                Name=n;
                LasName=ln; 
                StudentID=SId;
                StudentGender = Sg;
                EmailAddress=ea;
                DOB=date;
                PhoneNumber=pn;
                course = c;

            }
            //Method calculates the age of the student, taking in values of the birthdate and the current date
            public override int Age()
            {
               DateTime CurrentDate=DateTime.Now;
                int age = 0;
                age=CurrentDate.Year-DOB.Year;
                return age;
            }

            //Method takes the value from the method Age() to decide whether the potential student meets on of the conditions set out for the promotion
            //This method also checks other requirements of such as qualifcation and sex. Then a message will be returned to notify the user

            public override string promotion()
            {
                int years = Age();
                double total = 0;

                if((years>25 && string.Equals(course, "degree", StringComparison.OrdinalIgnoreCase)) && (string.Equals(StudentGender, "female", StringComparison.OrdinalIgnoreCase)))
                {
                    total= DegreeFees * 30 / 100;
                   return "Congratulations "+Name+" qualifies for the promotion";
                }
               else if ((years > 25 && string.Equals(course, "diploma", StringComparison.OrdinalIgnoreCase)) && (string.Equals(StudentGender, "female", StringComparison.OrdinalIgnoreCase)))
                {
                    total = DegreeFees * 30 / 100;
                    total = DegreeFees - total;
                    return "Congratulations! Student ID: "+StudentID+" ," + Name +" "+LasName+ " qualifies for the promotion." + " Total fees are: R" + total;
                }
                else if ((years > 25 && string.Equals(course, "degree", StringComparison.OrdinalIgnoreCase)) && (string.Equals(StudentGender, "male", StringComparison.OrdinalIgnoreCase)))
                {
                    total = DegreeFees * 19 / 100;
                    total = DegreeFees - total;
                    return "Congratulations " + Name + " qualifies for the promotion." + " Total fees are: R" + total;
                }
                else if ((years > 25 && string.Equals(course, "diploma", StringComparison.OrdinalIgnoreCase)) && (string.Equals(StudentGender, "male", StringComparison.OrdinalIgnoreCase)))
                {
                    total = DegreeFees * 19 / 100;
                    total = DegreeFees - total;
                    return "Congratulations " + Name + " qualifies for the promotion." + " Total fees are: R" + total;
                }
                else
                {
                    return   Name + " does not qualify for the promotions";
                }

            }

           


        }
        //the class inherits from qualification, since qualification inherits directly from the super class
        class StudentInfo:Qualification
        {
            public StudentInfo(string c, string n, string ln, Random SId, string Sg, string ea, DateTime date, string pn):base(c,n,ln,SId,Sg,ea,date,pn)
            {

            }
            public void StudenDetails()
            {

                int age = Age();

                Console.WriteLine();
                Console.WriteLine("Student Info: \nName: " + Name + "\nSurname: " + LasName + "\nSex: " + StudentGender + "\nStudent ID: " + StudentID.Next(50001, 59999) + "\nDate of Birth: " + DOB + "\nAge: " + age + "\nQualification: " + course);
                Console.WriteLine("==============================================================================================");
                Console.WriteLine("Student Contact Details: \nEmail Address: " + EmailAddress + "\nPhone Number: " + PhoneNumber);
                Console.WriteLine("\n=============================================================================================");
            }
        }
        static void Main(string[] args)
        {
            /*The main body provides an interface whereby the user can fill in answers that 
             * will go to the class. The variables will be used to interact with the classes*/
            //Variables that will be used for the inteface
            string qualification = "";
            double DegreeFees = 85000.00;
            double DiplomaFees = 45000.00;


            Random StudentID = new Random();
            string firstName = "";
            string LastName = "";
            StudentID.Next(50001, 59999);
            string sex = "";
            DateTime DOB = new DateTime(2000, 04, 05);
            string PhoneNumber = "";          
            string EamilAddress = "";

       
            //The interface begins here

                Console.WriteLine("Enter first name");
                 firstName = Console.ReadLine();
                Console.WriteLine("Enter last name");
                 LastName = Console.ReadLine();
            for (int i = 0; i < 3; i++)//The loop is there so that when a incorrect entry is made, the user can correct it without having to start all over
            {
                Console.WriteLine("Enter sex");
                 sex = Console.ReadLine();
                if (string.Equals(sex, "male", StringComparison.OrdinalIgnoreCase))//Program will not be case sensitive
                {
                    Console.WriteLine("You chose " + sex);
                    break;//If entry is true, the loop terminates

                }
                else if (string.Equals(sex, "female", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You chose " + sex);
                    break;//If entry is true, the loop terminates


                }
                else
                {
                    Console.WriteLine("Invalid selection");
                    i--;//If the entry is false, the user will be required to a re-entry instead of saving incorrect data

                }
            }
         
                Console.WriteLine("Enter date of birth e.g 'YYYY,MM,DD'");
                 DOB = Convert.ToDateTime(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter phone number");
                PhoneNumber = Console.ReadLine();
                if (PhoneNumber.Length != 10)//Ensuring that the user enters the correct amount of characters
                {
                    Console.WriteLine("Invalid numbers");
                    i--;

                }
                else
                {
                    Console.WriteLine("Numbers saved!");
                    break;
                }
            }
               
                Console.WriteLine("Enter Email address");
                EamilAddress = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter qualification");
                qualification = Console.ReadLine();
                if ((string.Equals(qualification, "diploma", StringComparison.OrdinalIgnoreCase)) || (string.Equals(qualification, "degree", StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("You chose " + qualification + " course");
                    if (string.Equals(qualification, "degree", StringComparison.OrdinalIgnoreCase))
                    {

                        Console.WriteLine("The total price is: R" + DegreeFees);
                        break;
                    }
                    else if (string.Equals(qualification, "diploma", StringComparison.OrdinalIgnoreCase))
                    {

                        Console.WriteLine("The total price is: R" + DiplomaFees);
                        break;

                    }
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid selection");
                    i--;

                }
            }
            //The inteface ends here
               
            //Assigning the class into a variable
            StudentInfo BC = new StudentInfo(qualification, firstName, LastName, StudentID, sex, EamilAddress, DOB, PhoneNumber);
           
            //object of the class
            string disply=BC.promotion();
            Console.WriteLine(disply);//displays the resutls of the method
            BC.StudenDetails();//Displays all the student details
            Console.ReadLine();


        }
    }
}
