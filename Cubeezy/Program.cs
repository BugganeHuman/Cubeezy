using Cubeezy;

Console.WriteLine("\nHello, Dude. I'm Cubeezy. I can role the die, do you want it?");
//int choice = 0;
while (true)
{
    Console.Write("\nEnter '1' to role the die, and '0' to exit:  ");
    bool choiceIsNumber = int.TryParse(Console.ReadLine(), out int choice);

    if (choiceIsNumber == false)
    {
        Console.WriteLine("\nI can understand only integers like 1 or 0");
        continue;
    }
   
    if (choice == 1)
    {
        int result = Cube.RollTheDie();
        Console.WriteLine($"\n{result}");

    }
    else if (choice == 0)
    {
        break;
    }
}




 


