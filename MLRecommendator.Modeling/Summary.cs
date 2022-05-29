namespace MLRecommendator.Modeling; 

public class Summary {
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? StartDate { get; set; }
    public string[]? Genres { get; set; }
    public float PredictedScore { get; set; }
}