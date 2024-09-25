/*
// Q1-methods
// part 1
void DisplayWelcomeMessage(){
    Console.WriteLine("Welcome!!!");
}
DisplayWelcomeMessage();

// part 2
void PersonalizedWelcomeMessage(string name){
    Console.WriteLine("Welcome to us, " + name);
}
Console.Write("Enter a name: ");
PersonalizedWelcomeMessage(Console.ReadLine());

// part 3
void CalculateSum(int numberA, int numberB){
    Console.WriteLine(numberA+numberB);
}
Console.Write("Enter first count: ");
int count = int.Parse(Console.ReadLine());
Console.Write("Enter second count: ");
CalculateSum(count, int.Parse(Console.ReadLine()));

// part 4
void CountSpaces(string inputString){
    int count = 0;
    foreach(char i in inputString){
        if(i == ' ') count++;
    }
    Console.WriteLine(count);
}
Console.Write("Enter a string: ");
CountSpaces(Console.ReadLine());

// part 5
void CalculateArraySum(int[] a){
    int sum = 0;
    foreach(int i in a){
        sum += i;
    }
    Console.WriteLine(sum);
}
Console.Write("Enter first count: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second count: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter third count: ");
CalculateArraySum(new int[3] {number1,number2,int.Parse(Console.ReadLine())});

// part 6
void SwapNumbers(ref int numberA, ref int numberB){
    int note = numberA;
    numberA = numberB;
    numberB = note;
}
Console.Write("Enter first count: ");
number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second count: ");
number2 = int.Parse(Console.ReadLine());
SwapNumbers(ref number1,ref number2);
Console.WriteLine(number1 + "\n" + number2);

// part 7
void CalculateExponent(int inputNumber, int exponent){
    int outputValue = inputNumber;
    for(int i = 1; i < exponent; i++){
        outputValue *= inputNumber;
    }
    Console.WriteLine(outputValue);
}
Console.Write("Enter base count: ");
count = int.Parse(Console.ReadLine());
Console.Write("Enter exponent count: ");
CalculateExponent(count,int.Parse(Console.ReadLine()));

// part 8
void DisplayFibonacciSequence(int inputNumber){
    int numberA = 1;
    int numberB = 1;
    int note;
    for(int i = 3; i <= inputNumber; i++){
        note = numberA;
        numberA += numberB;
        numberB = note;
    }
    Console.WriteLine(numberA);
}
Console.Write("Enter count of terms: ");
DisplayFibonacciSequence(int.Parse(Console.ReadLine()));

// part 9
void CheckPrimeNumber(int inputNumber){
    for(int i = 2; i <= Math.Sqrt(inputNumber); i++){
        if(inputNumber % i == 0){
            Console.WriteLine("no");
            return;
        }
    }
    Console.WriteLine("yes");
}
Console.Write("Enter a count: ");
CheckPrimeNumber(int.Parse(Console.ReadLine()));

// part 10
void CalculateDigitSum(int inputNumber){
    int sum = 0;
    while(inputNumber/10 > 0){
        sum += inputNumber % 10;
        inputNumber /= 10;
    }
    Console.WriteLine(sum + inputNumber);
}
Console.Write("Enter a count: ");
CalculateDigitSum(int.Parse(Console.ReadLine()));
*/
// part 11-13 
// note all except this class to check
/*
class program(){
    class Part11{
        static public void DisplayInfo(string name, int age){
            Console.WriteLine(name + "\n" + age);
        }
    }
    
    class Part12{
        static public void GetSquareRoot(int inputNumber){
            Console.WriteLine(Math.Sqrt(inputNumber));
        }
    }
    class Part13{
        static public void GreetUser(string greetingMessage, string name){
            Console.WriteLine(greetingMessage + name);
        }
    }
    static void Main(){
        Part11.DisplayInfo("Leovis Vuong",16);

        Console.Write("Enter a count: ");
        Part12.GetSquareRoot(int.Parse(Console.ReadLine()));

        Console.Write("Enter your name: ");
        Part13.GreetUser("Hello ", Console.ReadLine());
    }
}
*/



