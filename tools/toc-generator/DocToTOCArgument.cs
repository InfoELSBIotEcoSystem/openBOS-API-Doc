public class DocToTOCArgument
{
    public string outputDir="";
    public string inputDir="";
    public string outFile = "toc.json";

    public string outputFile
    {
        get => outFile;
        set => outFile = value;
    }
}