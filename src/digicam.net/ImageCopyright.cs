namespace digicam.net;
public class ImageCopyright
{
    public ImageCopyright(long imageid, string property, string value, string extraValue)
    {
        ImageId = imageid;
        Property = property;
        Value = value;
        ExtraValue = extraValue;
    }

    public virtual long Id { get; set; }
    public virtual long ImageId { get; set; }
    public virtual string Property { get; set; }
    public virtual string Value { get; set; }
    public virtual string ExtraValue { get; set; }
}
