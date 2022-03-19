public class Person
{
    private string FName { get; set; }
    private string LName { get; set; }
    private double? Height { get; set; }
    private string MobileNumber { get; set; }
    private string? FathersName { get; set; }
    private double? Weight { get; set; }
    private string? BirthDay { get; set; }
    private string? Address { get; set; }
    public Person(string FName, string LName, string MobileNumber)
    {
        this.FName = FName; this.LName = LName; this.MobileNumber = MobileNumber;
        //this.Height = null; this.Weight = null; this.FathersName = null; this.BirthDay = null; this.Address= null;
    }
    public Person(string FName, string LName, string MobileNumber, double? Height, double? Weight,
                  string FathersName, string BirthDay, string Address) : this (FName, LName, MobileNumber )
    {
        this.Height = Height; this.Weight = Weight; this.FathersName = FathersName; this.BirthDay = BirthDay; this.Address = Address; 
    }
    public override string ToString()
    {
        return $"{FName}, {LName}, {MobileNumber}";
    }
}