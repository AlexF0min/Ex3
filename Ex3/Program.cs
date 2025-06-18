System.Console.WriteLine("Display the pattern like diamond\n-----------------------------");

System.Console.Write("Input number of rows (half of the diamond): ");
int numberOfRows = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= numberOfRows; i++)
{
    
    for (int j = 0; j <= numberOfRows - i; j++) // Why j= 1 and not 0??
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= 2 * i - 1; j++)  // I need an explanation of that 
    {
        System.Console.Write("*");
    }
    System.Console.Write("\n"); 
}
for (int i = numberOfRows - 1 ; i <= numberOfRows; i--)
{
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        System.Console.WriteLine(" ");
    }
    for (int j = 1; j <= 2 * j - 1; j++) 
    {
        Console.Write("*");
    }
}



