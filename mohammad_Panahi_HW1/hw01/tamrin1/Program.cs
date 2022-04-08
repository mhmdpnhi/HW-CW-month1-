int counter = 2;
while (true)
{
    Console.WriteLine("please select your usage...\n" +
                      "1.enter four number and one operator >> (f) \n" +
                      "2.enter at least 2 operator and one more numbers >> (s) \n" +
                      "3.enter 2 number and calculation seconed power and square root both >> (t) ");
    char kind = Convert.ToChar(Console.ReadLine());
    
    //first kind of usage
    if(kind == 'f' || kind == 'F')
    {
        Console.WriteLine("please enert 4 number: ");
        double num1 = Convert.ToDouble(Console.ReadLine()),
               num2 = Convert.ToDouble(Console.ReadLine()),
               num3 = Convert.ToDouble(Console.ReadLine()),
               num4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("please enter a operator: ");
        var opera = Convert.ToChar(Console.ReadLine());
        switch (opera)
        {
            case '+':
                Console.WriteLine("resault is: " + num1 + " + " + num2 + " + " + num3 + " + " + num4 + " = " + (num1 + num2 + num3 + num4));
                break;
            case '-':
                Console.WriteLine("resault is: " + num1 + " -" + num2 + " - " + num3 + " - " + num4 + " = " + (num1 - num2 - num3 - num4));
                break;
            case '*':
                Console.WriteLine("resault is: " + num1 + " * " + num2 + " * " + num3 + " * " + num4 + " = " + (num1 * num2 * num3 * num4));
                break;
            case '/':
                Console.WriteLine("resault is: " + num1 + " / " + num2 + " / " + num3 + " / " + num4 + " = " + (((num1/ num2)/ num3)/ num4));
                break;
        }
    }

    // seconed kind of usage
    if(kind == 's' || kind == 'S')
    {
        Console.WriteLine("enter number of operators: ");
        int numberOFOperators = Convert.ToInt32(Console.ReadLine());
        char[] operators = new char[numberOFOperators];
        double[] numbers = new double[numberOFOperators + 1];
        Console.WriteLine("enter operators: ");
        for(int i=0; i<numberOFOperators; i++) { operators[i] = Convert.ToChar(Console.ReadLine()); }
        
        // sort the operators
        for(int i=0; i<operators.Length-1; i++) {
            if((operators[i]=='+' || operators[i]=='-') && (operators[i+1]=='*' || operators[i + 1]=='/')) { 
                char ch=operators[i]; operators[i]=operators[i + 1]; operators[i + 1] = ch;
            }
        }
        Console.WriteLine("enter numbers: ");
        for(int i=0; i<numbers.Length; i++) { numbers[i] = Convert.ToDouble(Console.ReadLine()); }
        
        //calculation 
        double answer = numbers[0];
        for(int i=0; i<operators.Length; i++)
        {
            switch (operators[i])
            {
                case '+':
                    answer += numbers[i + 1];
                    break;
                case '-':
                    answer -= numbers[i + 1];
                    break;
                case '*':
                    answer *= numbers[i + 1];
                    break;
                case '/':
                    answer /= numbers[i + 1];
                    break;
            }
        }
        Console.Write("resualt is: ");
        for(int i=0; i<numberOFOperators; i++)
        {
            Console.Write(numbers[i] +" "+ operators[i]+" ");
        }
        Console.WriteLine(numbers[numberOFOperators] + " = " + answer);
    }
    if(kind=='t' || kind == 'T')
    {
        Console.WriteLine("enetr 2 inteager: ");
        int    num1 = Convert.ToInt32(Console.ReadLine()),
               num2 = Convert.ToInt32(Console.ReadLine()),
               num1Pow=num1, num1SquareRoot=0,
               num2Pow=num2, num2SquareRoot=0;
        for (int i = 1; i < num1; i += 1) if (i * i == num1) num1SquareRoot = i;
        for (int i = 1; i < num2; i += 1) if (i * i == num2) num2SquareRoot = i;
        num1Pow = num1 * num1; num2Pow = num2 * num2;
        Console.WriteLine("seconed pow"+num1+" is: " + num1Pow +
                          "\nsquare root"+num1+" is: " + num1SquareRoot +
                          "\nseconed pow"+num2+" is: " + num2Pow +
                          "\nsquare root"+num2+" is: " + num2SquareRoot);
    }
    Console.WriteLine("\n do you want do this again? (y/n)");
    char checkCantinues = Convert.ToChar(Console.ReadLine());
    if (checkCantinues != 'y' && checkCantinues != 'Y') break;
    Console.WriteLine("\nnumber of repeat: " + counter+"\n");
    counter++;
}
