Console.WriteLine("Type in a number");
Console.Write(">> ");
int num = Convert.ToInt32(Console.ReadLine());

int check = num % 2;
if (check == 1)
{
    Console.WriteLine("The number is Odd");
}
else
{
    Console.WriteLine("The number is Even");
}
