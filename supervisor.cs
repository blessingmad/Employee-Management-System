public class Supervisor : Employee
{
    private string _project;

    public Employee(string record, string role, string summary, string location) : base (record, role, summary) 
    {
        _project = project;
    }
    public override string GetInfo()
    {
        return _project;
    }
}