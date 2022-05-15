namespace MLRecommendator.Database.Models;
public class Anime {
    public uint Id { get; set; }
    public string? Title { get; set; }
    public double Mean { get; set; }
    public uint Rank { get; set; }
    public uint Popularity { get; set; }
    public uint UsersNumber { get; set; }
    public uint UsersScoringNumber { get; set; }
    public string? Nsfw { get; set; }
    public string? Genres { get; set; }
    public ushort EpisodeNumber { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Status { get; set; }
    public string? Studios { get; set; }
    public string? Source { get; set; }
    public ushort AverageEpisodeDuration { get; set; }
    public string? Rating { get; set; }
}