namespace DemoMVC.Models
{
public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    // Thuộc tính FullName (Chỉ đọc)
    public string FullName => $"{FirstName} {LastName}"; // ❌ Chỉ có getter (read-only)

}

}
