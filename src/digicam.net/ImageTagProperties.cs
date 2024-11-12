namespace digicam.net;

public class ImageTagProperties
{
    public ImageTagProperties(long imageid, int tagid, string property, string value)
    {
        ImageId = imageid;
        Tagid = tagid;
        Property = property;
        Value = value;
    }
    
    public virtual long ImageId { get; set; }
    public virtual int Tagid { get; set; }
    public virtual string Property { get; set; }
    public virtual string Value { get; set; }
}