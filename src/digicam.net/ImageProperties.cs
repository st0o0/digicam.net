namespace digicam.net;

public class ImageProperties
{
    #region Member Variables
    protected long _imageid;
    protected string _property;
    protected string _value;
    #endregion
    #region Constructors
    public ImageProperties() { }
    public ImageProperties(long imageid, string property, string value)
    {
        this._imageid = imageid;
        this._property = property;
        this._value = value;
    }
    #endregion
    #region Public Properties
    public virtual long Imageid
    {
        get { return _imageid; }
        set { _imageid = value; }
    }
    public virtual string Property
    {
        get { return _property; }
        set { _property = value; }
    }
    public virtual string Value
    {
        get { return _value; }
        set { _value = value; }
    }
    #endregion
}