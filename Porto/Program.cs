Console.WriteLine("Indtast brevets størrelse i cm");
 double size = double.Parse(Console.ReadLine());

Console.WriteLine("\n Hvor meget vejer brevet");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine("\n Tast 1 for indland, tast 2 for udland");
int dest = int.Parse(Console.ReadLine());

if (size <= 6 || size > 16 )
{
    Console.WriteLine("Brevet er ugyldigt");
}


if (dest == 1)
{
    if (weight <= 50)
    {
        Console.WriteLine("Brevet koster 12kr at sende");
    }
    else if (weight <= 100 && weight > 50)
    {
        Console.WriteLine("Brevet koster 24kr at sende");
    }
    else Console.WriteLine("Det er for tungt, og skal sendes som en pakke");
}

else if(dest == 2)
{
    if (weight <= 50)
    {
        Console.WriteLine("Brevet koster 36kr at sende");
    }
    else if (weight <= 100 && weight > 50)
    {
        Console.WriteLine("Brevet koster 36kr at sende");
    }
    else Console.WriteLine("Det er for tungt, og skal sendes som en pakke");
}

Console.ReadKey();

