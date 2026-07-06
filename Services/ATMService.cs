namespace ATM_Banking_System.Services
{
    public class ATMService
    {
        public void CheckBalance()
        {
             
            Console.WriteLine("Your balance is: $1000");
            Console.WriteLine("Press any key to return to the main menu.");
        }
        public void ValidatePin()
        {

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Main Menu"); Console.WriteLine();
            Console.WriteLine("Please select an option: \"1. Check Balance\", \"2. Deposit\", \"3. Withdraw\", \"4. Exit\" ");
            Console.WriteLine("--------------------------------------------------------");
            string[] options = { "1. Check Balance", "2. Deposit", "3. Withdraw", "4. Exit" };
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You have selected Check Balance.");
                    ATMService checkbal = new ATMService();
                    checkbal.CheckBalance();
                    break;
                case "2":
                    Console.WriteLine("You have selected Deposit.");
                    DepositService deposit = new DepositService();
                    deposit.Deposit();
                    break;
                case "3":
                    Console.WriteLine("You have selected Withdraw.");
                    WithdrawService witdraw = new WithdrawService();
                    witdraw.Withdraw();
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        public void Exit()
        {
            Console.WriteLine("Thank you for using the ATM Banking System!");
            Environment.Exit(0);
        }
    }
}
