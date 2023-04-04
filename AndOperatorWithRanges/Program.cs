Console.WriteLine("Enter the current temperature:");
int currenttemp = int.Parse(Console.ReadLine());

if(currenttemp <= 0)
{
    Console.WriteLine("Freezing");
}
else if (currenttemp > 0 && currenttemp <= 5 )
{
    Console.WriteLine("Cold");
}
else if (currenttemp > 5 && currenttemp <= 10 )
{
    Console.WriteLine("Chilly");
}
else if (currenttemp > 10 &&currenttemp <= 15 )
{
    Console.WriteLine("Cool");
}
else if (currenttemp > 15 &&currenttemp <= 30 )
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Boilin hot");
}