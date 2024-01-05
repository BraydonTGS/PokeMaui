using Newtonsoft.Json;

namespace PokeMaui.Business.Api
{
    /// <summary>
    /// Pokemon API Response Object. 
    /// 
    /// This is used to Deserialize the API Results when making an API request: https://pokeapi.co/api/v2/pokemon/
    /// 
    /// Generated with: https://json2csharp.com/
    /// </summary>
    public class PokemonApiResponse
    {
        [JsonProperty("abilities")]
        public List<Ability> abilities { get; set; }

        [JsonProperty("base_experience")]
        public int? base_experience { get; set; }

        [JsonProperty("forms")]
        public List<Form> forms { get; set; }

        [JsonProperty("game_indices")]
        public List<GameIndex> game_indices { get; set; }

        [JsonProperty("height")]
        public int? height { get; set; }

        [JsonProperty("held_items")]
        public List<HeldItem> held_items { get; set; }

        [JsonProperty("id")]
        public int? id { get; set; }

        [JsonProperty("is_default")]
        public bool? is_default { get; set; }

        [JsonProperty("location_area_encounters")]
        public string location_area_encounters { get; set; }

        [JsonProperty("moves")]
        public List<Move> moves { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("order")]
        public int? order { get; set; }

        [JsonProperty("past_abilities")]
        public List<object> past_abilities { get; set; }

        [JsonProperty("past_types")]
        public List<object> past_types { get; set; }

        [JsonProperty("species")]
        public Species species { get; set; }

        [JsonProperty("sprites")]
        public Sprites sprites { get; set; }

        [JsonProperty("stats")]
        public List<Stat> stats { get; set; }

        [JsonProperty("types")]
        public List<Type> types { get; set; }

        [JsonProperty("weight")]
        public int? weight { get; set; }
    }

    public class Ability
    {
        [JsonProperty("ability")]
        public Ability ability { get; set; }

        [JsonProperty("is_hidden")]
        public bool? is_hidden { get; set; }

        [JsonProperty("slot")]
        public int? slot { get; set; }
    }

