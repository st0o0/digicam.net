namespace digicam.net;

public class VideoMetadata
{
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

    public virtual long Imageid { get; set; }
    public virtual string AspectRatio { get; set; }
    public virtual string AudioBitRate { get; set; }
    public virtual string AudioChannelType { get; set; }
    public virtual string AudioCompressor { get; set; }
    public virtual string Duration { get; set; }
    public virtual string FrameRate { get; set; }
    public virtual int ExposureProgram { get; set; }
    public virtual string VideoCodec { get; set; }
}
