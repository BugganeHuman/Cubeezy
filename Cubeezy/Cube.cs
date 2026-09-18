namespace Cubeezy;

public class Cube
{
    public static int RollTheDie()
    {
        
        int result = Random.Shared.Next(1, 7);
        return result;
    }


}
