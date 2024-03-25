// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
//Create a new C# project and create a program that assigns integer values to variables.
//Be sure that each value is stored in the correct variable type
//(try to find the most suitable variable type in order to save memory).
//    Finally you need to print all variables to the console.
//100
//128
//- 3540
//64876
//2147483648
//- 1 141 583 228
//- 122 337 203 685 477 580 8
sbyte mySbyte = 100;
byte myByte = 128;
short myShort = -3540;
ushort myUShort = 64876;
uint myUInt = 2147483648;
int myInt = -1141583228;
long myLong = -1223372036854775808;
Console.Write(mySbyte);
Console.Write(myByte);
Console.WriteLine("the short value is:{0},{1},{2}", myShort, myUShort, myUInt);

var myString = "the short value is:" + myShort + ",";
myString = myString + myUShort + ",";
myString = myString + myUInt;

Console.WriteLine(myString);
Console.WriteLine("the short value is:{0}", myShort);
//string interpolation
Console.WriteLine($"the short value is:{myShort},{myUShort},{myUInt}");
string escapedString = "\\\n\\";
Console.WriteLine(escapedString);

int myInt2 = -1141583228;
//this is not allowed
//myInt = null;

int? myNullbleInt = 2;
myNullbleInt = null;

bool? isMySoundWorking = true;
isMySoundWorking = false;
isMySoundWorking = null;

//implicit vs explicit conversion

//float myFloat = 3.1343444f;
//decimal myDecimal = 3.1343444333M;
//myDecimal = (decimal)myFloat;

//implicit conversion
int myIntX = 5;
long myLongX = (long)myIntX;

//explicit conversion
myIntX = (int)myLongX;

bool condition1 = true;
bool condition2 = true;

var a = 8;
var b = 5;
bool greater = (a > b) || ((a == 0) && (b == 0));

bool result = (condition1 || condition2);
//if(result)
if (result == true)
{
    Console.WriteLine("yey! this are true at once");
}

if (condition)
{
    // instructions to execute if the condition is true
}
if (condition2)
{
    // instructions to execute if the condition is true
}
else
{
    // instructions to execute if the condition is false
}