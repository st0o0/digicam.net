namespace digicam.net;

public class ImageComments
{
    #region Member Variables
    protected long _id;
    protected long _imageid;
    protected int _type;
    protected string _language;
    protected string _author;
    protected DateTime _date;
    protected string _comment;
    #endregion
    #region Constructors
    public ImageComments() { }
    public ImageComments(long imageid, int type, string language, string author, DateTime date, string comment)
    {
        this._imageid = imageid;
        this._type = type;
        this._language = language;
        this._author = author;
        this._date = date;
        this._comment = comment;
    }
    #endregion
    #region Public Properties
    public virtual long Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual long Imageid
    {
        get { return _imageid; }
        set { _imageid = value; }
    }
    public virtual int Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public virtual string Language
    {
        get { return _language; }
        set { _language = value; }
    }
    public virtual string Author
    {
        get { return _author; }
        set { _author = value; }
    }
    public virtual DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }
    public virtual string Comment
    {
        get { return _comment; }
        set { _comment = value; }
    }
    #endregion
}
