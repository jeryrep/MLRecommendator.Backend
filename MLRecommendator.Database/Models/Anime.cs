namespace MLRecommendator.Database.Models;
public class Anime {
    
    public uint Id { get; set; }
    public string? Title { get; set; }
    public float Mean { get; set; }
    public uint Rank { get; set; }
    public uint Popularity { get; set; }
    public uint UsersNumber { get; set; }
    public uint UsersScoringNumber { get; set; }
    public string? Nsfw { get; set; }
    private string? _genres;
    public string? Genres {
        get => _genres;
        set {
            _genres = value;
            Action = Convert.ToByte(_genres.Contains("Action"));
            Adventure = Convert.ToByte(_genres.Contains("Adventure"));
            AdultCast = Convert.ToByte(_genres.Contains("Adult Cast"));
            SciFi = Convert.ToByte(_genres.Contains("Sci-Fi"));
            Space = Convert.ToByte(_genres.Contains("Space"));
            Comedy = Convert.ToByte(_genres.Contains("Comedy"));
            Drama = Convert.ToByte(_genres.Contains("Drama"));
            Shounen = Convert.ToByte(_genres.Contains("Shounen"));
            Mystery = Convert.ToByte(_genres.Contains("Mystery"));
            Psychological = Convert.ToByte(_genres.Contains("Psychological"));
            Seinen = Convert.ToByte(_genres.Contains("Seinen"));
            Fantasy = Convert.ToByte(_genres.Contains("Fantasy"));
            Romance = Convert.ToByte(_genres.Contains("Romance"));
            Military = Convert.ToByte(_genres.Contains("Military"));
            Ecchi = Convert.ToByte(_genres.Contains("Ecchi"));
            SliceOfLife = Convert.ToByte(_genres.Contains("Slice of Life"));
            School = Convert.ToByte(_genres.Contains("School"));
            Historical = Convert.ToByte(_genres.Contains("Historical"));
            Isekai = Convert.ToByte(_genres.Contains("Isekai"));
        }
    }

    public ushort EpisodeNumber { get; set; }
    //public DateTime? StartDate { get; set; }
    //public DateTime? EndDate { get; set; }
    public string? Status { get; set; }
    public string? Studios { get; set; }
    public string? Source { get; set; }
    public ushort AverageEpisodeDuration { get; set; }
    public string? Rating { get; set; }
    public float Action { get; set; }
    public float Adventure { get; set; }
    public float AdultCast { get; set; }
    public float SciFi { get; set; }
    public float Space { get; set; }
    public float Comedy { get; set; }
    public float Drama { get; set; }
    public float Shounen { get; set; }
    public float Mystery { get; set; }
    public float Psychological { get; set; }
    public float Seinen { get; set; }
    public float Fantasy { get; set; }
    public float Romance { get; set; }
    public float Military { get; set; }
    public float Ecchi { get; set; }
    public float SliceOfLife { get; set; }
    public float School { get; set; }
    public float Historical { get; set; }
    public float Isekai { get; set; }
}