namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
public class Director
{
    public void startGame()
    {
       var vd = new VideoService();
        Raylib.InitWindow(800, 800, "Greed");
        while (!Raylib.WindowShouldClose())
        {
            vd.draw(null);
            vd.drawArtifact(50,50,10);
            
        }


    }
}