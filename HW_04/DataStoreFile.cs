
    public class DataStoreFile
{
    public static List<Person> PL = new List<Person>();
    public static void register(Person p)
    {
        File.WriteAllText("D:\\PersonFile.txt", p.Name + "\t" +
            p.Family + "\t" + p.Height + "\t" + p.Mobile + "\t" + p.FatherName
            + "\t" + p.Weight + "\t" + p.DateOfBirth + "\t" + p.Address);
    }


    public static void StoreToList()
    {
        var line = System.IO.File.ReadAllLines("D:\\PersonFile.txt");
        
        foreach (var item in line)
        {
            var y = item.Split('\t');
            Person x = new Person();
            x.Name = y[0];
            x.Family = y[1];
            x.Height = Convert.ToInt32(y[2]);
            x.Mobile = y[3];
            x.FatherName = y[4];
            x.Weight = Convert.ToInt32(y[5]);
            x.DateOfBirth = y[6];
            x.Address = y[7];
            PL.Add(x);

        }

    }


}