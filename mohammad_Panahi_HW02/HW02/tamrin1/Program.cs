Console.WriteLine("enter ur arr length(number of numbers):");
var length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter ur numbers:");
var numbers = new int[length];
for(int i=0; i<length; i++) numbers[i]= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your usage:\n" +
                  "1: get min of numbers.\n" +
                  "2: reverse array and print.\n" +
                  "3: arrange numbers (down to up).\n" +
                  "4: print the numbers which repeat more than once. \n" +
                  "5: give seconed array of numbers and get those numbers are in both array.");
var usage = Convert.ToChar(Console.ReadLine().Substring(0, 1));
switch (usage)
{
    case '1':
        Console.WriteLine(GetMin(numbers));
        break;
    case '2':
        PrintReverseArr(numbers);
        break;
    case '3':
        PrintArrange(numbers);
        break;
    case '4':
        PrintRepeat(numbers);
        break;
    case '5':
        Console.WriteLine("enter seconed numbers of numbers.");
        var length2=Convert.ToInt32(Console.ReadLine());
        var numbers2 = new int[length2];
        Console.WriteLine("enter ur numbers: ");
        for(int i=0; i<length2; i++) numbers2[i]=Convert.ToInt32(Console.ReadLine());
        // call method
        FindTheSame(numbers, numbers2);
        break;
    default:
        Console.WriteLine(" wrong number... ");
        break;
}
//helper
static int GetMax(int[] numbers)
{
    int max = int.MinValue;
    for(int i=0; i<numbers.Length; i++) 
        if(max<numbers[i]) max=numbers[i];
    return max;
}
//1
static int GetMin(int[] numbers)
{
    int min = int.MaxValue;
    
    //find min
    foreach (var item in numbers)
    {
        if (min > item) min = item;
    }
    return min;
}
//2
static void PrintReverseArr(int[] numbers)
{
    var numbers2 = new int[numbers.Length];
    
    //reverse in new arr
    for(int i=numbers.Length-1, j=0; i>=0; i--, j++) numbers2[j]=numbers[i];
    
    //print new arr
    for(int i=0; i<numbers2.Length; i++) Console.Write(numbers2[i]+" ");

    Console.WriteLine();
}
//3
static void PrintArrange(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
        for (int j = i + 1; j < numbers.Length; j++)
            if (numbers[i] > numbers[j]) { int keeper = numbers[i]; numbers[i] = numbers[j]; numbers[j] = keeper; }
    for(int i=0; i<numbers.Length; i++) Console.Write(numbers[i]+" ");
    Console.WriteLine();
}
//4
static void PrintRepeat(int[] numbers)
{
    int max = int.MinValue, min = GetMin(numbers);
    for(int i=0; i<numbers.Length; i++)
        if(numbers[i] > max) max = numbers[i];
    for (int i = min; i <= max; i++) {
        int counter = 0;
        for (int j = 0; j < numbers.Length; j++)
            if (i == numbers[j]) counter++;
        if (counter > 1) Console.WriteLine("number is: " + i + " and number of repeat is: " + counter);
    }
}
//5
static void FindTheSame(int[] numbers, int[] numbers2)
{
    int min = GetMin(numbers); int max= GetMax(numbers);
    if(min>GetMin(numbers2)) min= GetMin(numbers2);
    if(max<GetMax(numbers2)) max= GetMax(numbers2);
    int counter = 1;
    for (int i = min; i <= max; i++)
    {
        bool flag1 = false, flag2 = false;
        for (int j = 0; j < numbers.Length; j++) if (i == numbers[j]) { flag1 = true; break; }
        for (int j = 0; j < numbers2.Length; j++) if (i == numbers2[j]) { flag2 = true; break; }
        if (flag1 && flag2){ Console.WriteLine("common number " + counter + " is: " + i); counter++; }
    }
} 