Console.WriteLine("enter number of length and width of multiplication's table. (1-15)");
var lengthWidth = Convert.ToInt32(Console.ReadLine());
int[,] tableNumbers = new int[lengthWidth, lengthWidth];
for(int i=0; i<lengthWidth; i++)
    for(int j=0; j<lengthWidth; j++)
    {
        tableNumbers[i, j] = (i + 1) * (j + 1);
    }
for (int i = 0; i < lengthWidth; i++) {
    for (int j = 0; j < lengthWidth; j++) Console.Write(tableNumbers[i, j]+"\t");
    Console.Write("\n");
}