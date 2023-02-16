using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialized variables
            int passLenght;
            string passChars;
            int i;
            int j;
            int index;
            string generatedPass;
            int passNum;
            bool keepGoingNum;
            bool keepGoingLenght;


            //Declared variables
            passLenght = 0;
            passChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*_+=?";
            i = 0;
            j = 0;
            Random numRad = new Random();
            index = 0;
            passNum = 0;
            keepGoingNum = true;
            keepGoingLenght = true;
            List<string> passwordGenerates = new List<string>();


            Console.WriteLine("\n---Password Generator Application---\n");
            
            while (keepGoingNum)
            {
                Console.WriteLine("How many password do you want to generate?: ");
                //Validation of input number
                if (!int.TryParse(Console.ReadLine(), out passNum) || passNum <= 0)
                {
                    Console.WriteLine("Error! invalid input please enter number");
                }
                else
                {
                    keepGoingNum = false;
                }
            }

            while (keepGoingLenght)
            {
                Console.WriteLine("Enter the password lenght: ");
                //Validation of input number
                if (!int.TryParse(Console.ReadLine(), out passLenght) || passLenght <= 0)
                {
                    Console.WriteLine("Error! invalid input please enter number");
                }
                else
                {
                    keepGoingLenght = false;
                }
            }

            for (j = 0; j <passNum; j++)
            {
                
                generatedPass = string.Empty;

                for (i = 0; i < passLenght; i++)
                {
                    index = numRad.Next(0, passChars.Length);
                    generatedPass += passChars[index];
                }

                //Store the password in list
                passwordGenerates.Add(generatedPass);
            }

            foreach (string pass in passwordGenerates)
            {
                Console.WriteLine($"Generated Password: {pass}");
            }
           

            

        }
    }
}
