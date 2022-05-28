using Microsoft.ML.Data;

namespace MLRecommendator.Modeling; 

public class Prediction {
    public uint Id { get; set; }
    public float UserScore { get; set; }
    [ColumnName("Score")]
    public float PredictedScore { get; set; }
}