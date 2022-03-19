string filePath = "E:\\StudentInformation.CSV";
var newFile = File.Create(filePath);
newFile.Close();
Console.WriteLine("how many student do u have?");
var numberOfStudent = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= numberOfStudent; i++)
{
    Console.WriteLine($"enter student number {i} name... ");
    var name = Console.ReadLine();
    Console.WriteLine($"enter {name}'s age...");
    var age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"enter {name}'s average in last term...");
    var average = Convert.ToInt32(Console.ReadLine());
    File.AppendAllText(filePath, $"{i}, {name}, {age}, {average} \n");
}


