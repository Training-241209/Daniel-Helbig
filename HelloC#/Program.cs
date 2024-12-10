using System;
using System.Data;
using System.Globalization; // we import our namespaces/libraries with USING statement

namespace HelloC_; // file cabinet, we store our stuff in it

//our main class, this is our program entry point
class Program
{
    // this method is an entry point of execution
    static void Main(string[] args)
    {
        Console.WriteLine(34.40m);

        //Buily-in data types in C#endregion
        
        //integer/numeric
        int age = 45;
        double amountOfMoney = 45.90;
        float anotherFloating = 50.50f;
        long veryLargeNumber = 900000000000000000;
        

        //character and bools
        char myChar = 'G';
        bool isTrue = true;

        //Strings
        string username = "Cole";


        Console.WriteLine("Hello " + username);
        Console.WriteLine($"I am {age} years old"); // string interpolation

        // Arithmetic

        int a = 5 + 9;
        int b = 5 - 9;
        int c = 10 * 5;
        int d = 10 / 5;

        // COmparison

        //a < b || a == b;
        // a < b ^ b == a; XOR OPERATOR

        //Assignment operators

        int x = 10;
        x += 5;

        //Get user input

        Console.WriteLine("Enter your name: \n");
        string user = Console.ReadLine();
        Console.WriteLine("You entered: " + user);


        //Conditional statements
        bool isPassword = true;
        if(isPassword){
            Console.WriteLine("Access granted");
        } else{
            Console.WriteLine("Access denied");
        }

        //Switch

        int day = 5;

        switch(day){
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
        }
        
        int i = 0;
        do{
            Console.WriteLine("Number: " + i);
        } while(i < 5);

        int j = 10;
        while(i < 12){
            Console.WriteLine("Number: " + j);
            j++;
        }

        for(int k = 0; k < 5; k++){
            Console.WriteLine("Number: " + k);
        }

        //Type conversion

        // Implicit conversion

        int myInt = 50;
        double myDouble = myInt; //converted with no data loss

        //Explicit conversion
        myInt = (int)myDouble; //converted with data loss

        string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt\n");
Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");

    }
}
