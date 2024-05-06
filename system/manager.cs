//Derived class Manager, inheriting from Employee

public class Manager : Employee
{
    private string _location;

    public Manager(string record, string role,  string location) : base (record, role) 
    {
        _location = location;
    }
    public string GetLocation()

      {
        return _location;
    }

    public override string GetInfo()
    {
        return _location;
    }
}