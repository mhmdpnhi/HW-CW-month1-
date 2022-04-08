Console.WriteLine("enter first string: ");
var str = Console.ReadLine();
Console.WriteLine("enter seconed string: ");
var str2 = Console.ReadLine();
var strArr = str.ToCharArray(); var str2Arr = str2.ToCharArray();
int maxCounter = int.MinValue;
char[]? answer = new char[100];
for (int i = 0; i < answer.Length; i++) answer[i] = ' ';
for(int i=0; i<strArr.Length && i<str2Arr.Length; i++)
{
    if (strArr[i] == str2Arr[i])
    {
        int counter = 1;
        for(int j=i+1; j<strArr.Length && j<str2Arr.Length; j++)
        {
            if (strArr[j] == str2Arr[j]) counter++;
            else break;
        }
        if (counter > maxCounter)
        {
            maxCounter = counter;
            for(int j=0, k=i; k<i+counter; k++, j++)
            {
                answer[j] = strArr[k];
            }
        }
    }
}
Console.Write("biggest common string is: ");
for(int i=0; i<answer.Length; i++) if(answer[i]!=' ') Console.Write(answer[i]);