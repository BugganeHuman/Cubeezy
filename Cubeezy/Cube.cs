namespace Cubeezy;

public class Cube
{
    public static int RoleTheDie()
    {
        Random random = new Random();
        int result = random.Next(1, 7);
        return result;
    }


}
