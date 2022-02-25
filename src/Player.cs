using Raylib_cs;

namespace DefaultNamespace;
public class Player     //This class has all the atributes of the player
{
    public float radius = 10;
    public int speed = 10;

    public int x1 = 400;
    public int y1 = 700;

    // Checks if left arrow or A key are pressed and moves player left
    public void Left() {
        if(x1 > 5) {    //causes player to not go off screen
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)||Raylib.IsKeyDown(KeyboardKey.KEY_A)) {
                x1-=5;
            }
        }
    }

    // Checks if right arrow or D key are pressed and moves player right
    public void Right() {   //causes player to not go off screen
        if(x1 < 795) {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)||Raylib.IsKeyDown(KeyboardKey.KEY_D)) {
                x1+=5;
            }
    }



}

// Checks if up arrow or W key are pressed and moves player up
    public void Up() {
        if (y1 > 5) {      //causes player to not go off screen
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)||Raylib.IsKeyDown(KeyboardKey.KEY_W)) {
                y1-=5;
            }
        }
    }

    // Checks if down arrow or S key are pressed and moves player down
    public void Down() {
        if (y1 < 795) {     //causes player to not go off screen
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)||Raylib.IsKeyDown(KeyboardKey.KEY_S)) {
                y1+=5;
            }
        }
    }
}