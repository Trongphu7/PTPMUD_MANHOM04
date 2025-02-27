using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class GradeController : Controller
    {
        public IActionResult Index(double A, double B, double C)
        {
            var gradeModel = new GradeModel { A = A, B = B, C = C };

            // Sử dụng phương thức đúng
            double finalGrade = gradeModel.CalculateFinalGrade();
            string classification = gradeModel.GetClassification();

            ViewBag.Result = $"Điểm trung bình: {finalGrade:F2} - Xếp loại: {classification}";
            return View();
        }
    }
}
