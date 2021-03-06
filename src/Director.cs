namespace DefaultNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using System;
using System.Collections.Generic;
using System.Timers;
public class Director   // Starts the game and updates everything per frame
{
    public static int screenWidth = 800;
    public static int screenHeight = 800;
    
    private static System.Timers.Timer timer;
    SpawnDestroyService spawnDestroyService = new();
    static bool action = false;

    public static Texture2D bombTexture;
    public static Texture2D gemTexture;
    public static Texture2D rockTexture;
    public static Texture2D rocketTexture;


    // Loads all of the image textures
    public static void setImage() {
        // Load bomb image
        Image image = LoadImage("bin/Debug/net6.0/images/bomb.png");
        bombTexture = LoadTextureFromImage(image);
        UnloadImage(image);

        // Load gem image
        image = LoadImage("bin/Debug/net6.0/images/gem.png");
        gemTexture = LoadTextureFromImage(image);
        UnloadImage(image);

        // Load rock image
        image = LoadImage("bin/Debug/net6.0/images/rock.png");
        rockTexture = LoadTextureFromImage(image);
        UnloadImage(image);

        // Load rocket image
        image = LoadImage("bin/Debug/net6.0/images/Rocket.png");
        rocketTexture = LoadTextureFromImage(image);
        UnloadImage(image);
    }

    // Runs the game and updates per frame
    public void startGame()
    {
        var vd = new VideoService();
        Raylib.InitWindow(800, 800, "Greed");

        setImage();

        SetTimer();

        Player player = new Player();

        while (!Raylib.WindowShouldClose())
        {
            
            if (spawnDestroyService.checkIfSpawnNeeded()) {
                spawnDestroyService.spawnArtifact('b');
                spawnDestroyService.spawnArtifact('r');
                spawnDestroyService.spawnArtifact('g');
            }
            
            if (action) {
                vd.drawPlayer(player);
                player.Left();
                player.Right();
                player.Up();
                player.Down();
                spawnDestroyService.makeArtifactFall();
                vd.draw(spawnDestroyService.GetArtifacts());
                spawnDestroyService.collideCheckAll(player);
                vd.displayScore();
                action = false;
            }

        }

        // Creates timer to update game per time allotted
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