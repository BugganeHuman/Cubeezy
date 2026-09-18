using Cubeezy;

Console.WriteLine("\nHello, Dude. I'm Cubeezy. I can role the die, do you want it?");
int choice = 0;
while (true)
{
    Console.Write("\nEnter '1' to role the die, and '0' to exit:  ");
    try
    {
        choice = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception exception)
    {

        Console.WriteLine("\nI can understand only integers like 1 or 0");
        Console.WriteLine(exception);
        continue;
    }
    if (choice == 1)
    {
        int result = Cube.RoleTheDie();
        Console.WriteLine($"\n{result}");

    }
    else if (choice == 0)
    {
        break;
    }
}




 


