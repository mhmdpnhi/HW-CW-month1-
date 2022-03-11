Console.WriteLine("enter first number: ");
var num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter seconed number: ");
var num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("enter operator: ");
char opera = Convert.ToChar(Console.Read());
switch (opera)
{
    case '+':
        Console.WriteLine("resualt is: " + (num1 + num2));
        break;
    case '-':
        Console.WriteLine("resualt is: " + (num1 - num2));
        break;
    case '*':
        Console.WriteLine("resualt is: " + (num1 * num2));
        break;
    case '/':
        Console.WriteLine("resualt is: " + (num1 / num2));
        break;
    default:
        Console.WriteLine(" invalid operatpor was entered");
        break;
}