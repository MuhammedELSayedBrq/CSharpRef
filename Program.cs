using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MyClassLibrary;

namespace CSharpRef
{
    class Program
    {
        static void Main(string[] args)

        {   //This reference based on learning from 6warni youtube channel
            /*
            int x = 4, y = 3;
            Console.WriteLine("         ----------------Welcome To My Reference----------------\n\n\n");
            Console.WriteLine("Hello World!  "+y);
            Console.Write("No New Line After This Command. Type in any string: ");
            string userValue = Console.ReadLine();

            if (userValue == "!")
                Console.WriteLine("Exclumation Mark Input.");
            else if (userValue == ":")
                Console.WriteLine("Colon Input.");
            else
                Console.WriteLine("Not Known.");
            */

            /** Multi
              * Line
              * Comment Bettty Compliant Or not i don't know ":
              */
            /*
            Console.WriteLine("1 or no 1 ?");
            userValue = Console.ReadLine();
            string message = (userValue == "1") ? " A Car" : "Nothing";
            Console.WriteLine("You Won " + message);

            //varying console write message depending on vars after
            Console.WriteLine("{0}{1}", userValue, message);

            Console.Write("Number? ");
            int num = int.Parse(Console.ReadLine());

            for (int i=0; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            char[] arr = name.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
            string concatenated = String.Concat(arr);

            Console.WriteLine(print(concatenated));

            foreach (char ca in concatenated)
                Console.WriteLine(ca);

            int[] myNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in myNums)
                Console.WriteLine(i);
            Console.WriteLine("The Length of myNums Array is " + myNums.Length);
            int[] myNumber = new int[5];
            myNumber[0] = 10;
            myNumber[3] = 5;


            int[] randomNums = new int[20];
            Console.WriteLine("The next output is rondom generated number filling an array with length of 20 int");
            while (randomNums.Length < 20)
            {
                Random randomNum = new Random();
                int myRandomNum = randomNum.Next(1, 20);
                randomNums[randomNums.Length] = myRandomNum;                
            }
            foreach (int z in randomNums)
                Console.Write(z);
            
            Console.WriteLine("\n\nThe next number is string "+ 1.ToString());
            */
            /*
            //String
            string myStr = @"go to c:\  take the same string \n without interpret ";
            string myStr2 = string.Format("{0} and {1} this number will be more readable {2:N} ","1" , "1", 1091231231);
            string phoneNum = string.Format("+2 {0:### #### ####}", 01067318767);
            string subString = myStr.Substring(5, 11);
            string upper = myStr.ToUpper();
            string replaced = myStr.Replace(" ", "-");
            string removed = myStr.Remove(5);
            Console.WriteLine(myStr + myStr2 + "\n" + phoneNum);

            //StringBuilder is used when dealing with large string to handle memory more efficient
            StringBuilder myStr3 = new StringBuilder();
            for(int i=0; i< 100; i++)
            {
                myStr3.Append("--");
                myStr3.Append(i);
            }
            Console.WriteLine(myStr3);
            */

            /*
            //Date and Time
            DateTime nowTime = DateTime.Now;
            Console.WriteLine(nowTime + "\n" + nowTime.ToShortDateString() + "\n" + nowTime.ToLongDateString());
            Console.WriteLine(nowTime.ToShortTimeString());     
            Console.WriteLine(nowTime.AddDays(3).ToShortDateString());     
            Console.WriteLine(nowTime.AddMonths(3));
            Console.WriteLine(nowTime.Month);

            DateTime myBirthday = new DateTime(1999, 11, 01 , 4 , 16 , 55);
            DateTime myBirthday1 = DateTime.Parse("01-11-1999");
            DateTime myBirthday2 = DateTime.Parse("01/11/1999");
            TimeSpan myAge = DateTime.Now - myBirthday; //outpus: days,hours,mins,secs,femtosecs
            Console.WriteLine(myAge.TotalDays);
            */

            /*
            //Classes 
            Car car1 = new Car();
            car1.Make = "BMW";
            car1.Color = "Grey";
            car1.Model = "2019";
            car1.Year = 2024;

            Console.WriteLine(MarketValue(car1));
            */

            /*
            //Lesson 19
            cycle myCycle = new cycle("Ferrari", "off-road", 2023, "grey with red seats");
            cycle.printCount();
            */

            //Lesson 20 : variables in same class can be used anywhere in class

            //Lesson 21 Encapsulation : private variable or function of class cannot be accessed in global scope

            /*
            //Lesson 22 : Class Library 
            System.Console.WriteLine("Hello");
            //we may type the name of library or we may not 
            string text = "This is a simple file written by C# using System.IO Library.";
            System.IO.File.WriteAllText(@"C:\Users\Mohamed Khalil\source\repos\CSharpRef\Hello.txt", text);

            WebClient socket = new WebClient();
            string response = socket.DownloadString("http://6wrni.com");
            System.IO.File.WriteAllText(@"C:\Users\Mohamed Khalil\source\repos\CSharpRef\6wrni_Text.txt", response);
            */

            /*
            //Lesson 23 : DLL Class Library : in new project, class library
            //To import a library press Tools, Nuget package manager, Manage for solution then choose the lib
            operations newOp = new operations(1,2);
            Console.WriteLine( newOp.AllOperations());
            */

            /*
            // Lesson 24 : Collections
            Account acc1 = new Account();
            acc1.Name = "Account1";
            acc1.ID = "ACC001";
            acc1.Balance = 1000000;
            
            Account acc2 = new Account();
            acc2.Name = "Account2";
            acc2.ID = "ACC002";
            acc2.Balance = 2000000;

            Book b1 = new Book();
            b1.Title = "Rich dad, poor dad.";
            b1.Author = "mike wezouski";
            b1.ISBN = "0-1234-5678";

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(acc1);
            myArrayList.Add(acc2);

            // List is better than ArrayList cause it reduces runtime errors by raising errors in compile time.
            List<Account> myList = new List<Account>();
            myList.Add(acc1);
            myList.Add(acc2);

            Dictionary<string, Account> myDicitionary = new Dictionary<string, Account>();
            myDicitionary.Add(acc1.ID, acc1);
            myDicitionary.Add(acc2.ID, acc2);

            Console.WriteLine(myDicitionary["ACC001"].Name);


            foreach(Account item in myArrayList)
            {
                Console.WriteLine(item.Name);
            }
            */

            //Lesson 25 : Event Handler
            /*                         ms
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Start();



            */


            Console.WriteLine("----------------End of Context----------------");
            Console.ReadLine();
            //Console.ReadKey();

        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0}",e.SignalTime);
        }

        private static decimal MarketValue(Car car)
        {
            decimal carValue = 1000.0m;
            return carValue;
        }

        public static string print(string name)
        {
            string welcomeMessage = "Welcome " + name;
            return (welcomeMessage);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }



    }

    class Account
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
    class cycle
    {
        public cycle()
        {
            Make = "Skyline";
        }

        public cycle(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            count++;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public static int count { get; set; }
        public static void printCount(){
            Console.WriteLine("Number of cycles is {0}", cycle.count);
        }
    }

}
