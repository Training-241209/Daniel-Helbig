/*

FizzBuzz, we have an integer n , for every integer that is less than n, we have a few rules:
Print "FizzBuzz" if i/3 and i/5

Print "Fizz" if i/3

Print "Buzz" if i/5

Print "i" if none are true

*/

/* Access modifiers

public - it's the most open access modifier, all classes in proj can access it
private - most closed access modifier, only available to the class itself
internal - limited to the class and all its members, but not static members
protected - it's available for  classes and its children/subclasses

static keyword - means we don't have to have an object/instance to call method or access static members
static member values are shared

*/

int num = 20;
int count = 1;

while(count < num){
    if(count % 5 == 0 && count % 3 == 0){
        Console.WriteLine("FizzBuzz");
    } else if(count % 3 == 0){
        Console.WriteLine("Fizz");
    } else if(count % 5 == 0){
        Console.WriteLine("Buzz");
    } else {
        Console.WriteLine(count);
    }
    count++;
}
