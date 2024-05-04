//derived class Senior, inheriting from Employee.
public class Senior : Employee
{
    //unique attribute for the senior employee class
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