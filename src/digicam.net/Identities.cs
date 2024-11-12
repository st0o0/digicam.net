namespace digicam.net;

public class Identities
{
    #region Member Variables
    protected int _id;
    protected int _type;
    #endregion
    #region Constructors
    public Identities() { }
    public Identities(int type)
    {
        this._type = type;
    }
    #endregion
    #region Public Properties
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual int Type
    {
        get { return _type; }
        set { _type = value; }
    }
    #endregion
}
