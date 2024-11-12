namespace digicam.net;

#region UniqueHashes
public class UniqueHashes
{
    #region Member Variables
    protected string _uniqueHash;
    protected long _fileSize;
    protected long _thumbId;
    #endregion
    #region Constructors
    public UniqueHashes() { }
    public UniqueHashes(string uniqueHash, long fileSize, long thumbId)
    {
        this._uniqueHash = uniqueHash;
        this._fileSize = fileSize;
        this._thumbId = thumbId;
    }
    #endregion
    #region Public Properties
    public virtual string UniqueHash
    {
        get { return _uniqueHash; }
        set { _uniqueHash = value; }
    }
    public virtual long FileSize
    {
        get { return _fileSize; }
        set { _fileSize = value; }
    }
    public virtual long ThumbId
    {
        get { return _thumbId; }
        set { _thumbId = value; }
    }
    #endregion
}

#endregion
#region VideoMetadata
#endregion
