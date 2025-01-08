using System.Collections.ObjectModel;
using System.Dynamic;
using System.Text.Json.Serialization;

namespace Az.Functions.MetadataToJson.Models;

/// <summary>
/// as per
/// - https://github.com/Azure/azure-functions-dotnet-worker/blob/main/sdk/Sdk/Abstractions/SdkRetryOptions.cs
/// </summary>
public class SdkRetryOptions
{
    public string? Strategy { get; set; }

    public int MaxRetryCount { get; set; }

    public string? DelayInterval { get; set; }

    public string? MinimumInterval { get; set; }

    public string? MaximumInterval { get; set; }
}

/// <summary>
/// as per
/// - https://github.com/Azure/azure-functions-dotnet-worker/blob/main/sdk/Sdk/Abstractions/SdkFunctionMetadata.cs
/// </summary>
public class FunctionMetadata
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scriptFile")]
    public string? ScriptFile { get; set; }

    [JsonPropertyName("functionDirectory")]
    public string? FunctionDirectory { get; set; }


    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    [JsonPropertyName("properties")]
    public IDictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();

    [JsonPropertyName("bindings")]
    public Collection<ExpandoObject> Bindings { get; set; } = new Collection<ExpandoObject>();

    [JsonPropertyName("retry")]
    public SdkRetryOptions? Retry { get; set; }
}

internal class OriginalFunctionMetadata
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("scriptFile")]
    public string ScriptFile { get; set; } = string.Empty;

    [JsonPropertyName("entryPoint")]
    public string EntryPoint { get; set; } = string.Empty;

    [JsonPropertyName("language")]
    public string Language { get; set; } = string.Empty;

    [JsonPropertyName("properties")]
    public FunctionProperties Properties { get; set; } = new();

    [JsonPropertyName("bindings")]
    public IEnumerable<FunctionBinding> Bindings { get; set; } = new List<FunctionBinding>();
}