    public class Ability2
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class Animated
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class BlackWhite
    {
        [JsonProperty("animated")]
        public Animated animated { get; set; }

        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Crystal
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_transparent")]
        public string back_shiny_transparent { get; set; }

        [JsonProperty("back_transparent")]
        public string back_transparent { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_transparent")]
        public string front_shiny_transparent { get; set; }

        [JsonProperty("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class DiamondPearl
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class DreamWorld
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }
    }

    public class Emerald
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class FireredLeafgreen
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class Form
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class GameIndex
    {
        [JsonProperty("game_index")]
        public int? game_index { get; set; }

        [JsonProperty("version")]
        public Version version { get; set; }
    }

    public class GenerationI
    {
        [JsonProperty("red-blue")]
        public RedBlue redblue { get; set; }

        [JsonProperty("yellow")]
        public Yellow yellow { get; set; }
    }

    public class GenerationIi
    {
        [JsonProperty("crystal")]
        public Crystal crystal { get; set; }

        [JsonProperty("gold")]
        public Gold gold { get; set; }

        [JsonProperty("silver")]
        public Silver silver { get; set; }
    }

    public class GenerationIii
    {
        [JsonProperty("emerald")]
        public Emerald emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen { get; set; }

        [JsonProperty("ruby-sapphire")]
        public RubySapphire rubysapphire { get; set; }
    }

    public class GenerationIv
    {
        [JsonProperty("diamond-pearl")]
        public DiamondPearl diamondpearl { get; set; }

        [JsonProperty("heartgold-soulsilver")]
        public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }

        [JsonProperty("platinum")]
        public Platinum platinum { get; set; }
    }

    public class GenerationV
    {
        [JsonProperty("black-white")]
        public BlackWhite blackwhite { get; set; }
    }

    public class GenerationVi
    {
        [JsonProperty("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }

        [JsonProperty("x-y")]
        public XY xy { get; set; }
    }

    public class GenerationVii
    {
        [JsonProperty("icons")]
        public Icons icons { get; set; }

        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultrasunultramoon { get; set; }
    }

    public class GenerationViii
    {
        [JsonProperty("icons")]
        public Icons icons { get; set; }
    }

    public class Gold
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class HeartgoldSoulsilver
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class HeldItem
    {
        [JsonProperty("item")]
        public Item item { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetail> version_details { get; set; }
    }

    public class Home
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Icons
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }
    }

    public class Item
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class Move
    {
        [JsonProperty("move")]
        public Move move { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Move2
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class MoveLearnMethod
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class OfficialArtwork
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class OmegarubyAlphasapphire
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Other
    {
        [JsonProperty("dream_world")]
        public DreamWorld dream_world { get; set; }

        [JsonProperty("home")]
        public Home home { get; set; }

        [JsonProperty("official-artwork")]
        public OfficialArtwork officialartwork { get; set; }

        [JsonProperty("showdown")]
        public Showdown showdown { get; set; }
    }

    public class Platinum
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class RedBlue
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_gray")]
        public string back_gray { get; set; }

        [JsonProperty("back_transparent")]
        public string back_transparent { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_gray")]
        public string front_gray { get; set; }

        [JsonProperty("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class RubySapphire
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }
    }

    public class Showdown
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Silver
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_transparent")]
        public string front_transparent { get; set; }
    }

    public class Species
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_female")]
        public object back_female { get; set; }

        [JsonProperty("back_shiny")]
        public string back_shiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public object back_shiny_female { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }

        [JsonProperty("other")]
        public Other other { get; set; }

        [JsonProperty("versions")]
        public Versions versions { get; set; }
    }

    public class Stat
    {
        [JsonProperty("base_stat")]
        public int? base_stat { get; set; }

        [JsonProperty("effort")]
        public int? effort { get; set; }

        [JsonProperty("stat")]
        public Stat stat { get; set; }
    }

    public class Stat2
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class Type
    {
        [JsonProperty("slot")]
        public int? slot { get; set; }

        [JsonProperty("type")]
        public Type type { get; set; }
    }

    public class Type2
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class UltraSunUltraMoon
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Version
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class VersionDetail
    {
        [JsonProperty("rarity")]
        public int? rarity { get; set; }

        [JsonProperty("version")]
        public Version version { get; set; }
    }

    public class VersionGroup
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int? level_learned_at { get; set; }

        [JsonProperty("move_learn_method")]
        public MoveLearnMethod move_learn_method { get; set; }

        [JsonProperty("version_group")]
        public VersionGroup version_group { get; set; }
    }

    public class Versions
    {
        [JsonProperty("generation-i")]
        public GenerationI generationi { get; set; }

        [JsonProperty("generation-ii")]
        public GenerationIi generationii { get; set; }

        [JsonProperty("generation-iii")]
        public GenerationIii generationiii { get; set; }

        [JsonProperty("generation-iv")]
        public GenerationIv generationiv { get; set; }

        [JsonProperty("generation-v")]
        public GenerationV generationv { get; set; }

        [JsonProperty("generation-vi")]
        public GenerationVi generationvi { get; set; }

        [JsonProperty("generation-vii")]
        public GenerationVii generationvii { get; set; }

        [JsonProperty("generation-viii")]
        public GenerationViii generationviii { get; set; }
    }

    public class XY
    {
        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_female")]
        public object front_female { get; set; }

        [JsonProperty("front_shiny")]
        public string front_shiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public object front_shiny_female { get; set; }
    }

    public class Yellow
    {
        [JsonProperty("back_default")]
        public string back_default { get; set; }

        [JsonProperty("back_gray")]
        public string back_gray { get; set; }

        [JsonProperty("back_transparent")]
        public string back_transparent { get; set; }

        [JsonProperty("front_default")]
        public string front_default { get; set; }

        [JsonProperty("front_gray")]
        public string front_gray { get; set; }

        [JsonProperty("front_transparent")]
        public string front_transparent { get; set; }
    }


}