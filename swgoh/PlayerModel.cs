using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Swgoh
{
    public class PlayerModel
    {
        [JsonProperty("units")]
        public Unit[] Units { get; set; }
        [JsonProperty("data")]
        public PlayerData Data { get; set; }
    }
    public class Unit
    {
        [JsonProperty("data")]
        //object Data { get; set; }
        public UnitData Data { get; set; }
    }
    public class UnitData
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("power")] int Power { get; set; }
        [JsonProperty("combat_type")] int CombatType { get; set; }
        [JsonProperty("base_id")] string BaseId { get; set; }
        [JsonProperty("gear_level")] int GearLevel { get; set; }
        [JsonProperty("level")] int Level { get; set; }
        [JsonProperty("url")] string Url { get; set; }
        [JsonProperty("rarity")] int Rarity { get; set; }
        [JsonProperty("gear")] object Gear { get; set; }
        [JsonProperty("ability_data")] object AbilityData { get; set; }
        [JsonProperty("zeta_abilities")] public string[] ZetaAbilities { get; set; }

        [JsonProperty("stats")] Dictionary<object, object> Stats { get; set; }


    }
    public class PlayerData
    {
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("galactic_power")]
        int GalacticPower { get; set; }

        [JsonProperty("last_updated")]
        DateTime LastUpdated { get; set; }
        [JsonProperty("pve_battles_won")]
        int PVEBattlesWon { get; set; }
        [JsonProperty("character_galactic_power")]
        int CharacterGalacticPower { get; set; }
        [JsonProperty("guild_id")]
        int GuildId { get; set; }
        [JsonProperty("arena_rank")]
        int ArenaRank { get; set; }
        [JsonProperty("ally_code")]
        int AllyCode { get; set; }
        [JsonProperty("level")]
        int Level { get; set; }
        [JsonProperty("ship_galactic_power")]
        int ShipGalacticPower { get; set; }
        [JsonProperty("guild_name")]
        string GuildName { get; set; }
        [JsonProperty("arena_leader_base_id")]
        string ArenaLeaderBaseId { get; set; }
        [JsonProperty("url")]
        string Url { get; set; }
        [JsonProperty("fleet_arena")]
        FleetArenaModel FleetArena { get; set; }
        [JsonProperty("arena")]
        ArenaModel Arena { get; set; }
    }

    public class ArenaModel
    {
        [JsonProperty("members")]
        string[] Members { get; set; }
        [JsonProperty("leader")]
        string Leader { get; set; }
        [JsonProperty("rank")]
        int Rank { get; set; }
    }
    public class FleetArenaModel : ArenaModel
    {
        [JsonProperty("reinforcements")]
        string[] Reinforcements { get; set; }
    }
}
