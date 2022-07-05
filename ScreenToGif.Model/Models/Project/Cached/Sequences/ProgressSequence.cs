using ScreenToGif.Domain.Enums;

namespace ScreenToGif.Domain.Models.Project.Cached.Sequences;

public class ProgressSequence : RectSequence
{
    public ProgressTypes ProgressMode { get; set; }

    //Color.
    //Bar percentage.
    //Offset calculation:
    //  Automatic > Based on current start timespan.
    //  Manual
    //      Offset in Timespan
    
    //How to calculate the correct data to display?
    //  Should be dynamic, based on current timestamp + offset
    //  If offset is changed or sequence is expanded/shortned, upon new rendering, the values will be recalculated.
    
    public ProgressSequence()
    {
        Type = SequenceTypes.Progress;
    }
}