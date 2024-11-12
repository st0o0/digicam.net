namespace digicam.net;

public class Searches
{
    #region Member Variables
    protected int _id;
    protected int _type;
    protected string _name;
    protected string _query;
    #endregion
    #region Constructors
    public Searches() { }
    public Searches(int type, string name, string query)
    {
        this._type = type;
        this._name = name;
        this._query = query;
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
    public virtual string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public virtual string Query
    {
        get { return _query; }
        set { _query = value; }
    }
    #endregion
}