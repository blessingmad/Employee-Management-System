//derived class Senior, inheriting from Employee.
public class Senior : Employee
{
    //unique attribute for the senior employee class
    private string _salary;

    public Senior(string record, string role,string salary) : base (record, role) 
    {
        _salary = salary;
    }
       public string GetSalary()
    {
        return _salary;
    }
    public override string GetInfo()
    {
        return _salary;
    }
}