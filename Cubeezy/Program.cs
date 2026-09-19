using Cubeezy;

Console.WriteLine("\nHello, Dude. I'm Cubeezy. I can role the die, do you want it?");
while (true)
{
    Console.Write("\nEnter '1' to role the die, and '0' to exit:  ");
    bool choiceIsNumber = int.TryParse(Console.ReadLine(), out int choice);

    if (choiceIsNumber == false)
    {
        Console.WriteLine("\nI can understand only integers like 1 or 0");
        continue;
    }
   
    if (choice == 0 || choice < 0)
    {
        break;

    }
    else if (choice == 1)
    // это сделано ибо один бросок кубика это просто утилитарная вещь, а 2 и более 
    // кубика это уже игра, и каждый может ее определять и редактировать по своему
    {
        int result = Cube.RollTheDie();
        Console.WriteLine($"\n{result}");
    }
    else
    {
        int result = 0;


        for (int i = 0; i < choice; i++)
        {   
            int roll = Cube.RollTheDie();
            result += roll;
            Console.WriteLine($"\nroll {i + 1} = {roll}");
        }
        Console.WriteLine($"\n\nTotal Result = {result}");
    }
}




 


