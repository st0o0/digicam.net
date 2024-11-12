namespace digicam.net;


public class ImageTags
{
    #region Member Variables
    protected long _imageid;
    protected int _tagid;
    #endregion
    #region Constructors
    public ImageTags() { }
    #endregion
    #region Public Properties
    public virtual long Imageid
    {
        get { return _imageid; }
        set { _imageid = value; }
    }
    public virtual int Tagid
    {
        get { return _tagid; }
        set { _tagid = value; }
    }
    #endregion
}