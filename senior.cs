public class Senior : Employee
{
    private string _salary;

    public Employee(string record, string role, string summary, string salary) : base (record, role, summary) 
    {
        _salary = salary;
    }
    public override string GetInfo()
    {
        return _salary;
    }
}