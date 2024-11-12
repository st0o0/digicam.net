namespace digicam.net;
public class ImageHaarMatrix
{
    public ImageHaarMatrix(DateTime modificationDate, string uniqueHash, long matrix)
    {
        ModificationDate = modificationDate;
        UniqueHash = uniqueHash;
        Matrix = matrix;
    }

    public virtual long Imageid { get; set; }
    public virtual DateTime ModificationDate { get; set; }
    public virtual string UniqueHash { get; set; }
    public virtual long Matrix { get; set; }
}