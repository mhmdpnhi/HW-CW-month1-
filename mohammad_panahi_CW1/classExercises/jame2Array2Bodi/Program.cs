Console.WriteLine("enter length & width both array ");
var lengthWidth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numbers of first array: ");
int[,] array1 = new int[lengthWidth, lengthWidth],
       array2 = new int[lengthWidth, lengthWidth],
       resualt = new int[lengthWidth, lengthWidth];
for (int i = 0; i < lengthWidth; i++)
    for (int j = 0; j < lengthWidth; j++) array1[i, j] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numbers of seconed array");
for(int i = 0; i < lengthWidth; i++)
    for(int j=0; j < lengthWidth; j++) array2[i, j] = Convert.ToInt32(Console.ReadLine());
resualt = sumOf2Array(array1, array2, lengthWidth);
Console.WriteLine("sum of 2 array is: ");
for(int i = 0; i < lengthWidth; i++)
{
    for(int j=0; j<lengthWidth; j++) Console.Write(resualt[i, j]+"\t");
    Console.Write("\n");
}

//sum method 
int[,] sumOf2Array(int[,] arr1, int[,] arr2, int lengthWidth)
{
    int[,] sum = new int[lengthWidth, lengthWidth];
    for (int i = 0; i < lengthWidth; i++)
        for (int j = 0; j < lengthWidth; j++) sum[i, j] = arr1[i, j] + arr2[i, j];
    return sum;
}