using System;

class Program
{  
    
// Add employees function
static void AddEmployee(List<Employee> employees)
/// <summary>
/// Main entry point for the program
/// </summary>
/// <param name="args"></param>
static void Main(string[] args)
{
List<Employee> employees = new List<Employee>();
AddEmployee(employees);

}

{
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine();
    //dispaly date
    DateTime theCurrentDateTime = DateTime.Now;
    string dateText = theCurrentDateTime.ToLongDateString();
    Console.WriteLine($"{dateText}");
    Console.WriteLine("-------------------------------------------------");

    Console.WriteLine("This program displays details for employees");


    //create a black line
    //Write to the terminal
    Console.WriteLine();
    Console.WriteLine("1. Manager");
    Console.WriteLine("2. Senior Employee");
    Console.WriteLine("3. Supervisor");

    Console.WriteLine("Which Employee do you want to view?");
    Console.WriteLine();

    string answer = Console.ReadLine();
    int number = int.Parse(answer);
    string results = "";
    //Loop for conditions to be displayed when then user makes a choice.
    if (number == 1)
    { 
        results = "Display the Manager Info:";
    }
    else if (number == 2)
    {
        results = "Display the Senior Employee Info:";
    }
    else if (number == 3) 
    {
        results = "Display Supervisor";

    }
    else
    {
        //returns invalid if the user enters unsupported entries.
        results = "invalid entry";
    }
    Console.WriteLine($"{results}");
    Console.WriteLine();

    //List<Employees> employees = new List<Employees>();

    Manager e1 = new Manager ("Josh Dwawa","Motivates", "Location");
    employees.Add(e1);

    Senior e2 = new Senior ("Tapiwa Sithole", "Analyse", "Summary");
    employees.Add(e2);

    Supervisor e3 = new Supervisor ("Miho Mulatto", "Monitor", "Project1");
    employees.Add(e3);


    foreach (Employee e in employees)
    {
        string record = e.GetRecord();
        string role = e.GetRole();
        string summary = e.GetInfo();

        Console.WriteLine($"{record} {role} {summary}");
    }


}

}