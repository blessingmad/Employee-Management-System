using System;

//define the class
public abstract class Employee
{
    // class variables
  private string _record;

  private string _role;

  private string _summary;

  public Studies (string record, string role, string summary)
  {
    _record = record;
    _role = role;
    _summary = summary;
  }

  public string GetRecord()
  {
    return _record;
  }
  public string GetRole()
  {
    return _role;
  }
  public string()
  {
    return _summary;
  }
  public abstract string GetInfo();

}