/*
// Q2-while_loops
// part 1
using System.Diagnostics.Metrics;

int count = 1;
while(count < 11){
    Console.Write(count + " ");
    count++;
}
Console.Write("\n");

// part 2
count = 10;
while(count >0){
    Console.Write(count + " ");
    count--;
}
Console.Write("\n");

// part 3
count = 1;
while(count < 11){
    if(count%2 == 0) Console.Write(count + " ");
    count++;
}
Console.Write("\n");

// part 4
count = 1;
while(count < 11){
    if(count%2 != 0) Console.Write(count + " ");
    count++;
}
Console.Write("\n");

// part 5
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
count = 0;
while(count < 11){
    Console.WriteLine(number + " * " + count + " = " + count*number);
    count++;
}

// part 6
Console.Write("Enter a number: ");
number = int.Parse(Console.ReadLine());
count = 1;
int answer = 1;
while(count < number){
    count++;
    answer *= count;
}
Console.WriteLine("The factorial of " + number + " is: " + answer);

// part 7
Console.Write("Enter a number: ");
number = int.Parse(Console.ReadLine());
count = 1;
answer = 0;
while(count <= number){
    if(count < number) Console.Write(count + " + ");
    else Console.Write(count + " = ");
    answer += count;
    count++;
}
Console.WriteLine(answer);

// part 8
Console.Write("Input upto the table number starting from 1 : ");
number = int.Parse(Console.ReadLine());
count = 1;
int count2;
while(count <= 10){
    count2 = 1;
    while(count2 <= number){
        Console.Write(count2 + "x" + count + " = " + count*count2);
        if(count2 < number) Console.Write(", ");
        else Console.Write("\n");
        count2++;
    }
    count++;
}

// part 9
Console.Write("Input number of rows: ");
number = int.Parse(Console.ReadLine());
count = 1;
while(count <= number){
    for(int i = 1; i <= count; i++){
        Console.Write(i);
    }
    Console.Write("\n");
    count++;
}

// part 10
Console.Write("Input number of rows: ");
number = int.Parse(Console.ReadLine());
count = 1;
while(count <= number){
    for(int i = 1; i <= count; i++){
        Console.Write('*');
    }
    Console.Write("\n");
    count++;
}


// part 11
Console.Write("Input number of rows: ");
number = int.Parse(Console.ReadLine());
count = 1;
count2 = 1;
while(count <= number){
    for(int i = 1; i <= number-count; i++){
        Console.Write(" ");
    }
    for(int i = 1; i <= count; i++){
        Console.Write(count2 + " ");
        count2++;
    }
    Console.Write("\n");
    count++;
}
*/



// Q3-for_loops
// part 1
for(int i = 1; i < 11; i++){
    Console.Write(i + " ");
}
Console.Write("\n");

// part 2
Console.Write("Input number of terms: ");
int number = int.Parse(Console.ReadLine());
for(int i = 1; i <= number; i++){
    Console.WriteLine("Number is: " + i + " and cube of the " + i + " is: " + i*i*i);
}

// part 3
Console.Write("Input the number (Table to be calculated): ");

number = int.Parse(Console.ReadLine());
for(int i = 1; i < 11; i++){
    Console.WriteLine(number + " x " + i + " = " + number*i);
}

// part 4
for(int i = 1; i < 8; i++){
    if(i < 4){
        for(int j = 1; j < i; j++){
            Console.Write(' ');
        }
        Console.Write('*');
        for(int j =1; j <= 7-i*2; j++){
            Console.Write(' ');    
        }
        Console.WriteLine('*');
    }
    else{
        for(int j = 1; j < 4; j++){
            Console.Write(' ');
        }
        Console.Write('*');
        for(int j =1; j < 4; j++){
            Console.Write(' ');    
        }
        Console.Write("\n");
    }
}

// part 5
for(int i = 10; i < 51; i += 10){
    Console.WriteLine("Round " + i/10 + ": Health " + i);
}

// part 6
List<string> names = new List<string> {"Leovis","Anna","David","Antheo","Johnny"};
foreach(string i in names) Console.WriteLine("Name: " + i);

// part 7
List<int> numbers = new List<int> {2,3,4,5,6};
foreach(int i in numbers) Console.WriteLine("Square of " + i + ": " + i*i);