using Newtonsoft.Json;
using System.Collections.Generic;

namespace Swgoh
{
    public class GearModel
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("base_id")] public string BaseId { get; set; }
        [JsonProperty("recipes")] public object[] Recipes { get; set; }
        [JsonProperty("tier")] public int Tier { get; set; }
        [JsonProperty("required_level")] public int RequiredLevel { get; set; }
        [JsonProperty("stats")] Dictionary<object, object> Stats { get; set; }
        [JsonProperty("mark")] public string Mark { get; set; }
        [JsonProperty("cost")] public int Cost { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("image")] public string Image { get; set; }
        [JsonProperty("ingredients")] public Ingredient[] Ingredients { get; set; }

    }

    public class Ingredient
    {
        [JsonProperty("gear")] public string GearId { get; set; }
        [JsonProperty("amount")] public int Amount { get; set; }
    }
}
