namespace digicam.net;

public class KDTree
{
    #region Member Variables
    protected int _id;
    protected int _split_axis;
    protected int _position;
    protected byte[] _max_range;
    protected byte[] _min_range;
    protected int _parent;
    protected int _left;
    protected int _right;
    #endregion
    #region Constructors
    public KDTree() { }
    public KDTree(int split_axis, int position, byte[] max_range, byte[] min_range, int parent, int left, int right)
    {
        this._split_axis = split_axis;
        this._position = position;
        this._max_range = max_range;
        this._min_range = min_range;
        this._parent = parent;
        this._left = left;
        this._right = right;
    }
    #endregion
    #region Public Properties
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public virtual int Split_axis
    {
        get { return _split_axis; }
        set { _split_axis = value; }
    }
    public virtual int Position
    {
        get { return _position; }
        set { _position = value; }
    }
    public virtual byte[] Max_range
    {
        get { return _max_range; }
        set { _max_range = value; }
    }
    public virtual byte[] Min_range
    {
        get { return _min_range; }
        set { _min_range = value; }
    }
    public virtual int Parent
    {
        get { return _parent; }
        set { _parent = value; }
    }
    public virtual int Left
    {
        get { return _left; }
        set { _left = value; }
    }
    public virtual int Right
    {
        get { return _right; }
        set { _right = value; }
    }
    #endregion
}