using System.Text.Json.Serialization;

namespace TestSdk.Models;

public record Pet(
    [property: JsonPropertyName("id")] long Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("tag"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Tag = null
);
