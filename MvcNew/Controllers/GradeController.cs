namespace MvcMovie.Models
{
    public class GradeModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Phương thức tính điểm trung bình
        public double CalculateFinalGrade()
        {
            return (A + B + C) / 3;
        }

        // Phương thức phân loại điểm số
        public string GetClassification()
        {
            double finalGrade = CalculateFinalGrade();

            if (finalGrade >= 8.5) return "Giỏi";
            if (finalGrade >= 7.0) return "Khá";
            if (finalGrade >= 5.0) return "Trung bình";
            return "Yếu";
        }
    }
}
