namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
public class Director
{
    public void startGame()
    {
        Raylib.InitWindow(800, 480, "Hello World");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

            Raylib.EndDrawing();
        }
    }
}