using Rectangle;

Worker[] workers = new Worker[]
{
    new Worker("Vasiliy","Vasilevskiy",32,true,500),
    new Worker("Stepan","Bandera",65,true,1500),
    new Worker("Anton","Antonenko",17,false,200),
    new Worker("Vasiliy","Visokiy",22,false,100),
    new Worker("Oleg","Vasilevskiy",63,true,1000),
    new Worker("Dmitriy","Vasilevskiy",26,true,700),

};

foreach (Worker person in workers)
{
    Console.WriteLine(person);
}

Console.WriteLine("**************************************");

foreach (Worker person in workers)
{
    if (person.Age >= 18) Console.WriteLine(person);
}

Console.WriteLine("**************************************");

foreach (Worker person in workers)
{
    if (person.Surname == "Vasilevskiy")
    {
        Console.WriteLine($"Month salary of worker {person.Name} {person.Surname} is {person.MonthSalary}");
    }
}

Console.WriteLine("**************************************");

double totalSalary = 0;
foreach (Worker person in workers)
{
    if (person.OnPension)
    {
        totalSalary += person.MonthSalary;
    }
}
Console.WriteLine("Total salary of workers on pension in month = " + totalSalary); ;
