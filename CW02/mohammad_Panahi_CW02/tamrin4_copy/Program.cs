File.WriteAllText("E:\\testForCopy.txt","hihihi\nbibb\nups");
copyFile("E:\\testForCopy.txt");

static void copyFile(string fPath)
{
    var lines = File.ReadAllLines(fPath);
    File.WriteAllLines("E:\\testForCopy2.txt", lines);
}

