namespace DefaultNamespace;

public class Artifact
{
    // Compare itself and input of player
    // x, y, radius
    // Player's x, y, and radius are parameters
    int x1 = 0;
    int y1 = -100;
    float radius1 = 10;
    
    // Distance formula for circle to detect collision
    public bool checkCollision(int x2, int y2, float radius2) {
        float distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) - (radius2 + radius1);
        // Compares if the item is 0 distance away from another object, meaning it collided with an object
        if (distance <= 0) {
            return true;
        }
        else {
            return false;
        }
    }
}