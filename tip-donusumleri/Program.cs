using System;

// Implicit Conversion

byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c;
Console.WriteLine("d = " + d);

long h = d;
Console.WriteLine("h = " + h);

float i = h;
Console.WriteLine("i = " + i);

string e = "elf";
char ch = 'f';
object o = e + ch + h;
Console.WriteLine("o = " + o);

// Explicit Conversion

Console.WriteLine($"\nExplicit Conversions");

int x = 4;
byte y = (byte)x;
Console.WriteLine("y = " + y);

float f = 10.4f;
byte z = (byte)f; 
Console.WriteLine("z = " + z);

// ToString() Method
Console.WriteLine($"\nToString() Method");

int number = 8;
Console.WriteLine("number is " + number.ToString());

Console.WriteLine("the float is a string! " + 12.5f.ToString());

// System.Convert
Console.WriteLine($"\nSystem.Convert class");

string s1 = "10", s2 = "20";
int number1, number2;
int total;

number1 = Convert.ToInt32(s1);
number2 = Convert.ToInt32(s2);

total  = number1 + number2;
Console.WriteLine("total = " + total);

// Parse Method
Console.WriteLine($"\nParse Method");

ParseMethod();

static void ParseMethod() 
{
    string text1 = "10";
    string text2 = "12.3";
    int number1;
    double double1;

    number1 = Int32.Parse(text1);
    double1 = Double.Parse(text2);

    Console.WriteLine($"{number1}\n{double1}");

}