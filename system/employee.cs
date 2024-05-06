//This programe displayes the emmplyees and their unique features.

using System;

//The main Emmployee class
public abstract class Employee
{
    // class variables
  private string _record;

  private string _role;

 
// Constructor
  public Employee(string record, string role)
  {
    // Common attributes to be shared accross the programe
    
    _record = record;
    _role = role;
   
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
 
  public abstract string GetInfo();

}

