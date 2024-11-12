namespace digicam.net;

public class TagsTree
{
    #region Member Variables
    protected int _id;
    protected int _pid;
    #endregion
    #region Constructors
    public TagsTree() { }
    #endregion
    #region Public Properties
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual int Pid
    {
        get { return _pid; }
        set { _pid = value; }
    }
    #endregion
}