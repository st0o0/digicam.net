namespace digicam.net;

public class ImageSimilarity
{
    public ImageSimilarity(long imageid1, long imageid2, int algorithm, double value)
    {
        ImageId1 = imageid1;
        ImageId2 = imageid2;
        Algorithm = algorithm;
        Value = value;
    }

    public virtual long ImageId1 { get; set; }
    public virtual long ImageId2 { get; set; }
    public virtual int Algorithm { get; set; }
    public virtual double Value { get; set; }
}