
//variable

string name = "anu";
Console.WriteLine(name);

//data type

int a = 43;
string c = "text";
Console.WriteLine(a);      
Console.WriteLine(c);

//constants

const string s = "bag";
Console.WriteLine(s);

// implicit type

int myint = 4;
double mydouble = 5.44;
Console.WriteLine(myint);
Console.WriteLine(mydouble);

// explicit type

double mydouble2 = 9.78;
int myint2 = (int) mydouble2;
Console.WriteLine(mydouble2);
Console.WriteLine(myint2);

// operators
Console.WriteLine("enter two numbers");
double x=Convert.ToInt32(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
double add = (x + y);
double sub = (x - y);
double mul = (x * y);
double div = (x / y);
Console.WriteLine("adding two  number is:" + add);
Console.WriteLine("adding two  number is:" + sub);
Console.WriteLine("adding two  number is:" + div);
Console.WriteLine("adding two  number is:" + mul);

// if statement

Console.WriteLine("enter a number");
int b = Convert.ToInt32(Console.ReadLine());
if (b>18)
{
    Console.WriteLine("b is grater");
}

//if else statement

Console.WriteLine("enter a number");
int abc = Convert.ToInt32(Console.ReadLine());
if (abc > 18)
{
    Console.WriteLine("b is grater");
}
else
{
    Console.WriteLine("b is smaller");
}

//switch case

int day = 2;
switch (day)
{
    case 1:
Console.WriteLine("monday");
break;
    case 2:
        Console.WriteLine("tuesday");
        break;
    default:
        Console.WriteLine("wrong day");
        break;
}

// for loop

for (int i=0; i < 10;i++)
{
    Console.WriteLine(i);
}

// foreeach;/


string[] person = { "name", "age" };
foreach(string i in person)
{
    Console.WriteLine(i);
}


// while loop

int n = 0;
while(n<5)
{
    Console.WriteLine(n);
    n++;
}

// do while

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
}

while (k < 5);

// access element in an array

string[] fruits = { "mango", "orange", "pinaple" };
for (int i=0;i<fruits.Length;i++)
{
    Console.WriteLine(fruits[i]);

}

// change array element

string[] fruits1 = { "mango", "orange", "pinaple" };
fruits1[1] = "orange";
Console.WriteLine(fruits1[1]);

// Array length

string[] fruits2 = { "mango", "orange", "pinaple" };
Console.WriteLine(fruits2.Length);

//array sorting

int[] numbers = { 10, 3, 5, 7, 8 };
Array.Sort(numbers);
Console.WriteLine("sorted array of numbers");
foreach (int num in numbers)
{
    Console.WriteLine(num + " ");
}

//boxing
int intvalue = 42;
object boxedobject=intvalue;

// unboxing

int intvalue1 = 42;
object unboxdobject = intvalue1;

//string interpolation

string name1 = "anitha";
int age = 30;
string message = $"my name is {name1} and i am {age} years old.";

//composite formating
string name2 = "anitha";
int age1 = 30;
//string message1 = StringFormat ("my name is {0} and i am {1} year old");



// string methods


// to lowecase():
string orginal = "hi helo";
string lowercase=orginal.ToLower();

// to uppercase();
string school = "my scheool";
string uppercase=school.ToUpper();

//split():
string paragraph = "this is my new paragraph";
string[] words = paragraph.Split(' ');

//length:
string text = "hello";
int length = text.Length;



// array methoss

//index of
int[] number = { 1, 2, 3, 4 };
int index=Array.IndexOf(number,2);

//sort
int[] number1 = { 5, 6, 7 };
Array.Sort(number1);

//reverse
int[] number2 = { 6, 8, 9, 4 };
Array.Reverse(number2);

//foreeach
int[] number3 = { 1, 2, 5 };
Array.ForEach(number3, number =>
Console.WriteLine(number));

//clear
int[] number4 = { 3, 5, };
Array.Clear(number4);

//tolist
int[] number5 = { 5, 6, 8 };
List<int>number5list=number5.ToList();

//clone
int[] orginal1 = { 1, 2, 3, 4 };
int[] copy = (int[]) orginal.Clone();    


// class
class message
{
    public static void hello()
    {
        Console.WriteLine("welcome to the program");
            }
    public static void waiting()
    {
        Console.WriteLine("am waiting");
    }
}

//class program
//{
//    message.hello();
//        message.waiting();
//        console.readkey();

//}


// object

class human
{
    public string name;
    public int age;
    public void eat()
    {
        Console.WriteLine(name + "is eating");
    }
    class progrm
    {
        static void main(string[] args)
        {
            human human1 = new human();
            human human2 = new human();
            human1.name = "anitha";
            human2.age = 30;
            human1.eat();
            Console.ReadKey();

        }
    }
}

//constructor

class person1
{
    public string Name { get; set; }
    public int  Age { get; set; }
    public person1(string name,int age)
    {
        Name = name;
        Age = age;
    }
    public void displayinfo()
    {
        Console.WriteLine($"Name:{Name}, Age: {Age}");
    }
}
//class program
//{
//    static void main()
//    {
//        person1 person2 = new person1("a", 3);
//        person1.displayinfo();

//    }
//}



// inheritance program 
// base class
public class animal
{
    public void eat()
    {
        Console.WriteLine("animal is eating");
    }
}

// derived class

public class dog : animal
{
    public void bark()
    {
        Console.WriteLine("dog is barking");
    }
}

//main program
class program
{
    static void main()
    {
        dog mydog=new dog();
         mydog.eat();
        mydog.bark();

    }
}



// program using encapsulation
public class employee
{
    public int empexperiance
    {
        get { return empexperiance; }
        set {empexperiance = value; }
    }
}


// polimorphism

public class polimorphism
{
    public int Add1 (int a, int b)
    {
        return a + b;
    }
    
}


// FUNCTIONS
//no parameter and return type
class message1
{
    static void displaymessage()
    {
        Console.WriteLine("helloo");
    }
    static void main()
    {
        displaymessage();
    }
}


//parametr but no returntype
class number
{
    static void printnumber(int num)
    {
        Console.WriteLine("the number is:{nummber}");
    }
    static void main()
    {
        printnumber(42);
    }
}

//parameter and returntype
class number2
{
    static int addnum(int a, int b)
    {
        return a + b;
    }
    static void main()
    {
        int result = addnum (5, 7);
        Console.WriteLine("$sum is:{result}");
    }
}