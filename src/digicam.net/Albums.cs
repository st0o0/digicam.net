namespace digicam.net;

#region Albums
public class Albums
{
    #region Member Variables
    protected int _id;
    protected int _albumRoot;
    protected string _relativePath;
    protected DateTime _date;
    protected string _caption;
    protected string _collection;
    protected byte[] _icon;
    protected DateTime _modificationDate;
    #endregion
    #region Constructors
    public Albums(int albumRoot, string relativePath, DateTime date, string caption, string collection, byte[] icon, DateTime modificationDate)
    {
        this._albumRoot = albumRoot;
        this._relativePath = relativePath;
        this._date = date;
        this._caption = caption;
        this._collection = collection;
        this._icon = icon;
        this._modificationDate = modificationDate;
    }
    #endregion
    #region Public Properties
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual int AlbumRoot
    {
        get { return _albumRoot; }
        set { _albumRoot = value; }
    }
    public virtual string RelativePath
    {
        get { return _relativePath; }
        set { _relativePath = value; }
    }
    public virtual DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }
    public virtual string Caption
    {
        get { return _caption; }
        set { _caption = value; }
    }
    public virtual string Collection
    {
        get { return _collection; }
        set { _collection = value; }
    }
    public virtual byte[] Icon
    {
        get { return _icon; }
        set { _icon = value; }
    }
    public virtual DateTime ModificationDate
    {
        get { return _modificationDate; }
        set { _modificationDate = value; }
    }
    #endregion
}
#endregion
