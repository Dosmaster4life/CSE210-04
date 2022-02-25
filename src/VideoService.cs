namespace DefaultNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System;
using System.Collections.Generic;
public class VideoService
{
    
    private int offset = 5;
    public void startGame()
    {
       
    }
    public void draw(List<Artifact> objectsToDraw)
    {
        Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            for (int i = 0; i < objectsToDraw.Count; i ++) {
                drawArtifact(objectsToDraw[i].x1, objectsToDraw[i].y1, objectsToDraw[i].radius1, objectsToDraw[i].artifactName);
            }

            Raylib.EndDrawing();
        
    }
    public void drawPlayer(Player player )
    {
        Raylib.DrawCircle(player.x1,player.y1,player.radius,Color.BLACK);
        DrawTexture(Director.rocketTexture, player.x1, player.y1, GRAY);
    }

    public void drawArtifact(int x, int y, float radius, char artifactType) // draws an artifact
    {
        if (artifactType == 'b') {
            Raylib.DrawCircle(x,y,radius,Color.BLUE);
            DrawTexture(Director.bombTexture, x-offset, y-offset, Color.DARKBLUE);
            
        }
        else if (artifactType == 'g') {
            Raylib.DrawCircle(x,y,radius,Color.GREEN);
            DrawTexture(Director.gemTexture, x-offset, y-offset, Color.DARKGREEN);
        }
        else if (artifactType == 'r') {
            Raylib.DrawCircle(x,y,radius,Color.RED);
            DrawTexture(Director.rocketTexture, x-offset, y-offset, Color.DARKPURPLE);
        }
    }
}
