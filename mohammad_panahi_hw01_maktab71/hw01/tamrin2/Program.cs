Console.WriteLine("enter your number of numbers: ");
var numberOfNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a operator: ");
var ch=Convert.ToChar(Console.ReadLine());
double[] numbers = new double[numberOfNumber];
Console.WriteLine("enter numbers: ");
for (int i = 0; i < numberOfNumber; i++) numbers[i] = Convert.ToInt32(Console.ReadLine());
double answer = numbers[0];
switch (ch)
{
    case '+':
        for (int i = 1; i < numberOfNumber; i++) answer += numbers[i]; 
        break;
    case '-':
        for (int i = 1; i < numberOfNumber; i++) answer -= numbers[i];
        break;
    case '*':
        for (int i = 1; i < numberOfNumber; i++) answer *= numbers[i];
        break;
    case '/':
        for (int i = 1; i < numberOfNumber; i++) answer /= numbers[i];
        break;
}
Console.WriteLine("resualt is: " + answer);