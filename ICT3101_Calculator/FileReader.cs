namespace ICT3101_Calculator;

// Lab 4 2.
public class FileReader : IFileReader
{
    public string[] Read(string path)
    {
        return File.ReadAllLines(path);
    }
}