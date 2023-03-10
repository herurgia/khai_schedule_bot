namespace khai_schedule_bot.Models;

public class Group
{
    public int Id { get; set; }
    public int Faculty { get; set; }
    public int? Department { get; set; }
    /// <summary>
    /// Код специальности на украинском (напр. 515ст2)
    /// </summary>
    public string? UaCode { get; set; }
    /// <summary>
    /// Код специальности на английском (напр. 515st2)
    /// </summary>
    public string? EngCode { get; set; }
    
    public Group(int faculty, int? department, string? uaCode, string? engCode)
    {
        Faculty = faculty;
        UaCode = uaCode;
        EngCode = engCode;
        Department = department;
    }

    public override string ToString()
    {
        return $"Id: {Id}\tFaculty: {Faculty}\tUaCode: {UaCode}\tEngCode: {EngCode}";
    }
}