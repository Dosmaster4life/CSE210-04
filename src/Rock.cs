namespace DefaultNamespace;

public class Rock : Artifact
{
    // method that decrease score by 100.

    // Variable that contains a file path to an image.
    private string rockImagePath= "../CSE210-04/images/rock_pixel.png";

    public string getRockImagePath(string rockImage) {
        return rockImagePath;
    }
}