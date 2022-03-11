Console.WriteLine("choose ur usage:\n" +
                  "enter 'f' for multiplication of a matrix and a integer ,\n" +
                  "enter 's' for multiplication of two matrix .");
var usage=Convert.ToChar(Console.ReadLine());
if (usage == 'f')
{
    Console.WriteLine("enter a integer: ");
    var integer = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter matrix's length: ");
    var length = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter matrix's width: ");
    var width = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter matrix's numbers ");
    int[,] numbersOfMatrix = new int[length, width];
    for (int i = 0; i < length; i++)
        for (int j = 0; j < width; j++) numbersOfMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    int[,] resualt = new int[length, width];
    for(int i=0; i<length; i++)
    {
        for (int j = 0; j < width; j++) { resualt[i, j] = numbersOfMatrix[i, j] * integer; Console.WriteLine(resualt[i, j] + " "); }
        Console.WriteLine("\n");
    }
}
if (usage == 's')
{
    Console.WriteLine("enter both matrix's length and width (it shuld be same) : ");
    var lengthWidth = Convert.ToInt32(Console.ReadLine());
    int[,] matrix1 = new int[lengthWidth, lengthWidth], matrix2 = new int[lengthWidth, lengthWidth];

    Console.WriteLine("enter first matrix's numbers ");
    for(int i=0; i<lengthWidth; i++) 
        for(int j=0; j<lengthWidth; j++) matrix1[i,j]= Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("enter sconed matrix's numbers ");
    for (int i = 0; i < lengthWidth; i++)
        for (int j = 0; j < lengthWidth; j++) matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
    
    int[,] resualt = new int[lengthWidth, lengthWidth];
    for (int i=0; i<lengthWidth; i++)
    {
        for(int j=0; j<lengthWidth; j++)
        {
            int eachIndexResualt = 0;
            for (int k=0; k<lengthWidth; k++)
            {
                eachIndexResualt += matrix1[i, k] * matrix2[k, j];
            }
            resualt[i,j]= eachIndexResualt;
        }
    }
    for (int i = 0; i < lengthWidth; i++)
        for (int j = lengthWidth; j<lengthWidth; j++) Console.WriteLine(resualt[i, j]);
}
