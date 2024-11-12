namespace digicam.net;

public class Thumbnails
{
    #region Member Variables
    protected long _id;
    protected int _type;
    protected DateTime _modificationDate;
    protected int _orientationHint;
    protected long _data;
    #endregion
    #region Constructors
    public Thumbnails() { }
    public Thumbnails(int type, DateTime modificationDate, int orientationHint, long data)
    {
        this._type = type;
        this._modificationDate = modificationDate;
        this._orientationHint = orientationHint;
        this._data = data;
    }
    #endregion
    #region Public Properties
    public virtual long Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual int Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public virtual DateTime ModificationDate
    {
        get { return _modificationDate; }
        set { _modificationDate = value; }
    }
    public virtual int OrientationHint
    {
        get { return _orientationHint; }
        set { _orientationHint = value; }
    }
    public virtual long Data
    {
        get { return _data; }
        set { _data = value; }
    }
    #endregion
}
