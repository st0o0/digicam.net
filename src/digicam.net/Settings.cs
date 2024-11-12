namespace digicam.net;

public class Settings
{
    #region Member Variables
    protected string _keyword;
    protected string _value;
    #endregion
    #region Constructors
    public Settings() { }
    public Settings(string keyword, string value)
    {
        this._keyword = keyword;
        this._value = value;
    }
    #endregion
    #region Public Properties
    public virtual string Keyword
    {
        get { return _keyword; }
        set { _keyword = value; }
    }
    public virtual string Value
    {
        get { return _value; }
        set { _value = value; }
    }
    #endregion
}