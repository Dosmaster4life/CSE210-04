namespace DefaultNamespace;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Timers;
public class Director
{
    private static System.Timers.Timer timer;
    SpawnDestroyService spawnDestroyService = new();
    static bool action = false;
    public void startGame()
    {
        var vd = new VideoService();
        Raylib.InitWindow(800, 800, "Greed");

        SetTimer();

        while (!Raylib.WindowShouldClose())
        {
            
            if (spawnDestroyService.checkIfSpawnNeeded()) {
                spawnDestroyService.spawnArtifact('b');
                spawnDestroyService.spawnArtifact('g');
                spawnDestroyService.spawnArtifact('r');
               
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