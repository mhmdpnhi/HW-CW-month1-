string filePath = "E:\\forLoopTamrin.txt";
var newFile=File.Create(filePath);
newFile.Close();
string[] information = new string[3];
for(int i=0; i<3; i++)
{
    information[i] = Console.ReadLine();
}
File.WriteAllText(filePath, Convert.ToString(information));

