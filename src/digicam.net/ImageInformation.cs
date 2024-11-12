namespace digicam.net;
public class ImageInformation
{
    public ImageInformation(int rating, DateTime creationDate, DateTime digitizationDate, int orientation, int width, int height, string format, int colorDepth, int colorModel)
    {
        Rating = rating;
        CreationDate = creationDate;
        DigitizationDate = digitizationDate;
        Orientation = orientation;
        Width = width;
        Height = height;
        Format = format;
        ColorDepth = colorDepth;
        ColorModel = colorModel;
    }

    public virtual long ImageId { get; set; }
    public virtual int Rating { get; set; }
    public virtual DateTime CreationDate { get; set; }
    public virtual DateTime DigitizationDate { get; set; }
    public virtual int Orientation { get; set; }
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public virtual string Format { get; set; }
    public virtual int ColorDepth { get; set; }
    public virtual int ColorModel { get; set; }
}