using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region AlbumRoots
    public class AlbumRoots
    {
        #region Member Variables
        protected int _id;
        protected string _label;
        protected int _status;
        protected int _type;
        protected string _identifier;
        protected string _specificPath;
        protected int _caseSensitivity;
        #endregion
        #region Constructors
        public AlbumRoots() { }
        public AlbumRoots(string label, int status, int type, string identifier, string specificPath, int caseSensitivity)
        {
            this._label = label;
            this._status = status;
            this._type = type;
            this._identifier = identifier;
            this._specificPath = specificPath;
            this._caseSensitivity = caseSensitivity;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public virtual int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public virtual int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public virtual string Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }
        public virtual string SpecificPath
        {
            get { return _specificPath; }
            set { _specificPath = value; }
        }
        public virtual int CaseSensitivity
        {
            get { return _caseSensitivity; }
            set { _caseSensitivity = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Albums
    public class Albums
    {
        #region Member Variables
        protected int _id;
        protected int _albumRoot;
        protected string _relativePath;
        protected unknown _date;
        protected string _caption;
        protected string _collection;
        protected unknown _icon;
        protected DateTime _modificationDate;
        #endregion
        #region Constructors
        public Albums() { }
        public Albums(int albumRoot, string relativePath, unknown date, string caption, string collection, unknown icon, DateTime modificationDate)
        {
            this._albumRoot = albumRoot;
            this._relativePath = relativePath;
            this._date = date;
            this._caption = caption;
            this._collection = collection;
            this._icon = icon;
            this._modificationDate = modificationDate;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual int AlbumRoot
        {
            get { return _albumRoot; }
            set { _albumRoot = value; }
        }
        public virtual string RelativePath
        {
            get { return _relativePath; }
            set { _relativePath = value; }
        }
        public virtual unknown Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public virtual string Caption
        {
            get { return _caption; }
            set { _caption = value; }
        }
        public virtual string Collection
        {
            get { return _collection; }
            set { _collection = value; }
        }
        public virtual unknown Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
        public virtual DateTime ModificationDate
        {
            get { return _modificationDate; }
            set { _modificationDate = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region CustomIdentifiers
    public class CustomIdentifiers
    {
        #region Member Variables
        protected string _identifier;
        protected unknown _thumbId;
        #endregion
        #region Constructors
        public CustomIdentifiers() { }
        public CustomIdentifiers(string identifier, unknown thumbId)
        {
            this._identifier = identifier;
            this._thumbId = thumbId;
        }
        #endregion
        #region Public Properties
        public virtual string Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }
        public virtual unknown ThumbId
        {
            get { return _thumbId; }
            set { _thumbId = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region DownloadHistory
    public class DownloadHistory
    {
        #region Member Variables
        protected unknown _id;
        protected string _identifier;
        protected string _filename;
        protected unknown _filesize;
        protected DateTime _filedate;
        #endregion
        #region Constructors
        public DownloadHistory() { }
        public DownloadHistory(string identifier, string filename, unknown filesize, DateTime filedate)
        {
            this._identifier = identifier;
            this._filename = filename;
            this._filesize = filesize;
            this._filedate = filedate;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual string Identifier
        {
            get { return _identifier; }
            set { _identifier = value; }
        }
        public virtual string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public virtual unknown Filesize
        {
            get { return _filesize; }
            set { _filesize = value; }
        }
        public virtual DateTime Filedate
        {
            get { return _filedate; }
            set { _filedate = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region FaceMatrices
    public class FaceMatrices
    {
        #region Member Variables
        protected int _id;
        protected int _identity;
        protected string _context;
        protected unknown _embedding;
        #endregion
        #region Constructors
        public FaceMatrices() { }
        public FaceMatrices(int identity, string context, unknown embedding)
        {
            this._identity = identity;
            this._context = context;
            this._embedding = embedding;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual int Identity
        {
            get { return _identity; }
            set { _identity = value; }
        }
        public virtual string Context
        {
            get { return _context; }
            set { _context = value; }
        }
        public virtual unknown Embedding
        {
            get { return _embedding; }
            set { _embedding = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region FaceSettings
    public class FaceSettings
    {
        #region Member Variables
        protected string _keyword;
        protected string _value;
        #endregion
        #region Constructors
        public FaceSettings() { }
        public FaceSettings(string keyword, string value)
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region FilePaths
    public class FilePaths
    {
        #region Member Variables
        protected string _path;
        protected unknown _thumbId;
        #endregion
        #region Constructors
        public FilePaths() { }
        public FilePaths(string path, unknown thumbId)
        {
            this._path = path;
            this._thumbId = thumbId;
        }
        #endregion
        #region Public Properties
        public virtual string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public virtual unknown ThumbId
        {
            get { return _thumbId; }
            set { _thumbId = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Identities
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region IdentityAttributes
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageComments
    public class ImageComments
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _imageid;
        protected int _type;
        protected string _language;
        protected string _author;
        protected DateTime _date;
        protected string _comment;
        #endregion
        #region Constructors
        public ImageComments() { }
        public ImageComments(unknown imageid, int type, string language, string author, DateTime date, string comment)
        {
            this._imageid = imageid;
            this._type = type;
            this._language = language;
            this._author = author;
            this._date = date;
            this._comment = comment;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public virtual string Language
        {
            get { return _language; }
            set { _language = value; }
        }
        public virtual string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public virtual DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public virtual string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageCopyright
    public class ImageCopyright
    {
        #region Member Variables
        protected unknown _id;
        protected unknown _imageid;
        protected string _property;
        protected string _value;
        protected string _extraValue;
        #endregion
        #region Constructors
        public ImageCopyright() { }
        public ImageCopyright(unknown imageid, string property, string value, string extraValue)
        {
            this._imageid = imageid;
            this._property = property;
            this._value = value;
            this._extraValue = extraValue;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
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
        public virtual string ExtraValue
        {
            get { return _extraValue; }
            set { _extraValue = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageHaarMatrix
    public class ImageHaarMatrix
    {
        #region Member Variables
        protected unknown _imageid;
        protected DateTime _modificationDate;
        protected string _uniqueHash;
        protected long _matrix;
        #endregion
        #region Constructors
        public ImageHaarMatrix() { }
        public ImageHaarMatrix(DateTime modificationDate, string uniqueHash, long matrix)
        {
            this._modificationDate = modificationDate;
            this._uniqueHash = uniqueHash;
            this._matrix = matrix;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual DateTime ModificationDate
        {
            get { return _modificationDate; }
            set { _modificationDate = value; }
        }
        public virtual string UniqueHash
        {
            get { return _uniqueHash; }
            set { _uniqueHash = value; }
        }
        public virtual long Matrix
        {
            get { return _matrix; }
            set { _matrix = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageHistory
    public class ImageHistory
    {
        #region Member Variables
        protected unknown _imageid;
        protected string _uuid;
        protected string _history;
        #endregion
        #region Constructors
        public ImageHistory() { }
        public ImageHistory(string uuid, string history)
        {
            this._uuid = uuid;
            this._history = history;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual string Uuid
        {
            get { return _uuid; }
            set { _uuid = value; }
        }
        public virtual string History
        {
            get { return _history; }
            set { _history = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageInformation
    public class ImageInformation
    {
        #region Member Variables
        protected unknown _imageid;
        protected int _rating;
        protected DateTime _creationDate;
        protected DateTime _digitizationDate;
        protected int _orientation;
        protected int _width;
        protected int _height;
        protected string _format;
        protected int _colorDepth;
        protected int _colorModel;
        #endregion
        #region Constructors
        public ImageInformation() { }
        public ImageInformation(int rating, DateTime creationDate, DateTime digitizationDate, int orientation, int width, int height, string format, int colorDepth, int colorModel)
        {
            this._rating = rating;
            this._creationDate = creationDate;
            this._digitizationDate = digitizationDate;
            this._orientation = orientation;
            this._width = width;
            this._height = height;
            this._format = format;
            this._colorDepth = colorDepth;
            this._colorModel = colorModel;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        public virtual DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public virtual DateTime DigitizationDate
        {
            get { return _digitizationDate; }
            set { _digitizationDate = value; }
        }
        public virtual int Orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }
        public virtual int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public virtual int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public virtual string Format
        {
            get { return _format; }
            set { _format = value; }
        }
        public virtual int ColorDepth
        {
            get { return _colorDepth; }
            set { _colorDepth = value; }
        }
        public virtual int ColorModel
        {
            get { return _colorModel; }
            set { _colorModel = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageMetadata
    public class ImageMetadata
    {
        #region Member Variables
        protected unknown _imageid;
        protected string _make;
        protected string _model;
        protected string _lens;
        protected unknown _aperture;
        protected unknown _focalLength;
        protected unknown _focalLength;
        protected unknown _exposureTime;
        protected int _exposureProgram;
        protected int _exposureMode;
        protected int _sensitivity;
        protected int _flash;
        protected int _whiteBalance;
        protected int _whiteBalanceColorTemperature;
        protected int _meteringMode;
        protected unknown _subjectDistance;
        protected int _subjectDistanceCategory;
        #endregion
        #region Constructors
        public ImageMetadata() { }
        public ImageMetadata(string make, string model, string lens, unknown aperture, unknown focalLength, unknown focalLength, unknown exposureTime, int exposureProgram, int exposureMode, int sensitivity, int flash, int whiteBalance, int whiteBalanceColorTemperature, int meteringMode, unknown subjectDistance, int subjectDistanceCategory)
        {
            this._make = make;
            this._model = model;
            this._lens = lens;
            this._aperture = aperture;
            this._focalLength = focalLength;
            this._focalLength = focalLength;
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
        public virtual unknown Imageid
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
        public virtual unknown Aperture
        {
            get { return _aperture; }
            set { _aperture = value; }
        }
        public virtual unknown FocalLength
        {
            get { return _focalLength; }
            set { _focalLength = value; }
        }
        public virtual unknown FocalLength
        {
            get { return _focalLength; }
            set { _focalLength = value; }
        }
        public virtual unknown ExposureTime
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
        public virtual unknown SubjectDistance
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImagePositions
    public class ImagePositions
    {
        #region Member Variables
        protected unknown _imageid;
        protected string _latitude;
        protected unknown _latitudeNumber;
        protected string _longitude;
        protected unknown _longitudeNumber;
        protected unknown _altitude;
        protected unknown _orientation;
        protected unknown _tilt;
        protected unknown _roll;
        protected unknown _accuracy;
        protected string _description;
        #endregion
        #region Constructors
        public ImagePositions() { }
        public ImagePositions(string latitude, unknown latitudeNumber, string longitude, unknown longitudeNumber, unknown altitude, unknown orientation, unknown tilt, unknown roll, unknown accuracy, string description)
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
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual string Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        public virtual unknown LatitudeNumber
        {
            get { return _latitudeNumber; }
            set { _latitudeNumber = value; }
        }
        public virtual string Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        public virtual unknown LongitudeNumber
        {
            get { return _longitudeNumber; }
            set { _longitudeNumber = value; }
        }
        public virtual unknown Altitude
        {
            get { return _altitude; }
            set { _altitude = value; }
        }
        public virtual unknown Orientation
        {
            get { return _orientation; }
            set { _orientation = value; }
        }
        public virtual unknown Tilt
        {
            get { return _tilt; }
            set { _tilt = value; }
        }
        public virtual unknown Roll
        {
            get { return _roll; }
            set { _roll = value; }
        }
        public virtual unknown Accuracy
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageProperties
    public class ImageProperties
    {
        #region Member Variables
        protected unknown _imageid;
        protected string _property;
        protected string _value;
        #endregion
        #region Constructors
        public ImageProperties() { }
        public ImageProperties(unknown imageid, string property, string value)
        {
            this._imageid = imageid;
            this._property = property;
            this._value = value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageRelations
    public class ImageRelations
    {
        #region Member Variables
        protected unknown _subject;
        protected unknown _object;
        protected int _type;
        #endregion
        #region Constructors
        public ImageRelations() { }
        public ImageRelations(unknown subject, unknown object, int type)
        {
            this._subject = subject;
            this._object = object;
            this._type = type;
        }
        #endregion
        #region Public Properties
        public virtual unknown Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public virtual unknown Object
        {
            get { return _object; }
            set { _object = value; }
        }
        public virtual int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Images
    public class Images
    {
        #region Member Variables
        protected unknown _id;
        protected int _album;
        protected string _name;
        protected int _status;
        protected int _category;
        protected DateTime _modificationDate;
        protected unknown _fileSize;
        protected string _uniqueHash;
        protected unknown _manualOrder;
        #endregion
        #region Constructors
        public Images() { }
        public Images(int album, string name, int status, int category, DateTime modificationDate, unknown fileSize, string uniqueHash, unknown manualOrder)
        {
            this._album = album;
            this._name = name;
            this._status = status;
            this._category = category;
            this._modificationDate = modificationDate;
            this._fileSize = fileSize;
            this._uniqueHash = uniqueHash;
            this._manualOrder = manualOrder;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual int Album
        {
            get { return _album; }
            set { _album = value; }
        }
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public virtual int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public virtual int Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public virtual DateTime ModificationDate
        {
            get { return _modificationDate; }
            set { _modificationDate = value; }
        }
        public virtual unknown FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        public virtual string UniqueHash
        {
            get { return _uniqueHash; }
            set { _uniqueHash = value; }
        }
        public virtual unknown ManualOrder
        {
            get { return _manualOrder; }
            set { _manualOrder = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageSimilarity
    public class ImageSimilarity
    {
        #region Member Variables
        protected unknown _imageid;
        protected unknown _imageid;
        protected int _algorithm;
        protected unknown _value;
        #endregion
        #region Constructors
        public ImageSimilarity() { }
        public ImageSimilarity(unknown imageid, unknown imageid, int algorithm, unknown value)
        {
            this._imageid = imageid;
            this._imageid = imageid;
            this._algorithm = algorithm;
            this._value = value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual int Algorithm
        {
            get { return _algorithm; }
            set { _algorithm = value; }
        }
        public virtual unknown Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageTagProperties
    public class ImageTagProperties
    {
        #region Member Variables
        protected unknown _imageid;
        protected int _tagid;
        protected string _property;
        protected string _value;
        #endregion
        #region Constructors
        public ImageTagProperties() { }
        public ImageTagProperties(unknown imageid, int tagid, string property, string value)
        {
            this._imageid = imageid;
            this._tagid = tagid;
            this._property = property;
            this._value = value;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ImageTags
    public class ImageTags
    {
        #region Member Variables
        protected unknown _imageid;
        protected int _tagid;
        #endregion
        #region Constructors
        public ImageTags() { }
        public ImageTags()
        {
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual int Tagid
        {
            get { return _tagid; }
            set { _tagid = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region KDTree
    public class KDTree
    {
        #region Member Variables
        protected int _id;
        protected int _split_axis;
        protected int _position;
        protected unknown _max_range;
        protected unknown _min_range;
        protected int _parent;
        protected int _left;
        protected int _right;
        #endregion
        #region Constructors
        public KDTree() { }
        public KDTree(int split_axis, int position, unknown max_range, unknown min_range, int parent, int left, int right)
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
        public virtual unknown Max_range
        {
            get { return _max_range; }
            set { _max_range = value; }
        }
        public virtual unknown Min_range
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Searches
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Settings
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region SimilaritySettings
    public class SimilaritySettings
    {
        #region Member Variables
        protected string _keyword;
        protected string _value;
        #endregion
        #region Constructors
        public SimilaritySettings() { }
        public SimilaritySettings(string keyword, string value)
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region TagProperties
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Tags
    public class Tags
    {
        #region Member Variables
        protected int _id;
        protected int _pid;
        protected string _name;
        protected unknown _icon;
        protected string _iconkde;
        #endregion
        #region Constructors
        public Tags() { }
        public Tags(int pid, string name, unknown icon, string iconkde)
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
        public virtual unknown Icon
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region TagsTree
    public class TagsTree
    {
        #region Member Variables
        protected int _id;
        protected int _pid;
        #endregion
        #region Constructors
        public TagsTree() { }
        public TagsTree()
        {
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
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region Thumbnails
    public class Thumbnails
    {
        #region Member Variables
        protected unknown _id;
        protected int _type;
        protected DateTime _modificationDate;
        protected int _orientationHint;
        protected long _data;
        #endregion
        #region Constructors
        public Thumbnails() { }
        public Thumbnails(int type, DateTime modificationDate, int orientationHint, long data)
        {
            this._type = type;
            this._modificationDate = modificationDate;
            this._orientationHint = orientationHint;
            this._data = data;
        }
        #endregion
        #region Public Properties
        public virtual unknown Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public virtual DateTime ModificationDate
        {
            get { return _modificationDate; }
            set { _modificationDate = value; }
        }
        public virtual int OrientationHint
        {
            get { return _orientationHint; }
            set { _orientationHint = value; }
        }
        public virtual long Data
        {
            get { return _data; }
            set { _data = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region ThumbSettings
    public class ThumbSettings
    {
        #region Member Variables
        protected string _keyword;
        protected string _value;
        #endregion
        #region Constructors
        public ThumbSettings() { }
        public ThumbSettings(string keyword, string value)
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
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region UniqueHashes
    public class UniqueHashes
    {
        #region Member Variables
        protected string _uniqueHash;
        protected unknown _fileSize;
        protected unknown _thumbId;
        #endregion
        #region Constructors
        public UniqueHashes() { }
        public UniqueHashes(string uniqueHash, unknown fileSize, unknown thumbId)
        {
            this._uniqueHash = uniqueHash;
            this._fileSize = fileSize;
            this._thumbId = thumbId;
        }
        #endregion
        #region Public Properties
        public virtual string UniqueHash
        {
            get { return _uniqueHash; }
            set { _uniqueHash = value; }
        }
        public virtual unknown FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        public virtual unknown ThumbId
        {
            get { return _thumbId; }
            set { _thumbId = value; }
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace DigiKam
{
    #region VideoMetadata
    public class VideoMetadata
    {
        #region Member Variables
        protected unknown _imageid;
        protected string _aspectRatio;
        protected string _audioBitRate;
        protected string _audioChannelType;
        protected string _audioCompressor;
        protected string _duration;
        protected string _frameRate;
        protected int _exposureProgram;
        protected string _videoCodec;
        #endregion
        #region Constructors
        public VideoMetadata() { }
        public VideoMetadata(string aspectRatio, string audioBitRate, string audioChannelType, string audioCompressor, string duration, string frameRate, int exposureProgram, string videoCodec)
        {
            this._aspectRatio = aspectRatio;
            this._audioBitRate = audioBitRate;
            this._audioChannelType = audioChannelType;
            this._audioCompressor = audioCompressor;
            this._duration = duration;
            this._frameRate = frameRate;
            this._exposureProgram = exposureProgram;
            this._videoCodec = videoCodec;
        }
        #endregion
        #region Public Properties
        public virtual unknown Imageid
        {
            get { return _imageid; }
            set { _imageid = value; }
        }
        public virtual string AspectRatio
        {
            get { return _aspectRatio; }
            set { _aspectRatio = value; }
        }
        public virtual string AudioBitRate
        {
            get { return _audioBitRate; }
            set { _audioBitRate = value; }
        }
        public virtual string AudioChannelType
        {
            get { return _audioChannelType; }
            set { _audioChannelType = value; }
        }
        public virtual string AudioCompressor
        {
            get { return _audioCompressor; }
            set { _audioCompressor = value; }
        }
        public virtual string Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public virtual string FrameRate
        {
            get { return _frameRate; }
            set { _frameRate = value; }
        }
        public virtual int ExposureProgram
        {
            get { return _exposureProgram; }
            set { _exposureProgram = value; }
        }
        public virtual string VideoCodec
        {
            get { return _videoCodec; }
            set { _videoCodec = value; }
        }
        #endregion
    }
    #endregion
}