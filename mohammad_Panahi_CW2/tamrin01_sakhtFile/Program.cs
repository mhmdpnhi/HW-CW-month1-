//Creat file
var newFile = File.Create("E:\\creatNewFile.txt");

//Close the file
newFile.Close();

//Write in file
File.WriteAllText("E:\\creatNewFile.txt", "heloo there");