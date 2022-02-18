﻿namespace DefaultNamespace;

public class Artifact
{
    Random rnd = new Random();
    public int x1 = 0;
    public int y1 = -100;
    public float radius1 = 10;
    private int fallSpeed = 0;

    // Set random x coordinate value within frame, set y coordinate value to -10

    // Random fall speed 1 - 10
    public void randomFallSpeed() {
        fallSpeed = rnd.Next(5,20);
    }

    // Distance formula for circle to detect collision
    public bool checkCollision(int x2, int y2, float radius2) {
        float distance = Convert.ToSingle(Math.Sqrt(Math.Pow(Convert.ToDouble((x2 - x1)), Convert.ToDouble(2)) + Math.Pow(Convert.ToDouble((y2 - y1)), Convert.ToDouble(2)))) - (radius2 + radius1);
        // Compares if the item is 0 distance away from another object, meaning it collided with an object
        if (distance <= 0) {
            // True means there was a collision
            return true;
        }
        else {
            // True means there wasn't a collison
            return false;
        }
    }
}