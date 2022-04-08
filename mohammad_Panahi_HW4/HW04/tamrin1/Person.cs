public class Person
{
    public string FName { get; set; }
    public string LName { get; set; }
    public double? Height { get; set; }
    public string MobileNumber { get; set; }
    public string? FathersName { get; set; }
    public double? Weight { get; set; }
    public DateTime? BirthDay { get; set; }
    public string? Address { get; set; }
    public Person()
    {

    }
    public Person(string FName, string LName, string MobileNumber)
    {
        this.FName = FName; this.LName = LName; this.MobileNumber = MobileNumber;
        //this.Height = null; this.Weight = null; this.FathersName = null; this.BirthDay = null; this.Address= null;
    }
    public Person(string FName, string LName, string MobileNumber, double? Height, double? Weight,
                  string FathersName, DateTime BirthDay, string Address) : this (FName, LName, MobileNumber )
    {
        this.Height = Height; this.Weight = Weight; this.FathersName = FathersName; this.BirthDay = BirthDay; this.Address = Address; 
    }
    public override string ToString()
    {
        return $"{FName}, {LName}, {MobileNumber}";
    }
}