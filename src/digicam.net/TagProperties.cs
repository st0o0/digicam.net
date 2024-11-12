namespace digicam.net;

public class TagProperties
{
    #region Member Variables
    protected int _tagid;
    protected string _property;
    protected string _value;
    #endregion
    #region Constructors
    public TagProperties() { }
    public TagProperties(int tagid, string property, string value)
    {
        this._tagid = tagid;
        this._property = property;
        this._value = value;
    }
    #endregion
    #region Public Properties
    public virtual int Tagid
    {
        get { return _tagid; }
        set { _tagid = value; }
    }
    public virtual string Property
    {
        get { return _property; }
        set { _property = value; }
    }
    public virtual string Value
    {
        get { return _value; }
        set { _value = value; }
    }
    #endregion
}
