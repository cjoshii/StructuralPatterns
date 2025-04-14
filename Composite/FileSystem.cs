namespace Composite;

public interface IFileSystemItem
{
    string Name { get; }
    void ShowInfo(string indent);
}


public class File(string name) : IFileSystemItem
{
    public string Name { get; private set; } = name;

    public void ShowInfo(string indent = "")
    {
        Console.WriteLine($"{indent}- {Name}");
    }
}

public class Directory(string name) : IFileSystemItem
{
    public string Name { get; private set; } = name;
    private readonly List<IFileSystemItem> items = [];

    public void Add(IFileSystemItem item)
    {
        items.Add(item);
    }

    public void Remove(IFileSystemItem item)
    {
        items.Remove(item);
    }

    public void ShowInfo(string indent = "")
    {
        Console.WriteLine($"{indent}+ {Name}");
        foreach (var item in items)
        {
            item.ShowInfo($"{indent}  ");
        }
    }
}