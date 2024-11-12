namespace digicam.net;

public class ImageRelations
{
    #region Member Variables
    protected long _subject;
    protected long _object;
    protected int _type;
    #endregion
    #region Constructors
    public ImageRelations() { }
    public ImageRelations(long subject, long @object, int type)
    {
        this._subject = subject;
        this._object = @object;
        this._type = type;
    }
    #endregion
    #region Public Properties
    public virtual long Subject
    {
        get { return _subject; }
        set { _subject = value; }
    }
    public virtual long Object
    {
        get { return _object; }
        set { _object = value; }
    }
    public virtual int Type
    {
        get { return _type; }
        set { _type = value; }
    }
    #endregion
}