namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
public class VideoService
{
    public void draw()
    {
       
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

            Raylib.EndDrawing();
        
    }
}