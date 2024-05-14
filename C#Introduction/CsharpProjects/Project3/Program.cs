using System.Collections;

string [,] ourAnimals = new string[,]
{
    {"001","Cat","12","Black","cheerful"},
    {"002","Dog","10","healty","cheerful"},
    {"003","Cat","2","Brown","cheerful"},
    {"004","Dog","1","green","cheerful"},
    {"005","Cat","3","Orange","cheerful"},
    {"006","Dog","5","Brown","cheerful"},
    {"007","Horse","7","healty","cheerful"},
    {"008","Cat","8","Orange","cheerful"},
    {"009","Dog","6","healty","cheerful"},
    {"010","Dog","4","Brown","cheerful"}
};
//menu 
string entry;
do 
{
    Console.WriteLine("Welcome to the Animal Farm");
    Console.WriteLine("1. Display all animals");
    Console.WriteLine("2. Add new Animals");
    Console.WriteLine("3. Edit an animal age");
    Console.WriteLine("4. Edit an animal personality");
    Console.WriteLine("5. Display all cats from a specifiec pysical characteristic");
    Console.WriteLine("6. Display all dogs from a specifiec pysical characteristic");
    Console.WriteLine("7. Exit");
    Console.WriteLine("Please enter a number from 1 to 6");
    entry=Console.ReadLine();
    
    bool flag=int.TryParse(entry, out int intEntry);
        if(!flag)
    {
        Console.WriteLine("Not a valid entry");
    }
    else if(intEntry>=1 && intEntry<=7)
    {
        switch( entry)
        {
            case "1":
                Console.WriteLine("Display all animals");
                break;
            case "2":
                Console.WriteLine("Add new Animals");
                break;
            case "3":
                Console.WriteLine("Edit an animal age");
                break;
            case "4":
                Console.WriteLine("Edit an animal personality");
                break;
            case "5":
                Console.WriteLine("Display all cats from a specifiec pysical characteristic");
                break;
            case "6":
                Console.WriteLine("Display all dogs from a specifiec pysical characteristic");
                break;  
            default:
                Console.WriteLine("Exit");
                break;  
        }
    }else
    {
        Console.WriteLine("Use  just numbers from 1 to 7");
    }
}
while(entry!="7");


   

        


