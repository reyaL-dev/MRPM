namespace MRPM.Core;

/// <summary>
/// Progress information for a long-running operation
/// </summary>
public record ProgressInfo(string Phase, int Current, int Total, string? Detail = null)
{
    public double Percent => Total <= 0 ? 0 : 100.0 * Current / Total;
}