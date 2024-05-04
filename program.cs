using System;

class program
{  
// Add employees function
static void AddEmployee(list<Employee> employees)


{
    Console.WriteLine("---------------------------------------------")
    Console.WriteLine();

    DateTime theCurrentDateTime = DateTime.Now;
    string dateText = theCurrentDateTime.ToLongDateString();
    Console WriteLine($"{dateText}");
    Console.WriteLine("-------------------------------------------------")

    Console.WriteLine("This program displays details for employees")


    //create a black line
    //Write to the terminal
    Console.WriteLine();
    Console.WriteLine("1. Manager");
    Console.WriteLine("2. Senior Employee");
    Console.WriteLine("3. Supervisor");

    Console.WriteLine("Which Employee do you want to view?")
    Console.WriteLine();

    string answer = Console.ReadLine();
    int numeber = int.Parse(answer);
    string results = "";
    //Loop for conditions to be displayed when then user makes a choice.
    if (number == 1)
    { 
        results = "Display the Manager Info:"
    }
    else if (number == 2)
    {
        results = "Display the Senior Employee Info:"
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

    List<Employees> employees = new List<Employees>();

    Manager e1 = new Manager ("Josh Dwawa");
    employees.Add(e1);

    Senior e2 = new Senior ("Tapiwa Sithole");
    employees.Add(e1);

    Supervisor e3 = new Supervisor ("Miho Mulatto");


    foreach (Employee e in employees)
    {
        string record = e.GetRecord();
        string role = e.GetRole();
        string summary = e.GetSummary();

        Console.WriteLine($"{record} {role} {summary}");
    }


}

}