namespace digicam.net;

public class ImageMetadata
{
    #region Member Variables
    protected long _imageid;
    protected string _make;
    protected string _model;
    protected string _lens;
    protected double _aperture;
    protected double _focalLength;
    protected double _focalLength35;
    protected double _exposureTime;
    protected int _exposureProgram;
    protected int _exposureMode;
    protected int _sensitivity;
    protected int _flash;
    protected int _whiteBalance;
    protected int _whiteBalanceColorTemperature;
    protected int _meteringMode;
    protected double _subjectDistance;
    protected int _subjectDistanceCategory;
    #endregion
    #region Constructors
    public ImageMetadata() { }
    public ImageMetadata(string make, string model, string lens, double aperture, double focalLength, double focalLength35, double exposureTime, int exposureProgram, int exposureMode, int sensitivity, int flash, int whiteBalance, int whiteBalanceColorTemperature, int meteringMode, double subjectDistance, int subjectDistanceCategory)
    {
        this._make = make;
        this._model = model;
        this._lens = lens;
        this._aperture = aperture;
        this._focalLength = focalLength;
        this._focalLength35 = focalLength35;
        this._exposureTime = exposureTime;
        this._exposureProgram = exposureProgram;
        this._exposureMode = exposureMode;
        this._sensitivity = sensitivity;
        this._flash = flash;
        this._whiteBalance = whiteBalance;
        this._whiteBalanceColorTemperature = whiteBalanceColorTemperature;
        this._meteringMode = meteringMode;
        this._subjectDistance = subjectDistance;
        this._subjectDistanceCategory = subjectDistanceCategory;
    }
    #endregion
    #region Public Properties
    public virtual long Imageid
    {
        get { return _imageid; }
        set { _imageid = value; }
    }
    public virtual string Make
    {
        get { return _make; }
        set { _make = value; }
    }
    public virtual string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public virtual string Lens
    {
        get { return _lens; }
        set { _lens = value; }
    }
    public virtual double Aperture
    {
        get { return _aperture; }
        set { _aperture = value; }
    }
    public virtual double FocalLength
    {
        get { return _focalLength; }
        set { _focalLength = value; }
    }
    public virtual double FocalLength35
    {
        get { return _focalLength; }
        set { _focalLength = value; }
    }
    public virtual double ExposureTime
    {
        get { return _exposureTime; }
        set { _exposureTime = value; }
    }
    public virtual int ExposureProgram
    {
        get { return _exposureProgram; }
        set { _exposureProgram = value; }
    }
    public virtual int ExposureMode
    {
        get { return _exposureMode; }
        set { _exposureMode = value; }
    }
    public virtual int Sensitivity
    {
        get { return _sensitivity; }
        set { _sensitivity = value; }
    }
    public virtual int Flash
    {
        get { return _flash; }
        set { _flash = value; }
    }
    public virtual int WhiteBalance
    {
        get { return _whiteBalance; }
        set { _whiteBalance = value; }
    }
    public virtual int WhiteBalanceColorTemperature
    {
        get { return _whiteBalanceColorTemperature; }
        set { _whiteBalanceColorTemperature = value; }
    }
    public virtual int MeteringMode
    {
        get { return _meteringMode; }
        set { _meteringMode = value; }
    }
    public virtual double SubjectDistance
    {
        get { return _subjectDistance; }
        set { _subjectDistance = value; }
    }
    public virtual int SubjectDistanceCategory
    {
        get { return _subjectDistanceCategory; }
        set { _subjectDistanceCategory = value; }
    }
    #endregion
}