Console.WriteLine("enter length of arr: ");
var length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter width of arr: ");
var width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter numbers: ");
int[,] numbers = new int[length, width];
int[] arr1Length = new int[length * width];
for (int i = 0, k=0; i < length; i++, k++)
    for (int j = 0; j < width; j++, k++){ numbers[i, j] = Convert.ToInt32(Console.ReadLine()); arr1Length[k] = numbers[i, j];
Console.WriteLine("\tur arr is : ");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++) Console.Write(numbers[i, j] + "\t");
    Console.Write("\n");
}
for(int i=0; i<arr1Length.Length; i++)
    for(int j=0; j<arr1Length.Length; j++) if(arr1Length[i])
int counterMove = 1;
switch (counterMove)
{
    case 1:

        break;
}