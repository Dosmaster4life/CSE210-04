namespace DefaultNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System;
using System.Collections.Generic;
public class VideoService   // Displays graphics to the screen
{
    
    private int offset = 15;
    public void startGame()
    {
       
    }

    // Sets the background color and draws each artifact
    public void draw(List<Artifact> objectsToDraw)
    {
        Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            for (int i = 0; i < objectsToDraw.Count; i ++) {
                drawArtifact(objectsToDraw[i].x1, objectsToDraw[i].y1, objectsToDraw[i].radius1, objectsToDraw[i].artifactName);
            }

            Raylib.EndDrawing();
        
    }
    
    // Draws the player onto the screen
    public void drawPlayer(Player player )
    {
        // Draw player collider
        Raylib.DrawCircle(player.x1,player.y1,player.radius,Color.BLACK);
        // Draw player image
        DrawTexture(Director.rocketTexture, player.x1-offset, player.y1-offset, WHITE);
    }

    // Draws the artifacts onto the screen
    public void drawArtifact(int x, int y, float radius, char artifactType) // draws an artifact
    {
        if (artifactType == 'b') {
            // Draw bomb collider
            Raylib.DrawCircle(x,y,radius,Color.BLACK);
            // Draw bomb image
            DrawTexture(Director.bombTexture, x-offset, y-offset, Color.BLUE);
            
        }
        else if (artifactType == 'g') {
            // Draw gem collider
            Raylib.DrawCircle(x,y,radius,Color.BLACK);
            // Draw gem image
            DrawTexture(Director.gemTexture, x-offset, y-offset, Color.DARKGREEN);
        }
        else if (artifactType == 'r') {
            // Draw rock collider
            Raylib.DrawCircle(x,y,radius,Color.BLACK);
            // Draw rock image
            DrawTexture(Director.rockTexture, x-offset, y-offset, Color.GRAY);
        }
    }

    // Draws the score text onto the screen
    public void displayScore() {
        DrawText("Score: " + ScoreManager.score.ToString(), 25, 25, 20, WHITE);
    }
}
