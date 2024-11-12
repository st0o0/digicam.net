namespace digicam.net;

public class ImageHistory
{
    public ImageHistory(string uuid, string history)
    {
        Uuid = uuid;
        History = history;
    }

    public virtual long Imageid { get; set; }
    public virtual string Uuid { get; set; }
    public virtual string History { get; set; }
}