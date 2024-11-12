namespace digicam.net;
#region DownloadHistory
#region FaceSettings
#endregion
#region FilePaths
public class FilePaths
{
    #region Member Variables
    protected string _path;
    protected long _thumbId;
    #endregion
    #region Constructors
    public FilePaths() { }
    public FilePaths(string path, long thumbId)
    {
        this._path = path;
        this._thumbId = thumbId;
    }
    #endregion
    #region Public Properties
    public virtual string Path
    {
        get { return _path; }
        set { _path = value; }
    }
    public virtual long ThumbId
    {
        get { return _thumbId; }
        set { _thumbId = value; }
    }
    #endregion
}
#endregion
#endregion
