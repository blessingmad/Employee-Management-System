//This programe displayes the emmplyees and their unique features.

using System;

//The main Emmployee class
public abstract class Employee
{
    // class variables
  private string _record;

  private string _role;

  private string _summary;
// Constructor
  public Studies (string record, string role, string summary)
  {
    // Common attributes to be shared accross the programe
    
    _record = record;
    _role = role;
    _summary = summary;
  }
  //get entiries from the user.
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

