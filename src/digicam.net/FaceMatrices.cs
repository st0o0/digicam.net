namespace digicam.net;
#region DownloadHistory
#region FaceMatrices
public class FaceMatrices
{
    #region Member Variables
    protected int _id;
    protected int _identity;
    protected string _context;
    protected byte[] _embedding;
    #endregion
    #region Constructors
    public FaceMatrices() { }
    public FaceMatrices(int identity, string context, byte[] embedding)
    {
        this._identity = identity;
        this._context = context;
        this._embedding = embedding;
    }
    #endregion
    #region Public Properties
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual int Identity
    {
        get { return _identity; }
        set { _identity = value; }
    }
    public virtual string Context
    {
        get { return _context; }
        set { _context = value; }
    }
    public virtual byte[] Embedding
    {
        get { return _embedding; }
        set { _embedding = value; }
    }
    #endregion
}
#endregion
#endregion
