namespace MLRecommendator.Database.Models;
public class UserSerie {
    public int Id { get; set; }
    public string? UserId { get; set; }
    public uint SeriesId { get; set; }
    public byte Score { get; set; }
}