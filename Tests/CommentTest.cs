namespace Tests;

using knightmoves;
using Xunit;
using System.Text.RegularExpressions;

public class CommentTest
{
    [Fact]
    public void Should_Return_The_Course_Length_From_The_Method()
    {
        var courses = new Course();
        var courseLength = courses.CourseLength();

        Assert.Equal(20, courseLength);
    }

    [Fact]
    public void Should_Define_A_Method_Level_Variable_As_int_courseLength()
    {
        string filePath = Path.Combine(Path.GetDirectoryName(typeof(Course).Assembly.Location) ?? string.Empty, "../../../Course.cs");

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);
        Regex rx = new Regex(@"\bint\s+courseLength\b");

        Assert.True(rx.IsMatch(content), "Course.cs does not contain a method-level variable as 'int courseLength'.");
    }

    [Fact]
    public void Should_Assign_courseLength_To_The_Number_20()
    {
        string filePath = Path.Combine(Path.GetDirectoryName(typeof(Course).Assembly.Location) ?? string.Empty, "../../../Course.cs");

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);
        Regex rx = new Regex(@"\bcourseLength\s*=\s*20\s*;");

        Assert.True(rx.IsMatch(content), "Course.cs does not assign 'courseLength' to the number 20.");
    }

    [Fact]
    public void Should_Define_A_Class_Level_Variable_As_public_int_MaxStudents()
    {
        string filePath = Path.Combine(Path.GetDirectoryName(typeof(Course).Assembly.Location) ?? string.Empty, "../../../Course.cs");

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);
        Regex rx = new Regex(@"\bpublic\s+int\s+MaxStudents\b");

        Assert.True(rx.IsMatch(content), "Course.cs does not contain a class-level variable as 'public int MaxStudents'.");
    }

    [Fact]
    public void Should_Assign_MaxStudents_To_The_Number_25()
    {
        var course = new Course();

        Assert.Equal(25, course.MaxStudents);
    }

    [Fact]
    public void Should_Define_A_Class_Level_Public_Constant_int_Named_PerfectScore()
    {
        string filePath = Path.Combine(Path.GetDirectoryName(typeof(Course).Assembly.Location) ?? string.Empty, "../../../Course.cs");

        Assert.True(File.Exists(filePath), "File does not exist");

        string content = File.ReadAllText(filePath);
        Regex rx = new Regex(@"\bpublic\s+const\s+int\s+PerfectScore\b");

        Assert.True(rx.IsMatch(content), "Course.cs does not contain a class-level public constant int named PerfectScore.");
    }

    [Fact]
    public void Should_Assign_PerfectScore_To_The_Number_100()
    {
        Assert.Equal(100, Course.PerfectScore);
    }
}
