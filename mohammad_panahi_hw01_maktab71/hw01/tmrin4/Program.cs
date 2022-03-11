Console.WriteLine("enter your even numbers (letters to finish): ");
int[] numbers = new int[10000];
int counter = 0;
//for (int i = 0; i < numbers.Length; i++) numbers[i] = null;
while (true)
{
    var s = Console.ReadLine();
    if (((Convert.ToChar(s.Substring(0, 1)) >= 'a' && Convert.ToChar(s.Substring(0, 1)) <= 'z') ||
    Convert.ToChar(s.Substring(0, 1)) >= 'A' && Convert.ToChar(s.Substring(0, 1)) <= 'Z'))
    {
        numbers[counter] = 0;
        break;
    }
    else numbers[counter]= Convert.ToInt32(s);
   
    counter++;
}
//sort UP TO SMALL
for(int i=0; i<counter-1; i++)
    for(int j=i+1; j<counter; j++)
        if (numbers[i] < numbers[j])
        {
            int keeper = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = keeper;
        }

double[] pranthesesAnswer = new double[counter / 2];
for (int i = 0, counterr = 1, j = 0; i < counter-1; i += 2, counterr++, j++)
{
    if (counterr > 4) counterr = 1;
    switch (counterr)
    {
        case 1:
            pranthesesAnswer[j] = numbers[i] * numbers[i + 1];
            Console.WriteLine(numbers[i] + " * " + numbers[i + 1] + " = " + pranthesesAnswer[j]);
            break;
        case 2:
            pranthesesAnswer[j] = numbers[i] / numbers[i + 1];
            Console.WriteLine(numbers[i] + " / " + numbers[i + 1] + " = " + pranthesesAnswer[j]);
            break;
        case 3:
            pranthesesAnswer[j] = numbers[i] - numbers[i + 1];
            Console.WriteLine(numbers[i] + " - " + numbers[i + 1] + " = " + pranthesesAnswer[j]);
            break;
        case 4:
            pranthesesAnswer[j] = numbers[i] + numbers[i + 1];
            Console.WriteLine(numbers[i] + " + " + numbers[i + 1] + " = " + pranthesesAnswer[j]);
            break;
    }
}
double resualt = 0;
Console.Write("result is: ( " + pranthesesAnswer[0] + " ) ");
for (int i = 1; i < pranthesesAnswer.Length; i++) { resualt += pranthesesAnswer[i]; Console.Write("+ ( " + pranthesesAnswer[i] + " ) "); }
Console.WriteLine(" = " + (resualt + pranthesesAnswer[0]));