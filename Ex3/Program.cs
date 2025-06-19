// Work in progress... 

System.Console.WriteLine("Display the pattern like diamond\n-----------------------------");

System.Console.Write("Input number of rows (half of the diamond): ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= numberOfRows; i++)
{

    for (int j = 0; j <= numberOfRows - i; j++) // spaces // 
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= 2 * i - 1; j++)  //stars
    {
        System.Console.Write("*");
    }
    System.Console.Write("\n");

}


for (int i = numberOfRows - 1; i >= 0; i--)
{
    for (int j = 0; j <= numberOfRows - i; j++) 
    {
        System.Console.Write(" "); 
    }

    for (int j = 1; j <= 2 * i - 1; j++)

    {
        Console.Write("*");
    }

    System.Console.Write("\n");

}



