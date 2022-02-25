﻿namespace DefaultNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System;
using System.Collections.Generic;
using System.Timers;
public class Director
{
    public static int screenWidth = 800;
    public static int screenHeight = 800;
    
    private static System.Timers.Timer timer;
    SpawnDestroyService spawnDestroyService = new();
    static bool action = false;

    public static Texture2D bombTexture;

    public static void setImage() {
        Image image = LoadImage("bin/Debug/net6.0/images/bomb.png");
        bombTexture = LoadTextureFromImage(image);

        UnloadImage(image);
    }
    public void startGame()
    {
        var vd = new VideoService();
        Raylib.InitWindow(800, 800, "Greed");

        setImage();

        SetTimer();

        while (!Raylib.WindowShouldClose())
        {
            
            if (spawnDestroyService.checkIfSpawnNeeded()) {
                spawnDestroyService.spawnArtifact('b');
                spawnDestroyService.spawnArtifact('r');
                spawnDestroyService.spawnArtifact('g');
            }
            
            if (action) {
                spawnDestroyService.makeArtifactFall();
                vd.draw(spawnDestroyService.GetArtifacts());
                action = false;
            }

        }

        static void SetTimer() {
            timer = new System.Timers.Timer(20);

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        static void OnTimedEvent(Object source, ElapsedEventArgs e) {
            action = true;
        }
    }
}