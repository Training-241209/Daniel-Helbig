namespace Magic_Ball;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Ball!");
        Console.WriteLine("Think about your question, and type something");

        string? userInput = Console.ReadLine();

        if(!string.IsNullOrEmpty(userInput)){
            Console.WriteLine("The magic ball says:");
            Console.WriteLine(GetPrediction());
        }
    }

    //Method for prediction

    public static string GetPrediction(){
        string[] predictions = { 
            "It is certain",
            "Without a doubt",
            "Most likely"
        };

        Random myRandomNumber = new Random();
        int randomNumber = myRandomNumber.Next(0, predictions.Length);

        return predictions[randomNumber];
        
    }
}