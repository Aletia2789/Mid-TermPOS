using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_TermPOS
{
    class Payment
    {
        public static void MakePayment()
        {
            Console.WriteLine("How would you like to pay?\n 1=Cash \n 2=Credit \n 3=Check");
            string choice = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Sorry, " + choice + " is not an option. \nHow would you like to pay?\n 1=Cash \n 2=Credit \n 3=Check");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case "1":
                    break;
                case "2":

                    break;
                case "3":
                    break;
            }

        }

        public static CreditCard GetCardInfo()
        {
            Console.WriteLine("What is your card number? ");
            string card_number = Console.ReadLine();
            while (card_number.Length != 16)
            {
                Console.WriteLine("Sorry, " + card_number + " is not 16 numbers. \nWhat is your card number?");
                card_number = Console.ReadLine();
            }

            Console.WriteLine("What is your card expiration month? ");
            string ex_month = Console.ReadLine();
            while (ex_month.Length != 2)
            {
                Console.WriteLine("Sorry, " + ex_month + " is not 2 numbers. \nWhat is your card expiration month? ");
                ex_month = Console.ReadLine();
            }

            Console.WriteLine("What is your card expiration year? ");
            string ex_year = Console.ReadLine();
            while (ex_year.Length != 2)
            {
                Console.WriteLine("Sorry, " + ex_year + " is not 2 numbers. \nWhat is your card expiration year?");
                ex_year = Console.ReadLine();
            }

            Console.WriteLine("What is your card cvv? ");
            string cvv = Console.ReadLine();
            while (cvv.Length != 3)
            {
                Console.WriteLine("Sorry, " + cvv + " is not 3 numbers. \nWhat is your card cvv? ");
                cvv = Console.ReadLine();
            }

            return new CreditCard(card_number, ex_month, ex_year, cvv);

        }
    }
}
}
