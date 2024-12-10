namespace ExpenseTracker;

class Program
{
    static void Main(string[] args)
    {
        Greeting();
        
        DisplayOptions();
        int userOption = getUserOption();

        switch(userOption){
            case 1:
                Console.WriteLine("User selected add expense.");
                break;
            case 2:
                Console.WriteLine("user selected view expenses.");
                break;
            case 3:
                Console.WriteLine("User selected edit expenses.");
                break;
            case 4:
                Console.WriteLine("User selected delete expenses.");
                break;
            case 5:
                Console.WriteLine("User selected save to a file.");
                break;
            case 6:
                Console.WriteLine("User selected exit.");
                break;
        }
    }

    public static void Greeting(){
        
        Console.WriteLine("Welcome to the ExpenseTracker");
        Thread.Sleep(1500);
        Console.WriteLine("Select one of the following options: \n");

    }

    public static void DisplayOptions(){
        Console.WriteLine("1. Add Expense");
        Console.WriteLine("2. View Expenses");
        Console.WriteLine("3. Edit Expenses");
        Console.WriteLine("4. Delete Expenses");
        Console.WriteLine("5. Save to a file");
        Console.WriteLine("6. Exit");
        
    }

    public static int getUserOption(){
        Console.WriteLine("Select the option: \n");
        string? userInput = Console.ReadLine();

        //Exception handling
        try{            
            return Int32.Parse(userInput);
        }catch(FormatException e){
            Console.WriteLine("invalid input! Make sure you typed a number.");
            return getUserOption();
        }

    }
}
