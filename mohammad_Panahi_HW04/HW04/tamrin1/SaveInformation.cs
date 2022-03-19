static class SaveInformation
{
    static List<Person> persons = new List<Person>();
    static string savedFilePath = "E:\\information.CSV";
    static int numbersOfPersons=1;
    
    public static void addPerson(Person p)
    {
        //if (numbersOfPersons == 1) File.AppendAllText(savedFilePath, $"Id, first Name, last Name, mobile Number");
        persons.Add(p);
        File.AppendAllText(savedFilePath, numbersOfPersons+", "+p.ToString()+"\n");
        numbersOfPersons += 1;
    }
    public static void eraseInformation()
    {
        File.WriteAllText(savedFilePath, "");
    }
    public static string[] getInformation()
    {
        return File.ReadAllLines(savedFilePath);
    }
}
