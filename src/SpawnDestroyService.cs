namespace DefaultNamespace;

public class SpawnDestroyService
{
    public int artifactMax = 20;
    public int screenHeight = 800;
    public List<Artifact> artifactsList = new();

    public void spawnArtifact(char artifact) {
        switch(artifact) {
            case 'b':
                Bomb bomb = new();
                bomb.setXYCoordinate();
                bomb.randomFallSpeed();
                artifactsList.Add(bomb);
                break;
            case 'g':
                Gem gem = new();
                gem.setXYCoordinate();
                gem.randomFallSpeed();
                artifactsList.Add(gem);
                break;
            case 'r':
                Rock rock = new();
                rock.setXYCoordinate();
                rock.randomFallSpeed();
                artifactsList.Add(rock);
                break;
        }
    }

    public bool checkIfSpawnNeeded() {
        if(artifactMax - (artifactsList.Count - 1) > 0) {
            return true;
        }
        else {
            return false;
        }
    }

    public List<Artifact> GetArtifacts() {
        return artifactsList;
    }

    public void makeArtifactFall() {
        for(int i = 0; i < artifactsList.Count; i++) {
            artifactsList[i].fall();

            if (artifactsList[i].y1 > screenHeight) {
                artifactsList.RemoveAt(i);
            }
        }
    }
}