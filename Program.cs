using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRef
{
    class Program
    {
        static void Main(string[] args)
        {   //This reference based on learning from 6warni youtube channel
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

            /** Multi
              * Line
              * Comment Bettty Compliant Or not i don't know ":
              */
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

            Console.WriteLine("----------------End of Context----------------");
            Console.ReadLine();
            //Console.ReadKey();
            
        }
        
        public static string print(string name)
        {
            string welcomeMessage = "Welcome " + name;
            return (welcomeMessage);
        }
    }
}
