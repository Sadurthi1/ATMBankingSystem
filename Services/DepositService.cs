namespace ATM_Banking_System.Services
{
    public class DepositService
    {
        public void Deposit()
        {
            while (true)
            {

                {
                    Console.WriteLine("Are you sure for deposit: \"1 = Yes\", \"2 = No\" ");
                    string confirmation = Console.ReadLine();
                    if (confirmation == "1")
                    {
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Please enter the amount to deposit:");
                        string input = Console.ReadLine();
                        int i = Convert.ToInt32(input);
                        if (i >= 1000)
                        {
                            Console.WriteLine("Are you sure the amount is correct: \"1. Yes\", \"2. No\" ");
                            string confirmation2 = Console.ReadLine();
                            if (confirmation2 == "1")
                            {
                                Console.WriteLine("loading.............Deposit successful!");
                                Console.WriteLine("Thanks for using our bank");
                                ATMService aTMService = new ATMService();
                                aTMService.ValidatePin();
                            }
                            else if (confirmation2 == "2")
                            {
                                Console.WriteLine("Deposit cancelled.");
                                Console.WriteLine("Come back for more transactions");
                                Console.WriteLine();
                                ATMService aTMService1 = new ATMService();
                                aTMService1.ValidatePin();
                               
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("loading.................Should be greater than 1000");
                                Console.WriteLine();
                                continue;
                            }
                        }
                        else if (confirmation == "2")
                        {
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Reached the limit");
                            Console.WriteLine("====================================================");
                            return;
                        }
                    }
                    Console.WriteLine("====================================================");
                    Console.WriteLine("Return to Main Menu");
                    Console.WriteLine("====================================================");
                    ATMService aTMService2 = new ATMService();
                    aTMService2.ValidatePin();
                }
            }
        }
    }
}
