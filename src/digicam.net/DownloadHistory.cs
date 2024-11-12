namespace digicam.net;

public class DownloadHistory
{
    #region Member Variables
    protected int _id;
    protected string _identifier;
    protected string _filename;
    protected uint _filesize;
    protected DateTime _filedate;
    #endregion
    #region Constructors
    public DownloadHistory() { }
    public DownloadHistory(string identifier, string filename, uint filesize, DateTime filedate)
    {
        this._identifier = identifier;
        this._filename = filename;
        this._filesize = filesize;
        this._filedate = filedate;
    }
    #endregion
    #region Public Properties
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual string Identifier
    {
        get { return _identifier; }
        set { _identifier = value; }
    }
    public virtual string Filename
    {
        get { return _filename; }
        set { _filename = value; }
    }
    public virtual uint Filesize
    {
        get { return _filesize; }
        set { _filesize = value; }
    }
    public virtual DateTime Filedate
    {
        get { return _filedate; }
        set { _filedate = value; }
    }
    #endregion
}
