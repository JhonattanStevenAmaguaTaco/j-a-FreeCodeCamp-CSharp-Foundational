
// Prints error   Cannot implicitly convert type 'int' to 'string'
/*
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);
*/

//prints 24
/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/
/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/
/*
Since any int value can easily fit inside of a decimal, 
the compiler performs the conversion.

The term widening conversion means that
 you're attempting to convert a value from 
 a data type that could hold less information to 
 a data type that can hold more information. 
 In this case, a value stored in 
 a variable of type int converted to
 a variable of type decimal, doesn't lose information.
*/


// Perform a cast
/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

*/
//To perform a cast, you use the casting operator () 
//to surround a data type, then place it next to 
//the variable you want to convert 
//(example: (int)myDecimal).
// You perform an explicit conversion to the defined cast data type (int).

//Determine if your conversion is a "widening conversion" or a "narrowing conversion"
//Widening conversion: converting a value from a data type that could hold less information
                    //to a data type that can hold more information.
//Narrowing conversion: converting a value from a data type that could hold more information
                    // to a data type that can hold less information.
/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal; // Narrowing conversion from 1.23456789 to 1.234568

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/
/*
Performing Data Conversions
Earlier, it was stated that a value change from one data type
 into another could cause a runtime exception, and you should 
 perform data conversion. 
 For data conversions, there are three techniques you can use:

Use a helper method on the variable
Use a helper method on the data type
Use the Convert class' methods
*/
/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
//Convert a string to a int using the Convert class
/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/


//Casting vs Converting
/*
int value = (int)1.5m; // casting truncates 1.5 to 1
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up 1.5 to 2
Console.WriteLine(value2);
*/
/*
Exercise - Examine the TryParse() method

The TryParse() method is a helper method that attempts to convert a string to a number.
The TryParse() method does several things simultaneously:

It attempts to parse a string into the given numeric data type.
If successful, it stores the converted value in an out parameter, explained in following section.
It returns a bool to indicate whether the action succeeded or failed.


string name = "Bob";
Console.WriteLine(int.Parse(name)); // Throws an exception


 /*----------------*/
/*
 string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
*/

//Using values vs using reference types
//Using values
/*
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

//VS ausing reference types
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;
// When ref_B = ref_A is executed, 
//ref_B points to the same memory location as ref_A. 
//So, when ref_B[0] is changed, ref_A[0] 
//also changes because they both point to the same memory location
Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");
*/
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
//Here you're using the Array.Clear()
// method to clear the values stored
// in the elements of the pallets array starting at index 0 and clearing 2 elements.

*/

//Use the ToCharArray() to reverse a string
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);*/


// Combine all of the chars into a new comma-separated-value string using Join()
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
//a,2,3,c,b String.Join(",", valueArray) is used to combine all of the chars into a new comma-separated-value string.
Console.WriteLine(result);
char="a"; 


string[] items = result.Split(','); 
// Split the string into an array of strings using the Split() method and a comma as the delimiter.

foreach (string item in items)
{
    Console.WriteLine(item);
}


//Composite formatting
//The composite formatting feature is used to build strings by combining multiple strings,
//numbers, and other data types.  It uses the {index} syntax to identify placeholders in the string.
//The index is the zero-based position of the argument in the argument list.
//The argument list is the list of variables that are passed to the method.
//The placeholders are replaced by the values of the arguments in the argument list.


string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);//World Hello!
Console.WriteLine("{0} {0} {0}!", first, second);//Hello Hello Hello!


//String interpolation
//String interpolation is a feature that allows you to embed expressions in a string.
//The expressions are evaluated and replaced with the result.
//The expressions are enclosed in curly braces {} and prefixed with a $ symbol.
//The expressions can be simple variables, complex expressions, or method calls.
string firs = "Hello";
string secon = "World";
Console.WriteLine($"{firs} {secon}!");//Hello World!
Console.WriteLine($"{secon} {firs}!");//    World Hello!
Console.WriteLine($"{firs} {firs} {firs}!");//Hello Hello Hello!


//Formatting currency
//:C is the currency format specifier. It formats a number as a currency value.
decimal price = 123.45m;//m is used to indicate that the number is a decimal.
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");//Price: $123.45 (Save $50.00)

//Formatting numbers
//:N is the number format specifier. It formats a number with a thousands separator.
//The thousands separator is a comma (,).
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");//Measurement: 123,456.79 units
//If you want to display more precision, you can do that by adding a number after the specifier.
//The following code will display four digits after the decimal point using the N4 specifier.
decimal measurement2= 123456.78912m;
Console.WriteLine($"Measurement: {measurement2:N4} units");//Measurement: 123,456.7891 units

//Combining formatting approaches
decimal price2 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

//(price2 - salePrice)/price2) = 0.113
//{((price2 - salePrice)/price2):P2} = 11.19%
yourDiscount += $"A discount of {((price2 - salePrice)/price2):P2}!"; //inserted
Console.WriteLine(yourDiscount);

//The PadLeft() method 
//adds blank spaces to the left-hand side of the string 
//so that the total number of characters equals the argument you send it.
// In this case, you want the total length of the string to be 12 characters.
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12));
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));

 //use the strings indexOf and SubString() methods

 string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');//Find the index of the opening parenthesis
int closingPosition = message.IndexOf(')');//Find the index of the closing parenthesis

Console.WriteLine(openingPosition);   // 14
Console.WriteLine(closingPosition);  // 32
int length = closingPosition - openingPosition;//Calculate the length of the substring
Console.WriteLine(message.Substring(openingPosition, length));//inside the parentheses
//remove
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);//Remove 20 characters starting at index 5
Console.WriteLine(updatedData);
//REPLACE
string message2 = "This--is--ex-amp-le--da-ta";
message2 = message2.Replace("--", " ");//Replace all occurrences of "--" with a space
message2 = message2.Replace("-", "");//Replace all occurrences of "-" with an empty string
Console.WriteLine(message2);
string.Join()