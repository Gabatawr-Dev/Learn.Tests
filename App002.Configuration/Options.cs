using System.Text.Json;

namespace App002.Configuration;

public class Options
{
    public string Name { get; set; } = null!;
    public string Version { get; set; } = null!;
    public string[] Tags { get; set; } = null!;
    public string[] Files { get; set; } = null!;
    
    private static readonly JsonSerializerOptions _serializerOptions = new() { WriteIndented = true };
    public override string ToString() => JsonSerializer.Serialize(this, _serializerOptions);
}