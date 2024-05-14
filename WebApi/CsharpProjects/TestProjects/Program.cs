// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");
string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

string[] fraudulentOrderIDs2 = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs2[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs2[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs2[2]}");

Console.WriteLine($"length: {fraudulentOrderIDs2.Length}");
///FOREACH
string[] names={"Juan","Marcos","Bruno"};
int count=0;
foreach (string name in names){
    count++;
    Console.WriteLine($"el nombre en la posicion {count} es : {names[count-1]}");
}
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}