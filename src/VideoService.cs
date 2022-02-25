namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
public class VideoService
{
    public void startGame()
    {
       
    }
    public void draw(List<Artifact> objectsToDraw)
    {
        Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            for (int i = 0; i < objectsToDraw.Count; i ++) {
                drawArtifact(objectsToDraw[i].x1, objectsToDraw[i].y1, objectsToDraw[i].radius1, objectsToDraw[i].artifactName);
            }

            Raylib.EndDrawing();
        
    }
    public void drawPlayer(Player player )
{
Raylib.DrawCircle(player.x1,player.y1,player.radius,Color.BLACK);
}

    public void drawArtifact(int x, int y, float radius, char artifactType) // draws an artifact
    {
        if (artifactType == 'b') {
            Raylib.DrawCircle(x,y,radius,Color.BLUE);
        }
        else if (artifactType == 'g') {
            Raylib.DrawCircle(x,y,radius,Color.GREEN);
        }
        else if (artifactType == 'r') {
            Raylib.DrawCircle(x,y,radius,Color.RED);
        }
    }
}
