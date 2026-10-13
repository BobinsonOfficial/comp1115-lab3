int StartA;
int StartB;
int StopA;
int StopB;
int TotalA = 0;
int TotalB = 0;

//Get Player A starting number
Console.WriteLine("Player A enter starting number (1-6): ");
while (!int.TryParse(Console.ReadLine(), out StartA)
              || StartA < 1 || StartA > 6)
{
    Console.Write("That is invalid, Player A please enter a number from 1 to 6: ");
}

//Get Player A stopping munber
Console.WriteLine("Player A enter stopping number (7-18)");
while (!int.TryParse(Console.ReadLine(), out StopA)
              || StopA < 7 || StopA > 18)
{
    Console.Write("That is invalid, Player A please enter a number from 7 to 18: ");
}


//Get Player B starting number
Console.WriteLine("Player B enter starting number (1-6): ");
while (!int.TryParse(Console.ReadLine(), out StartB)
              || StartB < 1 || StartB > 6)
{
    Console.Write("That is invalid, Player B please enter a number from 1 to 6: ");
}

//Get Player B stopping number
Console.WriteLine("Player B enter stopping number (7-18)");
while (!int.TryParse(Console.ReadLine(), out StopB)
              || StopB < 7 || StopB > 18)
{
    Console.Write("That is invalid, Player B please enter a number from 7 to 18: ");
}

//test that it was getting the numbers correctly
//Console.WriteLine( StartA + " " + StopA + " " + StartB + " " + StopB );


//Calculate Player A total
for (int i = StartA; i <= StopA; i++) 
{
    TotalA += i;
}

//Calculate Player b total
for (int i = StartB; i <= StopB; i++)
{
    TotalB += i;
}

//Display both players totals
Console.WriteLine("Player A total = " + TotalA);
Console.WriteLine("Player B total = " + TotalB);


//Compare both players totals to determine winner
if (TotalA > TotalB)
{
    Console.WriteLine("Player A wins.");
}
else if (TotalB > TotalA)
{
    Console.WriteLine("Player B wins.");
}
else
{
    Console.WriteLine("It's a tie.");
}