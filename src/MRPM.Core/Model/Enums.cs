namespace MRPM.Core.Model
{
    /// <summary>
    /// Source type for a resource pack
    /// </summary>
    public enum SourceType
    {
        Unknown, Folder, InstanceFolder, ZipArchive
    }

    /// <summary>
    /// Mod loader type
    /// </summary>
    public enum ModLoaderType
    {
        Unknown, Forge, Fabric
    }

    public enum MetadataSource
    {
        None, Local, Remote, McModInfo, Manifest, FileName
    }

    /// <summary>
    /// First mod (alphabetically) wins
    /// </summary>
    public enum ConflictStrategy
    {

        FirstWins,
        LastWins
    }

    public enum AssetFileStatus
    {
        Extracted, SkippedConflict, Overridden, Missing
    }

    /// <summary>
    /// Texture status for a resource pack
    /// </summary>
    public enum TextureStatus
    {
        Unmatched, Suggested, Auto, Manual, KeepOriginal, Excluded, Problem
    }

    public enum MatchStage
    {
        Rule = 0,
        Exact = 1,
        Normalized = 2,
        SameName = 3,
        Fuzzy = 4,
        Keyword = 5,
        Manual = 9
    }

    public enum DecisionSource
    {
        Auto, User
    }

    /// <summary>
    /// Should a texture be scaled down during export
    /// </summary>
    public enum ScalingPolicy
    {
        Inherit,
        Scale,
        NoScale
    }

    /// <summary>
    /// Which Scaling method to use during export
    /// </summary>
    public enum ScaleMethod
    {
        NearestNeighbor,
        Box
    }

}