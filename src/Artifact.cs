namespace DefaultNamespace;

public class Artifact
{
    // Compare itself and input of player
    // x, y, radius
    // Player's x, y, and radius are parameters
    public int x1 = 0;
    public int y1 = -100;
    public float radius1 = 10;
    
    // Distance formula for circle to detect collision
    public bool checkCollision(int x2, int y2, float radius2) {
        float distance = Convert.ToSingle(Math.Sqrt(Math.Pow(Convert.ToDouble((x2 - x1)), Convert.ToDouble(2)) + Math.Pow(Convert.ToDouble((y2 - y1)), Convert.ToDouble(2)))) - (radius2 + radius1);
        // Compares if the item is 0 distance away from another object, meaning it collided with an object
        if (distance <= 0) {
            return true;
        }
        else {
            return false;
        }
    }
}