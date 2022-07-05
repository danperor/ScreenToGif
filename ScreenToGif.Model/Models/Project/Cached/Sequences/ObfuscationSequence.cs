using ScreenToGif.Domain.Enums;

namespace ScreenToGif.Domain.Models.Project.Cached.Sequences;

public class ObfuscationSequence : RectSequence
{
    public ObfuscationModes ObfuscationMode { get; set; }

    //ObfuscationSize, other properties.
    
    public ObfuscationSequence()
    {
        Type = SequenceTypes.Obfuscation;
    }
}