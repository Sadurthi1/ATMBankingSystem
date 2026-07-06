

using ATM_Banking_System.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATM_Banking_System.Models
{
    public class Account
    {
        public void Acnt()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Please enter your account number:");

            string line = Console.ReadLine();
            int AccountNumber = Convert.ToInt32(line);
            if (AccountNumber > 10000) // Account Number Validation //
            {
                Console.WriteLine();
                Console.WriteLine("loading...............Account number is valid.");
                Console.WriteLine("Please enter your PIN:");
                string pin = Console.ReadLine();
                int pinno = Convert.ToInt32(pin);
                    if (pinno > 1000) // Pin Validation //
                    {
                        Console.WriteLine();
                        Console.WriteLine("loading.................PIN is valid.");
                       ATMService aTMService = new ATMService();
                       aTMService.ValidatePin();

                     }
                    else
                    {
                        Console.WriteLine("PIN is invalid.");
                        Environment.Exit(0);
                    }
            }
            else
            
            {
                Console.WriteLine("Account number is invalid.");
                Environment.Exit(0);
            }
        
        }



    }

}
