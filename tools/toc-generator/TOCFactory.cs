using System.Web;
public class TOCFactory
{
    static public TOC CreateDirectory(
            List<TOC> targetList,
            string listName,
            string url
        )
    {
        var item = new TOCDirectory();
        item.innerList = new List<TOC>();
        item.url = url;
        item.listName = HttpUtility.HtmlDecode(listName);
        item.id = targetList.Count+1;
        targetList.Add(item);
        return item;
    }

    static public TOCFile CreateFile(
            List<TOC> targetList,
            string listName,
            string url
        )
    {
        var item = new TOCFile();
        item.url = url;
        item.title = HttpUtility.HtmlDecode(listName);
        item.id = targetList.Count+1;
        targetList.Add(item);
        return item;
    }
}