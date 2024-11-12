namespace digicam.net;

public class ImagePositions
{
    #region Member Variables
    protected long _imageid;
    protected string _latitude;
    protected double _latitudeNumber;
    protected string _longitude;
    protected double _longitudeNumber;
    protected double _altitude;
    protected double _orientation;
    protected double _tilt;
    protected double _roll;
    protected double _accuracy;
    protected string _description;
    #endregion
    #region Constructors
    public ImagePositions() { }
    public ImagePositions(string latitude, double latitudeNumber, string longitude, double longitudeNumber, double altitude, double orientation, double tilt, double roll, double accuracy, string description)
    {
        this._latitude = latitude;
        this._latitudeNumber = latitudeNumber;
        this._longitude = longitude;
        this._longitudeNumber = longitudeNumber;
        this._altitude = altitude;
        this._orientation = orientation;
        this._tilt = tilt;
        this._roll = roll;
        this._accuracy = accuracy;
        this._description = description;
    }
    #endregion
    #region Public Properties
    public virtual long Imageid
    {
        get { return _imageid; }
        set { _imageid = value; }
    }
    public virtual string Latitude
    {
        get { return _latitude; }
        set { _latitude = value; }
    }
    public virtual double LatitudeNumber
    {
        get { return _latitudeNumber; }
        set { _latitudeNumber = value; }
    }
    public virtual string Longitude
    {
        get { return _longitude; }
        set { _longitude = value; }
    }
    public virtual double LongitudeNumber
    {
        get { return _longitudeNumber; }
        set { _longitudeNumber = value; }
    }
    public virtual double Altitude
    {
        get { return _altitude; }
        set { _altitude = value; }
    }
    public virtual double Orientation
    {
        get { return _orientation; }
        set { _orientation = value; }
    }
    public virtual double Tilt
    {
        get { return _tilt; }
        set { _tilt = value; }
    }
    public virtual double Roll
    {
        get { return _roll; }
        set { _roll = value; }
    }
    public virtual double Accuracy
    {
        get { return _accuracy; }
        set { _accuracy = value; }
    }
    public virtual string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    #endregion
}