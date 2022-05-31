using Microsoft.ML.Data;

namespace MLRecommendator.Modeling; 

public class Prediction {
    public uint SeriesId { get; set; }
    [ColumnName("Score")]
    public float PredictedScore { get; set; }
}