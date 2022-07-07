using System;
using System.Collections.Generic;
/*.=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= -.
   /------------------------------ \
  |     By                                     |
  |     Jacob Merlin                   |
   \------------------------------ /
                 !           ! 
                !           !
                !          !
               ! _       !
         /   !__)     !
 __/___/_____)
        (_______)
 ___(______)
      \_(____)
         !       !
         !      !
         \__/
'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='*/

namespace master_List_EXE
{//todo===============================================================================================================
    public class List_01
    {//?=============================================================================================================

        public static void addSpaces()
        {//~========================================================================================================
            Console.WriteLine("================================================================");
            Console.WriteLine("================================================================");
        }//~========================================================================================================

        public static void PrintGreeting()
        {//~========================================================================================================
         //== varibes == 
            //================
            string str_1;
            string str_2;
            //================
            str_1 = "Hello everyone! Welcome to my methods script.";
            str_2 = "This will showcase using if statements.";
            //================

            //!Logic ================================================================================================
            Console.WriteLine(str_1);
            Console.WriteLine(str_2);

        }//~========================================================================================================

        public static void PrintGameDetails()
        {//~========================================================================================================
         //== varibes == 
            //================
            string str_1;
            string str_2;
            //================
            str_1 = "This will be a game where you guess what the A.I. favorite number is.";
            str_2 = "The A.I. will guess higher or lower, if it guesses right you win! ";
            //================

            //!Logic ================================================================================================
            Console.WriteLine(str_1);
            Console.WriteLine(str_2);

        }//~========================================================================================================

        public static void method_1()
        {//~========================================================================================================
            //== varibes == 
            //================
            var r = new Random();
            int favNumber = r.Next(1, 100);
            //================
            bool isValid;
            int input;
            int num_Tries = 9;
            bool out_Of_Tries = false;
            //================
            //!Logic ================================================================================================
           

            do
            {//todo==============================================================
                Console.WriteLine("Please input a number.");
                isValid = int.TryParse(Console.ReadLine(), out input);
                
                if (input > favNumber)
                {//?=============================
                    Console.WriteLine("Your number is higher!");
                    isValid = false;
                    num_Tries--;
                    Console.WriteLine("Tries Left: " + num_Tries);
                }//?=============================
                else if (input < favNumber)
                {//?=============================
                    Console.WriteLine("Your number is lower!");
                    isValid = false;
                    num_Tries--;
                    Console.WriteLine("Tries Left: " + num_Tries);
                }//?=============================
                else 
                {//?============================= 
                    Console.WriteLine("Congratulations for guessing the correct number!");
                    isValid = true;
                }//?=============================
                if(num_Tries == 0)
                {//?=============================
                    out_Of_Tries = true;
                    isValid = true;
                }//?=============================
            }//todo==============================================================
            while (!isValid);

            if (out_Of_Tries)
            {//?=============================
                Console.WriteLine("out of tries.");
            }//?=============================

        }//~========================================================================================================

        public static void method_2()
        {//*========================================================================================================
         //==== varibes ====

            //================
            int input;
            bool isValid;
            int num_Tries = 9;
            bool out_Of_Tries = false;
            //================
            Console.WriteLine("Please input a number.");
            isValid = int.TryParse(Console.ReadLine(), out input);
            Console.WriteLine(input);


            switch (input)
            {
                case 1:
                    Console.WriteLine("English");
                    break;
                case 2:
                    Console.WriteLine("Math");
                    break;
                case 3:
                    Console.WriteLine("Science");
                    break;
                case 4:
                    Console.WriteLine("History");
                    break;
                case 5:
                    Console.WriteLine("P.E.");
                    break;
                default:
                    Console.WriteLine("You must just really hate school.");
                    break;
            }

        }//*========================================================================================================

    }//?=============================================================================================================

}//todo===============================================================================================================