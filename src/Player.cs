using Raylib_cs;

namespace DefaultNamespace;
public class Player //This class has all the atributes of the player
{
 //string color = "red";
 //int x = 5;
 //int y = 5;
 //float radius = 5;
 //int speed = 10;

    int x1 = 400;
    int y1 = 700;
 public void setXYCoordinate() {
        
    }

 //Below detect if specific keys are being

    public void Left(string[] args)//this method is to detect if the A key is bineg held down by theh player, if so the palyer's icon should move left. 
    {
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
        {
         x1 = -10;
        }
    }

    public void Right(string[] args)//this method is to detect if the D key is bineg held down by theh player, if so the palyer's icon should move right. 
    {
    if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
        {
         x1 = +10;
        }
    }

}