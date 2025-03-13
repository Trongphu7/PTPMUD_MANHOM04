namespace MvcMovie.Models
{
    public class BMIModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI => Height > 0 ? Weight / (Height * Height) : 0;

        public string Category
        {
            get
            {
                if (BMI < 18.5) return "Gầy";
                if (BMI < 25) return "Bình thường";
                if (BMI < 30) return "Thừa cân";
                return "Béo phì";
            }
        }
    }
}
