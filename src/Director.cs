namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
public class Director
{
    public void startGame()
    {
    VideoService vd = new VideoService();
     Raylib.InitWindow(800, 480, "Greed");
            while (!Raylib.WindowShouldClose())
            {
             vd.draw();
            
            }
   
    
       
    }
}