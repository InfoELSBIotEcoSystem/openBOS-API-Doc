using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
public class DocToTOC
{
    public List<TOC> root => new List<TOC>();

    private DocToTOCArgument arguments;
    public DocToTOC(DocToTOCArgument arguments)
    {
        this.arguments = arguments;
    }

    class TOCContext
    {
        public string path="";
        public TOC toc;
    }

    public void Generate()
    {
        TOCContext rootContext = new TOCContext();
        rootContext.path = arguments.inputDir;
        rootContext.toc = new TOCDirectory();
        ((TOCDirectory)rootContext.toc).innerList = new List<TOC>();
        Generate(arguments.inputDir, rootContext);

        string jsonString = JsonSerializer.Serialize(((TOCDirectory)rootContext.toc).innerList, new JsonSerializerOptions(){
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            WriteIndented=true,
        });

        File.WriteAllText(Path.Combine(arguments.outputDir, arguments.outFile), jsonString);
    }

    void Generate(string relativePath, TOCContext rootContext)
    {
        Queue<TOCContext> queue = new Queue<TOCContext>();
        queue.Enqueue(rootContext);
        while (queue.Count > 0)
        {
            var tocContext = queue.Dequeue();
            foreach (string subDir in Directory.GetDirectories(tocContext.path))
            {
                var fileName = Directory.GetFiles(subDir, "_index.md").First();
                TOCContext tocCtx = new TOCContext();
                tocCtx.toc = CreateDirectory(relativePath, tocContext, fileName);
                tocCtx.path = subDir;
                queue.Enqueue(tocCtx);
            }
            var files = Directory.GetFiles(tocContext.path, "*.md");
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i];
                if (files[i].ToLower().Contains("_index.md")) continue;
                TOCContext tocCtx = new TOCContext();
                tocCtx.toc = CreateFile(relativePath, tocContext, fileName);
                tocCtx.path = files[i];
            }
        }
    }

    private static TOC CreateDirectory(string relativePath, TOCContext tocContext, string fileName)
    {
        return TOCFactory.CreateDirectory(
                            ((TOCDirectory)tocContext.toc).innerList,
                            File.ReadLines(fileName).Where(x => x.StartsWith("# ")).First().Substring(2),
                            Path.GetRelativePath(relativePath, fileName).Replace("\\","/"));
    }
    private static TOCFile CreateFile(string relativePath, TOCContext tocContext, string fileName)
    {
        return TOCFactory.CreateFile(
                            ((TOCDirectory)tocContext.toc).innerList,
                            File.ReadLines(fileName).Where(x => x.StartsWith("# ")).First().Substring(2),
                            Path.GetRelativePath(relativePath, fileName).Replace("\\","/"));
    }
}