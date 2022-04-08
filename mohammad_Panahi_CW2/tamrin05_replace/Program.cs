string path1 = "E:\\1.txt";
string path2 = "E:\\2.txt";
string path3 = "E:\\backUp1.txt";
replace(path1, path2, path3);
static void replace(string fPath, string sPath, string backUp)
{
    File.WriteAllText(backUp, File.ReadAllText(fPath));
    File.WriteAllText(fPath, File.ReadAllText(sPath));
    File.Delete(sPath);
}