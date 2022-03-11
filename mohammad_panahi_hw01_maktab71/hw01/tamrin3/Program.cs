int numberOfNumbers;
Console.WriteLine("enter number of numbers (just even): ");
while (true)
{

    numberOfNumbers = Convert.ToInt32(Console.ReadLine());
    if (numberOfNumbers % 2 == 0) break;
    else Console.WriteLine("u have to enter even numbers...\nenter number of numbers again: ");
}
double[] numbers = new double[numberOfNumbers];
Console.WriteLine("enter your numbers:");
for (int i = 0; i < numberOfNumbers; i++) numbers[i] = Convert.ToInt32(Console.ReadLine());
//sort the array
for (int i = 0; i < numberOfNumbers-1; i++)
{
    for (int j = i + 1; j < numberOfNumbers; j++)
    {
        if (numbers[i] < numbers[j])
        {
            double keeper = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = keeper;
        }
    }
}
//foreach (double number in numbers) Console.Write(number+" ");
double[] pranthesesAnswer = new double[numberOfNumbers / 2];
for(int i=0, counter=1, j=0; i<numberOfNumbers; i+=2, counter++, j++)
{
    if (counter > 4) counter = 1;
    switch (counter)
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
Console.Write("result is: ( "+pranthesesAnswer[0]+" ) ");
for (int i = 1; i < pranthesesAnswer.Length; i++) { resualt += pranthesesAnswer[i]; Console.Write("+ ( " + pranthesesAnswer[i] + " ) "); }
Console.WriteLine(" = " + (resualt + pranthesesAnswer[0]));