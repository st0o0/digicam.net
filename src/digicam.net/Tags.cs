namespace digicam.net;

public class Tags
{
    #region Member Variables
    protected int _id;
    protected int _pid;
    protected string _name;
    protected long _icon;
    protected string _iconkde;
    #endregion
    #region Constructors
    public Tags() { }
    public Tags(int pid, string name, long icon, string iconkde)
    {
        this._pid = pid;
        this._name = name;
        this._icon = icon;
        this._iconkde = iconkde;
    }
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
    public virtual string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public virtual long Icon
    {
        get { return _icon; }
        set { _icon = value; }
    }
    public virtual string Iconkde
    {
        get { return _iconkde; }
        set { _iconkde = value; }
    }
    #endregion
}