// test
Boolean i = true;
while (i)
{
    Person persons = new Person();
    Console.WriteLine("Please Enter Name");
    persons.Name = Console.ReadLine();
    Console.WriteLine("Please Enter Family");                   
    persons.Family = Console.ReadLine();
    Console.WriteLine("Please Enter Height");
    persons.Height = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please Enter Mobile");
    persons.Mobile = Console.ReadLine();
    Console.WriteLine("Please Enter Father Name");
    persons.FatherName = Console.ReadLine();
    Console.WriteLine("Please Enter Weight");
    persons.Weight = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please Enter DateOfBirth");
    persons.DateOfBirth = Console.ReadLine();
    Console.WriteLine("Please Enter Address");
    persons.Address = Console.ReadLine();

    DataStoreFile.register(persons);
    Console.WriteLine("are you want exit y/n");
    if (Console.ReadKey().Key == ConsoleKey.Y) i = false;
    if (Console.ReadKey().Key == ConsoleKey.N) i = true;



}

DataStoreFile.StoreToList();

foreach (var item in DataStoreFile.PL)
{
    Console.Write($"{item.Name} {item.Family} {item.Mobile}");
}


File.WriteAllText("D:\\PersonFile.txt", string.Empty);
