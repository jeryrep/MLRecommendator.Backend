namespace MLRecommendator.Database.Models; 

public class UserSerie {
    public uint Id { get; set; }
    public string? Title { get; set; }
    public string? Status { get; set; }
    public byte Score { get; set; }
    public ushort WatchedEpisodesNumber { get; set; }
    public bool IsRewatching { get; set; }
}