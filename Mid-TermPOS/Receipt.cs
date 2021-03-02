using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_TermPOS
{
    class Receipt
    {
        public static void GenerateReceipt(List<Product> cart, Payment pay)
        {
            double total = 0;
            Console.WriteLine("Here is your receipt: \n");
            foreach (LineItem lineitem in cart) 
            {
                Console.WriteLine(lineitem.Name + "              " + lineitem.Count.ToString() + " : $" + (lineitem.Count * lineitem.Price).ToString());

                total += lineitem.Count * lineitem.Price;

            }
            Console.WriteLine("Your tax is :"+(0.06 * total).ToString());
            Console.WriteLine("Your total is :" + (1.06 * total).ToString());
            Console.WriteLine("With payment information below: ");    
            
            switch (pay.Type)
            {
                case "Cash":
                    break;
                case "Card":
                    Console.WriteLine("CardNumber: " + pay.CardNumber);
                    Console.WriteLine("Expiration Month: " + pay.ExpMonth);
                    Console.WriteLine("Expiration Year: " + pay.ExpYear);
                    Console.WriteLine("CVV: " + pay.CVV);
                    break;
                case "Check":
                    break;
            }


        }
    } }
