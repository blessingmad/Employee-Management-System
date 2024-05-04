//Derived class Manager, inheriting from Employee

public class Manager : Employee
{
    private string _location;

    public Employee(string record, string role, string summary, string location) : base (record, role, summary) 
    {
        _location = location;
    }
    public override string GetInfo()
    {
        return _location;
    }
}