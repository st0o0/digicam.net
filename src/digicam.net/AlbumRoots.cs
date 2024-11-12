namespace digicam.net;
public class AlbumRoots
{
    public AlbumRoots(string label, int status, int type, string identifier, string specificPath, int caseSensitivity)
    {
        Label = label;
        Status = status;
        Type = type;
        Identifier = identifier;
        SpecificPath = specificPath;
        CaseSensitivity = caseSensitivity;
    }
    
    public virtual int Id { get; set; }
    public virtual string Label { get; set; }
    public virtual int Status { get; set; }
    public virtual int Type { get; set; }
    public virtual string Identifier { get; set; }
    public virtual string SpecificPath { get; set; }
    public virtual int CaseSensitivity { get; set; }
}
