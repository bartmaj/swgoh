using Newtonsoft.Json;

namespace Swgoh
{
    public class CharacterModel
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("base_id")] public string BaseId { get; set; }
        [JsonProperty("pk")] public int Id { get; set; }
        [JsonProperty("url")] public string Url { get; set; }
        [JsonProperty("image")] public string Image { get; set; }
        [JsonProperty("power")] public int Power { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("combat_type")] public int CombatType { get; set; }
        [JsonProperty("gear_levels")] public GearLevel[] GearLevels { get; set; }
        [JsonProperty("alignment")] public string Alignment { get; set; }
        [JsonProperty("categories")] public string[] Categories { get; set; }
        [JsonProperty("ability_classes")] public string[] AbilityClasses { get; set; }
        [JsonProperty("role")] public string Role { get; set; }
        [JsonProperty("ship")] public string Ship { get; set; }
        [JsonProperty("ship_slot")] public string ShipSlot { get; set; }
        [JsonProperty("activate_shard_count")] public string ActivateShardCount { get; set; }

    }

    public class GearLevel
    {
        [JsonProperty("tier")] public int Tier { get; set; }
        [JsonProperty("gear")] public string[] Gear { get; set; }
    }
}
