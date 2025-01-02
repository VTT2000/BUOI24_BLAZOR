using System;
using System.Text.Json.Serialization;

namespace web_blazor_server.Models;

public class ProductModel
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("price")]
    public string Price { get; set; }

    [JsonPropertyName("img")]
    public Uri Img { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("deleted")]
    public bool Deleted { get; set; }
}