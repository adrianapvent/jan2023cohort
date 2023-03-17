// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Developer Melissa = new Developer("Melissa", 44);
Melissa.PrintHired();
Melissa.PrintHiredDev();
Melissa.PrintDevInfo();

// Projects FirstProj = new Projects("First Project", Melissa);
Projects FirstProj = new Projects("First Project", "Melissa", 44);
FirstProj.PrintProjInfo();