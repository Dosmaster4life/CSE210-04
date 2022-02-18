namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
public class VideoService
{
    public void startGame()
    {
       
    }
    public void draw(List<Artifact>? objectsToDraw)
    {
        Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);


            Raylib.EndDrawing();
        
    }

    public void drawArtifact(int x, int y, float radius) // draws an artifact
    {
        Raylib.DrawCircle(x,y,radius,Color.BLUE);
    }
}
