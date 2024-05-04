//Derived class supervisor inheriting from Employees
public class Supervisor : Employee
{
    //unique variable for the subclass suspervisor
    private string _project;

    public Employee(string record, string role, string summary, string location) : base (record, role, summary) 
    {
        _project = project;
    }
    public override string GetInfo()
    {
        //keeps the answer for the user
        return _project;
    }
}