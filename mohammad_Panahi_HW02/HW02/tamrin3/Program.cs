Console.WriteLine("enter numbers as String and split with space's button");
var numbers=Console.ReadLine();
int[] numbersArr = ChangeToNumbersArr(numbers);
foreach (var item in numbersArr)
{
    Console.WriteLine(item);
}

static int[] ChangeToNumbersArr(string numbers)
{
    var ch=numbers.ToCharArray(); int counter = 1;
    foreach (var item in ch)
    {
        if (item == ' ') counter++; 
    }
    int[] numberArr = new int[counter];
    for(int i=0, j=0; i<ch.Length; i++)
    {
        bool flag = false;
        while(ch[i]!=' ')
        {
            numberArr[j]=(numberArr[j]*10)+(Convert.ToInt32(ch[i])-48);
            i++;
            flag = true;
            if (i >= ch.Length) break;
        }
        if(flag) j++;
    }
    return numberArr;
}