// Work in progress... 

System.Console.WriteLine("Display the pattern like diamond\n-----------------------------");

System.Console.Write("Input number of rows (half of the diamond): ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= numberOfRows; i++)
{

    for (int j = 0; j <= numberOfRows - i; j++) // spaces // for some reason there is two spaces in 5th row
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
    for (int j = 0; j <= numberOfRows - i; j++) // for some reason; second half of the 
    //                                              diamond does not have a space in first row( or may be it has ?? )

    {
        System.Console.Write(" "); // switched space for _ to see that there is a space at first row of a second half
    }

    for (int j = 1; j <= 2 * i - 1; j++)

    {
        Console.Write("*");
    }

    System.Console.Write("\n");

}



