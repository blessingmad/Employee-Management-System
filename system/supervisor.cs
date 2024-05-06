//Derived class supervisor inheriting from Employees
public class Supervisor : Employee
{
    //unique variable for the subclass suspervisor
    private string _project;

    public Supervisor(string record, string role, string project) : base (record, role) 
    {
        _project = project;
    }
       public string GetProject()
    {
        return _project;
    }
    public override string GetInfo()
    {
        //keeps the answer for the user
        return _project;
    }
}