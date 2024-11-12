namespace digicam.net;

public class IdentityAttributes
{
    #region Member Variables
    protected int _id;
    protected int _type;
    protected string _attribute;
    protected string _value;
    #endregion
    #region Constructors
    public IdentityAttributes() { }
    public IdentityAttributes(int id, int type, string attribute, string value)
    {
        this._id = id;
        this._type = type;
        this._attribute = attribute;
        this._value = value;
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
    public virtual string Attribute
    {
        get { return _attribute; }
        set { _attribute = value; }
    }
    public virtual string Value
    {
        get { return _value; }
        set { _value = value; }
    }
    #endregion
}
