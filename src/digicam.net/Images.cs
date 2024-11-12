namespace digicam.net;

public class Images
{
    public Images(int album, string name, int status, int category, DateTime modificationDate, long fileSize, string uniqueHash, long manualOrder)
    {
        Album = album;
        Name = name;
        Status = status;
        Category = category;
        ModificationDate = modificationDate;
        FileSize = fileSize;
        UniqueHash = uniqueHash;
        ManualOrder = manualOrder;
    }

    public virtual long Id { get; set; }
    public virtual int Album { get; set; }
    public virtual string Name { get; set; }
    public virtual int Status { get; set; }
    public virtual int Category { get; set; }
    public virtual DateTime ModificationDate { get; set; }
    public virtual long FileSize { get; set; }
    public virtual string UniqueHash { get; set; }
    public virtual long ManualOrder { get; set; }
}