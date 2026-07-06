namespace ATM_Banking_System.Services
{
    public class WithdrawService
    {
        public void Withdraw()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Please enter the amount to withdraw:");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (withdrawAmount < 2000) { 
                Console.WriteLine("Are you sure, the withdraw amount is correct: " + withdrawAmount + " \"1 = Confirm\", \"2 = Ignore\" ");
                string confirmation = Console.ReadLine();
                if (confirmation == "1") { 
                    Console.WriteLine("Choose type of amount: \"0. 1\",\"1. 10\" ,\"2. 20\", \"3. 50\", \"4. 100\" ");
                    string[] options = { "0. 1","1. 10", "2. 20", "3. 50", "4. 100" };
                    if (withdrawAmount % 10 != 0)
                    {
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine("Withdraw amount should be in multiples of 10.");
                        Console.WriteLine("Return to Main Menu");
                        Console.WriteLine("--------------------------------------------------------");
                        return;
                    }
                    switch (Console.ReadLine())
                    {
                        case "1":
                            int i = withdrawAmount / 10;
                            Console.WriteLine("You have selected 10." + "please collect: " + i + " - 10 notes" );
                            Console.WriteLine("loading.............Withdraw successful!");
                            ATMService aTMService = new ATMService();
                            aTMService.ValidatePin();
                            break;
;
                        case "2":
                            int j = withdrawAmount / 20;
                            Console.WriteLine("You have selected 20." + "please collect: " + j + " - 20 notes");
                            Console.WriteLine("loading.............Withdraw successful!");
                            ATMService aTMService1 = new ATMService();
                            aTMService1.ValidatePin();
                            break;

                        case "3":
                            int k = withdrawAmount / 50;
                            Console.WriteLine("You have selected 50." + "please collect: " + k + " - 50 notes");
                            Console.WriteLine("loading.............Withdraw successful!");
                            ATMService aTMService2 = new ATMService();
                            aTMService2.ValidatePin();
                            break;
                        case "4":
                            int l = withdrawAmount / 100;
                            Console.WriteLine("You have selected 100." + "please collect: " + l + " - 100 notes");
                            Console.WriteLine("loading.............Withdraw successful!");
                            ATMService aTMService3 = new ATMService();
                            aTMService3.ValidatePin();
                            break;  
                    }

                }
                else if (confirmation == "2")
                {

                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Withdraw cancelled.");
                    Console.WriteLine("Return to Main Menu");
                    Console.WriteLine("--------------------------------------------------------");
                    return;
                }
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Withdraw amount should be less than 2000.");
                Console.WriteLine("Return to Main Menu");
                Console.WriteLine("--------------------------------------------------------");
                return;
            }



        }

    }
}
