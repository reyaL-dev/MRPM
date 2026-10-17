namespace MRPM.Core.Model;


public class Session
{
    public const int CurrentSchemaVersion = 1;

    public int SchemaVersion { get; set; } = CurrentSchemaVersion;
    public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset Updated { get; set; } = DateTimeOffset.Now;
}


/// <summary>Represents the settings for a session with default </summary>
public class SessionSettings

{
    public List<string> Extensions { get; set; } = new() { ".png", ".json", ".ogg", ".mcmeta" };
    public ConflictStrategy ConflictStrategy { get; set; } = ConflictStrategy.FirstWins;
    public bool AutoDisableModsWithoutTextures { get; set; } = true;
}